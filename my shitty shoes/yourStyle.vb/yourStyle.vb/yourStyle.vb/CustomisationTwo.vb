Public Class FrmCustomisationTwo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If cmbHeelback.SelectedItem <> "White" Then
            dblCurrentPrice += dblHeelBack
        ElseIf cmbLaces.SelectedItem <> "White" Then
            dblCurrentPrice += dblLaces
        ElseIf lblFileSelected.Text <> "No file selected" Then
            dblCurrentPrice += dblLogo
        End If

        FrmText.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click
        'used this video for reference  https://www.youtube.com/watch?v=qVEu3Z9CW84
        'using openfile dialog to allow the user to select their own logo 
        'changing the title of the window 
        OpenFileDialog1.Title = "Browse Logos"
        'open the files browser
        OpenFileDialog1.ShowDialog()
        lblFileSelected.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub lblText_Click(sender As Object, e As EventArgs)

    End Sub
End Class