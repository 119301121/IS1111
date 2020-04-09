Public Class FrmPrint
    Private Sub Customer_InformationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Customer_InformationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.YourStyleDataSet)

    End Sub

    Private Sub FrmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YourStyleDataSet.Customer_Information' table. You can move, or remove it, as needed.
        Me.Customer_InformationTableAdapter.Fill(Me.YourStyleDataSet.Customer_Information)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Frmprinter.Show()
    End Sub
End Class