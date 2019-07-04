Imports ParkingSystem
Public Class Parking

    Dim database As Server = New Server

    Private WithEvents _MainPanel As New Panel
    Private _ChildForm As Form

    Dim isMaximize As Boolean = False
    Public Property single_user As User_History

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = True
        Me.MaximizeBox = True
        switchPanel(_Transaction)

    End Sub

    Sub switchPanel(ByVal panel As Form)

        Panel_Change.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel_Change.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub x_button_Click(sender As Object, e As EventArgs) Handles x_button.Click


        Dim time_end As DateTime = New DateTime
        time_end = Convert.ToDateTime(DateTime.Now)

        Dim time_start As DateTime = Convert.ToDateTime(single_user.Time_in1)

        Dim total_session = time_end.Subtract(time_start)

        single_user.Time_out1 = time_end
        single_user.Session1 = total_session.ToString

        database.Add_User_History(single_user)
        Me.Close()

    End Sub

    Private Sub Minimize_Button_Click(sender As Object, e As EventArgs) Handles Minimize_Button.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Maximize_button_Click(sender As Object, e As EventArgs) Handles Maximize_button.Click

        If isMaximize = False Then

            Me.WindowState = FormWindowState.Maximized
            isMaximize = True
        ElseIf isMaximize = True Then

            Me.WindowState = FormWindowState.Normal
            isMaximize = False

        End If

    End Sub

    Private Sub Transaction_Button_Click(sender As Object, e As EventArgs) Handles Transaction_Button.Click
        switchPanel(_Transaction)
    End Sub

    Private Sub History_Button_Click(sender As Object, e As EventArgs) Handles History_Button.Click
        switchPanel(Transaction_History)
    End Sub

    Private Sub Pricing_Button_Click(sender As Object, e As EventArgs) Handles Pricing_Button.Click
        switchPanel(Pricing)
    End Sub

    Private Sub Membership_Button_Click(sender As Object, e As EventArgs) Handles Membership_Button.Click
        switchPanel(Membership)
    End Sub

    Private Sub ParkingList_Button_Click(sender As Object, e As EventArgs) Handles ParkingList_Button.Click
        switchPanel(Parking_List)
    End Sub

    Private Sub Users_Button_Click(sender As Object, e As EventArgs) Handles Users_Button.Click
        switchPanel(User_List)
    End Sub
End Class
