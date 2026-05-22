Imports Microsoft.Data.SqlClient

Public Class ReportForm

    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentResourceTrackerDB;Integrated Security=True"

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()
    End Sub

    Private Sub LoadReport()

        Dim query As String = "SELECT * FROM Users"

        Using conn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()

            adapter.Fill(table)
            dgvReport.DataSource = table
        End Using

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Dim tempLogin As New LoginForm()
        Dim main As New MainForm(tempLogin)


        main.lblRole.Text = "ROLE: ADMIN"

        main.Show()

        Me.Close()
    End Sub
End Class
