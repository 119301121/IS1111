Public Class FrmYourStyle
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'if the corresponding radiobutton is checked the price will be added to the price variable
        If rdoClassic.Checked = True Then
            dblCurrentPrice += dblClassic
        ElseIf rdoRetro.Checked = True Then
            dblCurrentPrice += dblRetro
        Else rdoVintage.Checked = True
            dblCurrentPrice += dblVintage
        End If

        FrmCustomisation.Show()
        Me.Hide()
    End Sub
End Class
