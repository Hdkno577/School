Public Class Form1
    Structure car
        Dim color As String
        Dim make As String
        Dim year As Integer
        Dim seats As Integer
        Dim price As Decimal
        Dim model As String
        Dim hp As Integer
    End Structure
    Sub showCar(c As car)
        colorBox.Text = c.color
        makeBox.Text = c.make
        yearBox.Text = c.year
        priceBox.Text = c.price
        modelBox.Text = c.model
        seatBox.Text = c.seats
        hpBox.Text = c.hp
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TT As car
        TT.color = "Silver"
        TT.make = "Audi"
        TT.year = 2001
        TT.seats = 4
        TT.price = 3500
        TT.model = "TT"
        TT.hp = 225
        showCar(TT)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim TT As car
        TT.color = "Blue"
        TT.make = "Toyota"
        TT.year = 2001
        TT.seats = 5
        TT.price = 2000
        TT.model = "Corolla"
        TT.hp = 125
        showCar(TT)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim TT As car
        TT.color = "Black"
        TT.make = "Porsche"
        TT.year = 2015
        TT.seats = 2
        TT.price = 60500
        TT.model = "Cayman"
        TT.hp = 385
        showCar(TT)
    End Sub
End Class
