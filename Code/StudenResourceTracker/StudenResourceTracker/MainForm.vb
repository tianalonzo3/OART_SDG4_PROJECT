Public Class MainForm
    ' A variable to hold the specific login form instance that opened this main form
    Public UserRole As String
    Private _loginForm As LoginForm

    ' Create a custom constructor to accept the login form
    Public Sub New(loginInstance As LoginForm)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _loginForm = loginInstance
    End Sub

    Private Sub btnResources_Click(sender As Object, e As EventArgs) Handles btnResources.Click

        ResourceForm.UserRole = UserRole

        ResourceForm.ShowDialog()

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ' Verify credentials before rendering the administration window
        If lblRole.Text.ToUpper().Contains("ADMIN") Then
            ' User is authorized: safe to transition to the report grid
            Dim reportForm As New ReportForm()
            reportForm.Show()
            Me.Hide()
        Else
            ' Prevent unauthorized access and notify the student
            MessageBox.Show("Access Denied: You do not have administrative permission to view system reports.",
                        "Authorization Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Use the exact instance that was saved, not the default class shortcut
        _loginForm.Show()
        Me.Close()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRole.Text = "Role: " & UserRole

        If UserRole = "Student" Then

            btnReports.Enabled = False

        End If

    End Sub

    Private Sub lblRole_Click(sender As Object, e As EventArgs) Handles lblRole.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class