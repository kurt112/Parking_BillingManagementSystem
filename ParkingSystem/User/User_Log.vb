Public Class User_Log
    ReadOnly database As Server = New Server
    Dim Date_word As String = " USER_HISTORY.DATE = "
    Private Sub Search_OnValueChanged(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        SetTable()
    End Sub

    Private Sub User_Log_Load(sender As Object, e As EventArgs) Handles Me.Load
        start_date.Value = Date.Today()
        date_end.Value = Date.Today()
        SetTable()
    End Sub

    Private Sub Start_date_onValueChanged(sender As Object, e As EventArgs) Handles start_date.onValueChanged

        Date_word = " USER_HISTORY.DATE = "

        start_date_copy.Value = start_date.Value

        If (start_date_copy.Value < date_end.Value) Then

            While Not (start_date_copy.Value = date_end.Value.AddDays(1))

                If (start_date_copy.Value.AddDays(1) = date_end.Value.AddDays(1)) Then

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "'"

                Else

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "' OR USER_HISTORY.DATE = "

                End If


                start_date_copy.Value = start_date_copy.Value.AddDays(1)

            End While
            SetTable()
        End If

    End Sub

    Private Sub Date_end_onValueChanged(sender As Object, e As EventArgs) Handles date_end.onValueChanged
        Date_word = " USER_HISTORY.DATE = "

        start_date_copy.Value = start_date.Value
        If (start_date_copy.Value < date_end.Value) Then

            While Not (start_date_copy.Value = date_end.Value.AddDays(1))

                If (start_date_copy.Value.AddDays(1) = date_end.Value.AddDays(1)) Then

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "' "

                Else

                    Date_word += "'" + start_date_copy.Value.ToString("dd'/'MM'/'yyyy") + "' OR USER_HISTORY.DATE = "

                End If


                start_date_copy.Value = start_date_copy.Value.AddDays(1)

            End While
            SetTable()
        End If
    End Sub

    Private Sub SetTable()
        database.User_History_Table(UserLogs_Table, Search.Text, Date_word)
    End Sub
End Class