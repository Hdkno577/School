Public Class Form1
    Dim r As New Random ' random number gnerator
    Dim num As Integer ' num is the random generator
    Dim count As Integer ' number of guesses
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        rangeLabel.Text = TrackBar1.Value ' take value from track bar and puts them on label
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num = r.Next(1, TrackBar1.Value)
        Label4.Text = num
        Me.BackColor = Color.White
        count = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim guess As Integer
        Integer.TryParse(TextBox1.Text, guess) ' get the number
        count = count + 1 ' add one to count
        countLabel.Text = count ' show the count
        If guess = num Then
            Me.BackColor = Color.Green
        ElseIf guess > num Then
            Me.BackColor = Color.Red
        ElseIf guess < num Then
            Me.BackColor = Color.Blue
        End If
    End Sub
End Class