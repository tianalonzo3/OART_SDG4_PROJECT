<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResourceForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResourceForm))
        txtTitle = New TextBox()
        txtFilePath = New TextBox()
        txtSubject = New TextBox()
        txtDescription = New TextBox()
        dgvResources = New DataGridView()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnLoad = New Button()
        lblTitle = New Label()
        lblDescription = New Label()
        lblSubject = New Label()
        lblFilePath = New Label()
        PictureBox1 = New PictureBox()
        CType(dgvResources, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(251, 41)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(125, 27)
        txtTitle.TabIndex = 0
        ' 
        ' txtFilePath
        ' 
        txtFilePath.Location = New Point(251, 141)
        txtFilePath.Name = "txtFilePath"
        txtFilePath.Size = New Size(125, 27)
        txtFilePath.TabIndex = 1
        ' 
        ' txtSubject
        ' 
        txtSubject.Location = New Point(251, 108)
        txtSubject.Name = "txtSubject"
        txtSubject.Size = New Size(125, 27)
        txtSubject.TabIndex = 2
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(251, 74)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(125, 27)
        txtDescription.TabIndex = 3
        ' 
        ' dgvResources
        ' 
        dgvResources.BackgroundColor = SystemColors.InactiveBorder
        dgvResources.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResources.Location = New Point(132, 202)
        dgvResources.Name = "dgvResources"
        dgvResources.RowHeadersWidth = 51
        dgvResources.Size = New Size(530, 220)
        dgvResources.TabIndex = 4
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Showcard Gothic", 9.0F, FontStyle.Bold)
        btnAdd.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnAdd.Location = New Point(474, 51)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(84, 50)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Showcard Gothic", 9.0F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.Lime
        btnUpdate.Location = New Point(578, 51)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(84, 50)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Showcard Gothic", 9.0F, FontStyle.Bold)
        btnDelete.ForeColor = Color.Red
        btnDelete.Location = New Point(474, 118)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(84, 50)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnLoad
        ' 
        btnLoad.Font = New Font("Showcard Gothic", 9.0F, FontStyle.Bold)
        btnLoad.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnLoad.Location = New Point(578, 118)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(84, 50)
        btnLoad.TabIndex = 8
        btnLoad.Text = "Load"
        btnLoad.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(132, 44)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(44, 20)
        lblTitle.TabIndex = 9
        lblTitle.Text = "Title:"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescription.Location = New Point(132, 77)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(93, 20)
        lblDescription.TabIndex = 10
        lblDescription.Text = "Description:"
        ' 
        ' lblSubject
        ' 
        lblSubject.AutoSize = True
        lblSubject.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSubject.Location = New Point(132, 108)
        lblSubject.Name = "lblSubject"
        lblSubject.Size = New Size(64, 20)
        lblSubject.TabIndex = 11
        lblSubject.Text = "Subject:"
        ' 
        ' lblFilePath
        ' 
        lblFilePath.AutoSize = True
        lblFilePath.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFilePath.Location = New Point(132, 144)
        lblFilePath.Name = "lblFilePath"
        lblFilePath.Size = New Size(69, 20)
        lblFilePath.TabIndex = 12
        lblFilePath.Text = "FilePath:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-2, -8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(805, 463)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' ResourceForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblFilePath)
        Controls.Add(lblSubject)
        Controls.Add(lblDescription)
        Controls.Add(lblTitle)
        Controls.Add(btnLoad)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(dgvResources)
        Controls.Add(txtDescription)
        Controls.Add(txtSubject)
        Controls.Add(txtFilePath)
        Controls.Add(txtTitle)
        Controls.Add(PictureBox1)
        Name = "ResourceForm"
        Text = "Resource"
        CType(dgvResources, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents dgvResources As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblFilePath As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
