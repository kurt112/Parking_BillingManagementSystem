<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_Histroy_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction_Histroy_List))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Search = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_end = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.start_date = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.start_date_copy = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Transaction_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Viewmember_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewlocation_contextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Viewuser_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextmenu_refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.Transaction_Table = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Transaction_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Membership_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.promoname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.location_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timein = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userassign = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.promoactive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Transaction_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(711, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(389, 92)
        Me.Panel3.TabIndex = 2
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
        Me.Search.Location = New System.Drawing.Point(116, 32)
        Me.Search.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(265, 47)
        Me.Search.TabIndex = 0
        Me.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.date_end)
        Me.Panel2.Controls.Add(Me.start_date)
        Me.Panel2.Controls.Add(Me.start_date_copy)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(646, 92)
        Me.Panel2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = ""
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(347, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date End"
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = ""
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Start"
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = ""
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(311, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "To"
        '
        'date_end
        '
        Me.date_end.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.date_end.BorderRadius = 0
        Me.date_end.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_end.ForeColor = System.Drawing.Color.White
        Me.date_end.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.date_end.FormatCustom = Nothing
        Me.date_end.Location = New System.Drawing.Point(352, 32)
        Me.date_end.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.date_end.Name = "date_end"
        Me.date_end.Size = New System.Drawing.Size(287, 53)
        Me.date_end.TabIndex = 1
        Me.date_end.Value = New Date(2019, 6, 23, 0, 48, 3, 835)
        '
        'start_date
        '
        Me.start_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.start_date.BorderRadius = 0
        Me.start_date.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_date.ForeColor = System.Drawing.Color.White
        Me.start_date.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.start_date.FormatCustom = Nothing
        Me.start_date.Location = New System.Drawing.Point(16, 32)
        Me.start_date.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.start_date.Name = "start_date"
        Me.start_date.Size = New System.Drawing.Size(287, 53)
        Me.start_date.TabIndex = 0
        Me.start_date.Value = New Date(2019, 6, 23, 0, 48, 3, 835)
        '
        'start_date_copy
        '
        Me.start_date_copy.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.start_date_copy.BorderRadius = 0
        Me.start_date_copy.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_date_copy.ForeColor = System.Drawing.Color.White
        Me.start_date_copy.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.start_date_copy.FormatCustom = Nothing
        Me.start_date_copy.Location = New System.Drawing.Point(175, 38)
        Me.start_date_copy.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.start_date_copy.Name = "start_date_copy"
        Me.start_date_copy.Size = New System.Drawing.Size(122, 41)
        Me.start_date_copy.TabIndex = 6
        Me.start_date_copy.Value = New Date(2019, 6, 23, 0, 48, 3, 835)
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
        Me.Panel1.Size = New System.Drawing.Size(1100, 92)
        Me.Panel1.TabIndex = 12
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
        'Transaction_Table
        '
        Me.Transaction_Table.AllowUserToAddRows = False
        Me.Transaction_Table.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.Transaction_Table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Transaction_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Transaction_Table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction_Table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Transaction_Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Transaction_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Transaction_Table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Transaction_Table.ColumnHeadersHeight = 35
        Me.Transaction_Table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Transaction_ID, Me.Membership_ID, Me.firstname, Me.lastname, Me.promoname, Me.location_, Me.timein, Me.timeout, Me.userassign, Me.promoactive, Me.date_})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Transaction_Table.DefaultCellStyle = DataGridViewCellStyle7
        Me.Transaction_Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Transaction_Table.DoubleBuffered = False
        Me.Transaction_Table.EnableHeadersVisualStyles = False
        Me.Transaction_Table.GridColor = System.Drawing.Color.White
        Me.Transaction_Table.HeaderBgColor = System.Drawing.Color.Black
        Me.Transaction_Table.HeaderForeColor = System.Drawing.Color.White
        Me.Transaction_Table.Location = New System.Drawing.Point(0, 92)
        Me.Transaction_Table.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
        Me.Transaction_Table.Name = "Transaction_Table"
        Me.Transaction_Table.ReadOnly = True
        Me.Transaction_Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Transaction_Table.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
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
        Me.Transaction_Table.Size = New System.Drawing.Size(1100, 468)
        Me.Transaction_Table.TabIndex = 16
        '
        'Transaction_ID
        '
        Me.Transaction_ID.HeaderText = "Transaction ID"
        Me.Transaction_ID.MinimumWidth = 6
        Me.Transaction_ID.Name = "Transaction_ID"
        Me.Transaction_ID.ReadOnly = True
        Me.Transaction_ID.Visible = False
        '
        'Membership_ID
        '
        Me.Membership_ID.HeaderText = "Membership_ID"
        Me.Membership_ID.MinimumWidth = 6
        Me.Membership_ID.Name = "Membership_ID"
        Me.Membership_ID.ReadOnly = True
        Me.Membership_ID.Visible = False
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
        'promoname
        '
        Me.promoname.HeaderText = "Promo Name"
        Me.promoname.MinimumWidth = 6
        Me.promoname.Name = "promoname"
        Me.promoname.ReadOnly = True
        '
        'location_
        '
        Me.location_.HeaderText = "Location"
        Me.location_.MinimumWidth = 6
        Me.location_.Name = "location_"
        Me.location_.ReadOnly = True
        '
        'timein
        '
        Me.timein.HeaderText = "Time In"
        Me.timein.MinimumWidth = 6
        Me.timein.Name = "timein"
        Me.timein.ReadOnly = True
        '
        'timeout
        '
        Me.timeout.HeaderText = "Time Out"
        Me.timeout.MinimumWidth = 6
        Me.timeout.Name = "timeout"
        Me.timeout.ReadOnly = True
        '
        'userassign
        '
        Me.userassign.HeaderText = "User Assign"
        Me.userassign.MinimumWidth = 6
        Me.userassign.Name = "userassign"
        Me.userassign.ReadOnly = True
        '
        'promoactive
        '
        Me.promoactive.HeaderText = "Promo Active"
        Me.promoactive.MinimumWidth = 6
        Me.promoactive.Name = "promoactive"
        Me.promoactive.ReadOnly = True
        '
        'date_
        '
        Me.date_.HeaderText = "Date"
        Me.date_.MinimumWidth = 6
        Me.date_.Name = "date_"
        Me.date_.ReadOnly = True
        '
        'Transaction_Histroy_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 560)
        Me.Controls.Add(Me.Transaction_Table)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Transaction_Histroy_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction_Histroy_List"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Transaction_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Search As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents start_date As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Transaction_ContextMenu As ToolStripMenuItem
    Friend WithEvents Viewmember_ContextMenu As ToolStripMenuItem
    Friend WithEvents viewlocation_contextMenu As ToolStripMenuItem
    Friend WithEvents Viewuser_ContextMenu As ToolStripMenuItem
    Friend WithEvents contextmenu_refresh As ToolStripMenuItem
    Friend WithEvents date_end As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents start_date_copy As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Transaction_Table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Transaction_ID As DataGridViewTextBoxColumn
    Friend WithEvents Membership_ID As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
    Friend WithEvents promoname As DataGridViewTextBoxColumn
    Friend WithEvents location_ As DataGridViewTextBoxColumn
    Friend WithEvents timein As DataGridViewTextBoxColumn
    Friend WithEvents timeout As DataGridViewTextBoxColumn
    Friend WithEvents userassign As DataGridViewTextBoxColumn
    Friend WithEvents promoactive As DataGridViewTextBoxColumn
    Friend WithEvents date_ As DataGridViewTextBoxColumn
End Class
