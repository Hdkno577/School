Public Class Equipment
    Private Sub EquipmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EquipmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EquipmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EquipmentDataSet)

    End Sub

    Private Sub Equipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EquipmentDataSet.Equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.EquipmentDataSet.Equipment)

    End Sub
End Class