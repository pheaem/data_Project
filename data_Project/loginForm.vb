Public Class loginForm
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = "admin" And txtPassword.Text = "admin" Then
            MsgBox("Log in Successfully!", MsgBoxStyle.OkOnly, "Log in Form")
            MenuForm.Show()
            Me.Hide()
        Else
            MsgBox("Sorry Incorrect Username and Password", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub
End Class
