<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblWelcome = New Label()
        btnStudentRegistration = New Button()
        btnDashboard = New Button()
        btnAttendance = New Button()
        btnReports = New Button()
        btnLogout = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = SystemColors.ButtonHighlight
        lblWelcome.Location = New Point(32, 44)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(0, 32)
        lblWelcome.TabIndex = 0
        ' 
        ' btnStudentRegistration
        ' 
        btnStudentRegistration.BackColor = Color.White
        btnStudentRegistration.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnStudentRegistration.FlatStyle = FlatStyle.Flat
        btnStudentRegistration.Location = New Point(32, 108)
        btnStudentRegistration.Margin = New Padding(3, 4, 3, 4)
        btnStudentRegistration.Name = "btnStudentRegistration"
        btnStudentRegistration.Size = New Size(507, 93)
        btnStudentRegistration.TabIndex = 1
        btnStudentRegistration.Text = "STUDENT REGISTRATION"
        btnStudentRegistration.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.White
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Location = New Point(32, 366)
        btnDashboard.Margin = New Padding(3, 4, 3, 4)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(507, 93)
        btnDashboard.TabIndex = 2
        btnDashboard.Text = "DASHBOARD"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' btnAttendance
        ' 
        btnAttendance.BackColor = Color.White
        btnAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnAttendance.FlatStyle = FlatStyle.Flat
        btnAttendance.Location = New Point(32, 231)
        btnAttendance.Margin = New Padding(3, 4, 3, 4)
        btnAttendance.Name = "btnAttendance"
        btnAttendance.Size = New Size(507, 93)
        btnAttendance.TabIndex = 3
        btnAttendance.Text = "ATTENDANCE MONITORING"
        btnAttendance.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.White
        btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Location = New Point(32, 488)
        btnReports.Margin = New Padding(3, 4, 3, 4)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(507, 93)
        btnReports.TabIndex = 4
        btnReports.Text = "REPORTS"
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.White
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Location = New Point(158, 616)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(259, 56)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(546, 0)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 36)
        Button1.TabIndex = 6
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Firebrick
        ClientSize = New Size(585, 727)
        Controls.Add(Button1)
        Controls.Add(btnLogout)
        Controls.Add(btnReports)
        Controls.Add(btnAttendance)
        Controls.Add(btnDashboard)
        Controls.Add(btnStudentRegistration)
        Controls.Add(lblWelcome)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmMainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmMainMenu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnStudentRegistration As Button
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button1 As Button
End Class
