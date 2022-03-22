Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "a" Then
            Label1.Visible = True
            Label2.Visible = False
        End If
        If ComboBox1.Text = "b" Then
            Label1.Visible = False
            Label2.Visible = True
        End If
    End Sub
End Class
