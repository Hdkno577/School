Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For index = 1 To 20
            ListBox1.Items.Add(index)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        For index = 2 To 100 Step 2
            ListBox1.Items.Add(index)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        For index = 10 To 1 Step -1
            ListBox1.Items.Add(index)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        Dim index As Integer
        While index < 20
            index += 1
            ListBox1.Items.Add(index)
        End While

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        Dim index As Integer
        While index < 100
            index += 2
            ListBox1.Items.Add(index)
        End While
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Items.Clear()
        Dim index As Integer = 11
        While index > 1
            index -= 1
            ListBox1.Items.Add(index)
        End While
    End Sub
End Class
