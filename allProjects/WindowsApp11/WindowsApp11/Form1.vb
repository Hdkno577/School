Public Class Form1
    'Dim side As Decimal
    'Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
    '    SideBox.Clear()
    '    AreaBox.Clear()
    '    PeriBox.Clear()
    '    SideBox.BackColor = DefaultBackColor
    'End Sub
    'Sub myclear()
    '    SideBox.Clear()
    '    AreaBox.Clear()
    '    PeriBox.Clear()
    '    SideBox.BackColor = DefaultBackColor
    'End Sub
    'Private Sub SideBox_CancelKeys(sender As Object, e As KeyPressEventArgs) Handles SideBox.KeyPress
    '    If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
    '        e.Handled = True
    '    End If
    'End Sub
    'Private Sub SideBox_TextChanged(sender As Object, e As EventArgs) Handles SideBox.TextChanged
    '    Try
    '        Decimal.TryParse(SideBox.Text, side)
    '        AreaBox.Text = side * side
    '        PeriBox.Text = side * 4
    '    Catch ex As Exception
    '        myclear()
    '        SideBox.BackColor = Color.Red
    '    End Try
    'End Sub
    'Function recArea(length As Decimal, width As Decimal) As Decimal
    '    Return length * width
    'End Function
    'Function recPeri(length As Decimal, width As Decimal) As Decimal
    '    Return 2 * (length + width)
    '    'recPeri = 2 * (length + width)
    'End Function

    'Private Sub WidthBox_TextChanged(sender As Object, e As EventArgs) Handles WidthBox.TextChanged, lengthBox.TextChanged
    '    Dim l As Decimal
    '    Dim w As Decimal
    '    Decimal.TryParse(lengthBox.Text, l)
    '    Decimal.TryParse(WidthBox.Text, w)
    '    rAreaBox.Text = recArea(l, w)
    '    rPeriBox.Text = recPeri(l, w)
    'End Sub

    'Private Sub sclear_Click(sender As Object, e As EventArgs) Handles sclear.Click
    '    rAreaBox.Clear()
    '    rPeriBox.Clear()
    '    lengthBox.Clear()
    '    WidthBox.Clear()
    'End Sub
    Function tristatearea(a As Decimal, b As Decimal, c As Decimal) As Decimal
        Dim s As Decimal
        s = (a + b + c) / 2
        Try
            Return Math.Sqrt(s * (s - a) * (s - b) * (s - c))


        Catch ex As Exception

        End Try
        Return 0
    End Function

    Private Sub TriA_TextChanged(sender As Object, e As EventArgs) Handles TriC.TextChanged, TriB.TextChanged, TriA.TextChanged
        Dim side1 As Decimal
        Dim Side2 As Decimal
        Dim side3 As Decimal
        Decimal.TryParse(TriA.Text, side1)
        Decimal.TryParse(TriB.Text, Side2)
        Decimal.TryParse(TriC.Text, side3)
        tArea.Text = tristatearea(side1, Side2, side3)
        tPeri.Text = triperi(side1, Side2, side3,)
    End Sub
    Function triperi(side1 As Decimal, side2 As Decimal, side3 As Decimal) As Decimal
        Return side1 + side2 + side3
    End Function
End Class
