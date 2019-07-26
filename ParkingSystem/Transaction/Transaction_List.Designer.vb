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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction_List))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Transaction_Hitory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Add_Transaction = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Search = New Bunifu.Framework.UI.BunifuMaterialTextbox()
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
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Transaction_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 75)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Transaction_Hitory)
        Me.Panel2.Controls.Add(Me.Add_Transaction)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(507, 75)
        Me.Panel2.TabIndex = 3
        '
        'Transaction_Hitory
        '
        Me.Transaction_Hitory.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Transaction_Hitory.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Transaction_Hitory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Transaction_Hitory.BorderRadius = 0
        Me.Transaction_Hitory.ButtonText = "Transaction History"
        Me.Transaction_Hitory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Transaction_Hitory.DisabledColor = System.Drawing.Color.Gray
        Me.Transaction_Hitory.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Transaction_Hitory.Iconcolor = System.Drawing.Color.Transparent
        Me.Transaction_Hitory.Iconimage = CType(resources.GetObject("Transaction_Hitory.Iconimage"), System.Drawing.Image)
        Me.Transaction_Hitory.Iconimage_right = Nothing
        Me.Transaction_Hitory.Iconimage_right_Selected = Nothing
        Me.Transaction_Hitory.Iconimage_Selected = Nothing
        Me.Transaction_Hitory.IconMarginLeft = 0
        Me.Transaction_Hitory.IconMarginRight = 0
        Me.Transaction_Hitory.IconRightVisible = False
        Me.Transaction_Hitory.IconRightZoom = 0R
        Me.Transaction_Hitory.IconVisible = False
        Me.Transaction_Hitory.IconZoom = 90.0R
        Me.Transaction_Hitory.IsTab = False
        Me.Transaction_Hitory.Location = New System.Drawing.Point(260, 14)
        Me.Transaction_Hitory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Transaction_Hitory.Name = "Transaction_Hitory"
        Me.Transaction_Hitory.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Transaction_Hitory.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Transaction_Hitory.OnHoverTextColor = System.Drawing.Color.White
        Me.Transaction_Hitory.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Transaction_Hitory.selected = False
        Me.Transaction_Hitory.Size = New System.Drawing.Size(232, 50)
        Me.Transaction_Hitory.TabIndex = 2
        Me.Transaction_Hitory.Text = "Transaction History"
        Me.Transaction_Hitory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Transaction_Hitory.Textcolor = System.Drawing.Color.White
        Me.Transaction_Hitory.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        '
        'Add_Transaction
        '
        Me.Add_Transaction.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Add_Transaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Add_Transaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add_Transaction.BorderRadius = 0
        Me.Add_Transaction.ButtonText = "Add Transaction"
        Me.Add_Transaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Transaction.DisabledColor = System.Drawing.Color.Gray
        Me.Add_Transaction.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Add_Transaction.Iconcolor = System.Drawing.Color.Transparent
        Me.Add_Transaction.Iconimage = CType(resources.GetObject("Add_Transaction.Iconimage"), System.Drawing.Image)
        Me.Add_Transaction.Iconimage_right = Nothing
        Me.Add_Transaction.Iconimage_right_Selected = Nothing
        Me.Add_Transaction.Iconimage_Selected = Nothing
        Me.Add_Transaction.IconMarginLeft = 0
        Me.Add_Transaction.IconMarginRight = 0
        Me.Add_Transaction.IconRightVisible = True
        Me.Add_Transaction.IconRightZoom = 0R
        Me.Add_Transaction.IconVisible = False
        Me.Add_Transaction.IconZoom = 90.0R
        Me.Add_Transaction.IsTab = False
        Me.Add_Transaction.Location = New System.Drawing.Point(8, 14)
        Me.Add_Transaction.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Add_Transaction.Name = "Add_Transaction"
        Me.Add_Transaction.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Add_Transaction.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Add_Transaction.OnHoverTextColor = System.Drawing.Color.White
        Me.Add_Transaction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Add_Transaction.selected = False
        Me.Add_Transaction.Size = New System.Drawing.Size(232, 50)
        Me.Add_Transaction.TabIndex = 1
        Me.Add_Transaction.Text = "Add Transaction"
        Me.Add_Transaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Add_Transaction.Textcolor = System.Drawing.Color.White
        Me.Add_Transaction.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(662, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(218, 75)
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
        Me.Search.LineThickness = 1
        Me.Search.Location = New System.Drawing.Point(6, 26)
        Me.Search.Margin = New System.Windows.Forms.Padding(6)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(206, 38)
        Me.Search.TabIndex = 0
        Me.Search.Text = "Search Anything"
        Me.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Transaction_Table.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Transaction_Table.HeaderBgColor = System.Drawing.Color.Black
        Me.Transaction_Table.HeaderForeColor = System.Drawing.Color.White
        Me.Transaction_Table.Location = New System.Drawing.Point(0, 73)
        Me.Transaction_Table.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
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
        Me.Transaction_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Transaction_Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction_Table.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transaction_Table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.Transaction_Table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Transaction_Table.RowTemplate.DividerHeight = 1
        Me.Transaction_Table.RowTemplate.Height = 40
        Me.Transaction_Table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Transaction_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Transaction_Table.Size = New System.Drawing.Size(880, 440)
        Me.Transaction_Table.TabIndex = 10
        '
        'Transaction_ID
        '
        Me.Transaction_ID.HeaderText = "Transaction ID"
        Me.Transaction_ID.Name = "Transaction_ID"
        Me.Transaction_ID.ReadOnly = True
        Me.Transaction_ID.Visible = False
        '
        'Membership_ID
        '
        Me.Membership_ID.HeaderText = "Membership_ID"
        Me.Membership_ID.Name = "Membership_ID"
        Me.Membership_ID.ReadOnly = True
        Me.Membership_ID.Visible = False
        '
        'firstname
        '
        Me.firstname.HeaderText = "First Name"
        Me.firstname.Name = "firstname"
        Me.firstname.ReadOnly = True
        '
        'lastname
        '
        Me.lastname.HeaderText = "Last Name"
        Me.lastname.Name = "lastname"
        Me.lastname.ReadOnly = True
        '
        'promoname
        '
        Me.promoname.HeaderText = "Promo Name"
        Me.promoname.Name = "promoname"
        Me.promoname.ReadOnly = True
        '
        'location_
        '
        Me.location_.HeaderText = "Location"
        Me.location_.Name = "location_"
        Me.location_.ReadOnly = True
        '
        'timein
        '
        Me.timein.HeaderText = "Time In"
        Me.timein.Name = "timein"
        Me.timein.ReadOnly = True
        '
        'timeout
        '
        Me.timeout.HeaderText = "Time Out"
        Me.timeout.Name = "timeout"
        Me.timeout.ReadOnly = True
        '
        'userassign
        '
        Me.userassign.HeaderText = "User Assign"
        Me.userassign.Name = "userassign"
        Me.userassign.ReadOnly = True
        '
        'promoactive
        '
        Me.promoactive.HeaderText = "Promo Active"
        Me.promoactive.Name = "promoactive"
        Me.promoactive.ReadOnly = True
        '
        'date_
        '
        Me.date_.HeaderText = "Date"
        Me.date_.Name = "date_"
        Me.date_.ReadOnly = True
        Me.date_.Visible = False
        '
        'Transaction_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 513)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Transaction_Table)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaction_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Transaction_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Add_Transaction As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Search As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Transaction_Table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Transaction_Hitory As Bunifu.Framework.UI.BunifuFlatButton
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
