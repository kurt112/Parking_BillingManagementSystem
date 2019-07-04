Public Class Parking_List
    Dim database As Server = New Server

    Private Sub Add_Parking_Click(sender As Object, e As EventArgs) Handles Add_Parking.Click

        Dim form As Parking_Add = New Parking_Add()
        form.ShowDialog()
    End Sub

    Private Sub Parking_List_Load(sender As Object, e As EventArgs) Handles Me.Load
        database.Parking_Table(Parking_Area_Table, status_.selectedValue.ToString)
    End Sub
End Class