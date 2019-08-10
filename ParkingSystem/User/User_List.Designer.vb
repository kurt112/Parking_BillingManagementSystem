<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_List
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_List))
        Me.User_table = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date_Created = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Search = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Add_User_logo = New System.Windows.Forms.PictureBox()
        Me.Add_User = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.User_log_logo = New System.Windows.Forms.PictureBox()
        Me.User_logs_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.User_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Add_User_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_log_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'User_table
        '
        Me.User_table.AllowUserToAddRows = False
        Me.User_table.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.User_table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.User_table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.User_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.User_table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.User_table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.User_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.User_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.User_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.User_table.ColumnHeadersHeight = 35
        Me.User_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Password, Me.Date_Created, Me.Status})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.User_table.DefaultCellStyle = DataGridViewCellStyle3
        Me.User_table.DoubleBuffered = True
        Me.User_table.EnableHeadersVisualStyles = False
        Me.User_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.User_table.HeaderBgColor = System.Drawing.Color.Black
        Me.User_table.HeaderForeColor = System.Drawing.Color.White
        Me.User_table.Location = New System.Drawing.Point(0, 100)
        Me.User_table.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.User_table.Name = "User_table"
        Me.User_table.ReadOnly = True
        Me.User_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.User_table.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.User_table.RowHeadersVisible = False
        Me.User_table.RowHeadersWidth = 51
        Me.User_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.User_table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.User_table.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.User_table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.User_table.RowTemplate.DividerHeight = 1
        Me.User_table.RowTemplate.Height = 40
        Me.User_table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.User_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.User_table.Size = New System.Drawing.Size(1280, 471)
        Me.User_table.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "User Name"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Password
        '
        Me.Password.HeaderText = "Password"
        Me.Password.MinimumWidth = 6
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        '
        'Date_Created
        '
        Me.Date_Created.HeaderText = "Date Created"
        Me.Date_Created.MinimumWidth = 6
        Me.Date_Created.Name = "Date_Created"
        Me.Date_Created.ReadOnly = True
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
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 92)
        Me.Panel1.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(891, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(389, 92)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Add_User_logo)
        Me.Panel2.Controls.Add(Me.Add_User)
        Me.Panel2.Controls.Add(Me.User_log_logo)
        Me.Panel2.Controls.Add(Me.User_logs_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(601, 92)
        Me.Panel2.TabIndex = 3
        '
        'Add_User_logo
        '
        Me.Add_User_logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Add_User_logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_User_logo.Image = CType(resources.GetObject("Add_User_logo.Image"), System.Drawing.Image)
        Me.Add_User_logo.Location = New System.Drawing.Point(19, 17)
        Me.Add_User_logo.Name = "Add_User_logo"
        Me.Add_User_logo.Size = New System.Drawing.Size(67, 59)
        Me.Add_User_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Add_User_logo.TabIndex = 21
        Me.Add_User_logo.TabStop = False
        '
        'Add_User
        '
        Me.Add_User.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Add_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Add_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add_User.BorderRadius = 0
        Me.Add_User.ButtonText = "Add User"
        Me.Add_User.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_User.DisabledColor = System.Drawing.Color.White
        Me.Add_User.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Add_User.ForeColor = System.Drawing.Color.White
        Me.Add_User.Iconcolor = System.Drawing.Color.Transparent
        Me.Add_User.Iconimage = Nothing
        Me.Add_User.Iconimage_right = Nothing
        Me.Add_User.Iconimage_right_Selected = Nothing
        Me.Add_User.Iconimage_Selected = Nothing
        Me.Add_User.IconMarginLeft = 0
        Me.Add_User.IconMarginRight = 0
        Me.Add_User.IconRightVisible = True
        Me.Add_User.IconRightZoom = 0R
        Me.Add_User.IconVisible = False
        Me.Add_User.IconZoom = 70.0R
        Me.Add_User.IsTab = False
        Me.Add_User.Location = New System.Drawing.Point(85, 17)
        Me.Add_User.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Add_User.Name = "Add_User"
        Me.Add_User.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Add_User.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Add_User.OnHoverTextColor = System.Drawing.Color.White
        Me.Add_User.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Add_User.selected = False
        Me.Add_User.Size = New System.Drawing.Size(195, 60)
        Me.Add_User.TabIndex = 20
        Me.Add_User.Text = "Add User"
        Me.Add_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Add_User.Textcolor = System.Drawing.Color.White
        Me.Add_User.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'User_log_logo
        '
        Me.User_log_logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.User_log_logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.User_log_logo.Image = CType(resources.GetObject("User_log_logo.Image"), System.Drawing.Image)
        Me.User_log_logo.Location = New System.Drawing.Point(320, 16)
        Me.User_log_logo.Name = "User_log_logo"
        Me.User_log_logo.Size = New System.Drawing.Size(67, 59)
        Me.User_log_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.User_log_logo.TabIndex = 19
        Me.User_log_logo.TabStop = False
        '
        'User_logs_Button
        '
        Me.User_logs_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.User_logs_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.User_logs_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.User_logs_Button.BorderRadius = 0
        Me.User_logs_Button.ButtonText = "User Logs"
        Me.User_logs_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.User_logs_Button.DisabledColor = System.Drawing.Color.White
        Me.User_logs_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.User_logs_Button.ForeColor = System.Drawing.Color.White
        Me.User_logs_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.User_logs_Button.Iconimage = Nothing
        Me.User_logs_Button.Iconimage_right = Nothing
        Me.User_logs_Button.Iconimage_right_Selected = Nothing
        Me.User_logs_Button.Iconimage_Selected = Nothing
        Me.User_logs_Button.IconMarginLeft = 0
        Me.User_logs_Button.IconMarginRight = 0
        Me.User_logs_Button.IconRightVisible = True
        Me.User_logs_Button.IconRightZoom = 0R
        Me.User_logs_Button.IconVisible = False
        Me.User_logs_Button.IconZoom = 70.0R
        Me.User_logs_Button.IsTab = False
        Me.User_logs_Button.Location = New System.Drawing.Point(387, 16)
        Me.User_logs_Button.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.User_logs_Button.Name = "User_logs_Button"
        Me.User_logs_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.User_logs_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.User_logs_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.User_logs_Button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.User_logs_Button.selected = False
        Me.User_logs_Button.Size = New System.Drawing.Size(195, 60)
        Me.User_logs_Button.TabIndex = 18
        Me.User_logs_Button.Text = "User Logs"
        Me.User_logs_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.User_logs_Button.Textcolor = System.Drawing.Color.White
        Me.User_logs_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'User_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 570)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.User_table)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "User_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User_List"
        CType(Me.User_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Add_User_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_log_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User_table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents Date_Created As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Add_User_logo As PictureBox
    Friend WithEvents Add_User As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents User_log_logo As PictureBox
    Friend WithEvents User_logs_Button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Search As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
