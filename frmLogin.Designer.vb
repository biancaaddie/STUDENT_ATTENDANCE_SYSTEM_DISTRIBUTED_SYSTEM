<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        cboBranch = New ComboBox()
        Label4 = New Label()
        btnClear = New Button()
        Panel1 = New Panel()
        Button1 = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(64, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(343, 24)
        Label2.TabIndex = 1
        Label2.Text = "STUDENT ATTENDANCE SYSTEM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(39, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 22)
        Label3.TabIndex = 4
        Label3.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label1.Location = New Point(39, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 22)
        Label1.TabIndex = 3
        Label1.Text = "Username:"
        ' 
        ' btnLogin
        ' 
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnLogin.Location = New Point(351, 303)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(93, 41)
        btnLogin.TabIndex = 10
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(215, 179)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(229, 23)
        txtPassword.TabIndex = 8
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(215, 122)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(229, 23)
        txtUsername.TabIndex = 7
        ' 
        ' cboBranch
        ' 
        cboBranch.FormattingEnabled = True
        cboBranch.Items.AddRange(New Object() {"Branch A", "Branch B", "Branch C", "Main Branch"})
        cboBranch.Location = New Point(215, 234)
        cboBranch.Name = "cboBranch"
        cboBranch.Size = New Size(229, 23)
        cboBranch.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(39, 235)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 22)
        Label4.TabIndex = 12
        Label4.Text = "Branch:"
        ' 
        ' btnClear
        ' 
        btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Arial", 9F, FontStyle.Bold)
        btnClear.Location = New Point(234, 303)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(93, 41)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkRed
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(512, 22)
        Panel1.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(437, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(33, 23)
        Button1.TabIndex = 15
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.DarkRed
        FlowLayoutPanel1.Location = New Point(215, 122)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(229, 25)
        FlowLayoutPanel1.TabIndex = 15
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.BackColor = Color.DarkRed
        FlowLayoutPanel2.Location = New Point(215, 179)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(229, 25)
        FlowLayoutPanel2.TabIndex = 16
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.BackColor = Color.DarkRed
        FlowLayoutPanel3.Location = New Point(215, 234)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(229, 25)
        FlowLayoutPanel3.TabIndex = 17
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(476, 371)
        Controls.Add(Panel1)
        Controls.Add(btnClear)
        Controls.Add(Label4)
        Controls.Add(cboBranch)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(FlowLayoutPanel3)
        Controls.Add(FlowLayoutPanel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents cboBranch As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel

End Class
