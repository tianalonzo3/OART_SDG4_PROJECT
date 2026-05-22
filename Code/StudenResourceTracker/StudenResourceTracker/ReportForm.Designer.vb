<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        btnBack = New Button()
        CType(dgvReport, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvReport
        ' 
        dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReport.Dock = DockStyle.Fill
        dgvReport.Location = New Point(0, 0)
        dgvReport.Name = "dgvReport"
        dgvReport.RowHeadersWidth = 51
        dgvReport.Size = New Size(800, 450)
        dgvReport.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(0, 421)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(161, 29)
        btnBack.TabIndex = 1
        btnBack.Text = "Back To Dashboard"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' ReportForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(dgvReport)
        Name = "ReportForm"
        Text = "ReportForm"
        CType(dgvReport, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents btnBack As Button
End Class
