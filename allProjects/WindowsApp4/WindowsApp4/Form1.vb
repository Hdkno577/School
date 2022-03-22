Public Class Form1
    Dim letter As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        letter = "X"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles MyBase.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        sender.text = letter
        If letter = "X" Then
            letter = "O"
        Else
            letter = "X"
        End If
    End Sub
End Class
