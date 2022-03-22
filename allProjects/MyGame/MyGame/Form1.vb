Public Class Form1
    Const speed As Integer = 10
    Dim Xdir As Integer
    Dim Ydir As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.A Then
            movepic(P1, -speed, 0)
        End If
        If e.KeyCode = Keys.D Then
            movepic(P1, +speed, 0)
        End If
        If e.KeyCode = Keys.W Then
            movepic(P1, 0, -speed)
        End If
        If e.KeyCode = Keys.S Then
            movepic(P1, 0, +speed)
        End If
        If e.KeyCode = Keys.Left Then
            Xdir = -5
            Ydir = 0
        End If
        If e.KeyCode = Keys.Right Then
            Xdir = +5
            Ydir = 0
        End If
        If e.KeyCode = Keys.Up Then
            Ydir = -5
            Xdir = 0
        End If
        If e.KeyCode = Keys.Down Then
            Ydir = +5
            Xdir = 0
        End If
    End Sub
    Sub movepic(p As PictureBox, x As Integer, y As Integer)
        p.Location = New Point(p.Location.X + x, p.Location.Y + y)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        movepic(P1, 3, 0)
        movepic(P2, Xdir, Ydir)
    End Sub
End Class
