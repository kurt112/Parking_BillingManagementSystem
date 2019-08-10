Imports Bunifu.Framework.UI

Public Class Park_List

    Dim combobox As Combobox = New Combobox
    Dim showing As Boolean = False
    Dim start = True
    Dim Parking_table = Parking_Area_Table
    Dim database As Server = New Server
    Dim Index As Integer


    'When Parking Click
    Private Sub Add_Parking_Click(sender As Object, e As EventArgs)
        Dim form As Parking_Add = New Parking_Add()
        form.My_Table = Parking_Area_Table
        form.ShowDialog()

    End Sub


    'When the Focus is lose to the button the panel will close

    Private Sub Set_Parkingtable()

        database.Parking_Table(Search.Text, Parking_Area_Table)

    End Sub

    'Simpy set the nod
    Private Sub Parking_List_Load(sender As Object, e As EventArgs) Handles Me.Load

        Set_Parkingtable()
    End Sub

    Private Sub Goto_parking_area()
        Dim parking_add_ As Parking_Add = New Parking_Add
        parking_add_.My_Table = Parking_Area_Table
        parking_add_.ShowDialog()

    End Sub

    Private Sub Add_Parking_Button_Click(sender As Object, e As EventArgs) Handles Add_Parking_Button.Click
        Goto_parking_area()
    End Sub

    Private Sub Add_Parking_Logo_Click(sender As Object, e As EventArgs) Handles Add_Parking_Logo.Click
        Goto_parking_area()
    End Sub

    Private Sub Search_OnValueChanged(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        Set_Parkingtable()
    End Sub

    Private Sub Parking_Area_Table_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Parking_Area_Table.CellMouseDoubleClick
        MessageBox.Show("Im clicked")
        Check_Update()
    End Sub
    Private Sub Parking_Area_Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Parking_Area_Table.CellMouseClick
        Index = e.RowIndex
    End Sub

    Private Sub Update_Area()
        Dim parking_add As Parking_Add = New Parking_Add
        Dim parking_area As Parking_Area = New Parking_Area(0, "", "", "", "")
        Dim selectedRow As DataGridViewRow
        selectedRow = Parking_Area_Table.Rows(Index)


        database.Parking_Query(selectedRow.Cells(0).Value.ToString, parking_area)

        parking_add.Parking_area1 = parking_area
            parking_add.Update1 = True
            parking_add.My_Table = Parking_Area_Table
            parking_add.ShowDialog()

    End Sub

    Private Sub Check_Update()

        Update_Area()

    End Sub

End Class