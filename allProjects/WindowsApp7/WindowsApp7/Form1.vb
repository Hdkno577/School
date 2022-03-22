Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For index = 1 To 9
            For index2 = 1 To 9
                TextBox1.Text = TextBox1.Text & index * index2.ToString.PadLeft(3) & " "
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
        TextBox1.Text = TextBox1.Text & vbCrLf
    End Sub
End Class
