Public Class FrmManagerLogin
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        'had to hard code the variables because we couldn't get access working properly
        Dim strName As String = "Admin"
        Dim strPassword As String = "AccessIsHell"

        'validation for textboxes. Jack cant understand why you dont know the password.
        If txtName.Text = Nothing Then
            MsgBox("Please fill all fields")
            pctJack.Visible = True
        ElseIf txtPassword.Text = Nothing Then
            MsgBox("Please fill all fields")
            pctJack.Visible = True
        End If

        'moving to the manager form if the password is entered correctly or else show a message box to say something is wrong
        If txtName.Text = strName And txtPassword.Text = strPassword Then
            FrmManager.Show()
            Me.Hide()
        Else
            MsgBox("Username or password incorrect")
        End If
    End Sub
End Class