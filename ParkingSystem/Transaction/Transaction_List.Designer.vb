<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_List
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction_List))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Search = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Transaction_logo = New System.Windows.Forms.PictureBox()
        Me.Transaction = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.logo_transactionlogs = New System.Windows.Forms.PictureBox()
        Me.Transaction_logs_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Transaction_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Viewmember_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewlocation_contextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Viewuser_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextmenu_refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.date_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.promoactive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userassign = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timein = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.location_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.promoname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Membership_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Transaction_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Transaction_Table = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Transaction_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo_transactionlogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Transaction_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1173, 92)
        Me.Panel1.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(784, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(389, 92)
        Me.Panel3.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(335, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.DimGray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineThickness = 4
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(333, 32)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(37, 43)
        Me.BunifuMaterialTextbox1.TabIndex = 25
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Search
        '
        Me.Search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Search.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Search.ForeColor = System.Drawing.Color.White
        Me.Search.HintForeColor = System.Drawing.Color.White
        Me.Search.HintText = ""
        Me.Search.isPassword = False
        Me.Search.LineFocusedColor = System.Drawing.Color.Gray
        Me.Search.LineIdleColor = System.Drawing.Color.DimGray
        Me.Search.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.Search.LineThickness = 4
        Me.Search.Location = New System.Drawing.Point(90, 28)
        Me.Search.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(243, 47)
        Me.Search.TabIndex = 5
        Me.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Transaction_logo)
        Me.Panel2.Controls.Add(Me.Transaction)
        Me.Panel2.Controls.Add(Me.logo_transactionlogs)
        Me.Panel2.Controls.Add(Me.Transaction_logs_button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 92)
        Me.Panel2.TabIndex = 3
        '
        'Transaction_logo
        '
        Me.Transaction_logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction_logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transaction_logo.Image = CType(resources.GetObject("Transaction_logo.Image"), System.Drawing.Image)
        Me.Transaction_logo.Location = New System.Drawing.Point(28, 18)
        Me.Transaction_logo.Name = "Transaction_logo"
        Me.Transaction_logo.Size = New System.Drawing.Size(67, 59)
        Me.Transaction_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Transaction_logo.TabIndex = 13
        Me.Transaction_logo.TabStop = False
        '
        'Transaction
        '
        Me.Transaction.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Transaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transaction.BorderRadius = 0
        Me.Transaction.ButtonText = "Transaction"
        Me.Transaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transaction.DisabledColor = System.Drawing.Color.White
        Me.Transaction.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Transaction.ForeColor = System.Drawing.Color.White
        Me.Transaction.Iconcolor = System.Drawing.Color.Transparent
        Me.Transaction.Iconimage = Nothing
        Me.Transaction.Iconimage_right = Nothing
        Me.Transaction.Iconimage_right_Selected = Nothing
        Me.Transaction.Iconimage_Selected = Nothing
        Me.Transaction.IconMarginLeft = 0
        Me.Transaction.IconMarginRight = 0
        Me.Transaction.IconRightVisible = True
        Me.Transaction.IconRightZoom = 0R
        Me.Transaction.IconVisible = False
        Me.Transaction.IconZoom = 70.0R
        Me.Transaction.IsTab = False
        Me.Transaction.Location = New System.Drawing.Point(94, 18)
        Me.Transaction.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Transaction.Name = "Transaction"
        Me.Transaction.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction.OnHoverTextColor = System.Drawing.Color.White
        Me.Transaction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Transaction.selected = False
        Me.Transaction.Size = New System.Drawing.Size(195, 60)
        Me.Transaction.TabIndex = 12
        Me.Transaction.Text = "Transaction"
        Me.Transaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Transaction.Textcolor = System.Drawing.Color.White
        Me.Transaction.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'logo_transactionlogs
        '
        Me.logo_transactionlogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.logo_transactionlogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logo_transactionlogs.Image = CType(resources.GetObject("logo_transactionlogs.Image"), System.Drawing.Image)
        Me.logo_transactionlogs.Location = New System.Drawing.Point(329, 17)
        Me.logo_transactionlogs.Name = "logo_transactionlogs"
        Me.logo_transactionlogs.Size = New System.Drawing.Size(67, 59)
        Me.logo_transactionlogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo_transactionlogs.TabIndex = 11
        Me.logo_transactionlogs.TabStop = False
        '
        'Transaction_logs_button
        '
        Me.Transaction_logs_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Transaction_logs_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction_logs_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transaction_logs_button.BorderRadius = 0
        Me.Transaction_logs_button.ButtonText = "Transaction Logs"
        Me.Transaction_logs_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transaction_logs_button.DisabledColor = System.Drawing.Color.White
        Me.Transaction_logs_button.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Transaction_logs_button.ForeColor = System.Drawing.Color.White
        Me.Transaction_logs_button.Iconcolor = System.Drawing.Color.Transparent
        Me.Transaction_logs_button.Iconimage = Nothing
        Me.Transaction_logs_button.Iconimage_right = Nothing
        Me.Transaction_logs_button.Iconimage_right_Selected = Nothing
        Me.Transaction_logs_button.Iconimage_Selected = Nothing
        Me.Transaction_logs_button.IconMarginLeft = 0
        Me.Transaction_logs_button.IconMarginRight = 0
        Me.Transaction_logs_button.IconRightVisible = True
        Me.Transaction_logs_button.IconRightZoom = 0R
        Me.Transaction_logs_button.IconVisible = False
        Me.Transaction_logs_button.IconZoom = 70.0R
        Me.Transaction_logs_button.IsTab = False
        Me.Transaction_logs_button.Location = New System.Drawing.Point(396, 17)
        Me.Transaction_logs_button.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Transaction_logs_button.Name = "Transaction_logs_button"
        Me.Transaction_logs_button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction_logs_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction_logs_button.OnHoverTextColor = System.Drawing.Color.White
        Me.Transaction_logs_button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Transaction_logs_button.selected = False
        Me.Transaction_logs_button.Size = New System.Drawing.Size(195, 60)
        Me.Transaction_logs_button.TabIndex = 10
        Me.Transaction_logs_button.Text = "Transaction Logs"
        Me.Transaction_logs_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Transaction_logs_button.Textcolor = System.Drawing.Color.White
        Me.Transaction_logs_button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Transaction_ContextMenu, Me.Viewmember_ContextMenu, Me.viewlocation_contextMenu, Me.Viewuser_ContextMenu, Me.contextmenu_refresh})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(176, 134)
        '
        'Transaction_ContextMenu
        '
        Me.Transaction_ContextMenu.Image = CType(resources.GetObject("Transaction_ContextMenu.Image"), System.Drawing.Image)
        Me.Transaction_ContextMenu.Name = "Transaction_ContextMenu"
        Me.Transaction_ContextMenu.Size = New System.Drawing.Size(175, 26)
        Me.Transaction_ContextMenu.Text = "Transaction"
        '
        'Viewmember_ContextMenu
        '
        Me.Viewmember_ContextMenu.Image = CType(resources.GetObject("Viewmember_ContextMenu.Image"), System.Drawing.Image)
        Me.Viewmember_ContextMenu.Name = "Viewmember_ContextMenu"
        Me.Viewmember_ContextMenu.Size = New System.Drawing.Size(175, 26)
        Me.Viewmember_ContextMenu.Text = "View Member"
        '
        'viewlocation_contextMenu
        '
        Me.viewlocation_contextMenu.Image = CType(resources.GetObject("viewlocation_contextMenu.Image"), System.Drawing.Image)
        Me.viewlocation_contextMenu.Name = "viewlocation_contextMenu"
        Me.viewlocation_contextMenu.Size = New System.Drawing.Size(175, 26)
        Me.viewlocation_contextMenu.Text = "View Location"
        '
        'Viewuser_ContextMenu
        '
        Me.Viewuser_ContextMenu.Image = CType(resources.GetObject("Viewuser_ContextMenu.Image"), System.Drawing.Image)
        Me.Viewuser_ContextMenu.Name = "Viewuser_ContextMenu"
        Me.Viewuser_ContextMenu.Size = New System.Drawing.Size(175, 26)
        Me.Viewuser_ContextMenu.Text = "View User"
        '
        'contextmenu_refresh
        '
        Me.contextmenu_refresh.Image = CType(resources.GetObject("contextmenu_refresh.Image"), System.Drawing.Image)
        Me.contextmenu_refresh.Name = "contextmenu_refresh"
        Me.contextmenu_refresh.Size = New System.Drawing.Size(175, 26)
        Me.contextmenu_refresh.Text = "Refresh"
        '
        'date_
        '
        Me.date_.HeaderText = "Date"
        Me.date_.MinimumWidth = 6
        Me.date_.Name = "date_"
        Me.date_.ReadOnly = True
        '
        'promoactive
        '
        Me.promoactive.HeaderText = "Promo Active"
        Me.promoactive.MinimumWidth = 6
        Me.promoactive.Name = "promoactive"
        Me.promoactive.ReadOnly = True
        '
        'userassign
        '
        Me.userassign.HeaderText = "User Assign"
        Me.userassign.MinimumWidth = 6
        Me.userassign.Name = "userassign"
        Me.userassign.ReadOnly = True
        '
        'timeout
        '
        Me.timeout.HeaderText = "Time Out"
        Me.timeout.MinimumWidth = 6
        Me.timeout.Name = "timeout"
        Me.timeout.ReadOnly = True
        '
        'timein
        '
        Me.timein.HeaderText = "Time In"
        Me.timein.MinimumWidth = 6
        Me.timein.Name = "timein"
        Me.timein.ReadOnly = True
        '
        'location_
        '
        Me.location_.HeaderText = "Location"
        Me.location_.MinimumWidth = 6
        Me.location_.Name = "location_"
        Me.location_.ReadOnly = True
        '
        'promoname
        '
        Me.promoname.HeaderText = "Promo Name"
        Me.promoname.MinimumWidth = 6
        Me.promoname.Name = "promoname"
        Me.promoname.ReadOnly = True
        '
        'lastname
        '
        Me.lastname.HeaderText = "Last Name"
        Me.lastname.MinimumWidth = 6
        Me.lastname.Name = "lastname"
        Me.lastname.ReadOnly = True
        '
        'firstname
        '
        Me.firstname.HeaderText = "First Name"
        Me.firstname.MinimumWidth = 6
        Me.firstname.Name = "firstname"
        Me.firstname.ReadOnly = True
        '
        'Membership_ID
        '
        Me.Membership_ID.HeaderText = "Membership_ID"
        Me.Membership_ID.MinimumWidth = 6
        Me.Membership_ID.Name = "Membership_ID"
        Me.Membership_ID.ReadOnly = True
        Me.Membership_ID.Visible = False
        '
        'Transaction_ID
        '
        Me.Transaction_ID.HeaderText = "Transaction ID"
        Me.Transaction_ID.MinimumWidth = 6
        Me.Transaction_ID.Name = "Transaction_ID"
        Me.Transaction_ID.ReadOnly = True
        Me.Transaction_ID.Visible = False
        '
        'Transaction_Table
        '
        Me.Transaction_Table.AllowUserToAddRows = False
        Me.Transaction_Table.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Transaction_Table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Transaction_Table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Transaction_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Transaction_Table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction_Table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Transaction_Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Transaction_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Transaction_Table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Transaction_Table.ColumnHeadersHeight = 35
        Me.Transaction_Table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Transaction_ID, Me.Membership_ID, Me.firstname, Me.lastname, Me.promoname, Me.location_, Me.timein, Me.timeout, Me.userassign, Me.promoactive, Me.date_})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Transaction_Table.DefaultCellStyle = DataGridViewCellStyle3
        Me.Transaction_Table.DoubleBuffered = False
        Me.Transaction_Table.EnableHeadersVisualStyles = False
        Me.Transaction_Table.GridColor = System.Drawing.Color.White
        Me.Transaction_Table.HeaderBgColor = System.Drawing.Color.Black
        Me.Transaction_Table.HeaderForeColor = System.Drawing.Color.White
        Me.Transaction_Table.Location = New System.Drawing.Point(0, 90)
        Me.Transaction_Table.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.Transaction_Table.Name = "Transaction_Table"
        Me.Transaction_Table.ReadOnly = True
        Me.Transaction_Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Transaction_Table.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Transaction_Table.RowHeadersVisible = False
        Me.Transaction_Table.RowHeadersWidth = 51
        Me.Transaction_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Transaction_Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction_Table.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transaction_Table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.Transaction_Table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Transaction_Table.RowTemplate.DividerHeight = 1
        Me.Transaction_Table.RowTemplate.Height = 40
        Me.Transaction_Table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Transaction_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Transaction_Table.Size = New System.Drawing.Size(1173, 542)
        Me.Transaction_Table.TabIndex = 10
        '
        'Transaction_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 631)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Transaction_Table)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Transaction_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Transaction_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo_transactionlogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Transaction_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Transaction_logo As PictureBox
    Friend WithEvents Transaction As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents logo_transactionlogs As PictureBox
    Friend WithEvents Transaction_logs_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Search As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Transaction_ContextMenu As ToolStripMenuItem
    Friend WithEvents Viewmember_ContextMenu As ToolStripMenuItem
    Friend WithEvents viewlocation_contextMenu As ToolStripMenuItem
    Friend WithEvents Viewuser_ContextMenu As ToolStripMenuItem
    Friend WithEvents contextmenu_refresh As ToolStripMenuItem
    Friend WithEvents date_ As DataGridViewTextBoxColumn
    Friend WithEvents promoactive As DataGridViewTextBoxColumn
    Friend WithEvents userassign As DataGridViewTextBoxColumn
    Friend WithEvents timeout As DataGridViewTextBoxColumn
    Friend WithEvents timein As DataGridViewTextBoxColumn
    Friend WithEvents location_ As DataGridViewTextBoxColumn
    Friend WithEvents promoname As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents Membership_ID As DataGridViewTextBoxColumn
    Friend WithEvents Transaction_ID As DataGridViewTextBoxColumn
    Friend WithEvents Transaction_Table As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
