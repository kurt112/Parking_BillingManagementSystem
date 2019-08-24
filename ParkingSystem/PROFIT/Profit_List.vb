Public Class Profit_List
    Private ReadOnly database As Server = New Server
    Dim Date_word As String = " PROFIT_DATE = "

    Private Sub Set_Table()
        database.Profit_Table(Search.Text, Profit_table, total_value, Date_word)
    End Sub

    Private Sub Profit_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        start_date.Value = Date.Today()
        date_end.Value = Date.Today()
        Set_Table()
    End Sub

    Private Sub Search_OnValueChanged(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        Set_Table()
    End Sub

    '********************************************* For Date ************************************************************
    Private Sub Start_date_onValueChanged(sender As Object, e As EventArgs) Handles start_date.onValueChanged

        Date_word = " PROFIT_DATE = "

        start_date_copy.Value = start_date.Value

        If (start_date_copy.Value < date_end.Value) Then

            While Not (start_date_copy.Value = date_end.Value.AddDays(1))

                If (start_date_copy.Value.AddDays(1) = date_end.Value.AddDays(1)) Then

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "'"

                Else

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "' OR  PROFIT_DATE = "

                End If


                start_date_copy.Value = start_date_copy.Value.AddDays(1)

            End While

            Set_Table()

        End If

    End Sub

    Private Sub Date_end_onValueChanged(sender As Object, e As EventArgs) Handles date_end.onValueChanged
        Date_word = " PROFIT_DATE = "

        start_date_copy.Value = start_date.Value
        If (start_date_copy.Value < date_end.Value) Then

            While Not (start_date_copy.Value = date_end.Value.AddDays(1))

                If (start_date_copy.Value.AddDays(1) = date_end.Value.AddDays(1)) Then

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "' "

                Else

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "' OR PROFIT_DATE = "

                End If

                start_date_copy.Value = start_date_copy.Value.AddDays(1)

            End While
            Set_Table()
        End If
    End Sub
    '*********************************************** End Date ************************************************************
End Class