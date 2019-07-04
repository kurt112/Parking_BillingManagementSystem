<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Register
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
        Me.User_id = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.email_address = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.last_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.first_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.password_repeat = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.password_mismatch = New System.Windows.Forms.Label()
        Me.username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Register_Button = New System.Windows.Forms.Button()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'User_id
        '
        Me.User_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.User_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.User_id.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_id.ForeColor = System.Drawing.Color.White
        Me.User_id.HintForeColor = System.Drawing.Color.Empty
        Me.User_id.HintText = ""
        Me.User_id.isPassword = False
        Me.User_id.LineFocusedColor = System.Drawing.Color.Gray
        Me.User_id.LineIdleColor = System.Drawing.Color.White
        Me.User_id.LineMouseHoverColor = System.Drawing.Color.White
        Me.User_id.LineThickness = 3
        Me.User_id.Location = New System.Drawing.Point(15, 14)
        Me.User_id.Margin = New System.Windows.Forms.Padding(4)
        Me.User_id.Name = "User_id"
        Me.User_id.Size = New System.Drawing.Size(370, 34)
        Me.User_id.TabIndex = 0
        Me.User_id.Text = "User Id"
        Me.User_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.White
        Me.password.HintForeColor = System.Drawing.Color.Empty
        Me.password.HintText = ""
        Me.password.isPassword = False
        Me.password.LineFocusedColor = System.Drawing.Color.Gray
        Me.password.LineIdleColor = System.Drawing.Color.White
        Me.password.LineMouseHoverColor = System.Drawing.Color.White
        Me.password.LineThickness = 3
        Me.password.Location = New System.Drawing.Point(15, 257)
        Me.password.Margin = New System.Windows.Forms.Padding(4)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(370, 34)
        Me.password.TabIndex = 1
        Me.password.Text = "Password"
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'email_address
        '
        Me.email_address.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.email_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_address.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_address.ForeColor = System.Drawing.Color.White
        Me.email_address.HintForeColor = System.Drawing.Color.Empty
        Me.email_address.HintText = ""
        Me.email_address.isPassword = False
        Me.email_address.LineFocusedColor = System.Drawing.Color.Gray
        Me.email_address.LineIdleColor = System.Drawing.Color.White
        Me.email_address.LineMouseHoverColor = System.Drawing.Color.White
        Me.email_address.LineThickness = 3
        Me.email_address.Location = New System.Drawing.Point(15, 159)
        Me.email_address.Margin = New System.Windows.Forms.Padding(4)
        Me.email_address.Name = "email_address"
        Me.email_address.Size = New System.Drawing.Size(370, 34)
        Me.email_address.TabIndex = 2
        Me.email_address.Text = "Email Address"
        Me.email_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'last_name
        '
        Me.last_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.last_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.last_name.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_name.ForeColor = System.Drawing.Color.White
        Me.last_name.HintForeColor = System.Drawing.Color.Empty
        Me.last_name.HintText = ""
        Me.last_name.isPassword = False
        Me.last_name.LineFocusedColor = System.Drawing.Color.Gray
        Me.last_name.LineIdleColor = System.Drawing.Color.White
        Me.last_name.LineMouseHoverColor = System.Drawing.Color.White
        Me.last_name.LineThickness = 3
        Me.last_name.Location = New System.Drawing.Point(15, 112)
        Me.last_name.Margin = New System.Windows.Forms.Padding(4)
        Me.last_name.Name = "last_name"
        Me.last_name.Size = New System.Drawing.Size(370, 34)
        Me.last_name.TabIndex = 3
        Me.last_name.Text = "Last Name"
        Me.last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'first_name
        '
        Me.first_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.first_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.first_name.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_name.ForeColor = System.Drawing.Color.White
        Me.first_name.HintForeColor = System.Drawing.Color.Empty
        Me.first_name.HintText = ""
        Me.first_name.isPassword = False
        Me.first_name.LineFocusedColor = System.Drawing.Color.Gray
        Me.first_name.LineIdleColor = System.Drawing.Color.White
        Me.first_name.LineMouseHoverColor = System.Drawing.Color.White
        Me.first_name.LineThickness = 3
        Me.first_name.Location = New System.Drawing.Point(15, 62)
        Me.first_name.Margin = New System.Windows.Forms.Padding(4)
        Me.first_name.Name = "first_name"
        Me.first_name.Size = New System.Drawing.Size(370, 34)
        Me.first_name.TabIndex = 4
        Me.first_name.Text = "First Name"
        Me.first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'password_repeat
        '
        Me.password_repeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.password_repeat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_repeat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_repeat.ForeColor = System.Drawing.Color.White
        Me.password_repeat.HintForeColor = System.Drawing.Color.Empty
        Me.password_repeat.HintText = ""
        Me.password_repeat.isPassword = False
        Me.password_repeat.LineFocusedColor = System.Drawing.Color.Gray
        Me.password_repeat.LineIdleColor = System.Drawing.Color.White
        Me.password_repeat.LineMouseHoverColor = System.Drawing.Color.White
        Me.password_repeat.LineThickness = 3
        Me.password_repeat.Location = New System.Drawing.Point(15, 303)
        Me.password_repeat.Margin = New System.Windows.Forms.Padding(4)
        Me.password_repeat.Name = "password_repeat"
        Me.password_repeat.Size = New System.Drawing.Size(370, 34)
        Me.password_repeat.TabIndex = 5
        Me.password_repeat.Text = "Re - type Password"
        Me.password_repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.password_mismatch)
        Me.Panel1.Controls.Add(Me.username)
        Me.Panel1.Controls.Add(Me.Register_Button)
        Me.Panel1.Controls.Add(Me.Exit_Button)
        Me.Panel1.Controls.Add(Me.password_repeat)
        Me.Panel1.Controls.Add(Me.User_id)
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.email_address)
        Me.Panel1.Controls.Add(Me.last_name)
        Me.Panel1.Controls.Add(Me.first_name)
        Me.Panel1.Location = New System.Drawing.Point(47, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 493)
        Me.Panel1.TabIndex = 6
        '
        'password_mismatch
        '
        Me.password_mismatch.AutoSize = True
        Me.password_mismatch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_mismatch.ForeColor = System.Drawing.Color.Red
        Me.password_mismatch.Location = New System.Drawing.Point(25, 344)
        Me.password_mismatch.Name = "password_mismatch"
        Me.password_mismatch.Size = New System.Drawing.Size(166, 17)
        Me.password_mismatch.TabIndex = 15
        Me.password_mismatch.Text = "Password does not match"
        Me.password_mismatch.Visible = False
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.White
        Me.username.HintForeColor = System.Drawing.Color.Empty
        Me.username.HintText = ""
        Me.username.isPassword = False
        Me.username.LineFocusedColor = System.Drawing.Color.Gray
        Me.username.LineIdleColor = System.Drawing.Color.White
        Me.username.LineMouseHoverColor = System.Drawing.Color.White
        Me.username.LineThickness = 3
        Me.username.Location = New System.Drawing.Point(15, 208)
        Me.username.Margin = New System.Windows.Forms.Padding(4)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(370, 34)
        Me.username.TabIndex = 7
        Me.username.Text = "Useraname"
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Register_Button
        '
        Me.Register_Button.BackColor = System.Drawing.Color.SeaGreen
        Me.Register_Button.FlatAppearance.BorderSize = 0
        Me.Register_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Register_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Register_Button.ForeColor = System.Drawing.Color.White
        Me.Register_Button.Location = New System.Drawing.Point(15, 373)
        Me.Register_Button.Name = "Register_Button"
        Me.Register_Button.Size = New System.Drawing.Size(370, 48)
        Me.Register_Button.TabIndex = 13
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
        Me.Exit_Button.Location = New System.Drawing.Point(15, 435)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(370, 48)
        Me.Exit_Button.TabIndex = 14
        Me.Exit_Button.Text = "Back"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'User_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(496, 542)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User_Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User_Register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User_id As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents email_address As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents last_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents first_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents password_repeat As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Register_Button As Button
    Friend WithEvents Exit_Button As Button
    Friend WithEvents username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents password_mismatch As Label
End Class
