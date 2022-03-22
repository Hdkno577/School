Public Class Form1
    Dim total As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear()
    End Sub
    Sub clear()
        FirstTextBox.Clear()
        LastTextBox.Clear()
        NumberTextBox.Clear()
        DateTextBox.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim amt As Decimal
        Decimal.TryParse(AmountTextBox.Text, amt)
        clear()
        total += amt
        TotalLabel.Text = total
    End Sub

    Private Sub AmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles AmountTextBox.TextChanged

    End Sub
End Class
