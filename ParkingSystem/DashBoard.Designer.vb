<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parking))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel_Change = New System.Windows.Forms.Panel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Maximize_button = New System.Windows.Forms.PictureBox()
        Me.Minimize_Button = New System.Windows.Forms.PictureBox()
        Me.x_button = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.username = New System.Windows.Forms.Label()
        Me.user_status = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Transaction_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ParkingList_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.History_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Pricing_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Membership_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Users_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.Maximize_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimize_Button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1016, 451)
        Me.Panel2.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel_Change)
        Me.Panel4.Controls.Add(Me.BunifuSeparator1)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(224, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(792, 521)
        Me.Panel4.TabIndex = 1
        '
        'Panel_Change
        '
        Me.Panel_Change.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel_Change.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Change.Location = New System.Drawing.Point(5, 111)
        Me.Panel_Change.Name = "Panel_Change"
        Me.Panel_Change.Size = New System.Drawing.Size(780, 404)
        Me.Panel_Change.TabIndex = 8
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 95)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(792, 25)
        Me.BunifuSeparator1.TabIndex = 7
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 105)
        Me.Panel1.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.Maximize_button)
        Me.Panel7.Controls.Add(Me.Minimize_Button)
        Me.Panel7.Controls.Add(Me.x_button)
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Controls.Add(Me.username)
        Me.Panel7.Controls.Add(Me.user_status)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(517, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(275, 105)
        Me.Panel7.TabIndex = 5
        '
        'Maximize_button
        '
        Me.Maximize_button.Image = CType(resources.GetObject("Maximize_button.Image"), System.Drawing.Image)
        Me.Maximize_button.Location = New System.Drawing.Point(209, 1)
        Me.Maximize_button.Name = "Maximize_button"
        Me.Maximize_button.Size = New System.Drawing.Size(31, 28)
        Me.Maximize_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Maximize_button.TabIndex = 5
        Me.Maximize_button.TabStop = False
        '
        'Minimize_Button
        '
        Me.Minimize_Button.Image = CType(resources.GetObject("Minimize_Button.Image"), System.Drawing.Image)
        Me.Minimize_Button.Location = New System.Drawing.Point(173, 1)
        Me.Minimize_Button.Name = "Minimize_Button"
        Me.Minimize_Button.Size = New System.Drawing.Size(31, 28)
        Me.Minimize_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Minimize_Button.TabIndex = 4
        Me.Minimize_Button.TabStop = False
        '
        'x_button
        '
        Me.x_button.Image = CType(resources.GetObject("x_button.Image"), System.Drawing.Image)
        Me.x_button.Location = New System.Drawing.Point(243, 0)
        Me.x_button.Name = "x_button"
        Me.x_button.Size = New System.Drawing.Size(31, 28)
        Me.x_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.x_button.TabIndex = 3
        Me.x_button.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.username.ForeColor = System.Drawing.Color.White
        Me.username.Location = New System.Drawing.Point(76, 36)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(80, 19)
        Me.username.TabIndex = 1
        Me.username.Text = "User_Name"
        '
        'user_status
        '
        Me.user_status.AutoSize = True
        Me.user_status.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_status.ForeColor = System.Drawing.Color.White
        Me.user_status.Location = New System.Drawing.Point(77, 55)
        Me.user_status.Name = "user_status"
        Me.user_status.Size = New System.Drawing.Size(66, 13)
        Me.user_status.TabIndex = 0
        Me.user_status.Text = "User_Status"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(508, 99)
        Me.Panel6.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(507, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Develop by: Kurt Oriqoue and Ejid Datoc"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-3, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(516, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "All Right Resevers to Informatics International College Cainta 2019"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(508, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Parking Billing Management System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Transaction_Button
        '
        Me.Transaction_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Transaction_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transaction_Button.BorderRadius = 0
        Me.Transaction_Button.ButtonText = "Transaction"
        Me.Transaction_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transaction_Button.DisabledColor = System.Drawing.Color.Gray
        Me.Transaction_Button.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Transaction_Button.ForeColor = System.Drawing.Color.DimGray
        Me.Transaction_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.Transaction_Button.Iconimage = CType(resources.GetObject("Transaction_Button.Iconimage"), System.Drawing.Image)
        Me.Transaction_Button.Iconimage_right = Nothing
        Me.Transaction_Button.Iconimage_right_Selected = Nothing
        Me.Transaction_Button.Iconimage_Selected = Nothing
        Me.Transaction_Button.IconMarginLeft = 0
        Me.Transaction_Button.IconMarginRight = 0
        Me.Transaction_Button.IconRightVisible = True
        Me.Transaction_Button.IconRightZoom = 0R
        Me.Transaction_Button.IconVisible = True
        Me.Transaction_Button.IconZoom = 90.0R
        Me.Transaction_Button.IsTab = False
        Me.Transaction_Button.Location = New System.Drawing.Point(1, 3)
        Me.Transaction_Button.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Transaction_Button.Name = "Transaction_Button"
        Me.Transaction_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Transaction_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.Transaction_Button.selected = False
        Me.Transaction_Button.Size = New System.Drawing.Size(223, 60)
        Me.Transaction_Button.TabIndex = 3
        Me.Transaction_Button.Text = "Transaction"
        Me.Transaction_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Transaction_Button.Textcolor = System.Drawing.Color.White
        Me.Transaction_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 17.0!, System.Drawing.FontStyle.Bold)
        '
        'ParkingList_Button
        '
        Me.ParkingList_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.ParkingList_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ParkingList_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ParkingList_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ParkingList_Button.BorderRadius = 0
        Me.ParkingList_Button.ButtonText = "Parking List"
        Me.ParkingList_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ParkingList_Button.DisabledColor = System.Drawing.SystemColors.GrayText
        Me.ParkingList_Button.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ParkingList_Button.ForeColor = System.Drawing.Color.DimGray
        Me.ParkingList_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.ParkingList_Button.Iconimage = CType(resources.GetObject("ParkingList_Button.Iconimage"), System.Drawing.Image)
        Me.ParkingList_Button.Iconimage_right = Nothing
        Me.ParkingList_Button.Iconimage_right_Selected = Nothing
        Me.ParkingList_Button.Iconimage_Selected = Nothing
        Me.ParkingList_Button.IconMarginLeft = 0
        Me.ParkingList_Button.IconMarginRight = 0
        Me.ParkingList_Button.IconRightVisible = True
        Me.ParkingList_Button.IconRightZoom = 0R
        Me.ParkingList_Button.IconVisible = True
        Me.ParkingList_Button.IconZoom = 90.0R
        Me.ParkingList_Button.IsTab = False
        Me.ParkingList_Button.Location = New System.Drawing.Point(1, 66)
        Me.ParkingList_Button.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.ParkingList_Button.Name = "ParkingList_Button"
        Me.ParkingList_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ParkingList_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ParkingList_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.ParkingList_Button.selected = False
        Me.ParkingList_Button.Size = New System.Drawing.Size(223, 60)
        Me.ParkingList_Button.TabIndex = 4
        Me.ParkingList_Button.Text = "Parking List"
        Me.ParkingList_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ParkingList_Button.Textcolor = System.Drawing.Color.White
        Me.ParkingList_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'History_Button
        '
        Me.History_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.History_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.History_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.History_Button.BorderRadius = 0
        Me.History_Button.ButtonText = "History"
        Me.History_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.History_Button.DisabledColor = System.Drawing.Color.Gray
        Me.History_Button.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.History_Button.ForeColor = System.Drawing.Color.DimGray
        Me.History_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.History_Button.Iconimage = CType(resources.GetObject("History_Button.Iconimage"), System.Drawing.Image)
        Me.History_Button.Iconimage_right = Nothing
        Me.History_Button.Iconimage_right_Selected = Nothing
        Me.History_Button.Iconimage_Selected = Nothing
        Me.History_Button.IconMarginLeft = 0
        Me.History_Button.IconMarginRight = 0
        Me.History_Button.IconRightVisible = True
        Me.History_Button.IconRightZoom = 0R
        Me.History_Button.IconVisible = True
        Me.History_Button.IconZoom = 90.0R
        Me.History_Button.IsTab = False
        Me.History_Button.Location = New System.Drawing.Point(1, 129)
        Me.History_Button.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.History_Button.Name = "History_Button"
        Me.History_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.History_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.History_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.History_Button.selected = False
        Me.History_Button.Size = New System.Drawing.Size(223, 60)
        Me.History_Button.TabIndex = 4
        Me.History_Button.Text = "History"
        Me.History_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.History_Button.Textcolor = System.Drawing.Color.White
        Me.History_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Pricing_Button
        '
        Me.Pricing_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Pricing_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Pricing_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pricing_Button.BorderRadius = 0
        Me.Pricing_Button.ButtonText = "Pricing"
        Me.Pricing_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pricing_Button.DisabledColor = System.Drawing.Color.Gray
        Me.Pricing_Button.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Pricing_Button.ForeColor = System.Drawing.Color.DimGray
        Me.Pricing_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.Pricing_Button.Iconimage = CType(resources.GetObject("Pricing_Button.Iconimage"), System.Drawing.Image)
        Me.Pricing_Button.Iconimage_right = Nothing
        Me.Pricing_Button.Iconimage_right_Selected = Nothing
        Me.Pricing_Button.Iconimage_Selected = Nothing
        Me.Pricing_Button.IconMarginLeft = 0
        Me.Pricing_Button.IconMarginRight = 0
        Me.Pricing_Button.IconRightVisible = True
        Me.Pricing_Button.IconRightZoom = 0R
        Me.Pricing_Button.IconVisible = True
        Me.Pricing_Button.IconZoom = 88.0R
        Me.Pricing_Button.IsTab = False
        Me.Pricing_Button.Location = New System.Drawing.Point(1, 192)
        Me.Pricing_Button.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Pricing_Button.Name = "Pricing_Button"
        Me.Pricing_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Pricing_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Pricing_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.Pricing_Button.selected = False
        Me.Pricing_Button.Size = New System.Drawing.Size(223, 60)
        Me.Pricing_Button.TabIndex = 5
        Me.Pricing_Button.Text = "Pricing"
        Me.Pricing_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Pricing_Button.Textcolor = System.Drawing.Color.White
        Me.Pricing_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Membership_Button
        '
        Me.Membership_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Membership_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Membership_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Membership_Button.BorderRadius = 0
        Me.Membership_Button.ButtonText = "Membership"
        Me.Membership_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Membership_Button.DisabledColor = System.Drawing.Color.Gray
        Me.Membership_Button.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Membership_Button.ForeColor = System.Drawing.Color.DimGray
        Me.Membership_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.Membership_Button.Iconimage = CType(resources.GetObject("Membership_Button.Iconimage"), System.Drawing.Image)
        Me.Membership_Button.Iconimage_right = Nothing
        Me.Membership_Button.Iconimage_right_Selected = Nothing
        Me.Membership_Button.Iconimage_Selected = Nothing
        Me.Membership_Button.IconMarginLeft = 0
        Me.Membership_Button.IconMarginRight = 0
        Me.Membership_Button.IconRightVisible = True
        Me.Membership_Button.IconRightZoom = 0R
        Me.Membership_Button.IconVisible = True
        Me.Membership_Button.IconZoom = 90.0R
        Me.Membership_Button.IsTab = False
        Me.Membership_Button.Location = New System.Drawing.Point(1, 255)
        Me.Membership_Button.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Membership_Button.Name = "Membership_Button"
        Me.Membership_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Membership_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Membership_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.Membership_Button.selected = False
        Me.Membership_Button.Size = New System.Drawing.Size(223, 60)
        Me.Membership_Button.TabIndex = 6
        Me.Membership_Button.Text = "Membership"
        Me.Membership_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Membership_Button.Textcolor = System.Drawing.Color.White
        Me.Membership_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Users_Button)
        Me.Panel3.Controls.Add(Me.Membership_Button)
        Me.Panel3.Controls.Add(Me.Pricing_Button)
        Me.Panel3.Controls.Add(Me.History_Button)
        Me.Panel3.Controls.Add(Me.ParkingList_Button)
        Me.Panel3.Controls.Add(Me.Transaction_Button)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(224, 521)
        Me.Panel3.TabIndex = 0
        '
        'Users_Button
        '
        Me.Users_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Users_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Users_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Users_Button.BorderRadius = 0
        Me.Users_Button.ButtonText = "Users"
        Me.Users_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Users_Button.DisabledColor = System.Drawing.Color.Gray
        Me.Users_Button.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Users_Button.ForeColor = System.Drawing.Color.DimGray
        Me.Users_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.Users_Button.Iconimage = CType(resources.GetObject("Users_Button.Iconimage"), System.Drawing.Image)
        Me.Users_Button.Iconimage_right = Nothing
        Me.Users_Button.Iconimage_right_Selected = Nothing
        Me.Users_Button.Iconimage_Selected = Nothing
        Me.Users_Button.IconMarginLeft = 0
        Me.Users_Button.IconMarginRight = 0
        Me.Users_Button.IconRightVisible = True
        Me.Users_Button.IconRightZoom = 0R
        Me.Users_Button.IconVisible = True
        Me.Users_Button.IconZoom = 90.0R
        Me.Users_Button.IsTab = False
        Me.Users_Button.Location = New System.Drawing.Point(1, 318)
        Me.Users_Button.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Users_Button.Name = "Users_Button"
        Me.Users_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Users_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Users_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.Users_Button.selected = False
        Me.Users_Button.Size = New System.Drawing.Size(223, 60)
        Me.Users_Button.TabIndex = 7
        Me.Users_Button.Text = "Users"
        Me.Users_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Users_Button.Textcolor = System.Drawing.Color.White
        Me.Users_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Parking
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 521)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Parking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parking"
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.Maximize_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimize_Button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Membership_Button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Pricing_Button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents History_Button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ParkingList_Button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Transaction_Button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents username As Label
    Friend WithEvents user_status As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Minimize_Button As PictureBox
    Friend WithEvents x_button As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Maximize_button As PictureBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel_Change As Panel
    Friend WithEvents Users_Button As Bunifu.Framework.UI.BunifuFlatButton
End Class
