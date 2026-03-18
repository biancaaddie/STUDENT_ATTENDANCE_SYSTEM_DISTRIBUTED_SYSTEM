Public Class frmMainMenu

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome: " & CurrentUsername &
                          " | Branch: " & CurrentBranchCode &
                          " | Role: " & CurrentRole

        If CurrentRole = "Branch" Then
            btnStudentRegistration.Visible = True
            btnAttendance.Visible = True
            btnDashboard.Visible = False
            btnReports.Visible = False

        ElseIf CurrentRole = "Main" Then
            btnStudentRegistration.Visible = False
            btnAttendance.Visible = False
            btnDashboard.Visible = True
            btnReports.Visible = True
        End If
    End Sub

    Private Sub btnStudentRegistration_Click(sender As Object, e As EventArgs) Handles btnStudentRegistration.Click
        Dim f As New frmStudentRegistration()
        f.ShowDialog()
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Dim f As New frmAttendance()
        f.ShowDialog()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim f As New frmDashboard()
        f.ShowDialog()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim f As New frmReports()
        f.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class