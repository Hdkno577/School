Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Tile" Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            Label1.Visible = True
            Label2.Visible = False
        End If
        If ComboBox1.Text = "Carpet" Then
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            Label1.Visible = False
            Label2.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Tile" Then
            Dim length As Integer
            Dim width As Integer
            Dim area As Decimal
            Dim total As Decimal
            Integer.TryParse(TextBox1.Text, length)
            Integer.TryParse(TextBox2.Text, width)
            area = length * width
            TextBox3.Text = area
            total = area * 5.99
            TextBox4.Text = total.ToString("c2")
        End If
        If ComboBox1.Text = "Carpet" Then
            Dim length As Integer
            Dim width As Integer
            Dim area As Decimal
            Dim total As Decimal
            Integer.TryParse(TextBox1.Text, length)
            Integer.TryParse(TextBox2.Text, width)
            area = length * width
            TextBox3.Text = area
            total = area * 2.99
            TextBox4.Text = total.ToString("c2")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Panel1.Visible = True
            Panel2.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Panel1.Visible = False
            Panel2.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
