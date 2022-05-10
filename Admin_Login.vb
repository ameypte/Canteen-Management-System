Public Class Admin_Login
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Admin_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtAdminPpassword.Text = "admin" And txtAdminPpassword.Text = "admin" Then
            MessageBox.Show("login successfully!")
            Food_Item.Show()
        End If
    End Sub
End Class