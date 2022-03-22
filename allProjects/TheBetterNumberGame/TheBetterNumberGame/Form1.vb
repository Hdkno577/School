Public Class Form1
    Dim r As New Random
    Dim num As Integer
    Dim count As Integer
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label2.Text = TrackBar1.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num = r.Next(1, TrackBar1.Value)
        Label4.Text = num
        Me.BackColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        count = count + 1
        Dim guess As Integer
        Integer.TryParse(TextBox1.Text, guess)
        countLabel.Text = count
        If guess = num Then
            Me.BackColor = Color.Green
        ElseIf guess > num Then
            Me.BackColor = Color.Red
        ElseIf guess < num Then
            Me.BackColor = Color.Blue
        End If
    End Sub
End Class
