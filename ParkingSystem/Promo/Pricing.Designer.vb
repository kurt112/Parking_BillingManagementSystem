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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pricing))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Promo_Logo = New System.Windows.Forms.PictureBox()
        Me.Create_Promo_Button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Search = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Promo_Table = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promo_column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hours_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promoends_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promotable_ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Register_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Refresh_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.setEnable_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.setDisable_ContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Promo_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Promo_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Promotable_ContextMenu.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1257, 92)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Promo_Logo)
        Me.Panel2.Controls.Add(Me.Create_Promo_Button)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(329, 92)
        Me.Panel2.TabIndex = 3
        '
        'Promo_Logo
        '
        Me.Promo_Logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Promo_Logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Promo_Logo.Image = CType(resources.GetObject("Promo_Logo.Image"), System.Drawing.Image)
        Me.Promo_Logo.Location = New System.Drawing.Point(34, 16)
        Me.Promo_Logo.Name = "Promo_Logo"
        Me.Promo_Logo.Size = New System.Drawing.Size(67, 59)
        Me.Promo_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Promo_Logo.TabIndex = 23
        Me.Promo_Logo.TabStop = False
        '
        'Create_Promo_Button
        '
        Me.Create_Promo_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Create_Promo_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Create_Promo_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Create_Promo_Button.BorderRadius = 0
        Me.Create_Promo_Button.ButtonText = "Create Promo"
        Me.Create_Promo_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Create_Promo_Button.DisabledColor = System.Drawing.Color.White
        Me.Create_Promo_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Create_Promo_Button.ForeColor = System.Drawing.Color.White
        Me.Create_Promo_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.Create_Promo_Button.Iconimage = Nothing
        Me.Create_Promo_Button.Iconimage_right = Nothing
        Me.Create_Promo_Button.Iconimage_right_Selected = Nothing
        Me.Create_Promo_Button.Iconimage_Selected = Nothing
        Me.Create_Promo_Button.IconMarginLeft = 0
        Me.Create_Promo_Button.IconMarginRight = 0
        Me.Create_Promo_Button.IconRightVisible = True
        Me.Create_Promo_Button.IconRightZoom = 0R
        Me.Create_Promo_Button.IconVisible = False
        Me.Create_Promo_Button.IconZoom = 70.0R
        Me.Create_Promo_Button.IsTab = False
        Me.Create_Promo_Button.Location = New System.Drawing.Point(100, 16)
        Me.Create_Promo_Button.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Create_Promo_Button.Name = "Create_Promo_Button"
        Me.Create_Promo_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Create_Promo_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Create_Promo_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.Create_Promo_Button.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Create_Promo_Button.selected = False
        Me.Create_Promo_Button.Size = New System.Drawing.Size(195, 60)
        Me.Create_Promo_Button.TabIndex = 22
        Me.Create_Promo_Button.Text = "Create Promo"
        Me.Create_Promo_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Create_Promo_Button.Textcolor = System.Drawing.Color.White
        Me.Create_Promo_Button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(868, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(389, 92)
        Me.Panel3.TabIndex = 2
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
        Me.Promo_Table.Location = New System.Drawing.Point(0, 87)
        Me.Promo_Table.Margin = New System.Windows.Forms.Padding(13, 4, 4, 4)
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
        Me.Promo_Table.RowHeadersWidth = 51
        Me.Promo_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Promo_Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Promo_Table.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Promo_Table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.Promo_Table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Promo_Table.RowTemplate.DividerHeight = 1
        Me.Promo_Table.RowTemplate.Height = 40
        Me.Promo_Table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Promo_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Promo_Table.Size = New System.Drawing.Size(1257, 523)
        Me.Promo_Table.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'Promo_column
        '
        Me.Promo_column.HeaderText = "Promo Name"
        Me.Promo_column.MinimumWidth = 6
        Me.Promo_column.Name = "Promo_column"
        Me.Promo_column.ReadOnly = True
        '
        'Hours_Column
        '
        Me.Hours_Column.HeaderText = "Duration"
        Me.Hours_Column.MinimumWidth = 6
        Me.Hours_Column.Name = "Hours_Column"
        Me.Hours_Column.ReadOnly = True
        '
        'Description_Column
        '
        Me.Description_Column.HeaderText = "Description"
        Me.Description_Column.MinimumWidth = 6
        Me.Description_Column.Name = "Description_Column"
        Me.Description_Column.ReadOnly = True
        '
        'Promoends_Column
        '
        Me.Promoends_Column.HeaderText = "Promo End"
        Me.Promoends_Column.MinimumWidth = 6
        Me.Promoends_Column.Name = "Promoends_Column"
        Me.Promoends_Column.ReadOnly = True
        '
        'Price_Column
        '
        Me.Price_Column.HeaderText = "Price"
        Me.Price_Column.MinimumWidth = 6
        Me.Price_Column.Name = "Price_Column"
        Me.Price_Column.ReadOnly = True
        '
        'Status_Column
        '
        Me.Status_Column.HeaderText = "Status"
        Me.Status_Column.MinimumWidth = 6
        Me.Status_Column.Name = "Status_Column"
        Me.Status_Column.ReadOnly = True
        '
        'Promotable_ContextMenu
        '
        Me.Promotable_ContextMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Promotable_ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Register_ContextMenu, Me.Update_ContextMenu, Me.DeleteContextMenu, Me.Refresh_ContextMenu, Me.setEnable_ContextMenu, Me.setDisable_ContextMenu})
        Me.Promotable_ContextMenu.Name = "ContextMenuStrip1"
        Me.Promotable_ContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Promotable_ContextMenu.Size = New System.Drawing.Size(180, 160)
        '
        'Register_ContextMenu
        '
        Me.Register_ContextMenu.Image = CType(resources.GetObject("Register_ContextMenu.Image"), System.Drawing.Image)
        Me.Register_ContextMenu.Name = "Register_ContextMenu"
        Me.Register_ContextMenu.Size = New System.Drawing.Size(179, 26)
        Me.Register_ContextMenu.Text = "Add Promo"
        '
        'Update_ContextMenu
        '
        Me.Update_ContextMenu.Image = CType(resources.GetObject("Update_ContextMenu.Image"), System.Drawing.Image)
        Me.Update_ContextMenu.Name = "Update_ContextMenu"
        Me.Update_ContextMenu.Size = New System.Drawing.Size(179, 26)
        Me.Update_ContextMenu.Text = "Update Promo"
        '
        'DeleteContextMenu
        '
        Me.DeleteContextMenu.Image = CType(resources.GetObject("DeleteContextMenu.Image"), System.Drawing.Image)
        Me.DeleteContextMenu.Name = "DeleteContextMenu"
        Me.DeleteContextMenu.Size = New System.Drawing.Size(179, 26)
        Me.DeleteContextMenu.Text = "Delete Promo"
        '
        'Refresh_ContextMenu
        '
        Me.Refresh_ContextMenu.Image = CType(resources.GetObject("Refresh_ContextMenu.Image"), System.Drawing.Image)
        Me.Refresh_ContextMenu.Name = "Refresh_ContextMenu"
        Me.Refresh_ContextMenu.Size = New System.Drawing.Size(179, 26)
        Me.Refresh_ContextMenu.Text = "Refresh Table"
        '
        'setEnable_ContextMenu
        '
        Me.setEnable_ContextMenu.Image = CType(resources.GetObject("setEnable_ContextMenu.Image"), System.Drawing.Image)
        Me.setEnable_ContextMenu.Name = "setEnable_ContextMenu"
        Me.setEnable_ContextMenu.Size = New System.Drawing.Size(179, 26)
        Me.setEnable_ContextMenu.Text = "Set Enable"
        '
        'setDisable_ContextMenu
        '
        Me.setDisable_ContextMenu.Image = CType(resources.GetObject("setDisable_ContextMenu.Image"), System.Drawing.Image)
        Me.setDisable_ContextMenu.Name = "setDisable_ContextMenu"
        Me.setDisable_ContextMenu.Size = New System.Drawing.Size(179, 26)
        Me.setDisable_ContextMenu.Text = "Set Disable"
        '
        'Pricing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 602)
        Me.Controls.Add(Me.Promo_Table)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Pricing"
        Me.Text = "Pricing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Promo_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Promo_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Promotable_ContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Promo_Table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Promo_column As DataGridViewTextBoxColumn
    Friend WithEvents Hours_Column As DataGridViewTextBoxColumn
    Friend WithEvents Description_Column As DataGridViewTextBoxColumn
    Friend WithEvents Promoends_Column As DataGridViewTextBoxColumn
    Friend WithEvents Price_Column As DataGridViewTextBoxColumn
    Friend WithEvents Status_Column As DataGridViewTextBoxColumn
    Friend WithEvents Search As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Promo_Logo As PictureBox
    Friend WithEvents Create_Promo_Button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Promotable_ContextMenu As ContextMenuStrip
    Friend WithEvents Register_ContextMenu As ToolStripMenuItem
    Friend WithEvents Update_ContextMenu As ToolStripMenuItem
    Friend WithEvents DeleteContextMenu As ToolStripMenuItem
    Friend WithEvents Refresh_ContextMenu As ToolStripMenuItem
    Friend WithEvents setEnable_ContextMenu As ToolStripMenuItem
    Friend WithEvents setDisable_ContextMenu As ToolStripMenuItem
End Class
