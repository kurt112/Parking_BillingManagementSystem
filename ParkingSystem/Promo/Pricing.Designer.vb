<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pricing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pricing))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuDropdown2 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Register_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Promo_Table = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promo_column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hours_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promoends_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Promo_Table, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(943, 75)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuDropdown2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 75)
        Me.Panel2.TabIndex = 3
        '
        'BunifuDropdown2
        '
        Me.BunifuDropdown2.BackColor = System.Drawing.Color.Gray
        Me.BunifuDropdown2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuDropdown2.BorderRadius = 3
        Me.BunifuDropdown2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuDropdown2.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown2.Items = New String() {"Available"}
        Me.BunifuDropdown2.Location = New System.Drawing.Point(13, 18)
        Me.BunifuDropdown2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDropdown2.Name = "BunifuDropdown2"
        Me.BunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuDropdown2.selectedIndex = 0
        Me.BunifuDropdown2.Size = New System.Drawing.Size(196, 45)
        Me.BunifuDropdown2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Register_Button)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(651, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(292, 75)
        Me.Panel3.TabIndex = 2
        '
        'Register_Button
        '
        Me.Register_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Register_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Register_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Register_Button.BorderRadius = 0
        Me.Register_Button.ButtonText = "Add Promo"
        Me.Register_Button.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.Register_Button.Location = New System.Drawing.Point(73, 14)
        Me.Register_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Register_Button.Name = "Register_Button"
        Me.Register_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Register_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Register_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.Register_Button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Register_Button.selected = False
        Me.Register_Button.Size = New System.Drawing.Size(206, 49)
        Me.Register_Button.TabIndex = 6
        Me.Register_Button.Text = "Add Promo"
        Me.Register_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Register_Button.Textcolor = System.Drawing.Color.White
        Me.Register_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Promo_Table
        '
        Me.Promo_Table.AllowUserToAddRows = False
        Me.Promo_Table.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Promo_Table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Promo_Table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Promo_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Promo_Table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Promo_Table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Promo_Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Promo_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Promo_Table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Promo_Table.ColumnHeadersHeight = 35
        Me.Promo_Table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Promo_column, Me.Hours_Column, Me.Description_Column, Me.Promoends_Column, Me.Price_Column, Me.Status_Column})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Promo_Table.DefaultCellStyle = DataGridViewCellStyle3
        Me.Promo_Table.DoubleBuffered = True
        Me.Promo_Table.EnableHeadersVisualStyles = False
        Me.Promo_Table.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Promo_Table.HeaderBgColor = System.Drawing.Color.Black
        Me.Promo_Table.HeaderForeColor = System.Drawing.Color.White
        Me.Promo_Table.Location = New System.Drawing.Point(0, 71)
        Me.Promo_Table.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.Promo_Table.Name = "Promo_Table"
        Me.Promo_Table.ReadOnly = True
        Me.Promo_Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Promo_Table.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Promo_Table.RowHeadersVisible = False
        Me.Promo_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Promo_Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Promo_Table.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Promo_Table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.Promo_Table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Promo_Table.RowTemplate.DividerHeight = 1
        Me.Promo_Table.RowTemplate.Height = 40
        Me.Promo_Table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Promo_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Promo_Table.Size = New System.Drawing.Size(943, 425)
        Me.Promo_Table.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Promo_column
        '
        Me.Promo_column.HeaderText = "Promo Name"
        Me.Promo_column.Name = "Promo_column"
        Me.Promo_column.ReadOnly = True
        '
        'Hours_Column
        '
        Me.Hours_Column.HeaderText = "Duration"
        Me.Hours_Column.Name = "Hours_Column"
        Me.Hours_Column.ReadOnly = True
        '
        'Description_Column
        '
        Me.Description_Column.HeaderText = "Description"
        Me.Description_Column.Name = "Description_Column"
        Me.Description_Column.ReadOnly = True
        '
        'Promoends_Column
        '
        Me.Promoends_Column.HeaderText = "Promo End"
        Me.Promoends_Column.Name = "Promoends_Column"
        Me.Promoends_Column.ReadOnly = True
        '
        'Price_Column
        '
        Me.Price_Column.HeaderText = "Price"
        Me.Price_Column.Name = "Price_Column"
        Me.Price_Column.ReadOnly = True
        '
        'Status_Column
        '
        Me.Status_Column.HeaderText = "Status"
        Me.Status_Column.Name = "Status_Column"
        Me.Status_Column.ReadOnly = True
        '
        'Pricing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 489)
        Me.Controls.Add(Me.Promo_Table)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pricing"
        Me.Text = "Pricing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Promo_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Promo_Table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuDropdown2 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Register_Button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Promo_column As DataGridViewTextBoxColumn
    Friend WithEvents Hours_Column As DataGridViewTextBoxColumn
    Friend WithEvents Description_Column As DataGridViewTextBoxColumn
    Friend WithEvents Promoends_Column As DataGridViewTextBoxColumn
    Friend WithEvents Price_Column As DataGridViewTextBoxColumn
    Friend WithEvents Status_Column As DataGridViewTextBoxColumn
End Class
