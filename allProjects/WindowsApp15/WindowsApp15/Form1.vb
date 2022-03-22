Public Class Form1
    Dim weopons(5) As weopon
    Structure weopon
        Dim Dmg As String
        Dim Spd As String
        Dim Acc As String
        Dim Emdg As String
        Dim pic As Image
    End Structure
    Sub showstats(w As weopon)
        dmgBox.Text = w.Dmg
        spdBox.Text = w.Spd
        accBox.Text = w.Acc
        emdgBox.Text = w.Emdg
        mainpic.Image = w.pic
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        showstats(weopons(0))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        showstats(weopons(1))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        showstats(weopons(2))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        showstats(weopons(3))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        showstats(weopons(4))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ch As weopon
        ch.Dmg = "50"
        ch.Spd = "65"
        ch.Acc = "80"
        ch.Emdg = "90"
        ch.pic = PictureBox1.Image
        weopons(0) = ch
        Dim bl As weopon
        bl.Dmg = "75"
        bl.Spd = "45"
        bl.Acc = "50"
        bl.Emdg = "95"
        bl.pic = PictureBox2.Image
        weopons(1) = bl
        Dim ws As weopon
        ws.Dmg = "65"
        ws.Spd = "75"
        ws.Acc = "75"
        ws.Emdg = "85"
        ws.pic = PictureBox3.Image
        weopons(2) = ws
        Dim sp As weopon
        sp.Dmg = "70"
        sp.Spd = "65"
        sp.Acc = "70"
        sp.Emdg = "80"
        sp.pic = PictureBox4.Image
        weopons(3) = sp
        Dim np As weopon
        np.Dmg = "45"
        np.Spd = "70"
        np.Acc = "75"
        np.Emdg = "50"
        np.pic = PictureBox5.Image
        weopons(4) = np
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        showstats(weopons(ComboBox1.SelectedIndex))
    End Sub
End Class
