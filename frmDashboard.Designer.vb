<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        btnLoadRecords = New Button()
        btnLoadSummary = New Button()
        Label1 = New Label()
        lblGrandTotal = New Label()
        lblBranchATotal = New Label()
        lblBranchBTotal = New Label()
        lblBranchCTotal = New Label()
        GroupBox1 = New GroupBox()
        ChartBar = New DataVisualization.Charting.Chart()
        ChartPie = New DataVisualization.Charting.Chart()
        dgvRecords = New DataGridView()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel2 = New Panel()
        GroupBox1.SuspendLayout()
        CType(ChartBar, ComponentModel.ISupportInitialize).BeginInit()
        CType(ChartPie, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvRecords, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLoadRecords
        ' 
        btnLoadRecords.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnLoadRecords.FlatStyle = FlatStyle.Flat
        btnLoadRecords.Location = New Point(14, 92)
        btnLoadRecords.Name = "btnLoadRecords"
        btnLoadRecords.Size = New Size(128, 36)
        btnLoadRecords.TabIndex = 0
        btnLoadRecords.Text = "Load All Records"
        btnLoadRecords.UseVisualStyleBackColor = True
        ' 
        ' btnLoadSummary
        ' 
        btnLoadSummary.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnLoadSummary.FlatStyle = FlatStyle.Flat
        btnLoadSummary.Location = New Point(148, 92)
        btnLoadSummary.Name = "btnLoadSummary"
        btnLoadSummary.Size = New Size(128, 36)
        btnLoadSummary.TabIndex = 1
        btnLoadSummary.Text = "Load Summary"
        btnLoadSummary.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(194, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 32)
        Label1.TabIndex = 2
        Label1.Text = "MAIN DASHBOARD"
        ' 
        ' lblGrandTotal
        ' 
        lblGrandTotal.AutoSize = True
        lblGrandTotal.Location = New Point(44, 33)
        lblGrandTotal.Name = "lblGrandTotal"
        lblGrandTotal.Size = New Size(68, 15)
        lblGrandTotal.TabIndex = 3
        lblGrandTotal.Text = "Grand Total"
        ' 
        ' lblBranchATotal
        ' 
        lblBranchATotal.AutoSize = True
        lblBranchATotal.Location = New Point(180, 33)
        lblBranchATotal.Name = "lblBranchATotal"
        lblBranchATotal.Size = New Size(55, 15)
        lblBranchATotal.TabIndex = 4
        lblBranchATotal.Text = "Branch A"
        ' 
        ' lblBranchBTotal
        ' 
        lblBranchBTotal.AutoSize = True
        lblBranchBTotal.Location = New Point(343, 33)
        lblBranchBTotal.Name = "lblBranchBTotal"
        lblBranchBTotal.Size = New Size(54, 15)
        lblBranchBTotal.TabIndex = 5
        lblBranchBTotal.Text = "Branch B"
        ' 
        ' lblBranchCTotal
        ' 
        lblBranchCTotal.AutoSize = True
        lblBranchCTotal.Location = New Point(492, 33)
        lblBranchCTotal.Name = "lblBranchCTotal"
        lblBranchCTotal.Size = New Size(55, 15)
        lblBranchCTotal.TabIndex = 6
        lblBranchCTotal.Text = "Branch C"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblBranchBTotal)
        GroupBox1.Controls.Add(lblBranchCTotal)
        GroupBox1.Controls.Add(lblGrandTotal)
        GroupBox1.Controls.Add(lblBranchATotal)
        GroupBox1.Location = New Point(14, 134)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(633, 69)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' ChartBar
        ' 
        ChartArea1.Name = "ChartArea1"
        ChartBar.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        ChartBar.Legends.Add(Legend1)
        ChartBar.Location = New Point(14, 444)
        ChartBar.Name = "ChartBar"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        ChartBar.Series.Add(Series1)
        ChartBar.Size = New Size(299, 270)
        ChartBar.TabIndex = 8
        ChartBar.Text = "Chart1"
        ' 
        ' ChartPie
        ' 
        ChartArea2.Name = "ChartArea1"
        ChartPie.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        ChartPie.Legends.Add(Legend2)
        ChartPie.Location = New Point(327, 444)
        ChartPie.Name = "ChartPie"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        ChartPie.Series.Add(Series2)
        ChartPie.Size = New Size(320, 270)
        ChartPie.TabIndex = 9
        ChartPie.Text = "Chart2"
        ' 
        ' dgvRecords
        ' 
        dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecords.Location = New Point(14, 223)
        dgvRecords.Name = "dgvRecords"
        dgvRecords.Size = New Size(633, 215)
        dgvRecords.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkRed
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-3, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(665, 25)
        Panel1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(630, -1)
        Button1.Name = "Button1"
        Button1.Size = New Size(32, 23)
        Button1.TabIndex = 0
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkRed
        Panel2.Location = New Point(13, 222)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(635, 217)
        Panel2.TabIndex = 12
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 730)
        Controls.Add(Panel1)
        Controls.Add(dgvRecords)
        Controls.Add(ChartPie)
        Controls.Add(ChartBar)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(btnLoadSummary)
        Controls.Add(btnLoadRecords)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmDashboard"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ChartBar, ComponentModel.ISupportInitialize).EndInit()
        CType(ChartPie, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvRecords, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLoadRecords As Button
    Friend WithEvents btnLoadSummary As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents lblBranchATotal As Label
    Friend WithEvents lblBranchBTotal As Label
    Friend WithEvents lblBranchCTotal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChartBar As DataVisualization.Charting.Chart
    Friend WithEvents ChartPie As DataVisualization.Charting.Chart
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
End Class
