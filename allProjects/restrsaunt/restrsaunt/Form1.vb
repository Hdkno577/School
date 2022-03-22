Public Class Form1
    Dim burg As Integer
    Dim cs As Integer
    Dim tenders As Integer
    Dim pizza As Integer
    Dim fries As Integer
    Dim tots As Integer
    Dim salad As Integer
    Dim nachos As Integer
    Dim coke As Integer
    Dim dew As Integer
    Dim dp As Integer
    Dim fanta As Integer
    Dim mainTotal As Decimal
    Dim sideTotal As Decimal
    Dim drinkTotal As Decimal
    Dim amount As Decimal

    Private Sub totalButton_Click(sender As Object, e As EventArgs) Handles totalButton.Click
        Integer.TryParse(burgerBox.Text, burg)
        Integer.TryParse(csBox.Text, cs)
        Integer.TryParse(tenderBox.Text, tenders)
        Integer.TryParse(pizzaBox.Text, pizza)
        mainTotal = burg * 5.0 + cs * 6.0 + tenders * 4.0 + pizza * 5.0
        Integer.TryParse(frieBox.Text, fries)
        Integer.TryParse(totBox.Text, tots)
        Integer.TryParse(saladBox.Text, salad)
        Integer.TryParse(nachoBox.Text, nachos)
        sideTotal = fries * 2.0 + tots * 2.0 + salad * 3.0 + nachos * 3.0
        Integer.TryParse(cokeBox.Text, coke)
        Integer.TryParse(dewBox.Text, dew)
        Integer.TryParse(dpBox.Text, dp)
        Integer.TryParse(fantaBox.Text, fanta)
        drinkTotal = coke * 1.5 + dew * 1.5 + dp * 1.5 + fanta * 1.5
        Decimal.TryParse(totalLabel.Text, amount)
        amount = mainTotal + sideTotal + drinkTotal
        totalLabel.Text = amount.ToString("c2")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Select Case True
            Case RadioButton1.Checked
                Panel1.Visible = True
            Case RadioButton2.Checked
                Panel2.Visible = True
            Case RadioButton3.Checked
                Panel3.Visible = True
        End Select
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        burgerBox.Clear()
        csBox.Clear()
        tenderBox.Clear()
        pizzaBox.Clear()
        frieBox.Clear()
        totBox.Clear()
        saladBox.Clear()
        nachoBox.Clear()
        cokeBox.Clear()
        dewBox.Clear()
        dpBox.Clear()
        fantaBox.Clear()
        totalLabel.Text = "$0.00"
    End Sub
End Class