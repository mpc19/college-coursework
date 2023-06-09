Imports System.Threading

Public Class ReceiptTemplate

    ' Basically sets all the value on the receipt
    ' A weird way of forcing the form to actually update,
    ' without calling update() the text would not render.
    Public Sub updateForm(ByVal curDate As String, ByVal name As String, ByVal address As String, ByVal pizza As String, ByVal cost As Double, ByVal delivery As Boolean, ByVal phone As String, ByVal toppings As Dictionary(Of String, Double))
        deliveryLabel.Text = "Cash over counter"
        If (delivery) Then
            driverLabel.Enabled = True
            deliveryLabel.Text = "Cash on delivery"
        End If
        If (String.IsNullOrEmpty(phone) = False) Then
            phoneLabel.Text = "Phone: " + CStr(phone)
        End If
        dateLabel.Text = curDate
        nameLabel.Text = name
        addressLabel.Text = address
        pizzaLabel.Text = pizza
        costLabel.Text = "£" + CStr(cost)

        If (toppings.Count > 0) Then
            If (toppings.ContainsKey("Extra Cheese")) Then
                toppingsList.Text += "Extra Cheese (£1.99)" + vbNewLine
            End If
            If (toppings.ContainsKey("Olives")) Then
                toppingsList.Text += "Olives (£2.29)" + vbNewLine
            End If
            If (toppings.ContainsKey("Pepperoni")) Then
                toppingsList.Text += "Pepperoni (£2.99)" + vbNewLine
            End If
            If (toppings.ContainsKey("Mushrooms")) Then
                toppingsList.Text += "Mushrooms (£1.19)" + vbNewLine
            End If
            If (toppings.ContainsKey("Ham")) Then
                toppingsList.Text += "Ham (£2.49)" + vbNewLine
            End If
            If (toppings.ContainsKey("Anchovies")) Then
                toppingsList.Text += "Anchovies (£1.49)" + vbNewLine
            End If
        Else
            toppingsLbl.Text = ""
        End If

        ' was going to assign a random ID to make the receipt look more generic or use it in the .csv file to match orders
        'randomUUID.Text = Guid.NewGuid.ToString
        MyBase.Update()
        MyBase.Show()
    End Sub

    Public Sub print()
        Me.Opacity = 100
        Me.Visible = True
        ' PrintForm1.Print()
    End Sub


    Private Sub ReceiptTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        driverLabel.Enabled = False
    End Sub

    Function getDisposed() As Boolean
        If (IsDisposed) Then
            Return True
        End If
        Return False
    End Function

End Class