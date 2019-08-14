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
        Me.first_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.username__ = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.password_error = New System.Windows.Forms.Label()
        Me.lastname_error = New System.Windows.Forms.Label()
        Me.firstname_error = New System.Windows.Forms.Label()
        Me.email_error = New System.Windows.Forms.Label()
        Me.userfield_error = New System.Windows.Forms.Label()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.Register_Button = New System.Windows.Forms.Button()
        Me.password_repeat = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.email_address = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.last_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.password_mismatch = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'User_id
        '
        Me.User_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.User_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.User_id.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_id.ForeColor = System.Drawing.Color.White
        Me.User_id.HintForeColor = System.Drawing.Color.White
        Me.User_id.HintText = ""
        Me.User_id.isPassword = False
        Me.User_id.LineFocusedColor = System.Drawing.Color.White
        Me.User_id.LineIdleColor = System.Drawing.Color.White
        Me.User_id.LineMouseHoverColor = System.Drawing.Color.White
        Me.User_id.LineThickness = 1
        Me.User_id.Location = New System.Drawing.Point(20, 16)
        Me.User_id.Margin = New System.Windows.Forms.Padding(5)
        Me.User_id.Name = "User_id"
        Me.User_id.Size = New System.Drawing.Size(493, 37)
        Me.User_id.TabIndex = 0
        Me.User_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'first_name
        '
        Me.first_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.first_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.first_name.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_name.ForeColor = System.Drawing.Color.White
        Me.first_name.HintForeColor = System.Drawing.Color.White
        Me.first_name.HintText = ""
        Me.first_name.isPassword = False
        Me.first_name.LineFocusedColor = System.Drawing.Color.White
        Me.first_name.LineIdleColor = System.Drawing.Color.White
        Me.first_name.LineMouseHoverColor = System.Drawing.Color.White
        Me.first_name.LineThickness = 1
        Me.first_name.Location = New System.Drawing.Point(19, 69)
        Me.first_name.Margin = New System.Windows.Forms.Padding(5)
        Me.first_name.Name = "first_name"
        Me.first_name.Size = New System.Drawing.Size(493, 42)
        Me.first_name.TabIndex = 4
        Me.first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel1.Controls.Add(Me.username__)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.password_error)
        Me.Panel1.Controls.Add(Me.lastname_error)
        Me.Panel1.Controls.Add(Me.firstname_error)
        Me.Panel1.Controls.Add(Me.email_error)
        Me.Panel1.Controls.Add(Me.userfield_error)
        Me.Panel1.Controls.Add(Me.Exit_Button)
        Me.Panel1.Controls.Add(Me.Register_Button)
        Me.Panel1.Controls.Add(Me.password_repeat)
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.username)
        Me.Panel1.Controls.Add(Me.email_address)
        Me.Panel1.Controls.Add(Me.last_name)
        Me.Panel1.Controls.Add(Me.password_mismatch)
        Me.Panel1.Controls.Add(Me.User_id)
        Me.Panel1.Controls.Add(Me.first_name)
        Me.Panel1.Location = New System.Drawing.Point(63, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 607)
        Me.Panel1.TabIndex = 6
        '
        'username__
        '
        Me.username__.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username__.ForeColor = System.Drawing.Color.Red
        Me.username__.Location = New System.Drawing.Point(132, 290)
        Me.username__.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.username__.Name = "username__"
        Me.username__.Size = New System.Drawing.Size(380, 23)
        Me.username__.TabIndex = 66
        Me.username__.Text = "Password does not match"
        Me.username__.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.username__.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(15, 347)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 23)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Re - type Password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(15, 288)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 23)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(15, 230)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 23)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Username"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(15, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 23)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Email Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(15, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(15, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 23)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "First Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(15, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "User Id"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'password_error
        '
        Me.password_error.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_error.ForeColor = System.Drawing.Color.Red
        Me.password_error.Location = New System.Drawing.Point(299, 347)
        Me.password_error.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.password_error.Name = "password_error"
        Me.password_error.Size = New System.Drawing.Size(214, 23)
        Me.password_error.TabIndex = 58
        Me.password_error.Text = "Password does not match"
        Me.password_error.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.password_error.Visible = False
        '
        'lastname_error
        '
        Me.lastname_error.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname_error.ForeColor = System.Drawing.Color.Red
        Me.lastname_error.Location = New System.Drawing.Point(133, 174)
        Me.lastname_error.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lastname_error.Name = "lastname_error"
        Me.lastname_error.Size = New System.Drawing.Size(380, 23)
        Me.lastname_error.TabIndex = 16
        Me.lastname_error.Text = "Password does not match"
        Me.lastname_error.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lastname_error.Visible = False
        '
        'firstname_error
        '
        Me.firstname_error.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname_error.ForeColor = System.Drawing.Color.Red
        Me.firstname_error.Location = New System.Drawing.Point(133, 114)
        Me.firstname_error.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.firstname_error.Name = "firstname_error"
        Me.firstname_error.Size = New System.Drawing.Size(380, 23)
        Me.firstname_error.TabIndex = 16
        Me.firstname_error.Text = "Password does not match"
        Me.firstname_error.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.firstname_error.Visible = False
        '
        'email_error
        '
        Me.email_error.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_error.ForeColor = System.Drawing.Color.Red
        Me.email_error.Location = New System.Drawing.Point(133, 229)
        Me.email_error.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.email_error.Name = "email_error"
        Me.email_error.Size = New System.Drawing.Size(380, 23)
        Me.email_error.TabIndex = 16
        Me.email_error.Text = "Password does not match"
        Me.email_error.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.email_error.Visible = False
        '
        'userfield_error
        '
        Me.userfield_error.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userfield_error.ForeColor = System.Drawing.Color.Red
        Me.userfield_error.Location = New System.Drawing.Point(133, 60)
        Me.userfield_error.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.userfield_error.Name = "userfield_error"
        Me.userfield_error.Size = New System.Drawing.Size(380, 23)
        Me.userfield_error.TabIndex = 57
        Me.userfield_error.Text = "Password does not match"
        Me.userfield_error.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.userfield_error.Visible = False
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.Red
        Me.Exit_Button.FlatAppearance.BorderSize = 0
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_Button.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Exit_Button.ForeColor = System.Drawing.Color.White
        Me.Exit_Button.Location = New System.Drawing.Point(20, 518)
        Me.Exit_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(493, 59)
        Me.Exit_Button.TabIndex = 56
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
        Me.Register_Button.Location = New System.Drawing.Point(20, 442)
        Me.Register_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Register_Button.Name = "Register_Button"
        Me.Register_Button.Size = New System.Drawing.Size(493, 59)
        Me.Register_Button.TabIndex = 54
        Me.Register_Button.Text = "Register"
        Me.Register_Button.UseVisualStyleBackColor = False
        '
        'password_repeat
        '
        Me.password_repeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.password_repeat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password_repeat.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_repeat.ForeColor = System.Drawing.Color.White
        Me.password_repeat.HintForeColor = System.Drawing.Color.White
        Me.password_repeat.HintText = ""
        Me.password_repeat.isPassword = True
        Me.password_repeat.LineFocusedColor = System.Drawing.Color.White
        Me.password_repeat.LineIdleColor = System.Drawing.Color.White
        Me.password_repeat.LineMouseHoverColor = System.Drawing.Color.White
        Me.password_repeat.LineThickness = 1
        Me.password_repeat.Location = New System.Drawing.Point(20, 360)
        Me.password_repeat.Margin = New System.Windows.Forms.Padding(5)
        Me.password_repeat.Name = "password_repeat"
        Me.password_repeat.Size = New System.Drawing.Size(493, 42)
        Me.password_repeat.TabIndex = 53
        Me.password_repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.White
        Me.password.HintForeColor = System.Drawing.Color.White
        Me.password.HintText = ""
        Me.password.isPassword = True
        Me.password.LineFocusedColor = System.Drawing.Color.White
        Me.password.LineIdleColor = System.Drawing.Color.White
        Me.password.LineMouseHoverColor = System.Drawing.Color.White
        Me.password.LineThickness = 1
        Me.password.Location = New System.Drawing.Point(19, 302)
        Me.password.Margin = New System.Windows.Forms.Padding(5)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(493, 42)
        Me.password.TabIndex = 49
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'username
        '
        Me.username.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.White
        Me.username.HintForeColor = System.Drawing.Color.White
        Me.username.HintText = ""
        Me.username.isPassword = False
        Me.username.LineFocusedColor = System.Drawing.Color.White
        Me.username.LineIdleColor = System.Drawing.Color.White
        Me.username.LineMouseHoverColor = System.Drawing.Color.White
        Me.username.LineThickness = 1
        Me.username.Location = New System.Drawing.Point(19, 243)
        Me.username.Margin = New System.Windows.Forms.Padding(5)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(493, 42)
        Me.username.TabIndex = 45
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'email_address
        '
        Me.email_address.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.email_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email_address.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_address.ForeColor = System.Drawing.Color.White
        Me.email_address.HintForeColor = System.Drawing.Color.White
        Me.email_address.HintText = ""
        Me.email_address.isPassword = False
        Me.email_address.LineFocusedColor = System.Drawing.Color.White
        Me.email_address.LineIdleColor = System.Drawing.Color.White
        Me.email_address.LineMouseHoverColor = System.Drawing.Color.White
        Me.email_address.LineThickness = 1
        Me.email_address.Location = New System.Drawing.Point(20, 185)
        Me.email_address.Margin = New System.Windows.Forms.Padding(5)
        Me.email_address.Name = "email_address"
        Me.email_address.Size = New System.Drawing.Size(493, 42)
        Me.email_address.TabIndex = 38
        Me.email_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'last_name
        '
        Me.last_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.last_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.last_name.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_name.ForeColor = System.Drawing.Color.White
        Me.last_name.HintForeColor = System.Drawing.Color.White
        Me.last_name.HintText = ""
        Me.last_name.isPassword = False
        Me.last_name.LineFocusedColor = System.Drawing.Color.White
        Me.last_name.LineIdleColor = System.Drawing.Color.White
        Me.last_name.LineMouseHoverColor = System.Drawing.Color.White
        Me.last_name.LineThickness = 1
        Me.last_name.Location = New System.Drawing.Point(20, 127)
        Me.last_name.Margin = New System.Windows.Forms.Padding(5)
        Me.last_name.Name = "last_name"
        Me.last_name.Size = New System.Drawing.Size(493, 42)
        Me.last_name.TabIndex = 31
        Me.last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'password_mismatch
        '
        Me.password_mismatch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_mismatch.ForeColor = System.Drawing.Color.Red
        Me.password_mismatch.Location = New System.Drawing.Point(132, 407)
        Me.password_mismatch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.password_mismatch.Name = "password_mismatch"
        Me.password_mismatch.Size = New System.Drawing.Size(380, 23)
        Me.password_mismatch.TabIndex = 15
        Me.password_mismatch.Text = "Password does not match"
        Me.password_mismatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.password_mismatch.Visible = False
        '
        'User_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 667)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "User_Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents User_id As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents first_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents password_mismatch As Label
    Friend WithEvents Exit_Button As Button
    Friend WithEvents Register_Button As Button
    Friend WithEvents password_repeat As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents email_address As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents last_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents password_error As Label
    Friend WithEvents lastname_error As Label
    Friend WithEvents firstname_error As Label
    Friend WithEvents email_error As Label
    Friend WithEvents userfield_error As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents username__ As Label
End Class
