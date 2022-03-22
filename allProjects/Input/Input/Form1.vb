Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Short
        Integer.TryParse(TextBox1.Text, num)
        Label1.Text = num

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num As Decimal
        Decimal.TryParse(TextBox1.Text, num)
        Label1.Text = num
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim temp As Image
        temp = PictureBox1.Image
        PictureBox1.Image = PictureBox2.Image
        PictureBox2.Image = temp
    End Sub
End Class
