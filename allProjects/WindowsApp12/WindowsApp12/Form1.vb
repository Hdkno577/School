Public Class Form1
    Dim turn As String = "O"
    Dim xscore As Integer
    Dim oscore As Integer
    Dim xmatch As Integer
    Dim omatch As Integer
    Function nextturn() As String
        If turn = "O" Then
            turn = "X"
        Else
            turn = "O"
        End If
        Return turn
    End Function
    Sub clear()
        B1.Text = ""
        B2.Text = ""
        B3.Text = ""
        B4.Text = ""
        B5.Text = ""
        B6.Text = ""
        B7.Text = ""
        B8.Text = ""
        B9.Text = ""
        turn = "O"
        Me.BackColor = DefaultBackColor
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
        CenterToScreen()
    End Sub
    Private Sub b_Click(sender As Button, e As EventArgs) Handles B1.Click, B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B2.Click
        If sender.Text = "" Then
            sender.Text = nextturn()
        End If
        If iswinner() Then
            Me.BackColor = Color.Green
            If turn = "X" Then
                oscore = oscore + 1
            Else
                xscore = xscore + 1
            End If
            oLabel.Text = xscore
            xLabel.Text = oscore
        End If
        best3()
        best5()
        best7()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear()
    End Sub
    Function iswinner() As Boolean
        If B1.Text = B2.Text And B2.Text = B3.Text And B3.Text <> "" Then Return True
        If B4.Text = B5.Text And B5.Text = B6.Text And B6.Text <> "" Then Return True
        If B7.Text = B8.Text And B8.Text = B9.Text And B9.Text <> "" Then Return True
        If B1.Text = B4.Text And B4.Text = B7.Text And B7.Text <> "" Then Return True
        If B2.Text = B5.Text And B5.Text = B8.Text And B8.Text <> "" Then Return True
        If B3.Text = B6.Text And B6.Text = B9.Text And B9.Text <> "" Then Return True
        If B1.Text = B5.Text And B5.Text = B9.Text And B9.Text <> "" Then Return True
        If B3.Text = B5.Text And B5.Text = B7.Text And B7.Text <> "" Then Return True
        Return False
    End Function
    Sub best3()
        If ComboBox1.Text = "Best of 3" Then
            If xLabel.Text = "2" Then
                Me.BackColor = Color.DarkGreen
                MsgBox("X wins")
                xLabel2.Text = xLabel2.Text + 1
                xscore = 0
                oscore = 0
                xLabel.Text = "0"
                oLabel.Text = "0"
            ElseIf oLabel.Text = "2" Then
                Me.BackColor = Color.DarkGreen
                MsgBox("O Wins")
                oLabel2.Text = oLabel.Text + 1
                xscore = 0
                oscore = 0
                xLabel.Text = "0"
                oLabel.Text = "0"
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles newmatchbutton.Click
        xLabel.Text = "0"
        xLabel2.Text = "0"
        xscore = 0
        oLabel.Text = "0"
        oLabel2.Text = "0"
        oscore = 0
        Me.BackColor = DefaultBackColor
        B1.Text = ""
        B2.Text = ""
        B3.Text = ""
        B4.Text = ""
        B5.Text = ""
        B6.Text = ""
        B7.Text = ""
        B8.Text = ""
        B9.Text = ""
        turn = "O"
    End Sub
    Sub best5()
        If ComboBox1.Text = "Best of 5" Then
            If xLabel.Text = "3" Then
                Me.BackColor = Color.DarkGreen
                MsgBox("X wins")
                xLabel2.Text = xLabel2.Text + 1
                xscore = 0
                oscore = 0
                xLabel.Text = "0"
                oLabel.Text = "0"
            ElseIf oLabel.Text = "3" Then
                Me.BackColor = Color.DarkGreen
                MsgBox("O Wins")
                oLabel2.Text = oLabel.Text + 1
                xscore = 0
                oscore = 0
                xLabel.Text = "0"
                oLabel.Text = "0"
            End If
        End If
    End Sub
    Sub best7()
        If ComboBox1.Text = "Best of 7" Then
            If xLabel.Text = "4" Then
                Me.BackColor = Color.DarkGreen
                MsgBox("X wins")
                xLabel2.Text = xLabel2.Text + 1
                xscore = 0
                oscore = 0
                xLabel.Text = "0"
                oLabel.Text = "0"
            ElseIf oLabel.Text = "4" Then
                Me.BackColor = Color.DarkGreen
                MsgBox("O Wins")
                oLabel2.Text = oLabel.Text + 1
                xscore = 0
                oscore = 0
                xLabel.Text = "0"
                oLabel.Text = "0"
            End If
        End If
    End Sub
End Class
