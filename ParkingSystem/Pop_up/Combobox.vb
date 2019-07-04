Public Class Combobox

    Private parking_add As Parking_Add
    Private button As Bunifu.Framework.UI.BunifuFlatButton
    Private panel As Panel
    Private ishowing As Boolean

    Public Property showing As Boolean
        Get
            Return ishowing
        End Get

        Set(ByVal New_showing As Boolean)
            ishowing = New_showing
        End Set

    End Property

    Public Property my_panel As Panel
        Get
            Return panel
        End Get

        Set(ByVal New_panel As Panel)
            panel = New_panel
        End Set

    End Property

    Public Property form As Parking_Add
        Get
            Return parking_add
        End Get

        Set(ByVal New_form As Parking_Add)
            parking_add = New_form
        End Set


    End Property

    Public Property button_flat As Bunifu.Framework.UI.BunifuFlatButton
        Get
            Return button
        End Get

        Set(ByVal New_button As Bunifu.Framework.UI.BunifuFlatButton)
            button = New_button
        End Set


    End Property


    Public Property table As Bunifu.Framework.UI.BunifuCustomDataGrid
        Get
            Return data_combobox
        End Get

        Set(value As Bunifu.Framework.UI.BunifuCustomDataGrid)
            data_combobox = value
        End Set

    End Property

    Private Sub data_combobox_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles data_combobox.CellMouseClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = data_combobox.Rows(index)
        Dim selected_row_value = selectedRow.Cells(0).Value.ToString

        If (selected_row_value.Equals("Add New Item")) Then

            Dim input_dialog As InputBox = New InputBox
            input_dialog.my_button = button
            input_dialog.table = table
            input_dialog.ShowDialog()


        Else

            button.Text = selected_row_value

        End If

        panel.Hide()
        ishowing = False

        ' Me.Close()
    End Sub

    Private Sub Combobox_Load(sender As Object, e As EventArgs) Handles Me.Load
        table.Rows.Add("Add New Item")
    End Sub
End Class