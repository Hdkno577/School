Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If HasAnE(TextBox1.Text) Then
            TextBox1.BackColor = Color.Red
        End If
        If HasAnE(TextBox2.Text) Then
            TextBox2.BackColor = Color.Red
        End If
        If HasAnE(TextBox3.Text) Then
            TextBox3.BackColor = Color.Red
        End If
        If HasAnE(TextBox4.Text) Then
            TextBox4.BackColor = Color.Red
        End If
        If HasAnE(TextBox5.Text) Then
            TextBox5.BackColor = Color.Red
        End If
        clearem()
    End Sub
    Sub clearem()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub
    Function HasAnE(word As String) As Boolean
        Return word.Contains("e")
    End Function
End Class
