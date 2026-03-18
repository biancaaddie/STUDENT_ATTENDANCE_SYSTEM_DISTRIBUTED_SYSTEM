<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        dgvReport = New DataGridView()
        dtpFrom = New DateTimePicker()
        dtpTo = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        btnLoadReport = New Button()
        btnFilterDate = New Button()
        btnPrint = New Button()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel2 = New Panel()
        CType(dgvReport, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvReport
        ' 
        dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReport.Location = New Point(12, 127)
        dgvReport.Name = "dgvReport"
        dgvReport.Size = New Size(675, 316)
        dgvReport.TabIndex = 0
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Location = New Point(54, 59)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(200, 23)
        dtpFrom.TabIndex = 1
        ' 
        ' dtpTo
        ' 
        dtpTo.Location = New Point(304, 59)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(200, 23)
        dtpTo.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 15)
        Label1.TabIndex = 3
        Label1.Text = "From:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(276, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(23, 15)
        Label2.TabIndex = 4
        Label2.Text = "To:"
        ' 
        ' btnLoadReport
        ' 
        btnLoadReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnLoadReport.FlatStyle = FlatStyle.Flat
        btnLoadReport.Location = New Point(287, 462)
        btnLoadReport.Name = "btnLoadReport"
        btnLoadReport.Size = New Size(193, 30)
        btnLoadReport.TabIndex = 5
        btnLoadReport.Text = "Load Report"
        btnLoadReport.UseVisualStyleBackColor = True
        ' 
        ' btnFilterDate
        ' 
        btnFilterDate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnFilterDate.FlatStyle = FlatStyle.Flat
        btnFilterDate.Location = New Point(12, 97)
        btnFilterDate.Name = "btnFilterDate"
        btnFilterDate.Size = New Size(125, 24)
        btnFilterDate.TabIndex = 6
        btnFilterDate.Text = "Filter by Date"
        btnFilterDate.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Location = New Point(496, 462)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(193, 30)
        btnPrint.TabIndex = 7
        btnPrint.Text = "Print Reports"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkRed
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-6, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(712, 28)
        Panel1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLight
        Button1.Location = New Point(675, -1)
        Button1.Name = "Button1"
        Button1.Size = New Size(34, 29)
        Button1.TabIndex = 0
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkRed
        Panel2.Location = New Point(11, 126)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(677, 318)
        Panel2.TabIndex = 9
        ' 
        ' frmReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(699, 504)
        Controls.Add(Panel1)
        Controls.Add(btnPrint)
        Controls.Add(btnFilterDate)
        Controls.Add(btnLoadReport)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtpTo)
        Controls.Add(dtpFrom)
        Controls.Add(dgvReport)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmReports"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmReports"
        CType(dgvReport, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLoadReport As Button
    Friend WithEvents btnFilterDate As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
End Class
