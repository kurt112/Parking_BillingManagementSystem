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
        switchPanel(User_List)
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
    '---------------------------------------------------------------------'
    'Just Switching panel'
    Private Sub Transaction_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles Transaction_Button.MouseClick
        switchPanel(Transaction_List)
    End Sub

    Private Sub Parking_List_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles Parking_List_Button.MouseClick
        switchPanel(Park_List)
    End Sub
    Private Sub User_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles User_Button.MouseClick
        switchPanel(User_List)
    End Sub
    Private Sub Membership_button_Click(sender As Object, e As EventArgs) Handles Membership_button.Click
        switchPanel(Membership_List)
    End Sub
    Private Sub Transaction_HistoryButton_Click(sender As Object, e As EventArgs) Handles Transaction_HistoryButton.Click
        switchPanel(Transaction_Histroy_List)
    End Sub
    Private Sub Promo_Button_Click(sender As Object, e As EventArgs) Handles Promo_Button.Click
        switchPanel(Pricing)
    End Sub
    '---------------------------------------------------------------------'
    'Just coloring stuff'
    Private Sub Transaction_Button_Hover(sender As Object, e As EventArgs) Handles Transaction_Button.MouseHover
        Transaction.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Private Sub Transaction_Button_MouseLeave(sender As Object, e As EventArgs) Handles Transaction_Button.MouseLeave
        Transaction.BackColor = Color.FromArgb(18, 18, 18)
    End Sub
    Private Sub Parking_List_Button_Hover(sender As Object, e As EventArgs) Handles Parking_List_Button.MouseHover
        Parking_List.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Private Sub Parking_List_Button_Leave(sender As Object, e As EventArgs) Handles Parking_List_Button.MouseLeave
        Parking_List.BackColor = Color.FromArgb(18, 18, 18)
    End Sub
    Private Sub Promo_Button_Hover(sender As Object, e As EventArgs) Handles Promo_Button.MouseHover
        Promo.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Private Sub Promo_Button_Leave(sender As Object, e As EventArgs) Handles Promo_Button.MouseLeave
        Promo.BackColor = Color.FromArgb(18, 18, 18)
    End Sub
    Private Sub Membership_Button_Hover(sender As Object, e As EventArgs) Handles Membership_button.MouseHover
        Membership.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Private Sub Membership_Button_Leave(sender As Object, e As EventArgs) Handles Membership_button.MouseLeave
        Membership.BackColor = Color.FromArgb(18, 18, 18)
    End Sub
    Private Sub History_Button_Hover(sender As Object, e As EventArgs) Handles Transaction_HistoryButton.MouseHover
        Transaction_History.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Private Sub History_Button_Leave(sender As Object, e As EventArgs) Handles Transaction_HistoryButton.MouseLeave
        Transaction_History.BackColor = Color.FromArgb(18, 18, 18)
    End Sub
    Private Sub User_Button_Hover(sender As Object, e As EventArgs) Handles User_Button.MouseHover
        Users.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Private Sub User_Button_Leave(sender As Object, e As EventArgs) Handles User_Button.MouseLeave
        Users.BackColor = Color.FromArgb(18, 18, 18)
    End Sub
End Class
