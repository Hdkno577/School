Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VIDOEsGAMES.Click
        PictureBox1.Visible = Not PictureBox1.Visible
    End Sub

    Private Sub ZELDA_Click(sender As Object, e As EventArgs) Handles ZELDA.Click
        PictureBox4.Visible = Not PictureBox4.Visible
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BOOKS.Click
        PictureBox3.Visible = Not PictureBox3.Visible
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles IRONMAN.Click
        PictureBox2.Visible = Not PictureBox2.Visible
    End Sub
End Class
