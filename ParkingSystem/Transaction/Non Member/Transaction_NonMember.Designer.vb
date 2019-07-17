<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaction_NonMember
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.paring_fee = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Register_Button = New System.Windows.Forms.Button()
        Me.parking_location = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Date_Today = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Time_out = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Time_In = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Transaction_id = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.paring_fee)
        Me.Panel1.Controls.Add(Me.Exit_Button)
        Me.Panel1.Controls.Add(Me.Register_Button)
        Me.Panel1.Controls.Add(Me.parking_location)
        Me.Panel1.Controls.Add(Me.Date_Today)
        Me.Panel1.Controls.Add(Me.Time_out)
        Me.Panel1.Controls.Add(Me.Time_In)
        Me.Panel1.Controls.Add(Me.Transaction_id)
        Me.Panel1.Location = New System.Drawing.Point(94, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 439)
        Me.Panel1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(11, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Parking fee"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(12, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Parking location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(11, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Date today"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Time out"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(11, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Time in"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(11, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Transaction id"
        '
        'paring_fee
        '
        Me.paring_fee.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.paring_fee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.paring_fee.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paring_fee.ForeColor = System.Drawing.Color.White
        Me.paring_fee.HintForeColor = System.Drawing.Color.Empty
        Me.paring_fee.HintText = ""
        Me.paring_fee.isPassword = False
        Me.paring_fee.LineFocusedColor = System.Drawing.Color.Blue
        Me.paring_fee.LineIdleColor = System.Drawing.Color.Gray
        Me.paring_fee.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.paring_fee.LineThickness = 3
        Me.paring_fee.Location = New System.Drawing.Point(15, 265)
        Me.paring_fee.Margin = New System.Windows.Forms.Padding(4)
        Me.paring_fee.Name = "paring_fee"
        Me.paring_fee.Size = New System.Drawing.Size(370, 25)
        Me.paring_fee.TabIndex = 21
        Me.paring_fee.Text = " "
        Me.paring_fee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.Red
        Me.Exit_Button.FlatAppearance.BorderSize = 0
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Exit_Button.ForeColor = System.Drawing.Color.White
        Me.Exit_Button.Location = New System.Drawing.Point(15, 380)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(370, 48)
        Me.Exit_Button.TabIndex = 20
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
        Me.Register_Button.Location = New System.Drawing.Point(15, 316)
        Me.Register_Button.Name = "Register_Button"
        Me.Register_Button.Size = New System.Drawing.Size(370, 48)
        Me.Register_Button.TabIndex = 19
        Me.Register_Button.Text = "Print"
        Me.Register_Button.UseVisualStyleBackColor = False
        '
        'parking_location
        '
        Me.parking_location.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.parking_location.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.parking_location.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parking_location.ForeColor = System.Drawing.Color.White
        Me.parking_location.HintForeColor = System.Drawing.Color.Empty
        Me.parking_location.HintText = "asdfas"
        Me.parking_location.isPassword = False
        Me.parking_location.LineFocusedColor = System.Drawing.Color.Blue
        Me.parking_location.LineIdleColor = System.Drawing.Color.Gray
        Me.parking_location.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.parking_location.LineThickness = 3
        Me.parking_location.Location = New System.Drawing.Point(15, 216)
        Me.parking_location.Margin = New System.Windows.Forms.Padding(4)
        Me.parking_location.Name = "parking_location"
        Me.parking_location.Size = New System.Drawing.Size(370, 25)
        Me.parking_location.TabIndex = 18
        Me.parking_location.Tag = ""
        Me.parking_location.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Date_Today
        '
        Me.Date_Today.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Date_Today.BorderRadius = 0
        Me.Date_Today.ForeColor = System.Drawing.Color.White
        Me.Date_Today.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date_Today.FormatCustom = Nothing
        Me.Date_Today.Location = New System.Drawing.Point(15, 168)
        Me.Date_Today.Name = "Date_Today"
        Me.Date_Today.Size = New System.Drawing.Size(370, 25)
        Me.Date_Today.TabIndex = 17
        Me.Date_Today.Value = New Date(2019, 6, 28, 18, 56, 4, 708)
        '
        'Time_out
        '
        Me.Time_out.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Time_out.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Time_out.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_out.ForeColor = System.Drawing.Color.White
        Me.Time_out.HintForeColor = System.Drawing.Color.Empty
        Me.Time_out.HintText = ""
        Me.Time_out.isPassword = False
        Me.Time_out.LineFocusedColor = System.Drawing.Color.Blue
        Me.Time_out.LineIdleColor = System.Drawing.Color.Gray
        Me.Time_out.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Time_out.LineThickness = 3
        Me.Time_out.Location = New System.Drawing.Point(15, 119)
        Me.Time_out.Margin = New System.Windows.Forms.Padding(4)
        Me.Time_out.Name = "Time_out"
        Me.Time_out.Size = New System.Drawing.Size(370, 25)
        Me.Time_out.TabIndex = 16
        Me.Time_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Time_In
        '
        Me.Time_In.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Time_In.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Time_In.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_In.ForeColor = System.Drawing.Color.White
        Me.Time_In.HintForeColor = System.Drawing.Color.Empty
        Me.Time_In.HintText = ""
        Me.Time_In.isPassword = False
        Me.Time_In.LineFocusedColor = System.Drawing.Color.Blue
        Me.Time_In.LineIdleColor = System.Drawing.Color.Gray
        Me.Time_In.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Time_In.LineThickness = 3
        Me.Time_In.Location = New System.Drawing.Point(15, 71)
        Me.Time_In.Margin = New System.Windows.Forms.Padding(4)
        Me.Time_In.Name = "Time_In"
        Me.Time_In.Size = New System.Drawing.Size(370, 25)
        Me.Time_In.TabIndex = 15
        Me.Time_In.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Transaction_id
        '
        Me.Transaction_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Transaction_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Transaction_id.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transaction_id.ForeColor = System.Drawing.Color.White
        Me.Transaction_id.HintForeColor = System.Drawing.Color.Empty
        Me.Transaction_id.HintText = ""
        Me.Transaction_id.isPassword = False
        Me.Transaction_id.LineFocusedColor = System.Drawing.Color.Blue
        Me.Transaction_id.LineIdleColor = System.Drawing.Color.Gray
        Me.Transaction_id.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Transaction_id.LineThickness = 3
        Me.Transaction_id.Location = New System.Drawing.Point(15, 21)
        Me.Transaction_id.Margin = New System.Windows.Forms.Padding(4)
        Me.Transaction_id.Name = "Transaction_id"
        Me.Transaction_id.Size = New System.Drawing.Size(370, 25)
        Me.Transaction_id.TabIndex = 0
        Me.Transaction_id.Text = "z"
        Me.Transaction_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Transaction_NonMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(588, 459)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaction_NonMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction_NonMember"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents paring_fee As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Register_Button As Button
    Friend WithEvents parking_location As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Date_Today As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Time_out As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Time_In As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Transaction_id As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
