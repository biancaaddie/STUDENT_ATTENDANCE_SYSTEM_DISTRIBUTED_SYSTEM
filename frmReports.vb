Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class frmReports

    Dim WithEvents PrintDoc As New PrintDocument
    Dim PrintPreview As New PrintPreviewDialog

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLoadReport_Click(sender As Object, e As EventArgs) Handles btnLoadReport.Click
        LoadReport()
    End Sub

    Private Sub btnFilterDate_Click(sender As Object, e As EventArgs) Handles btnFilterDate.Click
        LoadFilteredReport()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If dgvReport.Rows.Count = 0 Then
            MessageBox.Show("No records to print.")
            Exit Sub
        End If

        PrintPreview.Document = PrintDoc
        PrintPreview.ShowDialog()

    End Sub

    Private Sub LoadReport()

        Using conn As MySqlConnection = GetMainLocalConnection()

            conn.Open()

            Dim sql As String = "SELECT student_id, firstname, lastname, attendance_date, time_in, time_out, status, branch_code
                                 FROM central_attendance
                                 ORDER BY attendance_date DESC, branch_code ASC"

            Using da As New MySqlDataAdapter(sql, conn)

                Dim dt As New DataTable()

                da.Fill(dt)

                dgvReport.DataSource = dt

            End Using

        End Using

    End Sub

    Private Sub LoadFilteredReport()

        Using conn As MySqlConnection = GetMainLocalConnection()

            conn.Open()

            Dim sql As String = "SELECT student_id, firstname, lastname, attendance_date, time_in, time_out, status, branch_code
                                 FROM central_attendance
                                 WHERE attendance_date BETWEEN @dateFrom AND @dateTo
                                 ORDER BY attendance_date DESC, branch_code ASC"

            Using da As New MySqlDataAdapter(sql, conn)

                da.SelectCommand.Parameters.AddWithValue("@dateFrom", dtpFrom.Value.Date.ToString("yyyy-MM-dd"))
                da.SelectCommand.Parameters.AddWithValue("@dateTo", dtpTo.Value.Date.ToString("yyyy-MM-dd"))

                Dim dt As New DataTable()

                da.Fill(dt)

                dgvReport.DataSource = dt

            End Using

        End Using

    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage

        Dim fontTitle As New Font("Arial", 16, FontStyle.Bold)
        Dim fontHeader As New Font("Arial", 9, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 9)

        Dim startX As Integer = 30
        Dim startY As Integer = 80
        Dim rowHeight As Integer = 25
        Dim currentY As Integer = startY

        ' Title
        e.Graphics.DrawString("Student Attendance Report", fontTitle, Brushes.Black, startX, currentY)
        currentY += 35

        ' Date printed
        e.Graphics.DrawString("Date Printed: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"), fontBody, Brushes.Black, startX, currentY)
        currentY += 30

        ' 8 columns
        Dim colWidths() As Integer = {90, 100, 100, 100, 80, 80, 70, 60}
        Dim headers() As String = {"Student ID", "First Name", "Last Name", "Date", "Time In", "Time Out", "Status", "Branch"}

        ' Draw headers
        Dim currentX As Integer = startX

        For i As Integer = 0 To headers.Length - 1
            e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, colWidths(i), rowHeight)
            e.Graphics.DrawString(headers(i), fontHeader, Brushes.Black, currentX + 3, currentY + 5)
            currentX += colWidths(i)
        Next

        currentY += rowHeight

        ' Draw rows
        For r As Integer = 0 To dgvReport.Rows.Count - 1

            If dgvReport.Rows(r).IsNewRow Then Continue For

            currentX = startX

            For c As Integer = 0 To dgvReport.Columns.Count - 1

                Dim value As String = ""

                If dgvReport.Rows(r).Cells(c).Value IsNot Nothing Then
                    value = dgvReport.Rows(r).Cells(c).Value.ToString()
                End If

                ' Format date column
                If dgvReport.Columns(c).Name = "attendance_date" Then
                    Dim dt As DateTime
                    If DateTime.TryParse(value, dt) Then
                        value = dt.ToString("yyyy-MM-dd")
                    End If
                End If

                ' Format time columns
                If dgvReport.Columns(c).Name = "time_in" Or dgvReport.Columns(c).Name = "time_out" Then
                    Dim tm As DateTime
                    If DateTime.TryParse(value, tm) Then
                        value = tm.ToString("HH:mm:ss")
                    End If
                End If

                ' Prevent array error if columns change
                If c < colWidths.Length Then
                    e.Graphics.DrawRectangle(Pens.Black, currentX, currentY, colWidths(c), rowHeight)
                    e.Graphics.DrawString(value, fontBody, Brushes.Black,
                                          New RectangleF(currentX + 3, currentY + 5, colWidths(c) - 6, rowHeight - 6))
                    currentX += colWidths(c)
                End If

            Next

            currentY += rowHeight

            If currentY + rowHeight > e.MarginBounds.Bottom Then
                Exit For
            End If

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
End Class