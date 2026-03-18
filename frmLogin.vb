Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboBranch.Items.Clear()
        cboBranch.Items.Add("Branch A")
        cboBranch.Items.Add("Branch B")
        cboBranch.Items.Add("Branch C")
        cboBranch.Items.Add("Main Branch")
        cboBranch.SelectedIndex = 0
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginUser()
    End Sub

    Private Sub LoginUser()

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim selectedBranch As String = cboBranch.Text

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter username and password.")
            Exit Sub
        End If

        If selectedBranch = "Branch A" Then
            CurrentLocalDatabase = "attendance_branch_a"
            CurrentBranchCode = "A"
            CurrentRole = "Branch"

        ElseIf selectedBranch = "Branch B" Then
            CurrentLocalDatabase = "attendance_branch_b"
            CurrentBranchCode = "B"
            CurrentRole = "Branch"

        ElseIf selectedBranch = "Branch C" Then
            CurrentLocalDatabase = "attendance_branch_c"
            CurrentBranchCode = "C"
            CurrentRole = "Branch"

        ElseIf selectedBranch = "Main Branch" Then
            CurrentLocalDatabase = "attendance_central"
            CurrentBranchCode = "MAIN"
            CurrentRole = "Main"
        End If

        ' MAIN BRANCH LOGIN
        If CurrentRole = "Main" Then

            If username = "main" AndAlso password = "1234" Then

                CurrentUsername = username

                ' CLEAR TEXTBOXES AFTER LOGIN
                txtUsername.Clear()
                txtPassword.Clear()
                cboBranch.SelectedIndex = 0

                Dim f As New frmMainMenu()
                f.Show()
                Me.Hide()

            Else
                MessageBox.Show("Invalid main branch login.")
            End If

            Exit Sub
        End If

        ' BRANCH LOGIN
        Using conn As MySqlConnection = GetLocalConnection()

            conn.Open()

            Dim sql As String = "SELECT COUNT(*) FROM users WHERE username=@username AND password=@password AND branch_code=@branch_code"

            Using cmd As New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@branch_code", CurrentBranchCode)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then

                    CurrentUsername = username

                    ' CLEAR TEXTBOXES AFTER LOGIN
                    txtUsername.Clear()
                    txtPassword.Clear()
                    cboBranch.SelectedIndex = 0

                    Dim f As New frmMainMenu()
                    f.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Invalid login.")
                End If

            End Using

        End Using

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
        cboBranch.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class