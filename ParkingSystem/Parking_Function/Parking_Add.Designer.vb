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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Register_Button = New System.Windows.Forms.Button()
        Me.Parking_fee = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Parking_Level = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Parking_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Exit_Button)
        Me.Panel1.Controls.Add(Me.Register_Button)
        Me.Panel1.Controls.Add(Me.Parking_fee)
        Me.Panel1.Controls.Add(Me.Parking_Level)
        Me.Panel1.Controls.Add(Me.Parking_name)
        Me.Panel1.Location = New System.Drawing.Point(28, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 391)
        Me.Panel1.TabIndex = 7
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.Red
        Me.Exit_Button.FlatAppearance.BorderSize = 0
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Exit_Button.ForeColor = System.Drawing.Color.White
        Me.Exit_Button.Location = New System.Drawing.Point(20, 317)
        Me.Exit_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(493, 59)
        Me.Exit_Button.TabIndex = 47
        Me.Exit_Button.Text = "Back"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'Register_Button
        '
        Me.Register_Button.BackColor = System.Drawing.Color.SeaGreen
        Me.Register_Button.FlatAppearance.BorderSize = 0
        Me.Register_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Register_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Register_Button.ForeColor = System.Drawing.Color.White
        Me.Register_Button.Location = New System.Drawing.Point(20, 224)
        Me.Register_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Register_Button.Name = "Register_Button"
        Me.Register_Button.Size = New System.Drawing.Size(493, 59)
        Me.Register_Button.TabIndex = 46
        Me.Register_Button.Text = "Register"
        Me.Register_Button.UseVisualStyleBackColor = False
        '
        'Parking_fee
        '
        Me.Parking_fee.BackColor = System.Drawing.Color.Transparent
        Me.Parking_fee.BorderRadius = 3
        Me.Parking_fee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Parking_fee.ForeColor = System.Drawing.Color.White
        Me.Parking_fee.Items = New String(-1) {}
        Me.Parking_fee.Location = New System.Drawing.Point(20, 147)
        Me.Parking_fee.Margin = New System.Windows.Forms.Padding(5)
        Me.Parking_fee.Name = "Parking_fee"
        Me.Parking_fee.NomalColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Parking_fee.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Parking_fee.selectedIndex = -1
        Me.Parking_fee.Size = New System.Drawing.Size(493, 43)
        Me.Parking_fee.TabIndex = 45
        '
        'Parking_Level
        '
        Me.Parking_Level.BackColor = System.Drawing.Color.Transparent
        Me.Parking_Level.BorderRadius = 3
        Me.Parking_Level.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Parking_Level.ForeColor = System.Drawing.Color.White
        Me.Parking_Level.Items = New String(-1) {}
        Me.Parking_Level.Location = New System.Drawing.Point(20, 85)
        Me.Parking_Level.Margin = New System.Windows.Forms.Padding(5)
        Me.Parking_Level.Name = "Parking_Level"
        Me.Parking_Level.NomalColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Parking_Level.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Parking_Level.selectedIndex = -1
        Me.Parking_Level.Size = New System.Drawing.Size(493, 43)
        Me.Parking_Level.TabIndex = 44
        '
        'Parking_name
        '
        Me.Parking_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Parking_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Parking_name.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parking_name.ForeColor = System.Drawing.Color.White
        Me.Parking_name.HintForeColor = System.Drawing.Color.White
        Me.Parking_name.HintText = "Parking Name"
        Me.Parking_name.isPassword = False
        Me.Parking_name.LineFocusedColor = System.Drawing.Color.Blue
        Me.Parking_name.LineIdleColor = System.Drawing.Color.Gray
        Me.Parking_name.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Parking_name.LineThickness = 3
        Me.Parking_name.Location = New System.Drawing.Point(20, 23)
        Me.Parking_name.Margin = New System.Windows.Forms.Padding(5)
        Me.Parking_name.Name = "Parking_name"
        Me.Parking_name.Size = New System.Drawing.Size(493, 42)
        Me.Parking_name.TabIndex = 0
        Me.Parking_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Parking_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(593, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Parking_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Parking_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Register_Button As Button
    Friend WithEvents Parking_fee As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Parking_Level As Bunifu.Framework.UI.BunifuDropdown
End Class
