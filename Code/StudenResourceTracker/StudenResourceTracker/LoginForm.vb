Imports Microsoft.Data.SqlClient

Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            Using conn = DBConnection.GetConnection
                conn.Open()

                Dim query =
                    "SELECT Role FROM Users WHERE Username=@Username AND Password=@Password"

                Using cmd As New SqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim)

                    Dim role = cmd.ExecuteScalar
                    ' Inside your btnLogin_Click, replace the showing logic with this:
                    If role IsNot Nothing Then

                        MessageBox.Show("Login Successful!")

                        Dim dashboard As New MainForm(Me)

                        dashboard.UserRole = role.ToString()

                        dashboard.Show()

                        Me.Hide()

                    Else

                        MessageBox.Show("Invalid Username or Password")

                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class