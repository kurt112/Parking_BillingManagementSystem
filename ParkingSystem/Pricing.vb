Public Class Pricing
    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click
        Dim promo As Pricing_Promo = New Pricing_Promo()

        promo.ShowDialog()

    End Sub
End Class