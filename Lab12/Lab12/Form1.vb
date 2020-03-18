Public Class frmInputOutput
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblSpent.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Display expenditure as a percentage of opening 

    End Sub

    Private Sub frmInputOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declaring these as variables
        Dim dblOpening, dblCurrent As Double
        dblOpening = CDbl(txtOpening.Text)
        dblCurrent = CDbl(txtCurrent.Text)
        Dim decSpent As Decimal
        decSpent = CDec(txtSpent.Text





    End Sub
End Class
