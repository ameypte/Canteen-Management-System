Imports MySql.Data.MySqlClient

Public Class Add_Customers
    Dim SqlConn As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim SqlRd As MySqlDataReader
    Dim SqlDt As New DataTable
    Dim SqlQuery As String

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "amey"
    Dim database As String = "canteen_management_system"

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        SqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database
        Try
            SqlConn.Open()
            SqlQuery = "Insert into canteen_management_system.customers values(" & txtCustomerId.Text & ",'" & txtFirstName.Text & "','" & txtLastName.Text & "','" & DateTimePickerDOB.Text & "','" & txtAddress.Text & "','" & txtCity.Text & "'," & txtPincode.Text & ",'" & txtPhone.Text & "')"

            SqlCmd = New MySqlCommand(SqlQuery, SqlConn)
            SqlRd = SqlCmd.ExecuteReader
            SqlConn.Close()
            MessageBox.Show("Registration Successful!!")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Food items", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            SqlConn.Dispose()
        End Try
    End Sub
End Class