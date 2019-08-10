Imports Bunifu.Framework.UI
Imports ParkingSystem
Public Class Parking

#Region "The objects in the class"
    Dim database As Server = New Server

    Private WithEvents _MainPanel As New Panel
    Private _ChildForm As Form

    Dim member_table As BunifuCustomDataGrid
    Dim location_table As BunifuCustomDataGrid



    Dim isMaximize As Boolean = False
    Dim transaction_form As Transaction_List
    Dim area_form As Park_List
    Dim promohistory_form As Pricing
    Dim member_form As Membership_List
    Dim users_form As User_List

#End Region

#Region "Getter Setter of this class"
    Public Property single_user As User_History = New User_History("", "", "", "", "", "", "", "")

    Public Property Transaction_form1 As Transaction_List
        Get
            Return transaction_form
        End Get
        Set(value As Transaction_List)
            transaction_form = value
        End Set
    End Property


    Public Property Promohistory_form1 As Pricing
        Get
            Return promohistory_form
        End Get
        Set(value As Pricing)
            promohistory_form = value
        End Set
    End Property

    Public Property Member_form1 As Membership_List
        Get
            Return member_form
        End Get
        Set(value As Membership_List)
            member_form = value
        End Set
    End Property

    Public Property Users_form1 As User_List
        Get
            Return users_form
        End Get
        Set(value As User_List)
            users_form = value
        End Set
    End Property

    Public Property Area_form1 As Park_List
        Get
            Return area_form
        End Get
        Set(value As Park_List)
            area_form = value
        End Set
    End Property

    Public Property Member_table1 As BunifuCustomDataGrid
        Get
            Return member_table
        End Get
        Set(value As BunifuCustomDataGrid)
            member_table = value
        End Set
    End Property

    Public Property Location_table1 As BunifuCustomDataGrid
        Get
            Return location_table
        End Get
        Set(value As BunifuCustomDataGrid)
            location_table = value
        End Set
    End Property

#End Region



#Region "Form Load"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = single_user.Username1
        user_status.Text = single_user.First_name1 + " " + single_user.Last_name1
        _Date.Text = Date.Today.ToLongDateString
        Me.MinimizeBox = True
        Me.MaximizeBox = True
        transaction_form.Location_table1 = location_table
        transaction_form.Member_table1 = member_table
        transaction_form.Username1 = single_user.Username1
        switchTransaction(transaction_form)
    End Sub
#End Region

#Region "For Switching the panel"
    Sub switchPanel(ByVal panel As Form)

        Panel_Change.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel_Change.Controls.Add(panel)
        panel.Show()

    End Sub

    Sub switchTransaction(ByVal panel As Transaction_List)

        Panel_Change.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel_Change.Controls.Add(panel)
        panel.Show()

    End Sub
#End Region

#Region "Minimize, Fullscreen, X button"
    Private Sub x_button_Click(sender As Object, e As EventArgs) Handles x_button.Click


        Dim time_end As DateTime = Convert.ToDateTime(DateTime.Now)


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
#End Region

    '---------------------------------------------------------------------'
    'Just Switching panel'
    Private Sub Transaction_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles Transaction_Button.MouseClick

        transaction_form.Username1 = single_user.Username1

        switchTransaction(transaction_form)
    End Sub

    Private Sub Parking_List_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles Parking_List_Button.MouseClick
        switchPanel(area_form)
    End Sub
    Private Sub User_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles User_Button.MouseClick
        switchPanel(users_form)
    End Sub
    Private Sub Transaction_HistoryButton_Click(sender As Object, e As EventArgs) Handles Transaction_HistoryButton.Click
        switchPanel(transaction_form)
    End Sub
    Private Sub Promo_Button_Click(sender As Object, e As EventArgs) Handles Promo_Button.Click
        switchPanel(promohistory_form)
    End Sub
    Private Sub Membership_button_Click_1(sender As Object, e As EventArgs) Handles Membership_button.Click
        member_form.Username1 = single_user.Username1
        switchPanel(member_form)
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
    Private Sub Membership_Button_Hover(sender As Object, e As EventArgs)
        Membership.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Private Sub Membership_Button_Leave(sender As Object, e As EventArgs)
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
