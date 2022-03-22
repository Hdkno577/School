Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = Not Panel1.Visible
        If Panel1.Visible Then
            Button1.Text = "Hide"
            Button1.BackColor = Color.Maroon
        Else
            Button1.Text = "Show"
            Button1.BackColor = Color.Green
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        'PictureBox1.Visible = RadioButton1.Checked
        'PictureBox2.Visible = RadioButton2.Checked
        'PictureBox3.Visible = RadioButton3.Checked
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Select Case True
            Case RadioButton1.Checked
                PictureBox1.Visible = True
            Case RadioButton2.Checked
                PictureBox2.Visible = True
            Case RadioButton3.Checked
                PictureBox3.Visible = True
        End Select
    End Sub
End Class
