Public Class FrmCustomisation




    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        dblCurrentPrice = 0
        FrmYourStyle.Show()
        Me.Hide()
    End Sub


    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If cmbEyestay.SelectedItem <> "White" Then
            dblCurrentPrice += dblEyestay
        ElseIf cmbHeel.SelectedItem <> "White" Then
            dblCurrentPrice += dblHeel
        ElseIf cmbQuarter.SelectedItem <> "White" Then
            dblCurrentPrice += dblQuarter
        ElseIf cmbVamp.SelectedItem <> "White" Then
            dblCurrentPrice += dblVamp
        End If
        FrmCustomisationTwo.Show()
        Me.Hide()
    End Sub
End Class