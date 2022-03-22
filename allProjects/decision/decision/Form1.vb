Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Integer.TryParse(TextBox1.Text, num)
        If num > 10 Then
            Me.BackColor = Color.Green
        ElseIf num = 1 - 9 Then
            Me.BackColor = Color.Blue
        Else
            Me.BackColor = Color.Red
        End If
    End Sub
End Class
