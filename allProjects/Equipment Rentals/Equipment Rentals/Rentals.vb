Public Class Rentals
    Private Sub RentalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RentalBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RentalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EquipmentDataSet)

    End Sub

    Private Sub Rentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EquipmentDataSet.Rental' table. You can move, or remove it, as needed.
        Me.RentalTableAdapter.Fill(Me.EquipmentDataSet.Rental)
        Me.EquipmentTableAdapter.Fill(Me.EquipmentDataSet.Equipment)
        LoadCombos()
    End Sub
    Sub LoadCombos()
        Dim equipment = From eq In EquipmentDataSet.Equipment

        For Each e In equipment
            ComboBox1.Items.Add(e.Equipment_Name)
            ComboBox2.Items.Add(e.ID)

        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.SelectedIndex = ComboBox1.SelectedIndex
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rental As EquipmentDataSet.RentalRow
        rental = EquipmentDataSet.Rental.NewRentalRow
        rental.Epuipment_ID = ComboBox2.Text
        rental.Rental_Date = DateTimePicker1.Value
        rental.Hours = NumericUpDown1.Value
        EquipmentDataSet.Rental.AddRentalRow(rental)
        Me.Validate()
        Me.RentalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EquipmentDataSet)
    End Sub
End Class