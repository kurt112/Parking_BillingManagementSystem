Public Class Pricing
    Private database As Server = New Server

    Private Sub Pricing_Load(sender As Object, e As EventArgs) Handles Me.Load
        database.Table1 = Promo_Table
        database.Promo_Table("")

    End Sub

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click
        Dim promo As Pricing_Promo = New Pricing_Promo()
        promo.Table1 = Promo_Table
        promo.ShowDialog()

    End Sub





End Class