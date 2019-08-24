Imports Bunifu.Framework.UI
Imports ParkingSystem

Public Class Pricing_Promo
    ReadOnly database As Server = New Server

    Dim table As BunifuCustomDataGrid
    Private Shadows update As Boolean = False
    Private promo As Promo = New Promo(0, "", "", "", "", "", "")
    Private Shadows look As Boolean = False
    Public Property Table1 As BunifuCustomDataGrid
        Get
            Return table
        End Get
        Set(value As BunifuCustomDataGrid)
            table = value
        End Set
    End Property

    Public Property Update1 As Boolean
        Get
            Return update
        End Get
        Set(value As Boolean)
            update = value
        End Set
    End Property

    Public Property Promo1 As Promo
        Get
            Return promo
        End Get
        Set(value As Promo)
            promo = value
        End Set
    End Property

    Public Property Look1 As Boolean
        Get
            Return look
        End Get
        Set(value As Boolean)
            look = value
        End Set
    End Property

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()

    End Sub

    Private Sub Register_Button_Click(sender As Object, e As EventArgs) Handles Register_Button.Click

        If (update = True) Then
            If (look = True) Then
                Me.Close()
            Else
                Try
                    If (Validate() = True) Then

                        If (database.Promo_Update(promo) = True) Then
                            database.Promo_Table("", table)
                            MessageBox.Show("Update Successful")
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("Update not Successful")
                End Try

            End If
        Else

            If (Validate() = True) Then

                Dim price_float As Integer = CInt(PromoPrice.Text)

                Dim Promo_Hours_int As Integer = CInt(Promo_Hours.Text)
                database.InsertPromo(New Promo(1, Promo_Name.Text, Promo_Hours_int.ToString,
                                                                       Promo_Description.Text, promo_ends.Value.ToString("dd'/'MM'/'yyyy"),
                                                                       PromoPrice.Text, "Active"))
                database.Promo_Table("", table)
            End If

        End If
    End Sub

    Private Overloads Function Validate() As Boolean
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
                                If (promo_ends.Value.Equals(_date) Or promo_ends.Value < _date) Then
                                    Throw New Exception
                                Else
                                    Try
                                        Dim price_float As Integer = CInt(PromoPrice.Text)
                                        Return True
                                    Catch ex As Exception
                                        MessageBox.Show("Price should number")
                                    End Try
                                End If
                            Catch ex As Exception
                                MessageBox.Show("Promo should greater than to the date now")
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

        Return False
    End Function

    Private Sub Pricing_Promo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (update = True) Then
            If (look = True) Then
                Register_Button.Text = "OK"
            Else
                Register_Button.Text = "Update"
            End If
            Promo_Name.Text = promo.Name1
            Promo_Hours.Text = promo.Duration1
            Promo_Description.Text = promo.Description1
            promo_ends.Value = promo.Ends1
            PromoPrice.Text = promo.Price1
        End If
    End Sub
End Class