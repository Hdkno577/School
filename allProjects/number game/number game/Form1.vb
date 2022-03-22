Public Class Form1
    Dim r As New Random
    Dim count As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim guess As Integer
        count = count + 1
        Label3.Text = count
        Integer.TryParse(TextBox1.Text, guess)
        Dim rNum As Integer
        rNum = r.Next(1, TrackBar1.Value)
        Label1.Text = rNum
        If rNum = guess Then
            Me.BackColor = Color.Green
            count = 0
        ElseIf rNum > guess Then
            Me.BackColor = Color.Yellow
        ElseIf rNum < guess Then
            Me.BackColor = Color.Blue
        Else
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label2.Text = TrackBar1.Value
    End Sub
End Class
