Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Integer.TryParse(TextBox1.Text, num1)
        Integer.TryParse(TextBox2.Text, num2)
        Dim answer As Integer
        answer = num1 * num2
        Label1.Text = answer
    End Sub
End Class
