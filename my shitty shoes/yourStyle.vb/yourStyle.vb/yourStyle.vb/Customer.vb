Public Class FrmCustomer


    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YourStyleDataSet.Order_Summary' table. You can move, or remove it, as needed.
        Me.Order_SummaryTableAdapter.Fill(Me.YourStyleDataSet.Order_Summary)
        'TODO: This line of code loads data into the 'YourStyleDataSet.Customisation' table. You can move, or remove it, as needed.
        Me.CustomisationTableAdapter.Fill(Me.YourStyleDataSet.Customisation)
        'TODO: This line of code loads data into the 'YourStyleDataSet.Customer_Information' table. You can move, or remove it, as needed.
        Me.Customer_InformationTableAdapter.Fill(Me.YourStyleDataSet.Customer_Information)

    End Sub


End Class