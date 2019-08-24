Imports Bunifu.Framework.UI
Imports ParkingSystem
Public Class Parking

#Region "The objects in the class"
    ReadOnly database As Server = New Server

    Dim member_table As BunifuCustomDataGrid
    Dim location_table As BunifuCustomDataGrid
    Dim profit_tables As BunifuCustomDataGrid


    Dim isMaximize As Boolean = False
    Dim transaction_form As Transaction_List
    Dim area_form As Park_List
    Dim promohistory_form As Pricing
    Dim member_form As Membership_List
    Dim users_form As User_List
    Dim Profit_form As Profit_List

    Dim admin As Boolean = False

#End Region

#Region "Getter Setter of this class"
    Public Property Single_user As User_History = New User_History("", "", "", "", "", "", "", "")

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

    Public Property Profit_form1 As Profit_List
        Get
            Return Profit_form
        End Get
        Set(value As Profit_List)
            Profit_form = value
        End Set
    End Property

    Public Property Profit_tables1 As BunifuCustomDataGrid
        Get
            Return profit_tables
        End Get
        Set(value As BunifuCustomDataGrid)
            profit_tables = value
        End Set
    End Property

    Public Property Admin1 As Boolean
        Get
            Return admin
        End Get
        Set(value As Boolean)
            admin = value
        End Set
    End Property

#End Region



#Region "Form Load"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Text = Single_user.Username1
        user_status.Text = Single_user.First_name1 + " " + Single_user.Last_name1
        _Date.Text = Date.Today.ToLongDateString
        Me.MinimizeBox = True
        Me.MaximizeBox = True
        transaction_form.Location_table1 = location_table
        transaction_form.Member_table1 = member_table
        transaction_form.Username1 = Single_user.Username1

        If (admin = False) Then
            Profit_panel.Visible = False
            Users.Visible = False
        End If


        SwitchTransaction(transaction_form)
    End Sub
#End Region

#Region "For Switching the panel"
    Sub SwitchPanel(ByVal panel As Form)

        Panel_Change.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel_Change.Controls.Add(panel)
        panel.Show()

    End Sub

    Sub SwitchTransaction(ByVal panel As Transaction_List)

        Panel_Change.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        Panel_Change.Controls.Add(panel)
        panel.Show()

    End Sub
#End Region

#Region "Minimize, Fullscreen, X button"
    Private Sub X_button_Click(sender As Object, e As EventArgs) Handles x_button.Click


        Dim time_end As DateTime = Convert.ToDateTime(DateTime.Now)


        Dim time_start As DateTime = Convert.ToDateTime(Single_user.Time_in1)

        Dim total_session = time_end.Subtract(time_start)

        Single_user.Time_out1 = time_end.ToString("dd'/'MM'/'yyyy")
        Single_user.Session1 = total_session.ToString

        database.Add_User_History(Single_user)
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

        transaction_form.Username1 = Single_user.Username1

        SwitchTransaction(transaction_form)
    End Sub

    Private Sub Parking_List_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles Parking_List_Button.MouseClick
        SwitchPanel(area_form)
    End Sub
    Private Sub User_Button_MouseClick(sender As Object, e As MouseEventArgs) Handles User_Button.MouseClick
        SwitchPanel(users_form)
    End Sub
    Private Sub Transaction_HistoryButton_Click(sender As Object, e As EventArgs)
        SwitchPanel(transaction_form)
    End Sub
    Private Sub Promo_Button_Click(sender As Object, e As EventArgs) Handles Promo_Button.Click
        SwitchPanel(promohistory_form)
    End Sub
    Private Sub Membership_button_Click_1(sender As Object, e As EventArgs) Handles Membership_button.Click
        member_form.Username1 = Single_user.Username1
        SwitchPanel(member_form)
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

    Private Sub User_Button_Hover(sender As Object, e As EventArgs) Handles User_Button.MouseHover
        Users.BackColor = Color.FromArgb(64, 64, 64)
    End Sub
    Private Sub User_Button_Leave(sender As Object, e As EventArgs) Handles User_Button.MouseLeave
        Users.BackColor = Color.FromArgb(18, 18, 18)
    End Sub



    Private Sub Actions_Click_1(sender As Object, e As EventArgs) Handles Actions.Click
        SwitchPanel(Profit_form)
    End Sub

    Private Sub Actions_Hover_1(sender As Object, e As EventArgs) Handles Actions.MouseHover
        Profit_panel.BackColor = Color.FromArgb(64, 64, 64)

    End Sub
    Private Sub Actions_Leave_1(sender As Object, e As EventArgs) Handles Actions.MouseLeave
        Profit_panel.BackColor = Color.FromArgb(18, 18, 18)
    End Sub



    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim time_end As DateTime = Convert.ToDateTime(DateTime.Now)


        Dim time_start As DateTime = Convert.ToDateTime(Single_user.Time_in1)

        Dim total_session = time_end.Subtract(time_start)

        Single_user.Time_out1 = time_end.ToString("dd'/'MM'/'yyyy")
        Single_user.Session1 = total_session.ToString

        database.Add_User_History(Single_user)
        Dim login As Login = New Login
        Me.Close()
        login.ShowDialog()
    End Sub

    Private Sub PictureBox_Hover(sender As Object, e As EventArgs) Handles Logout.MouseHover
        logout_panel.BackColor = Color.FromArgb(64, 64, 64)

    End Sub
    Private Sub PictureBox10_Leave(sender As Object, e As EventArgs) Handles Logout.MouseLeave

        logout_panel.BackColor = Color.FromArgb(18, 18, 18)
    End Sub
End Class
