Imports MySql.Data.MySqlClient

Public Class frmStudentRegistration

    Private Sub frmStudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        RegisterStudent()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub btnLoadStudents_Click(sender As Object, e As EventArgs) Handles btnLoadStudents.Click
        LoadStudents()
    End Sub

    Private Sub RegisterStudent()
        Dim studentId As String = txtStudentID.Text.Trim()
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim lastName As String = txtLastName.Text.Trim()
        Dim course As String = txtCourse.Text.Trim()
        Dim yearLevel As String = txtYearLevel.Text.Trim()
        Dim section As String = txtSection.Text.Trim()

        If studentId = "" OrElse firstName = "" OrElse lastName = "" Then
            MessageBox.Show("Please complete the required fields.")
            Exit Sub
        End If

        Using conn As MySqlConnection = GetLocalConnection()
            conn.Open()

            Dim checkSql As String = "SELECT COUNT(*) FROM students WHERE student_id=@student_id"
            Using checkCmd As New MySqlCommand(checkSql, conn)
                checkCmd.Parameters.AddWithValue("@student_id", studentId)
                If Convert.ToInt32(checkCmd.ExecuteScalar()) > 0 Then
                    MessageBox.Show("Student ID already registered.")
                    Exit Sub
                End If
            End Using

            Dim insertSql As String = "INSERT INTO students(student_id, firstname, lastname, course, year_level, section)
                                       VALUES(@student_id, @firstname, @lastname, @course, @year_level, @section)"

            Using cmd As New MySqlCommand(insertSql, conn)
                cmd.Parameters.AddWithValue("@student_id", studentId)
                cmd.Parameters.AddWithValue("@firstname", firstName)
                cmd.Parameters.AddWithValue("@lastname", lastName)
                cmd.Parameters.AddWithValue("@course", course)
                cmd.Parameters.AddWithValue("@year_level", yearLevel)
                cmd.Parameters.AddWithValue("@section", section)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Student registered successfully.")
        ClearFields()
        LoadStudents()
    End Sub

    Private Sub LoadStudents()
        Using conn As MySqlConnection = GetLocalConnection()
            conn.Open()

            Dim sql As String = "SELECT student_id, firstname, lastname, course, year_level, section
                                 FROM students
                                 ORDER BY lastname ASC"

            Using da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvStudents.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub ClearFields()
        txtStudentID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtCourse.Clear()
        txtYearLevel.Clear()
        txtSection.Clear()
        txtStudentID.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub
End Class