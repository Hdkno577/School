Public Class Form1
    Dim cost As Decimal
    Dim length As Decimal
    Dim widths As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        length = lengthBox.Text
        widths = lengthBox.Text
        Decimal.TryParse(priceLabel.Text, cost)
        If RadioButton1.Checked Then
            cost = 12.99 * length * widths
            amountLabel.Text = cost.ToString("c2")
        End If
        If RadioButton2.Checked Then
            cost = 5.99 * length * widths
            amountLabel.Text = cost.ToString("c2")
        End If
        If RadioButton3.Checked Then
            cost = 9.99 * length * widths
            amountLabel.Text = cost.ToString("c2")
        End If
    End Sub

End Class
