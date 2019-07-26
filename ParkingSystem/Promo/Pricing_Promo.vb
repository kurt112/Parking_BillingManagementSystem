Imports Bunifu.Framework.UI

Public Class Pricing_Promo
    Dim database As Server = New Server
    Dim table As Bunifu.Framework.UI.BunifuCustomDataGrid

    Public Property Table1 As BunifuCustomDataGrid
        Get
            Return table
        End Get
        Set(value As BunifuCustomDataGrid)
            table = value
        End Set
    End Property

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()

    End Sub

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click
        Dim _date As Date = Date.Now
        Try
            If (Promo_Name.Text = "") Then
                Throw New Exception
            Else
                Try
                    Dim Promo_Hours_int As Integer = CInt(Promo_Hours.Text)
                    Try
                        If (Promo_Description.Text = "") Then
                            Throw New Exception
                        Else
                            Try
                                If (promo_ends.Value.Equals(_date)) Then
                                Else
                                    Try
                                        Dim price_float As Integer = CInt(PromoPrice.Text)
                                        database.InsertPromo(New Promo(1, Promo_Name.Text, Promo_Hours_int.ToString,
                                                                       Promo_Description.Text, promo_ends.Value.ToString("dd'/'MM'/'yyyy"),
                                                                       PromoPrice.Text, "Active"))

                                        database.Promo_Table("", table)
                                    Catch ex As Exception
                                        MessageBox.Show("Price should number")
                                    End Try
                                End If
                            Catch ex As Exception
                                MessageBox.Show("Promo should greater than to date now")
                            End Try
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Promo Description is Empty")
                    End Try
                Catch ex As Exception
                    MessageBox.Show("Promo hours should a number")
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Promo Name is empty")
        End Try

    End Sub
End Class