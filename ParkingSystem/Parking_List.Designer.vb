﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parking_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parking_List))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Add_Parking = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.status_ = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Search = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Parking_Area_Table = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parking_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parking_level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parking_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Parking_Area_Table, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1244, 75)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Add_Parking)
        Me.Panel2.Controls.Add(Me.status_)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(502, 75)
        Me.Panel2.TabIndex = 3
        '
        'Add_Parking
        '
        Me.Add_Parking.Activecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Add_Parking.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Add_Parking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Add_Parking.BorderRadius = 0
        Me.Add_Parking.ButtonText = "Add Parking"
        Me.Add_Parking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Parking.DisabledColor = System.Drawing.Color.Gray
        Me.Add_Parking.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Add_Parking.Iconcolor = System.Drawing.Color.Transparent
        Me.Add_Parking.Iconimage = CType(resources.GetObject("Add_Parking.Iconimage"), System.Drawing.Image)
        Me.Add_Parking.Iconimage_right = Nothing
        Me.Add_Parking.Iconimage_right_Selected = Nothing
        Me.Add_Parking.Iconimage_Selected = Nothing
        Me.Add_Parking.IconMarginLeft = 0
        Me.Add_Parking.IconMarginRight = 0
        Me.Add_Parking.IconRightVisible = True
        Me.Add_Parking.IconRightZoom = 0R
        Me.Add_Parking.IconVisible = True
        Me.Add_Parking.IconZoom = 170.0R
        Me.Add_Parking.IsTab = False
        Me.Add_Parking.Location = New System.Drawing.Point(268, 18)
        Me.Add_Parking.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Add_Parking.Name = "Add_Parking"
        Me.Add_Parking.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Add_Parking.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Add_Parking.OnHoverTextColor = System.Drawing.Color.White
        Me.Add_Parking.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Add_Parking.selected = False
        Me.Add_Parking.Size = New System.Drawing.Size(206, 45)
        Me.Add_Parking.TabIndex = 5
        Me.Add_Parking.Text = "Add Parking"
        Me.Add_Parking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Add_Parking.Textcolor = System.Drawing.Color.White
        Me.Add_Parking.TextFont = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'status_
        '
        Me.status_.BackColor = System.Drawing.Color.Gray
        Me.status_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.status_.BorderRadius = 3
        Me.status_.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_.ForeColor = System.Drawing.Color.White
        Me.status_.Items = New String() {"Available"}
        Me.status_.Location = New System.Drawing.Point(13, 18)
        Me.status_.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.status_.Name = "status_"
        Me.status_.NomalColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.status_.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.status_.selectedIndex = 0
        Me.status_.Size = New System.Drawing.Size(196, 45)
        Me.status_.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Search)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(952, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(292, 75)
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
        Me.Search.Location = New System.Drawing.Point(74, 25)
        Me.Search.Margin = New System.Windows.Forms.Padding(6)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(203, 38)
        Me.Search.TabIndex = 6
        Me.Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Parking_Area_Table
        '
        Me.Parking_Area_Table.AllowUserToAddRows = False
        Me.Parking_Area_Table.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.Parking_Area_Table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Parking_Area_Table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Parking_Area_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Parking_Area_Table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Parking_Area_Table.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Parking_Area_Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Parking_Area_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Parking_Area_Table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Parking_Area_Table.ColumnHeadersHeight = 35
        Me.Parking_Area_Table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.parking_name, Me.parking_level, Me.parking_price, Me.Status})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Parking_Area_Table.DefaultCellStyle = DataGridViewCellStyle7
        Me.Parking_Area_Table.DoubleBuffered = True
        Me.Parking_Area_Table.EnableHeadersVisualStyles = False
        Me.Parking_Area_Table.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Parking_Area_Table.HeaderBgColor = System.Drawing.Color.Black
        Me.Parking_Area_Table.HeaderForeColor = System.Drawing.Color.White
        Me.Parking_Area_Table.Location = New System.Drawing.Point(0, 75)
        Me.Parking_Area_Table.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.Parking_Area_Table.Name = "Parking_Area_Table"
        Me.Parking_Area_Table.ReadOnly = True
        Me.Parking_Area_Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Parking_Area_Table.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Parking_Area_Table.RowHeadersVisible = False
        Me.Parking_Area_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Parking_Area_Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Parking_Area_Table.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parking_Area_Table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.Parking_Area_Table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Parking_Area_Table.RowTemplate.DividerHeight = 1
        Me.Parking_Area_Table.RowTemplate.Height = 40
        Me.Parking_Area_Table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Parking_Area_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Parking_Area_Table.Size = New System.Drawing.Size(1244, 425)
        Me.Parking_Area_Table.TabIndex = 11
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'parking_name
        '
        Me.parking_name.HeaderText = "Parking Area"
        Me.parking_name.Name = "parking_name"
        Me.parking_name.ReadOnly = True
        '
        'parking_level
        '
        Me.parking_level.HeaderText = "Parking Floor"
        Me.parking_level.Name = "parking_level"
        Me.parking_level.ReadOnly = True
        '
        'parking_price
        '
        Me.parking_price.HeaderText = "Price"
        Me.parking_price.Name = "parking_price"
        Me.parking_price.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Parking_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 500)
        Me.Controls.Add(Me.Parking_Area_Table)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Parking_List"
        Me.Text = "Parking_List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Parking_Area_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Parking_Area_Table As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents status_ As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Add_Parking As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Search As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents parking_name As DataGridViewTextBoxColumn
    Friend WithEvents parking_level As DataGridViewTextBoxColumn
    Friend WithEvents parking_price As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class