Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Decimal
        Dim num2 As Decimal
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Label1.Text = num1 + num2
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Decimal
        Dim num2 As Decimal
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Label1.Text = num1 - num2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Decimal
        Dim num2 As Decimal
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Label1.Text = num1 * num2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Decimal
        Dim num2 As Decimal
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Label1.Text = num1 / num2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim s As String
        s = TextBox1.Text & TextBox2.Text
        Label1.Text = s
    End Sub
End Class
