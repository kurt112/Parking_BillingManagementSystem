<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaction_Input
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction_Input))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Promo_List = New Bunifu.Framework.UI.BunifuDropdown()
        Me.register_promo_button = New System.Windows.Forms.Button()
        Me.Park = New System.Windows.Forms.Button()
        Me.Register_Promo = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.parking_location = New System.Windows.Forms.TextBox()
        Me.Telephone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cellphone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.last_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.member_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.x_button = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.promo_value = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.date_registered_value = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.total_spend = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cashier_value = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.points_value = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.membership_level_value = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.last_parking = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.login_times_value = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Top_Up = New System.Windows.Forms.Button()
        Me.initial_amount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.RegisterPromo_Document = New System.Drawing.Printing.PrintDocument()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.x_button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Promo_List)
        Me.Panel2.Controls.Add(Me.register_promo_button)
        Me.Panel2.Controls.Add(Me.Park)
        Me.Panel2.Controls.Add(Me.Register_Promo)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(833, 665)
        Me.Panel2.TabIndex = 13
        '
        'Promo_List
        '
        Me.Promo_List.BackColor = System.Drawing.Color.Transparent
        Me.Promo_List.BorderRadius = 3
        Me.Promo_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Promo_List.ForeColor = System.Drawing.Color.White
        Me.Promo_List.Items = New String(-1) {}
        Me.Promo_List.Location = New System.Drawing.Point(33, 144)
        Me.Promo_List.Margin = New System.Windows.Forms.Padding(5)
        Me.Promo_List.Name = "Promo_List"
        Me.Promo_List.NomalColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Promo_List.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Promo_List.selectedIndex = -1
        Me.Promo_List.Size = New System.Drawing.Size(355, 43)
        Me.Promo_List.TabIndex = 43
        '
        'register_promo_button
        '
        Me.register_promo_button.BackColor = System.Drawing.SystemColors.HotTrack
        Me.register_promo_button.FlatAppearance.BorderSize = 0
        Me.register_promo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.register_promo_button.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.register_promo_button.ForeColor = System.Drawing.Color.White
        Me.register_promo_button.Location = New System.Drawing.Point(648, 151)
        Me.register_promo_button.Margin = New System.Windows.Forms.Padding(4)
        Me.register_promo_button.Name = "register_promo_button"
        Me.register_promo_button.Size = New System.Drawing.Size(164, 38)
        Me.register_promo_button.TabIndex = 42
        Me.register_promo_button.Text = "Register Promo"
        Me.register_promo_button.UseVisualStyleBackColor = False
        '
        'Park
        '
        Me.Park.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Park.FlatAppearance.BorderSize = 0
        Me.Park.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Park.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Park.ForeColor = System.Drawing.Color.White
        Me.Park.Location = New System.Drawing.Point(692, 614)
        Me.Park.Margin = New System.Windows.Forms.Padding(4)
        Me.Park.Name = "Park"
        Me.Park.Size = New System.Drawing.Size(120, 38)
        Me.Park.TabIndex = 41
        Me.Park.Text = "Park"
        Me.Park.UseVisualStyleBackColor = False
        '
        'Register_Promo
        '
        Me.Register_Promo.AutoSize = True
        Me.Register_Promo.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Promo.ForeColor = System.Drawing.Color.Yellow
        Me.Register_Promo.Location = New System.Drawing.Point(20, 118)
        Me.Register_Promo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Register_Promo.Name = "Register_Promo"
        Me.Register_Promo.Size = New System.Drawing.Size(105, 19)
        Me.Register_Promo.TabIndex = 39
        Me.Register_Promo.Text = "Register Promo"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.parking_location)
        Me.Panel5.Controls.Add(Me.Telephone)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.cellphone)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.email)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.last_name)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.firstname)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(13, 202)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(826, 384)
        Me.Panel5.TabIndex = 37
        '
        'parking_location
        '
        Me.parking_location.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.parking_location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.parking_location.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parking_location.ForeColor = System.Drawing.Color.White
        Me.parking_location.Location = New System.Drawing.Point(491, 306)
        Me.parking_location.Margin = New System.Windows.Forms.Padding(4)
        Me.parking_location.Multiline = True
        Me.parking_location.Name = "parking_location"
        Me.parking_location.ReadOnly = True
        Me.parking_location.Size = New System.Drawing.Size(281, 36)
        Me.parking_location.TabIndex = 36
        '
        'Telephone
        '
        Me.Telephone.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Telephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Telephone.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telephone.ForeColor = System.Drawing.Color.White
        Me.Telephone.Location = New System.Drawing.Point(19, 306)
        Me.Telephone.Margin = New System.Windows.Forms.Padding(4)
        Me.Telephone.Multiline = True
        Me.Telephone.Name = "Telephone"
        Me.Telephone.ReadOnly = True
        Me.Telephone.Size = New System.Drawing.Size(281, 36)
        Me.Telephone.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(15, 252)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Birth date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(487, 252)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 19)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Parking location"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cellphone
        '
        Me.cellphone.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.cellphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cellphone.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cellphone.ForeColor = System.Drawing.Color.White
        Me.cellphone.Location = New System.Drawing.Point(491, 169)
        Me.cellphone.Margin = New System.Windows.Forms.Padding(4)
        Me.cellphone.Multiline = True
        Me.cellphone.Name = "cellphone"
        Me.cellphone.ReadOnly = True
        Me.cellphone.Size = New System.Drawing.Size(281, 36)
        Me.cellphone.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(487, 126)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 19)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Cellphone Number"
        '
        'email
        '
        Me.email.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.email.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.White
        Me.email.Location = New System.Drawing.Point(19, 169)
        Me.email.Margin = New System.Windows.Forms.Padding(4)
        Me.email.Multiline = True
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Size = New System.Drawing.Size(281, 36)
        Me.email.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(15, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Email"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'last_name
        '
        Me.last_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.last_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.last_name.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_name.ForeColor = System.Drawing.Color.White
        Me.last_name.Location = New System.Drawing.Point(491, 48)
        Me.last_name.Margin = New System.Windows.Forms.Padding(4)
        Me.last_name.Multiline = True
        Me.last_name.Name = "last_name"
        Me.last_name.ReadOnly = True
        Me.last_name.Size = New System.Drawing.Size(281, 36)
        Me.last_name.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(487, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Last Name"
        '
        'firstname
        '
        Me.firstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.White
        Me.firstname.Location = New System.Drawing.Point(19, 48)
        Me.firstname.Margin = New System.Windows.Forms.Padding(4)
        Me.firstname.Multiline = True
        Me.firstname.Name = "firstname"
        Me.firstname.ReadOnly = True
        Me.firstname.Size = New System.Drawing.Size(281, 36)
        Me.firstname.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(15, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "First Name"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.member_id)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(13, 15)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(798, 96)
        Me.Panel4.TabIndex = 36
        '
        'member_id
        '
        Me.member_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.member_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.member_id.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.member_id.ForeColor = System.Drawing.Color.White
        Me.member_id.Location = New System.Drawing.Point(19, 43)
        Me.member_id.Margin = New System.Windows.Forms.Padding(4)
        Me.member_id.Name = "member_id"
        Me.member_id.Size = New System.Drawing.Size(355, 32)
        Me.member_id.TabIndex = 23
        Me.member_id.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Member Id"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.x_button)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Top_Up)
        Me.Panel1.Controls.Add(Me.initial_amount)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(831, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 665)
        Me.Panel1.TabIndex = 43
        '
        'x_button
        '
        Me.x_button.Image = CType(resources.GetObject("x_button.Image"), System.Drawing.Image)
        Me.x_button.Location = New System.Drawing.Point(479, 7)
        Me.x_button.Margin = New System.Windows.Forms.Padding(4)
        Me.x_button.Name = "x_button"
        Me.x_button.Size = New System.Drawing.Size(41, 34)
        Me.x_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.x_button.TabIndex = 33
        Me.x_button.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.promo_value)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.date_registered_value)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.total_spend)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.cashier_value)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.points_value)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.membership_level_value)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.last_parking)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.login_times_value)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(11, 212)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(507, 440)
        Me.Panel3.TabIndex = 32
        '
        'promo_value
        '
        Me.promo_value.AutoSize = True
        Me.promo_value.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.promo_value.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.promo_value.ForeColor = System.Drawing.Color.Yellow
        Me.promo_value.Location = New System.Drawing.Point(249, 350)
        Me.promo_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.promo_value.Name = "promo_value"
        Me.promo_value.Size = New System.Drawing.Size(121, 28)
        Me.promo_value.TabIndex = 50
        Me.promo_value.Text = "Not activate"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(5, 350)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 28)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Promo:"
        '
        'date_registered_value
        '
        Me.date_registered_value.AutoSize = True
        Me.date_registered_value.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.date_registered_value.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.date_registered_value.ForeColor = System.Drawing.Color.Yellow
        Me.date_registered_value.Location = New System.Drawing.Point(249, 293)
        Me.date_registered_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.date_registered_value.Name = "date_registered_value"
        Me.date_registered_value.Size = New System.Drawing.Size(212, 28)
        Me.date_registered_value.TabIndex = 48
        Me.date_registered_value.Text = "Date Registered Value"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.Yellow
        Me.Label23.Location = New System.Drawing.Point(5, 293)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(161, 28)
        Me.Label23.TabIndex = 47
        Me.Label23.Text = "Date Registered:"
        '
        'total_spend
        '
        Me.total_spend.AutoSize = True
        Me.total_spend.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.total_spend.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.total_spend.ForeColor = System.Drawing.Color.Yellow
        Me.total_spend.Location = New System.Drawing.Point(248, 399)
        Me.total_spend.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.total_spend.Name = "total_spend"
        Me.total_spend.Size = New System.Drawing.Size(119, 28)
        Me.total_spend.TabIndex = 46
        Me.total_spend.Text = "Total Spend"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(4, 399)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 28)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Total Spend:"
        '
        'cashier_value
        '
        Me.cashier_value.AutoSize = True
        Me.cashier_value.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cashier_value.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cashier_value.ForeColor = System.Drawing.Color.Yellow
        Me.cashier_value.Location = New System.Drawing.Point(249, 236)
        Me.cashier_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.cashier_value.Name = "cashier_value"
        Me.cashier_value.Size = New System.Drawing.Size(136, 28)
        Me.cashier_value.TabIndex = 44
        Me.cashier_value.Text = "Cashier_Value"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Yellow
        Me.Label21.Location = New System.Drawing.Point(4, 236)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(233, 28)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Cashier Registered User:"
        '
        'points_value
        '
        Me.points_value.AutoSize = True
        Me.points_value.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.points_value.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.points_value.ForeColor = System.Drawing.Color.Yellow
        Me.points_value.Location = New System.Drawing.Point(245, 68)
        Me.points_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.points_value.Name = "points_value"
        Me.points_value.Size = New System.Drawing.Size(124, 28)
        Me.points_value.TabIndex = 42
        Me.points_value.Text = "Points Value"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Yellow
        Me.Label19.Location = New System.Drawing.Point(4, 66)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 28)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Points:"
        '
        'membership_level_value
        '
        Me.membership_level_value.AutoSize = True
        Me.membership_level_value.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.membership_level_value.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.membership_level_value.ForeColor = System.Drawing.Color.Yellow
        Me.membership_level_value.Location = New System.Drawing.Point(245, 178)
        Me.membership_level_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.membership_level_value.Name = "membership_level_value"
        Me.membership_level_value.Size = New System.Drawing.Size(238, 28)
        Me.membership_level_value.TabIndex = 40
        Me.membership_level_value.Text = "Membership_Level_value"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(4, 177)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(185, 28)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Membership Level:"
        '
        'last_parking
        '
        Me.last_parking.AutoSize = True
        Me.last_parking.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.last_parking.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.last_parking.ForeColor = System.Drawing.Color.Yellow
        Me.last_parking.Location = New System.Drawing.Point(245, 117)
        Me.last_parking.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.last_parking.Name = "last_parking"
        Me.last_parking.Size = New System.Drawing.Size(128, 28)
        Me.last_parking.TabIndex = 38
        Me.last_parking.Text = "Last Parking "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(4, 116)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(127, 28)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Last Parking:"
        '
        'login_times_value
        '
        Me.login_times_value.AutoSize = True
        Me.login_times_value.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.login_times_value.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.login_times_value.ForeColor = System.Drawing.Color.Yellow
        Me.login_times_value.Location = New System.Drawing.Point(245, 16)
        Me.login_times_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.login_times_value.Name = "login_times_value"
        Me.login_times_value.Size = New System.Drawing.Size(173, 28)
        Me.login_times_value.TabIndex = 34
        Me.login_times_value.Text = "Login times value"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(4, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 28)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Login times:"
        '
        'Top_Up
        '
        Me.Top_Up.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Top_Up.FlatAppearance.BorderSize = 0
        Me.Top_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Top_Up.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Top_Up.ForeColor = System.Drawing.Color.White
        Me.Top_Up.Location = New System.Drawing.Point(392, 149)
        Me.Top_Up.Margin = New System.Windows.Forms.Padding(4)
        Me.Top_Up.Name = "Top_Up"
        Me.Top_Up.Size = New System.Drawing.Size(120, 38)
        Me.Top_Up.TabIndex = 31
        Me.Top_Up.Text = "Top up"
        Me.Top_Up.UseVisualStyleBackColor = False
        '
        'initial_amount
        '
        Me.initial_amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.initial_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.initial_amount.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.initial_amount.ForeColor = System.Drawing.Color.White
        Me.initial_amount.Location = New System.Drawing.Point(19, 63)
        Me.initial_amount.Margin = New System.Windows.Forms.Padding(4)
        Me.initial_amount.Multiline = True
        Me.initial_amount.Name = "initial_amount"
        Me.initial_amount.ReadOnly = True
        Me.initial_amount.Size = New System.Drawing.Size(493, 36)
        Me.initial_amount.TabIndex = 30
        Me.initial_amount.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(15, 43)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 19)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Initial Amount"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'RegisterPromo_Document
        '
        '
        'Transaction_Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 665)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Transaction_Input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction_Input"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.x_button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents register_promo_button As Button
    Friend WithEvents Park As Button
    Friend WithEvents Register_Promo As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents parking_location As TextBox
    Friend WithEvents Telephone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cellphone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents last_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents firstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents x_button As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents promo_value As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents date_registered_value As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents total_spend As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cashier_value As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents points_value As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents membership_level_value As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents last_parking As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents login_times_value As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Top_Up As Button
    Friend WithEvents initial_amount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Promo_List As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents member_id As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents RegisterPromo_Document As Printing.PrintDocument
End Class
