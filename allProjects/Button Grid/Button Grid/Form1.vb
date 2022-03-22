Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item As Control In Controls
            item.BackColor = BackColor.Maroon
        Next
    End Sub

    Private Sub Button101_Click(sender As Object, e As EventArgs) Handles Button101.Click
        For index = 2 To 100 Step 2
            Dim B As Control
            B = Controls("Button" & index)
            B.BackColor = Color.Green
        Next
    End Sub

    Private Sub Button102_Click(sender As Object, e As EventArgs) Handles Button102.Click
        For index = 5 To 100 Step 5
            Dim B As Control
            B = Controls("Button" & index)
            B.BackColor = Color.Orange
        Next
    End Sub

    Private Sub Button103_Click(sender As Object, e As EventArgs) Handles Button103.Click
        For index = 56 To 100 Step 7
            Dim B As Control
            B = Controls("Button" & index)
            B.BackColor = Color.Pink
        Next
    End Sub

    Private Sub Button104_Click(sender As Object, e As EventArgs) Handles Button104.Click
        For index = 6 To 50 Step 6
            Dim B As Control
            B = Controls("Button" & index)
            B.BackColor = Color.LightBlue
        Next
    End Sub

    Private Sub Button105_Click(sender As Object, e As EventArgs) Handles Button105.Click
        For index = 1 To 100
            Dim B As Button
            B = Controls("Button" & index)
            B.Location = New Point(B.Location.X, B.Location.Y + 5)
        Next
    End Sub
End Class
