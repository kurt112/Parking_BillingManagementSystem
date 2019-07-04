<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputBox))
        Me.value_text = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cancel_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Ok_button = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'value_text
        '
        Me.value_text.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.value_text.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.value_text.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.value_text.ForeColor = System.Drawing.Color.White
        Me.value_text.HintForeColor = System.Drawing.Color.Empty
        Me.value_text.HintText = ""
        Me.value_text.isPassword = False
        Me.value_text.LineFocusedColor = System.Drawing.Color.Blue
        Me.value_text.LineIdleColor = System.Drawing.Color.Gray
        Me.value_text.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.value_text.LineThickness = 3
        Me.value_text.Location = New System.Drawing.Point(7, 44)
        Me.value_text.Margin = New System.Windows.Forms.Padding(4)
        Me.value_text.Name = "value_text"
        Me.value_text.Size = New System.Drawing.Size(372, 38)
        Me.value_text.TabIndex = 5
        Me.value_text.Text = "New Value"
        Me.value_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(2, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(171, 36)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Add New Value"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cancel_button
        '
        Me.Cancel_button.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Cancel_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Cancel_button.BackColor = System.Drawing.Color.Red
        Me.Cancel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancel_button.BorderRadius = 0
        Me.Cancel_button.ButtonText = "Cancel"
        Me.Cancel_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_button.DisabledColor = System.Drawing.SystemColors.GrayText
        Me.Cancel_button.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Cancel_button.ForeColor = System.Drawing.Color.DimGray
        Me.Cancel_button.Iconcolor = System.Drawing.Color.Transparent
        Me.Cancel_button.Iconimage = CType(resources.GetObject("Cancel_button.Iconimage"), System.Drawing.Image)
        Me.Cancel_button.Iconimage_right = Nothing
        Me.Cancel_button.Iconimage_right_Selected = Nothing
        Me.Cancel_button.Iconimage_Selected = Nothing
        Me.Cancel_button.IconMarginLeft = 0
        Me.Cancel_button.IconMarginRight = 0
        Me.Cancel_button.IconRightVisible = False
        Me.Cancel_button.IconRightZoom = 0R
        Me.Cancel_button.IconVisible = False
        Me.Cancel_button.IconZoom = 90.0R
        Me.Cancel_button.IsTab = False
        Me.Cancel_button.Location = New System.Drawing.Point(204, 102)
        Me.Cancel_button.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Cancel_button.Name = "Cancel_button"
        Me.Cancel_button.Normalcolor = System.Drawing.Color.Red
        Me.Cancel_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Cancel_button.OnHoverTextColor = System.Drawing.Color.White
        Me.Cancel_button.selected = False
        Me.Cancel_button.Size = New System.Drawing.Size(181, 41)
        Me.Cancel_button.TabIndex = 10
        Me.Cancel_button.Text = "Cancel"
        Me.Cancel_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Cancel_button.Textcolor = System.Drawing.Color.White
        Me.Cancel_button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Ok_button
        '
        Me.Ok_button.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.Ok_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Ok_button.BackColor = System.Drawing.Color.SeaGreen
        Me.Ok_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ok_button.BorderRadius = 0
        Me.Ok_button.ButtonText = "Ok"
        Me.Ok_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ok_button.DisabledColor = System.Drawing.SystemColors.GrayText
        Me.Ok_button.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Ok_button.ForeColor = System.Drawing.Color.DimGray
        Me.Ok_button.Iconcolor = System.Drawing.Color.Transparent
        Me.Ok_button.Iconimage = CType(resources.GetObject("Ok_button.Iconimage"), System.Drawing.Image)
        Me.Ok_button.Iconimage_right = Nothing
        Me.Ok_button.Iconimage_right_Selected = Nothing
        Me.Ok_button.Iconimage_Selected = Nothing
        Me.Ok_button.IconMarginLeft = 0
        Me.Ok_button.IconMarginRight = 0
        Me.Ok_button.IconRightVisible = False
        Me.Ok_button.IconRightZoom = 0R
        Me.Ok_button.IconVisible = False
        Me.Ok_button.IconZoom = 90.0R
        Me.Ok_button.IsTab = False
        Me.Ok_button.Location = New System.Drawing.Point(8, 102)
        Me.Ok_button.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Ok_button.Name = "Ok_button"
        Me.Ok_button.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Ok_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Ok_button.OnHoverTextColor = System.Drawing.Color.White
        Me.Ok_button.selected = False
        Me.Ok_button.Size = New System.Drawing.Size(181, 41)
        Me.Ok_button.TabIndex = 11
        Me.Ok_button.Text = "Ok"
        Me.Ok_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Ok_button.Textcolor = System.Drawing.Color.White
        Me.Ok_button.TextFont = New System.Drawing.Font("Segoe UI Semibold", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'InputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(392, 154)
        Me.Controls.Add(Me.Ok_button)
        Me.Controls.Add(Me.Cancel_button)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.value_text)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InputBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InputBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents value_text As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Cancel_button As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Ok_button As Bunifu.Framework.UI.BunifuFlatButton
End Class
