Public Class FrmManager
    Private Sub pctPrinter_Click(sender As Object, e As EventArgs) Handles pctPrinter.Click
        FrmPrint.Show()
        Me.Hide()
    End Sub

    Private Sub pctShoe_Click(sender As Object, e As EventArgs) Handles pctShoe.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmCustomer.Show()
        Me.Hide()
    End Sub
End Class