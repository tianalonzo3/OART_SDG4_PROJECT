<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        btnResources = New Button()
        btnReports = New Button()
        btnLogout = New Button()
        lblRole = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnResources
        ' 
        btnResources.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnResources.ForeColor = Color.RoyalBlue
        btnResources.Location = New Point(553, 472)
        btnResources.Name = "btnResources"
        btnResources.Size = New Size(196, 62)
        btnResources.TabIndex = 0
        btnResources.Text = "Resources"
        btnResources.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReports.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnReports.Location = New Point(553, 552)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(196, 62)
        btnReports.TabIndex = 1
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Location = New Point(553, 631)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(196, 62)
        btnLogout.TabIndex = 2
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(553, 431)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(73, 26)
        lblRole.TabIndex = 3
        lblRole.Text = "Roles"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-209, -91)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1915, 1353)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), Image)
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(600, 167)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(110, 103)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MidnightBlue
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(492, 284)
        Label1.Name = "Label1"
        Label1.Size = New Size(332, 48)
        Label1.TabIndex = 11
        Label1.Text = "OART DASHBOARD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.MidnightBlue
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(492, 342)
        Label2.Name = "Label2"
        Label2.Size = New Size(329, 28)
        Label2.TabIndex = 12
        Label2.Text = "Open Access · Resources · Tracker"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1342, 943)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(lblRole)
        Controls.Add(btnLogout)
        Controls.Add(btnReports)
        Controls.Add(btnResources)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Name = "MainForm"
        Text = "MainForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnResources As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
