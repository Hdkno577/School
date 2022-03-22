Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            hat1.Visible = True
            Label2.Text = "$15.00"
        Else
            hat1.Visible = False
            Label2.Text = "$0.00"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            hat2.Visible = True
            Label2.Text = "$10.00"
        Else
            hat2.Visible = False
            Label2.Text = "$0.00"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            hat3.Visible = True
            Label2.Text = "$20.00"
        Else
            hat3.Visible = False
            Label2.Text = "$0.00"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            shirt1.Visible = True
            Label3.Text = "$10.00"
        Else
            shirt1.Visible = False
            Label3.Text = "$0.00"
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            shirt2.Visible = True
            Label3.Text = "$20.00"
        Else
            shirt2.Visible = False
            Label3.Text = "$0.00"
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            shirt3.Visible = True
            Label3.Text = "$15.00"
        Else
            shirt3.Visible = False
            Label3.Text = "$0.00"
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            pants1.Visible = True
            Label4.Text = "$15.00"
        Else
            pants1.Visible = False
            Label4.Text = "$0.00"
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked Then
            pants2.Visible = True
            Label4.Text = "$20.00"
        Else
            pants2.Visible = False
            Label4.Text = "$0.00"
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked Then
            pants3.Visible = True
            Label4.Text = "$10.00"
        Else
            pants3.Visible = False
            Label4.Text = "$0.00"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim h1 As Decimal
        Dim h2 As Decimal
        Dim h3 As Decimal
        Dim s1 As Decimal
        Dim s2 As Decimal
        Dim s3 As Decimal
        Dim p1 As Decimal
        Dim p2 As Decimal
        Dim p3 As Decimal
        h1 = 15.0
        h2 = 10.0
        h3 = 20.0
        s1 = 10.0
        s2 = 20.0
        s3 = 15.0
        p1 = 15.0
        p2 = 20.0
        p3 = 10.0
    End Sub
End Class
