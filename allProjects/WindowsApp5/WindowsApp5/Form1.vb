Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        For index = 1 To 10000 Step 5
            ListBox1.Items.Add(index)
        Next
    End Sub
End Class
