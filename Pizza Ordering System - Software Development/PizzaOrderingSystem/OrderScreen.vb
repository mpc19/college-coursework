Imports System.Threading

Public Class OrderScreen

    Protected discountApplied As Integer = 0
    Protected discountAmount As Double = 0
    Public price As Double = 20.0
    Public sizeAdd = 0
    Public crustAdd = 0
    Public toppings = 0
    Public pizza As Double = PizzaType.NONE

    Protected receipt As ReceiptTemplate

    Protected locked As Boolean = False

    Public orderName As String = ""
    Public address As String = ""

    Public Shared usingLogin As Boolean = False
    Private _orderScreen As OrderScreen

    Public selectedToppings As Dictionary(Of String, Double) = New Dictionary(Of String, Double)

    ' Enter button decides whether the details entered are valid
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterButton.Click
        If (Len(nameInput.Text) < 2) Then
            MsgBox("You need to enter a valid name", MsgBoxStyle.OkOnly, "Error")
            Return
        Else
            Dim name As String = CStr(nameInput.Text)
            If (name = vbNullString) Then
                MsgBox("You need to enter a valid name", MsgBoxStyle.OkOnly, "Error")
                Return
            Else
                If (name.Length < 2) Then
                    MsgBox("You need to enter a valid name", MsgBoxStyle.OkOnly, "Error")
                    Return
                End If

                If (name.Contains(0) Or name.Contains(1) Or name.Contains(2) Or name.Contains(3) Or name.Contains(4) Or name.Contains(5) Or name.Contains(6) Or name.Contains(7) Or name.Contains(8) Or name.Contains(9)) Then
                    MsgBox("You need to enter a valid name", MsgBoxStyle.OkOnly, "Error")
                    Return
                End If

                ' Name.Split = 1 - Micheal 2 - Downley 
                ' seperates stuff
                If (name.Split(" ").Length < 2) Then
                    MsgBox("You need to ask for a surname or initial", MsgBoxStyle.OkOnly, "Error")
                    Return
                End If

                purchaseButton.Enabled = True

            End If
        End If

        If (addressBox.Enabled = True) Then
            Dim ad As String = addressBox.Text
            If (ad = vbNullString Or ad = "" Or ad.Length < 4 Or ad.Contains(" ") = False) Then
                MsgBox("You need to enter a valid address.", MsgBoxStyle.OkOnly, "Error")
                Return
            End If
            address = ad
        End If

        lockDetails()

    End Sub

    ' Save order function
    Private Sub saveOrder(ByVal delivery As Boolean)
        Dim curDate As Date = System.DateTime.Now
        Dim formattedDate As String = curDate.ToLongTimeString + " " + curDate.ToLongDateString
        If delivery = False Then
            Dim order As String = ""
            order += CStr(formattedDate) + ","
            order += CStr(price) + ","
            LogFile.AppendLineToLog("orders.csv", order)
        Else
            Dim order As String = ""
            order += CStr(formattedDate) + ","
            order += CStr(price) + ","
            order += CStr(address) + ","
            LogFile.AppendLineToLog("orders.csv", order)
        End If

    End Sub

    ' Assign a template to the orderscreen.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        purchaseButton.Enabled = False
        unlockButton.Enabled = False
        discountLabel.Text = ""

        receipt = New ReceiptTemplate
        receipt.Show()
        receipt.ShowInTaskbar = False
        receipt.Opacity = 0
    End Sub

    ' Took a very long time, but to print a reciept template to print to the kitchen
    Private Sub continueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles purchaseButton.Click
        If (locked = False) Then
            MsgBox("You need to lock in the details.", MsgBoxStyle.OkOnly, "Error")
            Return
        End If


        If (cashForDelivery.Checked = cashOverCounter.Checked) Then
            MsgBox("You need to specify where cash will be collected", MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        If (cashForDelivery.Checked) Then
            If (address = vbNullString Or address = "" Or address.Length < 4 Or address.Contains(" ") = False) Then
                MsgBox("You need to enter a valid address.", MsgBoxStyle.OkOnly, "Error")
                Return
            End If
        End If

        If (pizza = PizzaType.NONE) Then
            MsgBox("You need to select a pizza type.", MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        Dim printOut As String
        Dim addphone As Boolean


        If (CStr(phoneInput.Text) <> vbNullString And CStr(phoneInput.Text) <> "") Then
            addphone = True
        End If

        If (address = vbNullString Or address = "" Or address.Length < 4 Or address.Contains(" ") = False) Then
            Call saveOrder(False)
            Dim curDate As Date = System.DateTime.Now
            Dim formattedDate As String = curDate.ToLongTimeString + " " + curDate.ToLongDateString
            If (IsNothing(receipt) Or receipt.Disposing Or receipt.getDisposed()) Then
                receipt = New ReceiptTemplate()
            End If
            receipt.Show()
            Me.Hide()
            receipt.updateForm(formattedDate, orderName, "", matchSize(sizeAdd) + " " + PizzaType.matchPrice(pizza), price, True, phoneInput.Text, selectedToppings)
            receipt.print()
            Thread.Sleep(2000)
            Me.Show()
            printOut = "Name: " + orderName + vbNewLine + "Price: £" + CStr(price)
        Else
            Call saveOrder(True)
            printOut = "Name: " + orderName + vbNewLine + "Price: £" + CStr(price) + vbNewLine + "Address: " + address
            Dim curDate As Date = System.DateTime.Now
            Dim formattedDate As String = curDate.ToLongTimeString + " " + curDate.ToLongDateString
            If (IsNothing(receipt) Or receipt.Disposing Or receipt.getDisposed()) Then
                receipt = New ReceiptTemplate()
            End If
            receipt.Show()
            Me.Hide()
            receipt.updateForm(formattedDate, orderName, address, matchSize(sizeAdd) + " " + PizzaType.matchPrice(pizza), price, True, phoneInput.Text, selectedToppings)
            receipt.print()
            Thread.Sleep(2000)
            Me.Show()
        End If


        MsgBox(printOut, MsgBoxStyle.Information, "Processing")
    End Sub

    Private Sub nameInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nameInput.TextChanged, addressBox.TextChanged
        If (purchaseButton.Enabled = True) Then
            purchaseButton.Enabled = False
            Return
        End If
    End Sub

    Private Sub cashOverCounter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cashOverCounter.CheckedChanged
        Dim isChecked As Boolean = cashOverCounter.Checked
        If (cashForDelivery.Checked) Then
            cashForDelivery.Checked = False
        End If

        If (isChecked = False) Then
            cashOverCounter.Checked = False
            addressBox.Enabled = False
            addressLabel.Enabled = False
        Else
            addressBox.Enabled = False
            addressLabel.Enabled = False
            cashOverCounter.Checked = True
        End If
    End Sub

    ' 
    Private Sub cashForDelivery_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cashForDelivery.CheckedChanged
        Dim isChecked As Boolean = cashForDelivery.Checked
        If (cashOverCounter.Checked) Then
            cashOverCounter.Checked = False
        End If

        If (isChecked = False) Then
            cashForDelivery.Checked = False
            addressBox.Enabled = False
            addressLabel.Enabled = False
        Else
            cashForDelivery.Checked = True
            addressBox.Enabled = True
            addressLabel.Enabled = True
            unlockDetails()
        End If
    End Sub

    ' Applies discounts of up to £5
    Private Sub applyDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles applyDiscount.Click
        If (pizza.Equals(PizzaType.NONE)) Then
            MsgBox("You haven't selected a pizza.", MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        If (discountComboBox.Text.Contains(".") = False) Then
            MsgBox("You need to enter a valid discont from the list", MsgBoxStyle.OkOnly, "Error")
            Return
        End If
        If (discountApplied > 0) Then
            MsgBox("You have already applied the maximum amount of discounts", MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        If (discountComboBox.SelectedIndex = 0) Then
            If (price - 1.0 > 0) Then
                price -= 1.0
                discountAmount = 1.0
            End If
        ElseIf (discountComboBox.SelectedIndex = 1) Then
            If (price - 2.0 > 0) Then
                price -= 2.0
                discountAmount = 2.0
            End If
        ElseIf (discountComboBox.SelectedIndex = 2) Then
            If (price - 3.0 > 0) Then
                price -= 3.0
                discountAmount = 3.0
            End If
        ElseIf (discountComboBox.SelectedIndex = 3) Then
            If (price - 4.0 > 0) Then
                price -= 4.0
                discountAmount = 4.0
            End If
        ElseIf (discountComboBox.SelectedIndex = 4) Then
            If (price - 5.0 > 0) Then
                price -= 5.0
                discountAmount = 5.0
            End If
        End If


        discountApplied += 1
        updatePrice()
    End Sub

    ' A long and absurd way of updating price.
    Private Sub updatePrice()
        price = pizza
        price += sizeAdd
        price += crustAdd
        Dim i As Integer = 0
        Dim toppingsPrice As Double = 0
        selectedToppings.Clear()
        While (i < 6)
            If (toppingsBox.GetItemCheckState(i)) Then
                If (i = 0) Then
                    price += 1.99
                    toppingsPrice += 1.99
                    selectedToppings.Add("Extra Cheese", 1.99)
                End If
                If (i = 1) Then
                    price += 2.29
                    toppingsPrice += 2.29
                    selectedToppings.Add("Olives", 2.29)
                End If
                If (i = 2) Then
                    price += 2.99
                    toppingsPrice += 2.99
                    selectedToppings.Add("Pepperoni", 2.99)
                End If
                If (i = 3) Then
                    price += 1.19
                    toppingsPrice += 1.19
                    selectedToppings.Add("Mushrooms", 1.19)
                End If
                If (i = 4) Then
                    price += 2.49
                    toppingsPrice += 2.49
                    selectedToppings.Add("Ham", 2.49)
                End If
                If (i = 5) Then
                    price += 1.49
                    toppingsPrice += 1.49
                    selectedToppings.Add("Anchovies", 1.49)
                End If
            End If
            i += 1
        End While

        If (toppingsPrice > 0) Then
            toppingsLbl.Text = "Toppings - £" + CStr(toppingsPrice)
        Else
            toppingsLbl.Text = "Toppings"
        End If
        If (sizeAdd <> 0) Then
            Dim str = ""
            If (sizeAdd < 0) Then
                str = "-£" + CStr(Math.Abs(sizeAdd))
            Else
                str = "+£" + CStr(sizeAdd)
            End If
            pizzaSizeLabel.Text = str
        Else
            pizzaSizeLabel.Text = ""
        End If
        If (crustAdd <> 0) Then
            Dim str = ""
            If (crustAdd < 0) Then
                str = "-£" + CStr(Math.Abs(crustAdd))
            Else
                str = "+£" + CStr(crustAdd)
            End If
            crustTypeLabel.Text = str
        Else
            crustTypeLabel.Text = ""
        End If
        If (price - discountAmount > 0) Then
            price -= discountAmount
        End If

        price = FormatNumber(price, 2)

        calculatedCost.Text = "£" + (price.ToString)
        If (discountApplied > 0 Or discountAmount > 0) Then
            discountLabel.Text = "(Applied £" + CStr(discountAmount) + " discount)"
        Else
            discountLabel.Text = ""
        End If
    End Sub

    Private Sub margarita_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles margarita.CheckedChanged
        Dim isChecked As Boolean = margarita.Checked

        If (isChecked = False) Then
            discountApplied = 0
            price = pizza
            updatePrice()
        Else
            pizza = PizzaType.MARGARITA
            price = pizza
            updatePrice()
        End If
    End Sub

    Private Sub resetDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetDiscount.Click
        discountApplied = 0
        discountAmount = 0
        price = pizza
        updatePrice()
    End Sub

    Private Sub pepperoni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pepperoni.CheckedChanged
        Dim isChecked As Boolean = pepperoni.Checked

        If (isChecked = False) Then
            discountApplied = 0
            price = pizza
            updatePrice()
        Else
            pizza = PizzaType.PEPPERONI
            price = pizza
            updatePrice()
        End If
    End Sub

    Private Sub hotnSpicy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hotnSpicy.CheckedChanged
        Dim isChecked As Boolean = hotnSpicy.Checked

        If (isChecked = False) Then
            discountApplied = 0
            price = pizza
            updatePrice()
        Else
            pizza = PizzaType.HOTNSPICY
            price = pizza
            updatePrice()
        End If
    End Sub

    Private Sub meatFeast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles meatFeast.CheckedChanged
        Dim isChecked As Boolean = meatFeast.Checked

        If (isChecked = False) Then
            discountApplied = 0
            price = pizza
            updatePrice()
        Else
            pizza = PizzaType.MEATFEAST
            price = pizza
            updatePrice()
        End If
    End Sub

    Private Sub hawaiian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hawaiian.CheckedChanged
        Dim isChecked As Boolean = hawaiian.Checked

        If (isChecked = False) Then
            discountApplied = 0
            price = pizza
            updatePrice()
        Else
            pizza = PizzaType.HAWAIIAN
            price = pizza
            updatePrice()
        End If
    End Sub


    Private Sub veggie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles veggie.CheckedChanged
        Dim isChecked As Boolean = veggie.Checked

        If (isChecked = False) Then
            discountApplied = 0
            price = pizza
            updatePrice()
        Else
            pizza = PizzaType.VEGGIE
            price = pizza
            updatePrice()
        End If
    End Sub

    ' Locks everything
    Private Sub lockDetails()
        orderName = UCase(nameInput.Text)
        address = UCase(addressBox.Text)
        enterButton.Enabled = False
        unlockButton.Enabled = True
        addressBox.Enabled = False
        addressLabel.Enabled = False
        nameInput.Enabled = False
        nameLabel.Enabled = False
        locked = True
    End Sub

    ' Unlocks everything
    Private Sub unlockDetails()
        enterButton.Enabled = True
        unlockButton.Enabled = False
        If (cashForDelivery.Checked = True) Then
            addressBox.Enabled = True
            addressLabel.Enabled = True
        End If
        nameInput.Enabled = True
        nameLabel.Enabled = True
        locked = False
    End Sub

    ' Unlocks details (to prevent mistakes like pressing E after you writen a name)
    Private Sub unlockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unlockButton.Click
        If (locked) Then
            unlockDetails()
        End If
    End Sub

    ' Sets the time, this ticks 20 times a second to make sure if it slows the time is updated more reliably.
    Private Sub timeUpdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeUpdate.Tick
        Dim curDate As Date = System.DateTime.Now
        dateLabel.Text = curDate.ToLongTimeString + " " + curDate.ToLongDateString
    End Sub

    ' Shows the `help`screen
    Private Sub helpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles helpButton.Click
        Dim helpScreen As HelpScreen = New HelpScreen()
        helpScreen.enable(usingLogin)
        helpScreen.Show()
    End Sub

    ' Update the price of different sizes
    Private Sub PizzaSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PizzaSize.SelectedIndexChanged
        If (pizza.Equals(PizzaType.NONE)) Then
            If (PizzaSize.SelectedIndex = 0) Then
                sizeAdd = -3
            End If

            If (PizzaSize.SelectedIndex = 1) Then
                sizeAdd = 0
            End If

            If (PizzaSize.SelectedIndex = 2) Then
                sizeAdd = 5
            End If
            Return
        End If

        updatePrice()
        If (PizzaSize.SelectedIndex = 0) Then
            sizeAdd = -3
            updatePrice()
        End If

        If (PizzaSize.SelectedIndex = 1) Then
            sizeAdd = 0
            updatePrice()
        End If

        If (PizzaSize.SelectedIndex = 2) Then
            sizeAdd = 5
            updatePrice()
        End If
    End Sub

    ' Updates value of added crust
    Private Sub CrustType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrustType.SelectedIndexChanged
        If (pizza.Equals(PizzaType.NONE)) Then
            If (CrustType.SelectedIndex = 0) Then
                crustAdd = 0
            End If

            If (CrustType.SelectedIndex = 1) Then
                crustAdd = 3
            End If

            If (CrustType.SelectedIndex = 2) Then
                crustAdd = 5
            End If
            Return
        End If

        updatePrice()
        If (CrustType.SelectedIndex = 0) Then
            crustAdd = 0
            updatePrice()
        End If

        If (CrustType.SelectedIndex = 1) Then
            crustAdd = 3
            updatePrice()
        End If

        If (CrustType.SelectedIndex = 2) Then
            crustAdd = 5
            updatePrice()
        End If

    End Sub

    ' Assume that the price can only be -3, 0 or 5
    Private Function matchSize(ByVal price As Double) As String
        If (price = -3) Then
            Return "Small"
        ElseIf (price = 0) Then
            Return "Medium"
        ElseIf (price = 5) Then
            Return "Large"
        End If
        Return "Medium"
    End Function

    ' A cheat way of resetting the order.
    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        Dim orderScreen = New OrderScreen
        receipt.Close()
        orderScreen.Show()
        orderScreen.closeParent(Me)
    End Sub

    ' Closes old orderscreen form.
    Private Sub closeParent(ByVal orderScreen As OrderScreen)
        Me.Update()
        Me.SetTopLevel(True)
        orderScreen.Close()
    End Sub

    ' Fixes crashing if receipt is closed randomly in the middle of the program usage.
    Private Sub OrderScreen_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If (IsDBNull(receipt)) Then
            Return
        End If
        receipt.Close()
    End Sub

    Private Sub toppingsBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toppingsBox.SelectedIndexChanged
        updatePrice()
        Update()
    End Sub

    Private Sub toppingsBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toppingsBox.SelectedValueChanged
        updatePrice()
        Update()
    End Sub

    Private Sub toppingsBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toppingsBox.Click
        updatePrice()
        Update()
    End Sub
End Class
