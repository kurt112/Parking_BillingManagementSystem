Public Class Pricing
    Private database As Server = New Server

    Private Sub Pricing_Load(sender As Object, e As EventArgs) Handles Me.Load
        database.Promo_Table("", Promo_Table)
    End Sub

    Private Sub Register_Button_Click()
        Dim promo As Pricing_Promo = New Pricing_Promo()
        promo.Table1 = Promo_Table
        promo.ShowDialog()
    End Sub

    Private Sub Create_Promo_Button_Click(sender As Object, e As EventArgs) Handles Create_Promo_Button.Click
        Register_Button_Click()
    End Sub

    Private Sub Promo_Logo_Click(sender As Object, e As EventArgs) Handles Promo_Logo.Click
        Register_Button_Click()
    End Sub

    Private Sub Search_OnValueChanged(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        database.Promo_Table(Search.Text, Promo_Table)
    End Sub
End Class