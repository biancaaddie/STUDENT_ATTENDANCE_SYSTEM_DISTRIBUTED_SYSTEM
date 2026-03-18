<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentRegistration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtCourse = New TextBox()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtStudentID = New TextBox()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtYearLevel = New TextBox()
        Label5 = New Label()
        txtSection = New TextBox()
        Label7 = New Label()
        btnRegister = New Button()
        btnClear = New Button()
        btnLoadStudents = New Button()
        dgvStudents = New DataGridView()
        Label8 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 15.75F, FontStyle.Bold)
        Label1.Location = New Point(205, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(266, 24)
        Label1.TabIndex = 0
        Label1.Text = "STUDENT REGISTRATION"
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(205, 231)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(402, 23)
        txtCourse.TabIndex = 10
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(205, 140)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(402, 23)
        txtFirstName.TabIndex = 8
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(205, 187)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(402, 23)
        txtLastName.TabIndex = 9
        ' 
        ' txtStudentID
        ' 
        txtStudentID.Location = New Point(205, 85)
        txtStudentID.Name = "txtStudentID"
        txtStudentID.Size = New Size(402, 23)
        txtStudentID.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label6.Location = New Point(61, 236)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 18)
        Label6.TabIndex = 5
        Label6.Text = "Course:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label4.Location = New Point(61, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 18)
        Label4.TabIndex = 3
        Label4.Text = "First Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label3.Location = New Point(61, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 18)
        Label3.TabIndex = 2
        Label3.Text = "Last Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label2.Location = New Point(61, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 18)
        Label2.TabIndex = 1
        Label2.Text = "Student Number:"
        ' 
        ' txtYearLevel
        ' 
        txtYearLevel.Location = New Point(205, 278)
        txtYearLevel.Name = "txtYearLevel"
        txtYearLevel.Size = New Size(402, 23)
        txtYearLevel.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label5.Location = New Point(61, 283)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 18)
        Label5.TabIndex = 4
        Label5.Text = "Year Level:"
        ' 
        ' txtSection
        ' 
        txtSection.Location = New Point(205, 324)
        txtSection.Name = "txtSection"
        txtSection.Size = New Size(402, 23)
        txtSection.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 11.25F, FontStyle.Bold)
        Label7.Location = New Point(61, 329)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 18)
        Label7.TabIndex = 6
        Label7.Text = "Section:"
        ' 
        ' btnRegister
        ' 
        btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Location = New Point(196, 380)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(120, 40)
        btnRegister.TabIndex = 13
        btnRegister.Text = "Register"
        ' 
        ' btnClear
        ' 
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Location = New Point(341, 380)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(120, 40)
        btnClear.TabIndex = 14
        btnClear.Text = "Clear"
        ' 
        ' btnLoadStudents
        ' 
        btnLoadStudents.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnLoadStudents.FlatStyle = FlatStyle.Flat
        btnLoadStudents.Location = New Point(486, 380)
        btnLoadStudents.Name = "btnLoadStudents"
        btnLoadStudents.Size = New Size(120, 40)
        btnLoadStudents.TabIndex = 15
        btnLoadStudents.Text = "Load Students"
        ' 
        ' dgvStudents
        ' 
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(-2, 463)
        dgvStudents.Name = "dgvStudents"
        dgvStudents.Size = New Size(682, 267)
        dgvStudents.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(-2, 441)
        Label8.Name = "Label8"
        Label8.Size = New Size(165, 19)
        Label8.TabIndex = 17
        Label8.Text = "Registered Students"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkRed
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(701, 22)
        Panel1.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLight
        Button1.Location = New Point(640, -4)
        Button1.Name = "Button1"
        Button1.Size = New Size(41, 26)
        Button1.TabIndex = 0
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkRed
        Panel2.Location = New Point(205, 85)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(402, 25)
        Panel2.TabIndex = 19
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkRed
        Panel3.Location = New Point(205, 140)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(402, 25)
        Panel3.TabIndex = 20
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DarkRed
        Panel4.Location = New Point(205, 187)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(402, 25)
        Panel4.TabIndex = 20
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DarkRed
        Panel5.Location = New Point(205, 231)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(402, 25)
        Panel5.TabIndex = 21
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.DarkRed
        Panel6.Location = New Point(205, 278)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(402, 25)
        Panel6.TabIndex = 20
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.DarkRed
        Panel7.Location = New Point(205, 324)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(402, 25)
        Panel7.TabIndex = 20
        ' 
        ' frmStudentRegistration
        ' 
        ClientSize = New Size(677, 716)
        Controls.Add(Panel1)
        Controls.Add(Label8)
        Controls.Add(dgvStudents)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(txtStudentID)
        Controls.Add(txtFirstName)
        Controls.Add(txtLastName)
        Controls.Add(txtCourse)
        Controls.Add(txtYearLevel)
        Controls.Add(txtSection)
        Controls.Add(btnRegister)
        Controls.Add(btnClear)
        Controls.Add(btnLoadStudents)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmStudentRegistration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Registration"
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtYearLevel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSection As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnLoadStudents As Button
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel

End Class