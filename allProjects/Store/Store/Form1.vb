Public Class Form1
    Dim Shirt As Integer
    Dim Hoodie As Integer
    Dim Fit As Integer
    Dim reg As Integer
    Dim fast As Integer
    Dim Total As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shirt = 50.0
        Label9.Text += Shirt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hoodie = 85.0
        Label9.Text += Hoodie
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Fit = 575.0
        Label9.Text += Fit
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label9.Text = ("0")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label9.Text = ("Thank You!")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        fast = 10.0
        If RadioButton2.Checked Then
            Label9.Text = Label9.Text - reg
        End If
        Label9.Text += fast
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        reg = 5.0
        If RadioButton2.Checked Then
            Label9.Text = Label9.Text - fast
        End If
        Label9.Text += reg
    End Sub
End Class
