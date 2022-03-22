Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim CB As Decimal
    Dim CH As Decimal
    Dim tendies As Decimal
    Dim pizza As Decimal
    Dim fries As Decimal
    Dim tots As Decimal
    Dim salad As Decimal
    Dim nachos As Decimal
    Dim coke As Decimal
    Dim md As Decimal
    Dim dp As Decimal
    Dim fanta As Decimal
    Dim main As Decimal
    Dim side As Decimal
    Dim drink As Decimal
    Dim total As Decimal
    Protected Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Decimal.TryParse(CBbox.Text, CB)
        Decimal.TryParse(CHbox.Text, CH)
        Decimal.TryParse(tenderbox.Text, tendies)
        Decimal.TryParse(pizzabox.Text, pizza)
        main = CB * 5.0 + CH * 5.0 + tendies * 3.5 + pizza * 3.0
        Decimal.TryParse(friebox.Text, fries)
        Decimal.TryParse(totbox.Text, tots)
        Decimal.TryParse(saladbox.Text, salad)
        Decimal.TryParse(nachobox.Text, nachos)
        side = fries * 3.0 + tots * 3.0 + salad * 1.5 + nachos * 2.5
        Decimal.TryParse(cokebox.Text, coke)
        Decimal.TryParse(MDbox.Text, md)
        Decimal.TryParse(DPbox.Text, dp)
        Decimal.TryParse(fantabox.Text, fanta)
        drink = coke * 1.5 + md * 1.5 + dp * 1.5 + fanta * 1.5
        total = main + side + drink
        totallabel.Text = total.ToString("c2")
    End Sub

End Class