<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Park_List
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Park_List))
        Me.Parking_Area_Table = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parking_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parking_level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parking_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Add_Parking_Logo = New System.Windows.Forms.PictureBox()
        Me.Add_Parking_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.logo_transactionlogs = New System.Windows.Forms.PictureBox()
        Me.Transaction_logs_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Search = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Parking_TableContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Register_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Refresh_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Viewmember_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Parking_Area_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Add_Parking_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo_transactionlogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Parking_TableContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Parking_Area_Table
        '
        Me.Parking_Area_Table.AllowUserToAddRows = False
        Me.Parking_Area_Table.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.Parking_Area_Table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Parking_Area_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Parking_Area_Table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Parking_Area_Table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Parking_Area_Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Parking_Area_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Parking_Area_Table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Parking_Area_Table.ColumnHeadersHeight = 35
        Me.Parking_Area_Table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.parking_name, Me.parking_level, Me.parking_price, Me.Status})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Parking_Area_Table.DefaultCellStyle = DataGridViewCellStyle7
        Me.Parking_Area_Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Parking_Area_Table.DoubleBuffered = True
        Me.Parking_Area_Table.EnableHeadersVisualStyles = False
        Me.Parking_Area_Table.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Parking_Area_Table.HeaderBgColor = System.Drawing.Color.Black
        Me.Parking_Area_Table.HeaderForeColor = System.Drawing.Color.White
        Me.Parking_Area_Table.Location = New System.Drawing.Point(0, 94)
        Me.Parking_Area_Table.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.Parking_Area_Table.Name = "Parking_Area_Table"
        Me.Parking_Area_Table.ReadOnly = True
        Me.Parking_Area_Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Parking_Area_Table.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Parking_Area_Table.RowHeadersVisible = False
        Me.Parking_Area_Table.RowHeadersWidth = 51
        Me.Parking_Area_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Parking_Area_Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Parking_Area_Table.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parking_Area_Table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.Parking_Area_Table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Parking_Area_Table.RowTemplate.DividerHeight = 1
        Me.Parking_Area_Table.RowTemplate.Height = 40
        Me.Parking_Area_Table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Parking_Area_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Parking_Area_Table.Size = New System.Drawing.Size(1123, 464)
        Me.Parking_Area_Table.TabIndex = 13
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'parking_name
        '
        Me.parking_name.HeaderText = "Parking Area"
        Me.parking_name.MinimumWidth = 6
        Me.parking_name.Name = "parking_name"
        Me.parking_name.ReadOnly = True
        '
        'parking_level
        '
        Me.parking_level.HeaderText = "Parking Floor"
        Me.parking_level.MinimumWidth = 6
        Me.parking_level.Name = "parking_level"
        Me.parking_level.ReadOnly = True
        '
        'parking_price
        '
        Me.parking_price.HeaderText = "Price"
        Me.parking_price.MinimumWidth = 6
        Me.parking_price.Name = "parking_price"
        Me.parking_price.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1123, 94)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Add_Parking_Logo)
        Me.Panel2.Controls.Add(Me.Add_Parking_Button)
        Me.Panel2.Controls.Add(Me.logo_transactionlogs)
        Me.Panel2.Controls.Add(Me.Transaction_logs_button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 94)
        Me.Panel2.TabIndex = 5
        '
        'Add_Parking_Logo
        '
        Me.Add_Parking_Logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Add_Parking_Logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Parking_Logo.Image = CType(resources.GetObject("Add_Parking_Logo.Image"), System.Drawing.Image)
        Me.Add_Parking_Logo.Location = New System.Drawing.Point(28, 18)
        Me.Add_Parking_Logo.Name = "Add_Parking_Logo"
        Me.Add_Parking_Logo.Size = New System.Drawing.Size(66, 59)
        Me.Add_Parking_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Add_Parking_Logo.TabIndex = 13
        Me.Add_Parking_Logo.TabStop = False
        '
        'Add_Parking_Button
        '
        Me.Add_Parking_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Add_Parking_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Add_Parking_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add_Parking_Button.BorderRadius = 0
        Me.Add_Parking_Button.ButtonText = "Add Parking"
        Me.Add_Parking_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Parking_Button.DisabledColor = System.Drawing.Color.White
        Me.Add_Parking_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Add_Parking_Button.ForeColor = System.Drawing.Color.White
        Me.Add_Parking_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.Add_Parking_Button.Iconimage = Nothing
        Me.Add_Parking_Button.Iconimage_right = Nothing
        Me.Add_Parking_Button.Iconimage_right_Selected = Nothing
        Me.Add_Parking_Button.Iconimage_Selected = Nothing
        Me.Add_Parking_Button.IconMarginLeft = 0
        Me.Add_Parking_Button.IconMarginRight = 0
        Me.Add_Parking_Button.IconRightVisible = True
        Me.Add_Parking_Button.IconRightZoom = 0R
        Me.Add_Parking_Button.IconVisible = False
        Me.Add_Parking_Button.IconZoom = 70.0R
        Me.Add_Parking_Button.IsTab = False
        Me.Add_Parking_Button.Location = New System.Drawing.Point(94, 18)
        Me.Add_Parking_Button.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Add_Parking_Button.Name = "Add_Parking_Button"
        Me.Add_Parking_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Add_Parking_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Add_Parking_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.Add_Parking_Button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Add_Parking_Button.selected = False
        Me.Add_Parking_Button.Size = New System.Drawing.Size(195, 60)
        Me.Add_Parking_Button.TabIndex = 12
        Me.Add_Parking_Button.Text = "Add Parking"
        Me.Add_Parking_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Add_Parking_Button.Textcolor = System.Drawing.Color.White
        Me.Add_Parking_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(734, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(389, 94)
        Me.Panel3.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
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
        'Parking_TableContextMenu
        '
        Me.Parking_TableContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Parking_TableContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Register_ContextMenu, Me.Update_ContextMenu, Me.DeleteContextMenu, Me.Refresh_ContextMenu, Me.Viewmember_ContextMenu})
        Me.Parking_TableContextMenu.Name = "ContextMenuStrip1"
        Me.Parking_TableContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Parking_TableContextMenu.Size = New System.Drawing.Size(215, 162)
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
        'Viewmember_ContextMenu
        '
        Me.Viewmember_ContextMenu.Image = CType(resources.GetObject("Viewmember_ContextMenu.Image"), System.Drawing.Image)
        Me.Viewmember_ContextMenu.Name = "Viewmember_ContextMenu"
        Me.Viewmember_ContextMenu.Size = New System.Drawing.Size(214, 26)
        Me.Viewmember_ContextMenu.Text = "View Member"
        '
        'Park_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 558)
        Me.Controls.Add(Me.Parking_Area_Table)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Park_List"
        Me.Text = "Park_List"
        CType(Me.Parking_Area_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Add_Parking_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo_transactionlogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Parking_TableContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Parking_Area_Table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents parking_name As DataGridViewTextBoxColumn
    Friend WithEvents parking_level As DataGridViewTextBoxColumn
    Friend WithEvents parking_price As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Search As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Add_Parking_Logo As PictureBox
    Friend WithEvents Add_Parking_Button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents logo_transactionlogs As PictureBox
    Friend WithEvents Transaction_logs_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Parking_TableContextMenu As ContextMenuStrip
    Friend WithEvents Register_ContextMenu As ToolStripMenuItem
    Friend WithEvents Update_ContextMenu As ToolStripMenuItem
    Friend WithEvents DeleteContextMenu As ToolStripMenuItem
    Friend WithEvents Refresh_ContextMenu As ToolStripMenuItem
    Friend WithEvents Viewmember_ContextMenu As ToolStripMenuItem
End Class
