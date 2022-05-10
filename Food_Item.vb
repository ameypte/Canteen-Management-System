Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class Food_Item
    Dim SqlConn As New MySqlConnection
    Dim SqlCmd As New MySqlCommand
    Dim SqlRd As MySqlDataReader
    Dim SqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "amey"
    Dim database As String = "canteen_management_system"

    Private bitmap As Bitmap

    Private Sub updateTable()
        SqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        SqlConn.Open()
        SqlCmd.Connection = SqlConn
        SqlCmd.CommandText = "SELECT * FROM canteen_management_system.food_item_list"
        SqlRd = SqlCmd.ExecuteReader
        SqlDt.Load(SqlRd)
        SqlRd.Close()
        SqlConn.Close()
        DataGridView1.DataSource = SqlDt
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Food_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iCancel As DialogResult
        iCancel = MessageBox.Show("Do you want to cancel?", "Food items", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iCancel = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SqlConn.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database
        Try
            SqlConn.Open()
            SqlCmd.Connection = SqlConn
            SqlCmd.CommandText = "SELECT * FROM canteen_management_system.food_item_list"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Food items", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try


    End Sub
End Class