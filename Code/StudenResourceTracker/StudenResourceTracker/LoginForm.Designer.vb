<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        lblUser = New Label()
        lblPassword = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(245, 309)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(184, 27)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(245, 346)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(184, 27)
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Algerian", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(335, 401)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.BackColor = Color.Transparent
        lblUser.Font = New Font("Broadway", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = Color.Black
        lblUser.Location = New Point(110, 309)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(106, 17)
        lblUser.TabIndex = 4
        lblUser.Text = "Username:"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.BackColor = Color.Transparent
        lblPassword.Font = New Font("Broadway", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = Color.Black
        lblPassword.Location = New Point(110, 353)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(100, 17)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSkyBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(lblPassword)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(lblUser)
        Panel1.Controls.Add(txtPassword)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(543, 738)
        Panel1.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(211, 70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 103)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(211, 176)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 46)
        Label1.TabIndex = 7
        Label1.Text = "OART"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(110, 233)
        Label2.Name = "Label2"
        Label2.Size = New Size(329, 28)
        Label2.TabIndex = 6
        Label2.Text = "Open Access · Resources · Tracker"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(540, 730)
        Controls.Add(Panel1)
        Cursor = Cursors.PanWest
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
