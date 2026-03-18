Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmDashboard

    Private Sub btnLoadRecords_Click(sender As Object, e As EventArgs) Handles btnLoadRecords.Click
        LoadRecords()
    End Sub

    Private Sub btnLoadSummary_Click(sender As Object, e As EventArgs) Handles btnLoadSummary.Click
        LoadGrandTotal()
        LoadBranchTotals()
        LoadBarChart()
        LoadPieChart()
    End Sub

    Private Sub LoadRecords()
        Using conn As MySqlConnection = GetMainLocalConnection()
            conn.Open()

            Dim sql As String = "SELECT student_id, firstname, lastname, attendance_date, time_in, time_out, status, branch_code
                                 FROM central_attendance
                                 ORDER BY attendance_date DESC, branch_code ASC"

            Using da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvRecords.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub LoadGrandTotal()
        Using conn As MySqlConnection = GetMainLocalConnection()
            conn.Open()

            Dim sql As String = "SELECT COUNT(*) FROM central_attendance"
            Using cmd As New MySqlCommand(sql, conn)
                lblGrandTotal.Text = "Grand Total: " & Convert.ToInt32(cmd.ExecuteScalar()).ToString()
            End Using
        End Using
    End Sub

    Private Sub LoadBranchTotals()
        lblBranchATotal.Text = "Branch A: 0"
        lblBranchBTotal.Text = "Branch B: 0"
        lblBranchCTotal.Text = "Branch C: 0"

        Using conn As MySqlConnection = GetMainLocalConnection()
            conn.Open()

            Dim sql As String = "SELECT branch_code, COUNT(*) AS total_records FROM central_attendance GROUP BY branch_code"
            Using cmd As New MySqlCommand(sql, conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim branch As String = reader("branch_code").ToString()
                        Dim total As Integer = Convert.ToInt32(reader("total_records"))

                        If branch = "A" Then lblBranchATotal.Text = "Branch A: " & total.ToString()
                        If branch = "B" Then lblBranchBTotal.Text = "Branch B: " & total.ToString()
                        If branch = "C" Then lblBranchCTotal.Text = "Branch C: " & total.ToString()
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadBarChart()
        ChartBar.Series.Clear()
        ChartBar.ChartAreas.Clear()
        ChartBar.ChartAreas.Add(New ChartArea("ChartArea1"))

        Dim series As New Series("Total Records per Branch")
        series.ChartType = SeriesChartType.Bar
        ChartBar.Series.Add(series)

        Using conn As MySqlConnection = GetMainLocalConnection()
            conn.Open()

            Dim sql As String = "SELECT branch_code, COUNT(*) AS total_records FROM central_attendance GROUP BY branch_code"
            Using cmd As New MySqlCommand(sql, conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        series.Points.AddXY(reader("branch_code").ToString(), Convert.ToInt32(reader("total_records")))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadPieChart()
        ChartPie.Series.Clear()
        ChartPie.ChartAreas.Clear()
        ChartPie.Legends.Clear()

        ChartPie.ChartAreas.Add(New ChartArea("ChartArea1"))
        ChartPie.Legends.Add(New Legend("Legend1"))

        Dim series As New Series("Distribution Percentage")
        series.ChartType = SeriesChartType.Pie
        ChartPie.Series.Add(series)

        Using conn As MySqlConnection = GetMainLocalConnection()
            conn.Open()

            Dim sql As String = "SELECT branch_code, COUNT(*) AS total_records FROM central_attendance GROUP BY branch_code"
            Using cmd As New MySqlCommand(sql, conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        series.Points.AddXY(reader("branch_code").ToString(), Convert.ToInt32(reader("total_records")))
                    End While
                End Using
            End Using
        End Using

        ChartPie.Series(0)("PieLabelStyle") = "Outside"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
End Class