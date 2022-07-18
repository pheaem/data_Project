Public Class loginForm
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = "admin" And txtPassword.Text = "admin" Then
            MenuForm.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username and Password", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class
