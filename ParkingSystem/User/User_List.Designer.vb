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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Add_User = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Userlog_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Search = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.User_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.User_table.Location = New System.Drawing.Point(0, 81)
        Me.User_table.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
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
        Me.User_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.User_table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.User_table.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.User_table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.User_table.RowTemplate.DividerHeight = 1
        Me.User_table.RowTemplate.Height = 40
        Me.User_table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.User_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.User_table.Size = New System.Drawing.Size(960, 383)
        Me.User_table.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "User Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Password
        '
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        '
        'Date_Created
        '
        Me.Date_Created.HeaderText = "Date Created"
        Me.Date_Created.Name = "Date_Created"
        Me.Date_Created.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 75)
        Me.Panel1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Add_User)
        Me.Panel2.Controls.Add(Me.Userlog_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(451, 75)
        Me.Panel2.TabIndex = 3
        '
        'Add_User
        '
        Me.Add_User.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Add_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Add_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add_User.BorderRadius = 0
        Me.Add_User.ButtonText = "Add user"
        Me.Add_User.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Add_User.DisabledColor = System.Drawing.Color.Gray
        Me.Add_User.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Add_User.Iconcolor = System.Drawing.Color.Transparent
        Me.Add_User.Iconimage = CType(resources.GetObject("Add_User.Iconimage"), System.Drawing.Image)
        Me.Add_User.Iconimage_right = Nothing
        Me.Add_User.Iconimage_right_Selected = Nothing
        Me.Add_User.Iconimage_Selected = Nothing
        Me.Add_User.IconMarginLeft = 0
        Me.Add_User.IconMarginRight = 0
        Me.Add_User.IconRightVisible = True
        Me.Add_User.IconRightZoom = 0R
        Me.Add_User.IconVisible = True
        Me.Add_User.IconZoom = 170.0R
        Me.Add_User.IsTab = False
        Me.Add_User.Location = New System.Drawing.Point(234, 21)
        Me.Add_User.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Add_User.Name = "Add_User"
        Me.Add_User.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Add_User.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Add_User.OnHoverTextColor = System.Drawing.Color.White
        Me.Add_User.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Add_User.selected = False
        Me.Add_User.Size = New System.Drawing.Size(206, 49)
        Me.Add_User.TabIndex = 4
        Me.Add_User.Text = "Add user"
        Me.Add_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Add_User.Textcolor = System.Drawing.Color.White
        Me.Add_User.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Userlog_Button
        '
        Me.Userlog_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Userlog_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Userlog_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Userlog_Button.BorderRadius = 0
        Me.Userlog_Button.ButtonText = "User's Logs"
        Me.Userlog_Button.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Userlog_Button.DisabledColor = System.Drawing.Color.Gray
        Me.Userlog_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Userlog_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.Userlog_Button.Iconimage = CType(resources.GetObject("Userlog_Button.Iconimage"), System.Drawing.Image)
        Me.Userlog_Button.Iconimage_right = Nothing
        Me.Userlog_Button.Iconimage_right_Selected = Nothing
        Me.Userlog_Button.Iconimage_Selected = Nothing
        Me.Userlog_Button.IconMarginLeft = 0
        Me.Userlog_Button.IconMarginRight = 0
        Me.Userlog_Button.IconRightVisible = True
        Me.Userlog_Button.IconRightZoom = 0R
        Me.Userlog_Button.IconVisible = True
        Me.Userlog_Button.IconZoom = 170.0R
        Me.Userlog_Button.IsTab = False
        Me.Userlog_Button.Location = New System.Drawing.Point(13, 21)
        Me.Userlog_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Userlog_Button.Name = "Userlog_Button"
        Me.Userlog_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Userlog_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Userlog_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.Userlog_Button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Userlog_Button.selected = False
        Me.Userlog_Button.Size = New System.Drawing.Size(206, 49)
        Me.Userlog_Button.TabIndex = 2
        Me.Userlog_Button.Text = "User's Logs"
        Me.Userlog_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Userlog_Button.Textcolor = System.Drawing.Color.White
        Me.Userlog_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(745, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(215, 75)
        Me.Panel3.TabIndex = 2
        '
        'Search
        '
        Me.Search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Search.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Search.ForeColor = System.Drawing.Color.White
        Me.Search.HintForeColor = System.Drawing.Color.Empty
        Me.Search.HintText = ""
        Me.Search.isPassword = False
        Me.Search.LineFocusedColor = System.Drawing.Color.Gray
        Me.Search.LineIdleColor = System.Drawing.Color.DimGray
        Me.Search.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.Search.LineThickness = 4
        Me.Search.Location = New System.Drawing.Point(21, 21)
        Me.Search.Margin = New System.Windows.Forms.Padding(6)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(182, 38)
        Me.Search.TabIndex = 4
        Me.Search.Text = "Search Anything"
        Me.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'User_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 463)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.User_table)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User_List"
        CType(Me.User_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User_table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Userlog_Button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Search As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Add_User As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents Date_Created As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class
