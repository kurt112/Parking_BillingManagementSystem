<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pricing_Promo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Promo_Name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Promo_Hours = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Promo_Description = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.promo_ends = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.PromoPrice = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Register_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Exit_Button)
        Me.Panel1.Controls.Add(Me.Register_Button)
        Me.Panel1.Controls.Add(Me.PromoPrice)
        Me.Panel1.Controls.Add(Me.promo_ends)
        Me.Panel1.Controls.Add(Me.Promo_Description)
        Me.Panel1.Controls.Add(Me.Promo_Hours)
        Me.Panel1.Controls.Add(Me.Promo_Name)
        Me.Panel1.Location = New System.Drawing.Point(165, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 379)
        Me.Panel1.TabIndex = 8
        '
        'Promo_Name
        '
        Me.Promo_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Promo_Name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Promo_Name.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Promo_Name.ForeColor = System.Drawing.Color.White
        Me.Promo_Name.HintForeColor = System.Drawing.Color.Empty
        Me.Promo_Name.HintText = ""
        Me.Promo_Name.isPassword = False
        Me.Promo_Name.LineFocusedColor = System.Drawing.Color.Blue
        Me.Promo_Name.LineIdleColor = System.Drawing.Color.Gray
        Me.Promo_Name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Promo_Name.LineThickness = 3
        Me.Promo_Name.Location = New System.Drawing.Point(15, 12)
        Me.Promo_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.Promo_Name.Name = "Promo_Name"
        Me.Promo_Name.Size = New System.Drawing.Size(370, 34)
        Me.Promo_Name.TabIndex = 0
        Me.Promo_Name.Text = "Promo Name"
        Me.Promo_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Promo_Hours
        '
        Me.Promo_Hours.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Promo_Hours.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Promo_Hours.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Promo_Hours.ForeColor = System.Drawing.Color.White
        Me.Promo_Hours.HintForeColor = System.Drawing.Color.Empty
        Me.Promo_Hours.HintText = ""
        Me.Promo_Hours.isPassword = False
        Me.Promo_Hours.LineFocusedColor = System.Drawing.Color.Blue
        Me.Promo_Hours.LineIdleColor = System.Drawing.Color.Gray
        Me.Promo_Hours.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Promo_Hours.LineThickness = 3
        Me.Promo_Hours.Location = New System.Drawing.Point(15, 56)
        Me.Promo_Hours.Margin = New System.Windows.Forms.Padding(4)
        Me.Promo_Hours.Name = "Promo_Hours"
        Me.Promo_Hours.Size = New System.Drawing.Size(370, 34)
        Me.Promo_Hours.TabIndex = 15
        Me.Promo_Hours.Text = "Promo Hours"
        Me.Promo_Hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Promo_Description
        '
        Me.Promo_Description.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Promo_Description.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Promo_Description.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Promo_Description.ForeColor = System.Drawing.Color.White
        Me.Promo_Description.HintForeColor = System.Drawing.Color.Empty
        Me.Promo_Description.HintText = ""
        Me.Promo_Description.isPassword = False
        Me.Promo_Description.LineFocusedColor = System.Drawing.Color.Blue
        Me.Promo_Description.LineIdleColor = System.Drawing.Color.Gray
        Me.Promo_Description.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Promo_Description.LineThickness = 3
        Me.Promo_Description.Location = New System.Drawing.Point(15, 102)
        Me.Promo_Description.Margin = New System.Windows.Forms.Padding(4)
        Me.Promo_Description.Name = "Promo_Description"
        Me.Promo_Description.Size = New System.Drawing.Size(370, 34)
        Me.Promo_Description.TabIndex = 16
        Me.Promo_Description.Text = "Promo Description"
        Me.Promo_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'promo_ends
        '
        Me.promo_ends.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.promo_ends.BorderRadius = 0
        Me.promo_ends.ForeColor = System.Drawing.Color.White
        Me.promo_ends.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.promo_ends.FormatCustom = Nothing
        Me.promo_ends.Location = New System.Drawing.Point(15, 149)
        Me.promo_ends.Name = "promo_ends"
        Me.promo_ends.Size = New System.Drawing.Size(370, 36)
        Me.promo_ends.TabIndex = 17
        Me.promo_ends.Value = New Date(2019, 6, 28, 18, 56, 4, 708)
        '
        'PromoPrice
        '
        Me.PromoPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PromoPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PromoPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromoPrice.ForeColor = System.Drawing.Color.White
        Me.PromoPrice.HintForeColor = System.Drawing.Color.Empty
        Me.PromoPrice.HintText = ""
        Me.PromoPrice.isPassword = False
        Me.PromoPrice.LineFocusedColor = System.Drawing.Color.Blue
        Me.PromoPrice.LineIdleColor = System.Drawing.Color.Gray
        Me.PromoPrice.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.PromoPrice.LineThickness = 3
        Me.PromoPrice.Location = New System.Drawing.Point(15, 198)
        Me.PromoPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.PromoPrice.Name = "PromoPrice"
        Me.PromoPrice.Size = New System.Drawing.Size(370, 34)
        Me.PromoPrice.TabIndex = 18
        Me.PromoPrice.Text = "Promo Price"
        Me.PromoPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Register_Button
        '
        Me.Register_Button.BackColor = System.Drawing.Color.SeaGreen
        Me.Register_Button.FlatAppearance.BorderSize = 0
        Me.Register_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Register_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Register_Button.ForeColor = System.Drawing.Color.White
        Me.Register_Button.Location = New System.Drawing.Point(15, 248)
        Me.Register_Button.Name = "Register_Button"
        Me.Register_Button.Size = New System.Drawing.Size(370, 48)
        Me.Register_Button.TabIndex = 19
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
        Me.Exit_Button.Location = New System.Drawing.Point(15, 312)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(370, 48)
        Me.Exit_Button.TabIndex = 20
        Me.Exit_Button.Text = "Back"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'Pricing_Promo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(731, 421)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pricing_Promo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pricing_Promo"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Register_Button As Button
    Friend WithEvents PromoPrice As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents promo_ends As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Promo_Description As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Promo_Hours As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Promo_Name As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
