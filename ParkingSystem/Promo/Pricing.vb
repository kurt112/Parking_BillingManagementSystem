Public Class Pricing
    Private ReadOnly database As Server = New Server
    Private index As Integer = 0
    Private Sub Pricing_Load(sender As Object, e As EventArgs) Handles Me.Load
        database.Promo_Table("", Promo_Table)
        Promo_Table.ContextMenuStrip = Promotable_ContextMenu
    End Sub

    Private Sub Register_Button_Click()
        Using promo As Pricing_Promo = New Pricing_Promo()
            promo.Table1 = Promo_Table
            promo.Update1 = False
            promo.ShowDialog()
        End Using
    End Sub

    Private Sub Create_Promo_Button_Click(sender As Object, e As EventArgs) Handles Create_Promo_Button.Click
        Register_Button_Click()
    End Sub

    Private Sub Promo_Logo_Click(sender As Object, e As EventArgs) Handles Promo_Logo.Click
        Register_Button_Click()
    End Sub

    Private Sub Search_OnValueChanged(sender As Object, e As EventArgs) Handles Search.OnValueChanged
        database.Promo_Table(Search.Text, Promo_Table)
    End Sub

    Private Sub Promo_Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Promo_Table.CellMouseClick
        index = e.RowIndex
    End Sub

    Private Sub Promo_Table_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Promo_Table.CellMouseDoubleClick
        Update_Promo()
    End Sub


    Private Sub Update_Promo()
        Dim promo As Promo = New Promo(0, "", "", "", "", "", "")
        Dim selectedRow As DataGridViewRow

        Try
            selectedRow = Promo_Table.Rows(index)
            database.Promo_Query(selectedRow.Cells(0).Value.ToString, promo)
            Dim result As DialogResult = MessageBox.Show("Do you want to Update this item?",
                                      "Update Confirmation",
                                      MessageBoxButtons.YesNo)
            If (result = DialogResult.Yes) Then
                Using pricing_promo As Pricing_Promo = New Pricing_Promo
                    pricing_promo.Promo1 = promo
                    pricing_promo.Update1 = True
                    pricing_promo.ShowDialog()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("No element found")
        End Try
    End Sub
    '************************************************************ Context Menu ***********************************************************************'

    Private Sub Register_ContextMenu_Click(sender As Object, e As EventArgs) Handles Register_ContextMenu.Click
        Register_Button_Click()
    End Sub

    Private Sub Update_ContextMenu_Click(sender As Object, e As EventArgs) Handles Update_ContextMenu.Click
        Update_Promo()

    End Sub

    Private Sub DeleteContextMenu_Click(sender As Object, e As EventArgs) Handles DeleteContextMenu.Click
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = Promo_Table.Rows(index)
            Dim result As DialogResult = MessageBox.Show("Do you want to Update this item?",
                                      "Update Confirmation",
                                      MessageBoxButtons.YesNo)
            If (result = DialogResult.Yes) Then
                database.Delete_Promo(selectedRow.Cells(0).Value.ToString)
                MessageBox.Show("Delete Succesul")
                database.Promo_Table(Search.Text, Promo_Table)
            End If
        Catch ex As Exception
            MessageBox.Show("No Element Found")
        End Try
    End Sub

    Private Sub Refresh_ContextMenu_Click(sender As Object, e As EventArgs) Handles Refresh_ContextMenu.Click
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = Promo_Table.Rows(index)
            database.Promo_Table(Search.Text, Promo_Table)
        Catch ex As Exception
            MessageBox.Show("No Element Found")
        End Try
    End Sub

    Private Sub SetEnable_ContextMenu_Click(sender As Object, e As EventArgs) Handles setEnable_ContextMenu.Click
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = Promo_Table.Rows(index)
            database.Promo_Enable(selectedRow.Cells(0).Value.ToString)
            database.Promo_Table(Search.Text, Promo_Table)
            MessageBox.Show("Item Enable Sucess")
        Catch ex As Exception
            MessageBox.Show("No Element Found")
        End Try

    End Sub

    Private Sub SetDisable_ContextMenu_Click(sender As Object, e As EventArgs) Handles setDisable_ContextMenu.Click
        Try
            Dim selectedRow As DataGridViewRow
            selectedRow = Promo_Table.Rows(index)
            database.Promo_Disable(selectedRow.Cells(0).Value.ToString)
            database.Promo_Table(Search.Text, Promo_Table)
            MessageBox.Show("Item Disable Sucess")
        Catch ex As Exception
            MessageBox.Show("No Element Found")
        End Try
    End Sub


    '********************************************************** End Context Menu ***********************************************************************'
End Class