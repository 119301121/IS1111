Imports System.Drawing.Text
Public Class FrmText
    'i used this video for reference https://www.youtube.com/watch?v=Lzc56H6MTbI&feature=youtu.be
    Dim FontSize As Integer = 8


    Private Sub FrmText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MyFont As New InstalledFontCollection


        For Each FontName As FontFamily In MyFont.Families

            cmbFont.Items.Add(FontName.Name)

        Next
    End Sub

    Private Sub cmbFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFont.SelectedIndexChanged
        'font size is equal to level of track bar
        FontSize = trkSize.Value
        'take the option selected from combo box and match the font style
        If cmbFontStyle.Text = "Regular" Then
            rchText.Font = New Font(cmbFont.Text, FontSize, FontStyle.Regular)
        ElseIf cmbFontStyle.Text = "Bold" Then
            rchText.Font = New Font(cmbFont.Text, FontSize, FontStyle.Bold)
        ElseIf cmbFontStyle.Text = "Italic" Then
            rchText.Font = New Font(cmbFont.Text, FontSize, FontStyle.Italic)
        End If

    End Sub

    Private Sub cmbFontStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFontStyle.SelectedIndexChanged
        FontSize = trkSize.Value

        If cmbFontStyle.Text = "Regular" Then
            rchText.Font = New Font(cmbFont.Text, FontSize, FontStyle.Regular)
        ElseIf cmbFontStyle.Text = "Bold" Then
            rchText.Font = New Font(cmbFont.Text, FontSize, FontStyle.Bold)
        ElseIf cmbFontStyle.Text = "Italic" Then
            rchText.Font = New Font(cmbFont.Text, FontSize, FontStyle.Italic)
        End If

    End Sub

    Private Sub trkSize_Scroll(sender As Object, e As EventArgs) Handles trkSize.Scroll

    End Sub

    Private Sub trkSize_ValueChanged(sender As Object, e As EventArgs) Handles trkSize.ValueChanged

        FontSize = trkSize.Value

        If cmbFontStyle.Text = "Regular" Then
            rchText.Font = New Font(cmbFont.Text, FontSize, FontStyle.Regular)
        ElseIf cmbFontStyle.Text = "Bold" Then
            rchText.Font = New Font(cmbFont.Text, FontSize, FontStyle.Bold)
        ElseIf cmbFontStyle.Text = "Italic" Then
            rchText.Font = New Font(cmbFont.Text, FontSize, FontStyle.Italic)
        End If

    End Sub

    Private Sub rchText_TextChanged(sender As Object, e As EventArgs) Handles rchText.TextChanged
        'if the length of teh streing in the text box is over ten add the extra pricing
        If rchText.Text.Length <= 10 Then
            dblCurrentPrice = dblCurrentPrice + 0.45
        ElseIf rchText.Text.Length > 10 Then
            dblCurrentPrice = dblCurrentPrice + 0.45 + ((rchText.Text.Length - 10) * 0.05)

        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        FrmCustomisationTwo.Show()
        Me.Hide()
    End Sub
End Class