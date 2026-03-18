Imports MySql.Data.MySqlClient

Public Class frmAttendance

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBranch.Text = "Branch: " & CurrentBranchCode
        LoadAttendance()
    End Sub

    Private Sub btnSubmitAttendance_Click(sender As Object, e As EventArgs) Handles btnSubmitAttendance.Click
        RecordAttendanceByStudentID()
    End Sub

    Private Sub btnLoadAttendance_Click(sender As Object, e As EventArgs) Handles btnLoadAttendance.Click
        LoadAttendance()
    End Sub

    Private Sub btnViewUnsynced_Click(sender As Object, e As EventArgs) Handles btnViewUnsynced.Click
        LoadUnsynced()
    End Sub

    Private Sub btnSync_Click(sender As Object, e As EventArgs) Handles btnSync.Click
        SyncTodayRecords()
    End Sub

    Private Sub RecordAttendanceByStudentID()
        Dim studentId As String = txtStudentID.Text.Trim()

        If studentId = "" Then
            MessageBox.Show("Please enter Student ID.")
            Exit Sub
        End If

        Using conn As MySqlConnection = GetLocalConnection()
            conn.Open()

            Dim firstName As String = ""
            Dim lastName As String = ""

            Dim studentSql As String = "SELECT firstname, lastname FROM students WHERE student_id=@student_id"
            Using studentCmd As New MySqlCommand(studentSql, conn)
                studentCmd.Parameters.AddWithValue("@student_id", studentId)

                Using reader As MySqlDataReader = studentCmd.ExecuteReader()
                    If reader.Read() Then
                        firstName = reader("firstname").ToString()
                        lastName = reader("lastname").ToString()
                    Else
                        lblStudentName.Text = "Student Name: Not registered"
                        lblAttendanceStatus.Text = "Status: Registration required"
                        MessageBox.Show("Student is not registered.")
                        Exit Sub
                    End If
                End Using
            End Using

            lblStudentName.Text = "Student Name: " & firstName & " " & lastName

            Dim attendanceId As Integer = 0
            Dim timeInVal As Object = Nothing
            Dim timeOutVal As Object = Nothing

            Dim checkSql As String = "SELECT id, time_in, time_out
                                      FROM attendance
                                      WHERE student_id=@student_id
                                      AND attendance_date=CURDATE()
                                      AND branch_code=@branch_code"

            Using checkCmd As New MySqlCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@student_id", studentId)
                checkCmd.Parameters.AddWithValue("@branch_code", CurrentBranchCode)

                Using reader As MySqlDataReader = checkCmd.ExecuteReader()
                    If reader.Read() Then
                        attendanceId = Convert.ToInt32(reader("id"))
                        timeInVal = reader("time_in")
                        timeOutVal = reader("time_out")
                    End If
                End Using
            End Using

            If attendanceId = 0 Then
                Dim uuid As String = Guid.NewGuid().ToString()

                Dim insertSql As String = "INSERT INTO attendance
                    (record_uuid, student_id, firstname, lastname, attendance_date, time_in, time_out, status, branch_code, synced)
                    VALUES
                    (@record_uuid, @student_id, @firstname, @lastname, CURDATE(), CURTIME(), NULL, 'Present', @branch_code, 0)"

                Using insertCmd As New MySqlCommand(insertSql, conn)
                    insertCmd.Parameters.AddWithValue("@record_uuid", uuid)
                    insertCmd.Parameters.AddWithValue("@student_id", studentId)
                    insertCmd.Parameters.AddWithValue("@firstname", firstName)
                    insertCmd.Parameters.AddWithValue("@lastname", lastName)
                    insertCmd.Parameters.AddWithValue("@branch_code", CurrentBranchCode)
                    insertCmd.ExecuteNonQuery()
                End Using

                lblAttendanceStatus.Text = "Status: Time In recorded"
                MessageBox.Show("Time In recorded successfully.")

            ElseIf Not IsDBNull(timeInVal) AndAlso IsDBNull(timeOutVal) Then
                Dim updateSql As String = "UPDATE attendance SET time_out=CURTIME(), synced=0 WHERE id=@id"

                Using updateCmd As New MySqlCommand(updateSql, conn)
                    updateCmd.Parameters.AddWithValue("@id", attendanceId)
                    updateCmd.ExecuteNonQuery()
                End Using

                lblAttendanceStatus.Text = "Status: Time Out recorded"
                MessageBox.Show("Time Out recorded successfully.")

            Else
                lblAttendanceStatus.Text = "Status: Attendance complete"
                MessageBox.Show("Attendance for today is already complete.")
            End If
        End Using

        txtStudentID.Clear()
        txtStudentID.Focus()
        LoadAttendance()
    End Sub

    Private Sub LoadAttendance()
        Using conn As MySqlConnection = GetLocalConnection()
            conn.Open()

            Dim sql As String = "SELECT student_id, firstname, lastname, attendance_date, time_in, time_out, status, branch_code, synced
                                 FROM attendance
                                 ORDER BY id DESC"

            Using da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvAttendance.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub LoadUnsynced()
        Using conn As MySqlConnection = GetLocalConnection()
            conn.Open()

            Dim sql As String = "SELECT student_id, firstname, lastname, attendance_date, time_in, time_out, status, branch_code, synced
                                 FROM attendance
                                 WHERE synced=0
                                 ORDER BY id DESC"

            Using da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvAttendance.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub SyncTodayRecords()
        Dim records As New List(Of Dictionary(Of String, Object))

        Try
            Using localConn As MySqlConnection = GetLocalConnection()
                localConn.Open()

                ' ONLY SYNC RECORDS WITH TIME OUT
                Dim selectSql As String = "SELECT * FROM attendance WHERE synced=0 AND attendance_date=CURDATE() AND time_out IS NOT NULL"
                Using selectCmd As New MySqlCommand(selectSql, localConn)
                    Using reader As MySqlDataReader = selectCmd.ExecuteReader()
                        While reader.Read()
                            Dim row As New Dictionary(Of String, Object)
                            row("record_uuid") = reader("record_uuid").ToString()
                            row("student_id") = reader("student_id").ToString()
                            row("firstname") = reader("firstname").ToString()
                            row("lastname") = reader("lastname").ToString()
                            row("attendance_date") = Convert.ToDateTime(reader("attendance_date"))
                            row("time_in") = If(IsDBNull(reader("time_in")), Nothing, reader("time_in").ToString())
                            row("time_out") = If(IsDBNull(reader("time_out")), Nothing, reader("time_out").ToString())
                            row("status") = reader("status").ToString()
                            row("branch_code") = reader("branch_code").ToString()
                            records.Add(row)
                        End While
                    End Using
                End Using

                If records.Count = 0 Then
                    MessageBox.Show("No completed attendance records to sync.")
                    Exit Sub
                End If

                Using centralConn As MySqlConnection = GetCentralConnection()
                    centralConn.Open()

                    For Each rec In records
                        Dim existsCount As Integer
                        Dim checkSql As String = "SELECT COUNT(*) FROM central_attendance WHERE record_uuid=@record_uuid"

                        Using checkCmd As New MySqlCommand(checkSql, centralConn)
                            checkCmd.Parameters.AddWithValue("@record_uuid", rec("record_uuid").ToString())
                            existsCount = Convert.ToInt32(checkCmd.ExecuteScalar())
                        End Using

                        If existsCount = 0 Then
                            Dim insertSql As String = "INSERT INTO central_attendance
                                (record_uuid, student_id, firstname, lastname, attendance_date, time_in, time_out, status, branch_code)
                                VALUES
                                (@record_uuid, @student_id, @firstname, @lastname, @attendance_date, @time_in, @time_out, @status, @branch_code)"

                            Using insertCmd As New MySqlCommand(insertSql, centralConn)
                                insertCmd.Parameters.AddWithValue("@record_uuid", rec("record_uuid").ToString())
                                insertCmd.Parameters.AddWithValue("@student_id", rec("student_id").ToString())
                                insertCmd.Parameters.AddWithValue("@firstname", rec("firstname").ToString())
                                insertCmd.Parameters.AddWithValue("@lastname", rec("lastname").ToString())
                                insertCmd.Parameters.AddWithValue("@attendance_date", CType(rec("attendance_date"), Date).ToString("yyyy-MM-dd"))
                                insertCmd.Parameters.AddWithValue("@time_in", If(rec("time_in") Is Nothing, DBNull.Value, rec("time_in")))
                                insertCmd.Parameters.AddWithValue("@time_out", If(rec("time_out") Is Nothing, DBNull.Value, rec("time_out")))
                                insertCmd.Parameters.AddWithValue("@status", rec("status").ToString())
                                insertCmd.Parameters.AddWithValue("@branch_code", rec("branch_code").ToString())
                                insertCmd.ExecuteNonQuery()
                            End Using
                        Else
                            Dim updateSql As String = "UPDATE central_attendance
                                                       SET time_in=@time_in, time_out=@time_out, status=@status
                                                       WHERE record_uuid=@record_uuid"

                            Using updateCmd As New MySqlCommand(updateSql, centralConn)
                                updateCmd.Parameters.AddWithValue("@record_uuid", rec("record_uuid").ToString())
                                updateCmd.Parameters.AddWithValue("@time_in", If(rec("time_in") Is Nothing, DBNull.Value, rec("time_in")))
                                updateCmd.Parameters.AddWithValue("@time_out", If(rec("time_out") Is Nothing, DBNull.Value, rec("time_out")))
                                updateCmd.Parameters.AddWithValue("@status", rec("status").ToString())
                                updateCmd.ExecuteNonQuery()
                            End Using
                        End If

                        Dim localUpdateSql As String = "UPDATE attendance SET synced=1 WHERE record_uuid=@record_uuid"
                        Using localUpdateCmd As New MySqlCommand(localUpdateSql, localConn)
                            localUpdateCmd.Parameters.AddWithValue("@record_uuid", rec("record_uuid").ToString())
                            localUpdateCmd.ExecuteNonQuery()
                        End Using
                    Next
                End Using
            End Using

            MessageBox.Show("Sync completed successfully.")
            LoadAttendance()

        Catch ex As Exception
            MessageBox.Show("Sync failed: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
End Class