<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parking_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parking_Add))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.parking_level = New System.Windows.Forms.Panel()
        Me.parking_fee = New System.Windows.Forms.Panel()
        Me.Register_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.parking_fee_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.parking_level_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Parking_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.parking_level)
        Me.Panel1.Controls.Add(Me.parking_fee)
        Me.Panel1.Controls.Add(Me.Register_Button)
        Me.Panel1.Controls.Add(Me.Exit_Button)
        Me.Panel1.Controls.Add(Me.parking_fee_button)
        Me.Panel1.Controls.Add(Me.parking_level_button)
        Me.Panel1.Controls.Add(Me.Parking_name)
        Me.Panel1.Location = New System.Drawing.Point(21, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 318)
        Me.Panel1.TabIndex = 7
        '
        'parking_level
        '
        Me.parking_level.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.parking_level.Location = New System.Drawing.Point(15, 103)
        Me.parking_level.Name = "parking_level"
        Me.parking_level.Size = New System.Drawing.Size(370, 135)
        Me.parking_level.TabIndex = 19
        Me.parking_level.Visible = False
        '
        'parking_fee
        '
        Me.parking_fee.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.parking_fee.Location = New System.Drawing.Point(15, 163)
        Me.parking_fee.Name = "parking_fee"
        Me.parking_fee.Size = New System.Drawing.Size(370, 135)
        Me.parking_fee.TabIndex = 18
        Me.parking_fee.Visible = False
        '
        'Register_Button
        '
        Me.Register_Button.BackColor = System.Drawing.Color.SeaGreen
        Me.Register_Button.FlatAppearance.BorderSize = 0
        Me.Register_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Register_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Register_Button.ForeColor = System.Drawing.Color.White
        Me.Register_Button.Location = New System.Drawing.Point(15, 196)
        Me.Register_Button.Name = "Register_Button"
        Me.Register_Button.Size = New System.Drawing.Size(370, 48)
        Me.Register_Button.TabIndex = 15
        Me.Register_Button.Text = "Register"
        Me.Register_Button.UseVisualStyleBackColor = False
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.Red
        Me.Exit_Button.FlatAppearance.BorderSize = 0
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Exit_Button.ForeColor = System.Drawing.Color.White
        Me.Exit_Button.Location = New System.Drawing.Point(15, 263)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(370, 48)
        Me.Exit_Button.TabIndex = 16
        Me.Exit_Button.Text = "Back"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'parking_fee_button
        '
        Me.parking_fee_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.parking_fee_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.parking_fee_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.parking_fee_button.BorderRadius = 0
        Me.parking_fee_button.ButtonText = "Parking Fee"
        Me.parking_fee_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.parking_fee_button.DisabledColor = System.Drawing.Color.Gray
        Me.parking_fee_button.Iconcolor = System.Drawing.Color.DimGray
        Me.parking_fee_button.Iconimage = CType(resources.GetObject("parking_fee_button.Iconimage"), System.Drawing.Image)
        Me.parking_fee_button.Iconimage_right = CType(resources.GetObject("parking_fee_button.Iconimage_right"), System.Drawing.Image)
        Me.parking_fee_button.Iconimage_right_Selected = Nothing
        Me.parking_fee_button.Iconimage_Selected = Nothing
        Me.parking_fee_button.IconMarginLeft = 0
        Me.parking_fee_button.IconMarginRight = 0
        Me.parking_fee_button.IconRightVisible = True
        Me.parking_fee_button.IconRightZoom = 0R
        Me.parking_fee_button.IconVisible = False
        Me.parking_fee_button.IconZoom = 90.0R
        Me.parking_fee_button.IsTab = False
        Me.parking_fee_button.Location = New System.Drawing.Point(15, 126)
        Me.parking_fee_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.parking_fee_button.Name = "parking_fee_button"
        Me.parking_fee_button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.parking_fee_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.parking_fee_button.OnHoverTextColor = System.Drawing.Color.White
        Me.parking_fee_button.selected = False
        Me.parking_fee_button.Size = New System.Drawing.Size(370, 37)
        Me.parking_fee_button.TabIndex = 2
        Me.parking_fee_button.Text = "Parking Fee"
        Me.parking_fee_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.parking_fee_button.Textcolor = System.Drawing.Color.White
        Me.parking_fee_button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'parking_level_button
        '
        Me.parking_level_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.parking_level_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.parking_level_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.parking_level_button.BorderRadius = 0
        Me.parking_level_button.ButtonText = "Parking Level"
        Me.parking_level_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.parking_level_button.DisabledColor = System.Drawing.Color.Gray
        Me.parking_level_button.Iconcolor = System.Drawing.Color.Transparent
        Me.parking_level_button.Iconimage = CType(resources.GetObject("parking_level_button.Iconimage"), System.Drawing.Image)
        Me.parking_level_button.Iconimage_right = CType(resources.GetObject("parking_level_button.Iconimage_right"), System.Drawing.Image)
        Me.parking_level_button.Iconimage_right_Selected = Nothing
        Me.parking_level_button.Iconimage_Selected = Nothing
        Me.parking_level_button.IconMarginLeft = 0
        Me.parking_level_button.IconMarginRight = 0
        Me.parking_level_button.IconRightVisible = True
        Me.parking_level_button.IconRightZoom = 0R
        Me.parking_level_button.IconVisible = False
        Me.parking_level_button.IconZoom = 90.0R
        Me.parking_level_button.IsTab = False
        Me.parking_level_button.Location = New System.Drawing.Point(15, 67)
        Me.parking_level_button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.parking_level_button.Name = "parking_level_button"
        Me.parking_level_button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.parking_level_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.parking_level_button.OnHoverTextColor = System.Drawing.Color.White
        Me.parking_level_button.selected = False
        Me.parking_level_button.Size = New System.Drawing.Size(370, 37)
        Me.parking_level_button.TabIndex = 1
        Me.parking_level_button.Text = "Parking Level"
        Me.parking_level_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.parking_level_button.Textcolor = System.Drawing.Color.White
        Me.parking_level_button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Parking_name
        '
        Me.Parking_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Parking_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Parking_name.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parking_name.ForeColor = System.Drawing.Color.White
        Me.Parking_name.HintForeColor = System.Drawing.Color.Empty
        Me.Parking_name.HintText = ""
        Me.Parking_name.isPassword = False
        Me.Parking_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.Parking_name.LineIdleColor = System.Drawing.Color.Gray
        Me.Parking_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Parking_name.LineThickness = 3
        Me.Parking_name.Location = New System.Drawing.Point(15, 14)
        Me.Parking_name.Margin = New System.Windows.Forms.Padding(4)
        Me.Parking_name.Name = "Parking_name"
        Me.Parking_name.Size = New System.Drawing.Size(370, 34)
        Me.Parking_name.TabIndex = 0
        Me.Parking_name.Text = "Parking Name"
        Me.Parking_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Parking_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(445, 366)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Parking_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Parking_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents parking_level_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents parking_fee_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Register_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents parking_level As Panel
    Friend WithEvents parking_fee As Panel
End Class
