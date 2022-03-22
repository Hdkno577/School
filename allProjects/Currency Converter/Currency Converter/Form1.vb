Public Class Form1
    Dim dollarCount As Decimal
    Dim euro As Decimal
    Dim pound As Decimal
    Dim yen As Decimal
    Dim cd As Decimal
    Dim ad As Decimal
    Dim peso As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Decimal.TryParse(DollarBox.Text, dollarCount)
        euro = dollarCount * 0.86
        pound = dollarCount * 0.73
        yen = dollarCount * 113.77
        cd = dollarCount * 1.24
        ad = dollarCount * 1.33
        peso = dollarCount * 20.31
        euroLabel.Text = "€" & euro.ToString("f2")
        poundLabel.Text = "£" & pound.ToString("f2")
        yenLabel.Text = "¥" & yen.ToString("f2")
        cdLabel.Text = cd.ToString("c2")
        adLabel.Text = ad.ToString("c2")
        pesoLabel.Text = peso.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DollarBox.Text = ("0.00")
        euroLabel.Text = ("€0.00")
        poundLabel.Text = ("£0.00")
        yenLabel.Text = ("¥0.00")
        cdLabel.Text = ("c$0.00")
        adLabel.Text = ("a$0.00")
        pesoLabel.Text = ("$0.00")
    End Sub
End Class
