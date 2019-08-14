<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Membership_List
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Membership_List))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.register = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.generate_picture = New System.Windows.Forms.PictureBox()
        Me.generate_guest = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Member_table = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emailaddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cellphone_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastparking = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.promo_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Search = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.MemberTable_Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Register_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Refresh_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Generateguest_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sort_By_FirstName = New System.Windows.Forms.ToolStripMenuItem()
        Me.Firstname_Sort_AZ = New System.Windows.Forms.ToolStripMenuItem()
        Me.Firstname_Sort_ZA = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lastname_Sort_AZ = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lastname_Sort_ZA = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastParkingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sort_By = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPromoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.generate_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Member_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MemberTable_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.register)
        Me.Panel2.Controls.Add(Me.generate_picture)
        Me.Panel2.Controls.Add(Me.generate_guest)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(722, 94)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'register
        '
        Me.register.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.register.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.register.BorderRadius = 0
        Me.register.ButtonText = "Register"
        Me.register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.register.DisabledColor = System.Drawing.Color.White
        Me.register.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.register.ForeColor = System.Drawing.Color.White
        Me.register.Iconcolor = System.Drawing.Color.Transparent
        Me.register.Iconimage = Nothing
        Me.register.Iconimage_right = Nothing
        Me.register.Iconimage_right_Selected = Nothing
        Me.register.Iconimage_Selected = Nothing
        Me.register.IconMarginLeft = 0
        Me.register.IconMarginRight = 0
        Me.register.IconRightVisible = True
        Me.register.IconRightZoom = 0R
        Me.register.IconVisible = False
        Me.register.IconZoom = 70.0R
        Me.register.IsTab = False
        Me.register.Location = New System.Drawing.Point(96, 18)
        Me.register.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.register.Name = "register"
        Me.register.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.register.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.register.OnHoverTextColor = System.Drawing.Color.White
        Me.register.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.register.selected = False
        Me.register.Size = New System.Drawing.Size(195, 60)
        Me.register.TabIndex = 8
        Me.register.Text = "Register"
        Me.register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.register.Textcolor = System.Drawing.Color.White
        Me.register.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'generate_picture
        '
        Me.generate_picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.generate_picture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.generate_picture.Image = CType(resources.GetObject("generate_picture.Image"), System.Drawing.Image)
        Me.generate_picture.Location = New System.Drawing.Point(331, 17)
        Me.generate_picture.Name = "generate_picture"
        Me.generate_picture.Size = New System.Drawing.Size(67, 59)
        Me.generate_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.generate_picture.TabIndex = 7
        Me.generate_picture.TabStop = False
        '
        'generate_guest
        '
        Me.generate_guest.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.generate_guest.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.generate_guest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.generate_guest.BorderRadius = 0
        Me.generate_guest.ButtonText = "Generate Guest"
        Me.generate_guest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.generate_guest.DisabledColor = System.Drawing.Color.White
        Me.generate_guest.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.generate_guest.ForeColor = System.Drawing.Color.White
        Me.generate_guest.Iconcolor = System.Drawing.Color.Transparent
        Me.generate_guest.Iconimage = Nothing
        Me.generate_guest.Iconimage_right = Nothing
        Me.generate_guest.Iconimage_right_Selected = Nothing
        Me.generate_guest.Iconimage_Selected = Nothing
        Me.generate_guest.IconMarginLeft = 0
        Me.generate_guest.IconMarginRight = 0
        Me.generate_guest.IconRightVisible = True
        Me.generate_guest.IconRightZoom = 0R
        Me.generate_guest.IconVisible = False
        Me.generate_guest.IconZoom = 70.0R
        Me.generate_guest.IsTab = False
        Me.generate_guest.Location = New System.Drawing.Point(398, 17)
        Me.generate_guest.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.generate_guest.Name = "generate_guest"
        Me.generate_guest.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.generate_guest.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.generate_guest.OnHoverTextColor = System.Drawing.Color.White
        Me.generate_guest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.generate_guest.selected = False
        Me.generate_guest.Size = New System.Drawing.Size(195, 60)
        Me.generate_guest.TabIndex = 6
        Me.generate_guest.Text = "Generate Guest"
        Me.generate_guest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.generate_guest.Textcolor = System.Drawing.Color.White
        Me.generate_guest.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Member_table
        '
        Me.Member_table.AllowUserToAddRows = False
        Me.Member_table.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Member_table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Member_table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Member_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Member_table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Member_table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Member_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Member_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Member_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Member_table.ColumnHeadersHeight = 35
        Me.Member_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.firstname, Me.lastname, Me.emailaddress, Me.cellphone_, Me.lastparking, Me.promo_, Me.status_})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Member_table.DefaultCellStyle = DataGridViewCellStyle3
        Me.Member_table.DoubleBuffered = True
        Me.Member_table.EnableHeadersVisualStyles = False
        Me.Member_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Member_table.HeaderBgColor = System.Drawing.Color.Black
        Me.Member_table.HeaderForeColor = System.Drawing.Color.White
        Me.Member_table.Location = New System.Drawing.Point(0, 92)
        Me.Member_table.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.Member_table.Name = "Member_table"
        Me.Member_table.ReadOnly = True
        Me.Member_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Member_table.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Member_table.RowHeadersVisible = False
        Me.Member_table.RowHeadersWidth = 51
        Me.Member_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Member_table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Member_table.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Member_table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.Member_table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Member_table.RowTemplate.DividerHeight = 1
        Me.Member_table.RowTemplate.Height = 40
        Me.Member_table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Member_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Member_table.Size = New System.Drawing.Size(1281, 442)
        Me.Member_table.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'firstname
        '
        Me.firstname.HeaderText = "First Name"
        Me.firstname.MinimumWidth = 6
        Me.firstname.Name = "firstname"
        Me.firstname.ReadOnly = True
        '
        'lastname
        '
        Me.lastname.HeaderText = "Last Name"
        Me.lastname.MinimumWidth = 6
        Me.lastname.Name = "lastname"
        Me.lastname.ReadOnly = True
        '
        'emailaddress
        '
        Me.emailaddress.HeaderText = "Email Address"
        Me.emailaddress.MinimumWidth = 6
        Me.emailaddress.Name = "emailaddress"
        Me.emailaddress.ReadOnly = True
        '
        'cellphone_
        '
        Me.cellphone_.HeaderText = "Cellphone"
        Me.cellphone_.MinimumWidth = 6
        Me.cellphone_.Name = "cellphone_"
        Me.cellphone_.ReadOnly = True
        '
        'lastparking
        '
        Me.lastparking.HeaderText = "Last Parking"
        Me.lastparking.MinimumWidth = 6
        Me.lastparking.Name = "lastparking"
        Me.lastparking.ReadOnly = True
        '
        'promo_
        '
        Me.promo_.HeaderText = "Promo"
        Me.promo_.MinimumWidth = 6
        Me.promo_.Name = "promo_"
        Me.promo_.ReadOnly = True
        '
        'status_
        '
        Me.status_.HeaderText = "Status"
        Me.status_.MinimumWidth = 6
        Me.status_.Name = "status_"
        Me.status_.ReadOnly = True
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
        Me.Panel1.Size = New System.Drawing.Size(1281, 94)
        Me.Panel1.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(892, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(389, 94)
        Me.Panel3.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(335, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
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
        Me.Search.HintText = "Search Anything"
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
        'MemberTable_Menu
        '
        Me.MemberTable_Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MemberTable_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Register_ContextMenu, Me.Update_ContextMenu, Me.DeleteContextMenu, Me.Refresh_ContextMenu, Me.Generateguest_ContextMenu, Me.ViewPromoToolStripMenuItem})
        Me.MemberTable_Menu.Name = "ContextMenuStrip1"
        Me.MemberTable_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MemberTable_Menu.Size = New System.Drawing.Size(215, 188)
        '
        'Register_ContextMenu
        '
        Me.Register_ContextMenu.Image = CType(resources.GetObject("Register_ContextMenu.Image"), System.Drawing.Image)
        Me.Register_ContextMenu.Name = "Register_ContextMenu"
        Me.Register_ContextMenu.Size = New System.Drawing.Size(214, 26)
        Me.Register_ContextMenu.Text = "Add"
        '
        'Update_ContextMenu
        '
        Me.Update_ContextMenu.Image = CType(resources.GetObject("Update_ContextMenu.Image"), System.Drawing.Image)
        Me.Update_ContextMenu.Name = "Update_ContextMenu"
        Me.Update_ContextMenu.Size = New System.Drawing.Size(214, 26)
        Me.Update_ContextMenu.Text = "Update"
        '
        'DeleteContextMenu
        '
        Me.DeleteContextMenu.Image = CType(resources.GetObject("DeleteContextMenu.Image"), System.Drawing.Image)
        Me.DeleteContextMenu.Name = "DeleteContextMenu"
        Me.DeleteContextMenu.Size = New System.Drawing.Size(214, 26)
        Me.DeleteContextMenu.Text = "Delete"
        '
        'Refresh_ContextMenu
        '
        Me.Refresh_ContextMenu.Image = CType(resources.GetObject("Refresh_ContextMenu.Image"), System.Drawing.Image)
        Me.Refresh_ContextMenu.Name = "Refresh_ContextMenu"
        Me.Refresh_ContextMenu.Size = New System.Drawing.Size(214, 26)
        Me.Refresh_ContextMenu.Text = "Refresh"
        '
        'Generateguest_ContextMenu
        '
        Me.Generateguest_ContextMenu.Image = CType(resources.GetObject("Generateguest_ContextMenu.Image"), System.Drawing.Image)
        Me.Generateguest_ContextMenu.Name = "Generateguest_ContextMenu"
        Me.Generateguest_ContextMenu.Size = New System.Drawing.Size(214, 26)
        Me.Generateguest_ContextMenu.Text = "Generate Guest"
        '
        'Sort_By_FirstName
        '
        Me.Sort_By_FirstName.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Firstname_Sort_AZ, Me.Firstname_Sort_ZA})
        Me.Sort_By_FirstName.Name = "Sort_By_FirstName"
        Me.Sort_By_FirstName.Size = New System.Drawing.Size(170, 26)
        Me.Sort_By_FirstName.Text = "First Name"
        '
        'Firstname_Sort_AZ
        '
        Me.Firstname_Sort_AZ.Image = CType(resources.GetObject("Firstname_Sort_AZ.Image"), System.Drawing.Image)
        Me.Firstname_Sort_AZ.Name = "Firstname_Sort_AZ"
        Me.Firstname_Sort_AZ.Size = New System.Drawing.Size(117, 26)
        Me.Firstname_Sort_AZ.Text = "A-Z"
        '
        'Firstname_Sort_ZA
        '
        Me.Firstname_Sort_ZA.Image = CType(resources.GetObject("Firstname_Sort_ZA.Image"), System.Drawing.Image)
        Me.Firstname_Sort_ZA.Name = "Firstname_Sort_ZA"
        Me.Firstname_Sort_ZA.Size = New System.Drawing.Size(117, 26)
        Me.Firstname_Sort_ZA.Text = "Z-A"
        '
        'LastNameToolStripMenuItem
        '
        Me.LastNameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Lastname_Sort_AZ, Me.Lastname_Sort_ZA})
        Me.LastNameToolStripMenuItem.Name = "LastNameToolStripMenuItem"
        Me.LastNameToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.LastNameToolStripMenuItem.Text = "Last Name"
        '
        'Lastname_Sort_AZ
        '
        Me.Lastname_Sort_AZ.Image = CType(resources.GetObject("Lastname_Sort_AZ.Image"), System.Drawing.Image)
        Me.Lastname_Sort_AZ.Name = "Lastname_Sort_AZ"
        Me.Lastname_Sort_AZ.Size = New System.Drawing.Size(117, 26)
        Me.Lastname_Sort_AZ.Text = "A-Z"
        '
        'Lastname_Sort_ZA
        '
        Me.Lastname_Sort_ZA.Image = CType(resources.GetObject("Lastname_Sort_ZA.Image"), System.Drawing.Image)
        Me.Lastname_Sort_ZA.Name = "Lastname_Sort_ZA"
        Me.Lastname_Sort_ZA.Size = New System.Drawing.Size(117, 26)
        Me.Lastname_Sort_ZA.Text = "Z-A"
        '
        'EmailToolStripMenuItem
        '
        Me.EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        Me.EmailToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.EmailToolStripMenuItem.Text = "Email"
        '
        'LastParkingToolStripMenuItem
        '
        Me.LastParkingToolStripMenuItem.Name = "LastParkingToolStripMenuItem"
        Me.LastParkingToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.LastParkingToolStripMenuItem.Text = "Last Parking"
        '
        'PromoToolStripMenuItem
        '
        Me.PromoToolStripMenuItem.Name = "PromoToolStripMenuItem"
        Me.PromoToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.PromoToolStripMenuItem.Text = "Promo"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(170, 26)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'Sort_By
        '
        Me.Sort_By.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Sort_By_FirstName, Me.LastNameToolStripMenuItem, Me.EmailToolStripMenuItem, Me.LastParkingToolStripMenuItem, Me.PromoToolStripMenuItem, Me.StatusToolStripMenuItem})
        Me.Sort_By.Image = CType(resources.GetObject("Sort_By.Image"), System.Drawing.Image)
        Me.Sort_By.Name = "Sort_By"
        Me.Sort_By.Size = New System.Drawing.Size(214, 26)
        Me.Sort_By.Text = "Sort By"
        '
        'ViewPromoToolStripMenuItem
        '
        Me.ViewPromoToolStripMenuItem.Image = CType(resources.GetObject("ViewPromoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewPromoToolStripMenuItem.Name = "ViewPromoToolStripMenuItem"
        Me.ViewPromoToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.ViewPromoToolStripMenuItem.Text = "View Promo"
        '
        'Membership_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 533)
        Me.Controls.Add(Me.Member_table)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Membership_List"
        Me.Text = "Membership_List"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.generate_picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Member_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MemberTable_Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Member_table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
    Friend WithEvents emailaddress As DataGridViewTextBoxColumn
    Friend WithEvents cellphone_ As DataGridViewTextBoxColumn
    Friend WithEvents lastparking As DataGridViewTextBoxColumn
    Friend WithEvents promo_ As DataGridViewTextBoxColumn
    Friend WithEvents status_ As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents register As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents generate_picture As PictureBox
    Friend WithEvents generate_guest As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MemberTable_Menu As ContextMenuStrip
    Friend WithEvents Register_ContextMenu As ToolStripMenuItem
    Friend WithEvents Update_ContextMenu As ToolStripMenuItem
    Friend WithEvents DeleteContextMenu As ToolStripMenuItem
    Friend WithEvents Sort_By_FirstName As ToolStripMenuItem
    Friend WithEvents Firstname_Sort_AZ As ToolStripMenuItem
    Friend WithEvents Firstname_Sort_ZA As ToolStripMenuItem
    Friend WithEvents LastNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lastname_Sort_AZ As ToolStripMenuItem
    Friend WithEvents Lastname_Sort_ZA As ToolStripMenuItem
    Friend WithEvents EmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LastParkingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PromoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sort_By As ToolStripMenuItem
    Friend WithEvents Refresh_ContextMenu As ToolStripMenuItem
    Friend WithEvents Generateguest_ContextMenu As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Search As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ViewPromoToolStripMenuItem As ToolStripMenuItem
End Class
