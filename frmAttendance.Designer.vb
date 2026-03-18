<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendance
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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnSubmitAttendance = New Button()
        txtStudentID = New TextBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        lblAttendanceStatus = New Label()
        lblStudentName = New Label()
        btnLoadAttendance = New Button()
        btnViewUnsynced = New Button()
        btnSync = New Button()
        GroupBox3 = New GroupBox()
        Label3 = New Label()
        dgvAttendance = New DataGridView()
        lblBranch = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(133, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(388, 32)
        Label1.TabIndex = 1
        Label1.Text = "ATTENDANCE MONITORING"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnSubmitAttendance)
        GroupBox1.Controls.Add(txtStudentID)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(30, 76)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(585, 69)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' btnSubmitAttendance
        ' 
        btnSubmitAttendance.FlatAppearance.MouseOverBackColor = Color.LimeGreen
        btnSubmitAttendance.FlatStyle = FlatStyle.Flat
        btnSubmitAttendance.Location = New Point(452, 22)
        btnSubmitAttendance.Name = "btnSubmitAttendance"
        btnSubmitAttendance.Size = New Size(113, 25)
        btnSubmitAttendance.TabIndex = 15
        btnSubmitAttendance.Text = "Submit"
        btnSubmitAttendance.UseVisualStyleBackColor = True
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(155, 24)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(271, 23)
        txtStudentID.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(19, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 18)
        Label2.TabIndex = 13
        Label2.Text = "Enter Student ID:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblAttendanceStatus)
        GroupBox2.Controls.Add(lblStudentName)
        GroupBox2.Location = New Point(30, 162)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(585, 103)
        GroupBox2.TabIndex = 16
        GroupBox2.TabStop = False
        ' 
        ' lblAttendanceStatus
        ' 
        lblAttendanceStatus.AutoSize = True
        lblAttendanceStatus.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAttendanceStatus.Location = New Point(19, 73)
        lblAttendanceStatus.Name = "lblAttendanceStatus"
        lblAttendanceStatus.Size = New Size(57, 18)
        lblAttendanceStatus.TabIndex = 14
        lblAttendanceStatus.Text = "Status:"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentName.Location = New Point(19, 29)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(112, 18)
        lblStudentName.TabIndex = 13
        lblStudentName.Text = "Student Name:"
        ' 
        ' btnLoadAttendance
        ' 
        btnLoadAttendance.FlatAppearance.MouseOverBackColor = Color.LimeGreen
        btnLoadAttendance.FlatStyle = FlatStyle.Flat
        btnLoadAttendance.Location = New Point(30, 271)
        btnLoadAttendance.Name = "btnLoadAttendance"
        btnLoadAttendance.Size = New Size(185, 45)
        btnLoadAttendance.TabIndex = 17
        btnLoadAttendance.Text = "Load Attendance"
        btnLoadAttendance.UseVisualStyleBackColor = True
        ' 
        ' btnViewUnsynced
        ' 
        btnViewUnsynced.FlatAppearance.MouseOverBackColor = Color.LimeGreen
        btnViewUnsynced.FlatStyle = FlatStyle.Flat
        btnViewUnsynced.Location = New Point(227, 271)
        btnViewUnsynced.Name = "btnViewUnsynced"
        btnViewUnsynced.Size = New Size(189, 45)
        btnViewUnsynced.TabIndex = 18
        btnViewUnsynced.Text = "Show Unsynced"
        btnViewUnsynced.UseVisualStyleBackColor = True
        ' 
        ' btnSync
        ' 
        btnSync.FlatAppearance.MouseOverBackColor = Color.LimeGreen
        btnSync.FlatStyle = FlatStyle.Flat
        btnSync.Location = New Point(426, 271)
        btnSync.Name = "btnSync"
        btnSync.Size = New Size(189, 45)
        btnSync.TabIndex = 19
        btnSync.Text = "Sync Records"
        btnSync.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Location = New Point(30, 322)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(585, 43)
        GroupBox3.TabIndex = 16
        GroupBox3.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(6, 17)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 18)
        Label3.TabIndex = 13
        Label3.Text = "Attendance Records"
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendance.Location = New Point(30, 371)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.Size = New Size(585, 222)
        dgvAttendance.TabIndex = 20
        ' 
        ' lblBranch
        ' 
        lblBranch.AutoSize = True
        lblBranch.Location = New Point(568, 608)
        lblBranch.Name = "lblBranch"
        lblBranch.Size = New Size(47, 15)
        lblBranch.TabIndex = 21
        lblBranch.Text = "Branch:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkRed
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(676, 25)
        Panel1.TabIndex = 22
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(617, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(37, 23)
        Button1.TabIndex = 23
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkRed
        Panel2.Location = New Point(29, 75)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(587, 71)
        Panel2.TabIndex = 23
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkRed
        Panel3.Location = New Point(29, 161)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(587, 105)
        Panel3.TabIndex = 16
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DarkRed
        Panel4.Location = New Point(29, 370)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(587, 224)
        Panel4.TabIndex = 24
        ' 
        ' frmAttendance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(652, 632)
        Controls.Add(Panel1)
        Controls.Add(lblBranch)
        Controls.Add(dgvAttendance)
        Controls.Add(GroupBox3)
        Controls.Add(btnSync)
        Controls.Add(btnViewUnsynced)
        Controls.Add(btnLoadAttendance)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAttendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAttendance"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents btnSubmitAttendance As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblAttendanceStatus As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents btnLoadAttendance As Button
    Friend WithEvents btnViewUnsynced As Button
    Friend WithEvents btnSync As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents lblBranch As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
