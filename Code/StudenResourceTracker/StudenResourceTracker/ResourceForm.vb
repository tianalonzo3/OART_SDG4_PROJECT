Imports Microsoft.Data.SqlClient

Public Class ResourceForm
    Public Shared Property UserRole As String

    Private Sub ResourceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If UserRole = "Student" Then

            btnAdd.Enabled = False
            btnUpdate.Enabled = False
            btnDelete.Enabled = False

        End If
    End Sub

    Public Class Resource

        Public Property ResourceID As Integer
        Public Property Title As String
        Public Property Description As String
        Public Property Subject As String
        Public Property FilePath As String

    End Class

    Private Sub LoadResources()

        Dim conn As SqlConnection = DBConnection.GetConnection()

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM Resources"

            Dim adapter As New SqlDataAdapter(query, conn)

            Dim table As New DataTable()

            adapter.Fill(table)

            dgvResources.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadResources()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtTitle.Text = "" Then
            MessageBox.Show("Title is required")
            Exit Sub
        End If

        Dim conn As SqlConnection = DBConnection.GetConnection()

        Try
            conn.Open()

            Dim query As String =
                "INSERT INTO Resources (Title, Description, Subject, FilePath)
             VALUES (@Title, @Description, @Subject, @FilePath)"

            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@Title", txtTitle.Text)
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text)
            cmd.Parameters.AddWithValue("@Subject", txtSubject.Text)
            cmd.Parameters.AddWithValue("@FilePath", txtFilePath.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Resource Added")

            LoadResources()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim conn As SqlConnection = DBConnection.GetConnection()

        Try
            conn.Open()

            Dim query As String =
                "UPDATE Resources
             SET Title=@Title,
                 Description=@Description,
                 Subject=@Subject,
                 FilePath=@FilePath
             WHERE ResourceID=@ResourceID"

            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@Title", txtTitle.Text)
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text)
            cmd.Parameters.AddWithValue("@Subject", txtSubject.Text)
            cmd.Parameters.AddWithValue("@FilePath", txtFilePath.Text)

            cmd.Parameters.AddWithValue("@ResourceID",
                dgvResources.CurrentRow.Cells("ResourceID").Value)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Resource Updated")

            LoadResources()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim conn As SqlConnection = DBConnection.GetConnection()

        Try
            conn.Open()

            Dim query As String =
                "DELETE FROM Resources WHERE ResourceID=@ResourceID"

            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@ResourceID",
                dgvResources.CurrentRow.Cells("ResourceID").Value)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Resource Deleted")

            LoadResources()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub dgvResources_CellClick(sender As Object,
                                   e As DataGridViewCellEventArgs) _
                                   Handles dgvResources.CellClick

        txtTitle.Text =
            dgvResources.CurrentRow.Cells("Title").Value.ToString()

        txtDescription.Text =
            dgvResources.CurrentRow.Cells("Description").Value.ToString()

        txtSubject.Text =
            dgvResources.CurrentRow.Cells("Subject").Value.ToString()

        txtFilePath.Text =
            dgvResources.CurrentRow.Cells("FilePath").Value.ToString()

    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class