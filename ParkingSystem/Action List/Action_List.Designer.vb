<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Action_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Action_List))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Register_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Search = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Member_table = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.memberid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.assignuser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transactiontype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date__ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Member_table, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(760, 76)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Register_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 76)
        Me.Panel2.TabIndex = 3
        '
        'Register_Button
        '
        Me.Register_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Register_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Register_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Register_Button.BorderRadius = 0
        Me.Register_Button.ButtonText = "Register"
        Me.Register_Button.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Register_Button.DisabledColor = System.Drawing.Color.Gray
        Me.Register_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Register_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.Register_Button.Iconimage = CType(resources.GetObject("Register_Button.Iconimage"), System.Drawing.Image)
        Me.Register_Button.Iconimage_right = Nothing
        Me.Register_Button.Iconimage_right_Selected = Nothing
        Me.Register_Button.Iconimage_Selected = Nothing
        Me.Register_Button.IconMarginLeft = 0
        Me.Register_Button.IconMarginRight = 0
        Me.Register_Button.IconRightVisible = True
        Me.Register_Button.IconRightZoom = 0R
        Me.Register_Button.IconVisible = True
        Me.Register_Button.IconZoom = 170.0R
        Me.Register_Button.IsTab = False
        Me.Register_Button.Location = New System.Drawing.Point(13, 18)
        Me.Register_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Register_Button.Name = "Register_Button"
        Me.Register_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Register_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Register_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.Register_Button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Register_Button.selected = False
        Me.Register_Button.Size = New System.Drawing.Size(206, 49)
        Me.Register_Button.TabIndex = 5
        Me.Register_Button.Text = "Register"
        Me.Register_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Register_Button.Textcolor = System.Drawing.Color.White
        Me.Register_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(468, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(292, 76)
        Me.Panel3.TabIndex = 2
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.Search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Search.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Search.ForeColor = System.Drawing.Color.White
        Me.Search.HintForeColor = System.Drawing.Color.Empty
        Me.Search.HintText = ""
        Me.Search.isPassword = False
        Me.Search.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Search.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Search.LineMouseHoverColor = System.Drawing.Color.Gray
        Me.Search.LineThickness = 1
        Me.Search.Location = New System.Drawing.Point(74, 29)
        Me.Search.Margin = New System.Windows.Forms.Padding(6)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(203, 38)
        Me.Search.TabIndex = 7
        Me.Search.Text = "Available"
        Me.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Member_table
        '
        Me.Member_table.AllowUserToAddRows = False
        Me.Member_table.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Member_table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
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
        Me.Member_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.memberid, Me.firstname, Me.lastname, Me.assignuser, Me.transactiontype, Me.date__})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Member_table.DefaultCellStyle = DataGridViewCellStyle3
        Me.Member_table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Member_table.DoubleBuffered = True
        Me.Member_table.EnableHeadersVisualStyles = False
        Me.Member_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Member_table.HeaderBgColor = System.Drawing.Color.Black
        Me.Member_table.HeaderForeColor = System.Drawing.Color.White
        Me.Member_table.Location = New System.Drawing.Point(0, 76)
        Me.Member_table.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
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
        Me.Member_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Member_table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Member_table.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Member_table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.Member_table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Member_table.RowTemplate.DividerHeight = 1
        Me.Member_table.RowTemplate.Height = 40
        Me.Member_table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Member_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Member_table.Size = New System.Drawing.Size(760, 374)
        Me.Member_table.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'memberid
        '
        Me.memberid.HeaderText = "Member id"
        Me.memberid.Name = "memberid"
        Me.memberid.ReadOnly = True
        Me.memberid.Visible = False
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
        'assignuser
        '
        Me.assignuser.HeaderText = "Assign User"
        Me.assignuser.Name = "assignuser"
        Me.assignuser.ReadOnly = True
        '
        'transactiontype
        '
        Me.transactiontype.HeaderText = "Action Type"
        Me.transactiontype.Name = "transactiontype"
        Me.transactiontype.ReadOnly = True
        '
        'date__
        '
        Me.date__.HeaderText = "Date"
        Me.date__.Name = "date__"
        Me.date__.ReadOnly = True
        '
        'Action_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 450)
        Me.Controls.Add(Me.Member_table)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Action_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Action_List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Member_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Register_Button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Search As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Member_table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents memberid As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
    Friend WithEvents assignuser As DataGridViewTextBoxColumn
    Friend WithEvents transactiontype As DataGridViewTextBoxColumn
    Friend WithEvents date__ As DataGridViewTextBoxColumn
End Class
