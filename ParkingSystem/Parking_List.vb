Public Class Parking_List
    Dim database As Server = New Server
    Dim combobox As Combobox = New Combobox
    Dim showing As Boolean = False
    Dim start = True


    'When Parking Click
    Private Sub Add_Parking_Click(sender As Object, e As EventArgs) Handles Add_Parking.Click
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
        database.Parking_Table(Parking_Area_Table, Search.Text)
    End Sub
    'Simpy set the nod
    Private Sub Parking_List_Load(sender As Object, e As EventArgs) Handles Me.Load

        Set_Parkingtable()

    End Sub

    Private Sub Search_Changed(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        database.Parking_Table(Parking_Area_Table, Search.Text)
    End Sub

    Private Sub Print(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        '        Bitmap bm = New Bitmap(Parking_Area_Table.Width, Parking_Area_Table.Height)

    End Sub



    ' I have hidden button on the lower left of the sort method

End Class