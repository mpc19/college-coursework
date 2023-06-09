Imports System.IO

Public Class Prices

    Sub loadPrices()
        margaritaPrice.Text = CStr(PizzaType.MARGARITA)
        pepperoniPrice.Text = CStr(PizzaType.PEPPERONI)
        spicyPrice.Text = CStr(PizzaType.HOTNSPICY)
        wainPrice.Text = CStr(PizzaType.HAWAIIAN)
        feastPrice.Text = CStr(PizzaType.MEATFEAST)
        veggiePrice.Text = CStr(PizzaType.VEGGIE)
    End Sub

    Private Sub Prices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click
        If (checkPrice(margaritaPrice) And checkPrice(pepperoniPrice) And checkPrice(spicyPrice) And checkPrice(wainPrice) And checkPrice(feastPrice) And checkPrice(veggiePrice)) Then
            PizzaType.MARGARITA = CDbl(margaritaPrice.Text)
            PizzaType.PEPPERONI = CDbl(pepperoniPrice.Text)
            PizzaType.HOTNSPICY = CDbl(spicyPrice.Text)
            PizzaType.HAWAIIAN = CDbl(wainPrice.Text)
            PizzaType.MEATFEAST = CDbl(feastPrice.Text)
            PizzaType.VEGGIE = CDbl(veggiePrice.Text)

            MsgBox("Saving prices.", MsgBoxStyle.OkOnly, "Processing")
            Close()
        End If
    End Sub

    Public Function checkPrice(ByVal box As TextBox) As Boolean
        If (box.Text.Contains(".") And box.Text.Split(".").Length = 2) Then
            If (box.Text.Split(".")(1).Length < 3) Then
                Return True
            End If
        End If
        Return False
    End Function
End Class