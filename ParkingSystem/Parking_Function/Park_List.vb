Public Class Park_List

    Dim combobox As Combobox = New Combobox
    Dim showing As Boolean = False
    Dim start = True


    'When Parking Click
    Private Sub Add_Parking_Click(sender As Object, e As EventArgs)
        Dim form As Parking_Add = New Parking_Add()
        form.My_Table = Parking_Area_Table
        form.ShowDialog()

    End Sub
    'Switching panel
    Private Sub switchPanel(ByVal panel As Combobox, ByVal Main_Panel As Panel)

        Main_Panel.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Main_Panel.Controls.Add(panel)
        Main_Panel.BackColor = Color.Transparent
        panel.Show()
    End Sub

    'When the Focus is lose to the button the panel will close

    Private Sub Set_Parkingtable()
        Dim database As Server = New Server
        database.Parking_Table(Search.Text, Parking_Area_Table)
    End Sub
    'Simpy set the nod
    Private Sub Parking_List_Load(sender As Object, e As EventArgs) Handles Me.Load

        Set_Parkingtable()
    End Sub

    Private Sub Search_Changed(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        Set_Parkingtable()
    End Sub

    Private Sub Print(sender As Object, e As Printing.PrintPageEventArgs)
        '        Bitmap bm = New Bitmap(Parking_Area_Table.Width, Parking_Area_Table.Height)

    End Sub

    Private Sub Add_Parking_Click_1(sender As Object, e As EventArgs) Handles Add_Parking.Click
        Dim parking_add_ As Parking_Add = New Parking_Add
        parking_add_.My_Table = Parking_Area_Table
        parking_add_.ShowDialog()

    End Sub
End Class