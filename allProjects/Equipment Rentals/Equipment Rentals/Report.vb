Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EquipmentDataSet.Rental' table. You can move, or remove it, as needed.
        Me.RentalTableAdapter.Fill(Me.EquipmentDataSet.Rental)
        Me.EquipmentTableAdapter.Fill(Me.EquipmentDataSet.Equipment)
        LoadCombos()
    End Sub
    Sub LoadCombos()
        Dim equipment = From eq In EquipmentDataSet.Equipment

        For Each e In equipment
            ComboBox1.Items.Add(e.Equipment_Name)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rentals = From r In EquipmentDataSet.Rental Join eq In EquipmentDataSet.Equipment
        On r.Epuipment_ID Equals eq.ID Where
        eq.Equipment_Name = ComboBox1.Text
        TextBox1.Clear()
        For Each rent In rentals
            TextBox1.Text += rent.eq.Equipment_Name & " On " & rent.r.Rental_Date &
                " For " & rent.r.Hours & " hours. Total cost: " &
                (rent.eq.cost * rent.r.Hours).ToString("c2") & vbCrLf

        Next
    End Sub
End Class