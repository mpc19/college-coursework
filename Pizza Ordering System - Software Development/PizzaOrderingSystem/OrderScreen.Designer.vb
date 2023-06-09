<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderScreen))
        Me.nameInput = New System.Windows.Forms.TextBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.enterButton = New System.Windows.Forms.Button()
        Me.purchaseButton = New System.Windows.Forms.Button()
        Me.cashOverCounter = New System.Windows.Forms.CheckBox()
        Me.cashForDelivery = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.calculatedCost = New System.Windows.Forms.Label()
        Me.applyDiscount = New System.Windows.Forms.Button()
        Me.discountComboBox = New System.Windows.Forms.ComboBox()
        Me.margarita = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hotnSpicy = New System.Windows.Forms.RadioButton()
        Me.meatFeast = New System.Windows.Forms.RadioButton()
        Me.pepperoni = New System.Windows.Forms.RadioButton()
        Me.hawaiian = New System.Windows.Forms.RadioButton()
        Me.veggie = New System.Windows.Forms.RadioButton()
        Me.resetDiscount = New System.Windows.Forms.Button()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.addressBox = New System.Windows.Forms.TextBox()
        Me.unlockButton = New System.Windows.Forms.Button()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.timeUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.helpButton = New System.Windows.Forms.Button()
        Me.discountLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PizzaSize = New System.Windows.Forms.ComboBox()
        Me.CrustType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pizzaSizeLabel = New System.Windows.Forms.Label()
        Me.crustTypeLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.toppingsBox = New System.Windows.Forms.CheckedListBox()
        Me.toppingsLbl = New System.Windows.Forms.Label()
        Me.phoneInput = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nameInput
        '
        Me.nameInput.Location = New System.Drawing.Point(56, 66)
        Me.nameInput.Name = "nameInput"
        Me.nameInput.Size = New System.Drawing.Size(100, 20)
        Me.nameInput.TabIndex = 0
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.BackColor = System.Drawing.Color.Transparent
        Me.nameLabel.Location = New System.Drawing.Point(12, 69)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(38, 13)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "Name:"
        '
        'enterButton
        '
        Me.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterButton.Location = New System.Drawing.Point(160, 77)
        Me.enterButton.Name = "enterButton"
        Me.enterButton.Size = New System.Drawing.Size(60, 22)
        Me.enterButton.TabIndex = 2
        Me.enterButton.Text = "Enter"
        Me.enterButton.UseVisualStyleBackColor = True
        '
        'purchaseButton
        '
        Me.purchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.purchaseButton.Location = New System.Drawing.Point(56, 136)
        Me.purchaseButton.Name = "purchaseButton"
        Me.purchaseButton.Size = New System.Drawing.Size(75, 23)
        Me.purchaseButton.TabIndex = 3
        Me.purchaseButton.Text = "Print"
        Me.purchaseButton.UseVisualStyleBackColor = True
        '
        'cashOverCounter
        '
        Me.cashOverCounter.AutoSize = True
        Me.cashOverCounter.BackColor = System.Drawing.Color.Transparent
        Me.cashOverCounter.ForeColor = System.Drawing.Color.Black
        Me.cashOverCounter.Location = New System.Drawing.Point(432, 207)
        Me.cashOverCounter.Name = "cashOverCounter"
        Me.cashOverCounter.Size = New System.Drawing.Size(113, 17)
        Me.cashOverCounter.TabIndex = 4
        Me.cashOverCounter.Text = "Cash over counter"
        Me.cashOverCounter.UseVisualStyleBackColor = False
        '
        'cashForDelivery
        '
        Me.cashForDelivery.AutoSize = True
        Me.cashForDelivery.BackColor = System.Drawing.Color.Transparent
        Me.cashForDelivery.ForeColor = System.Drawing.Color.Black
        Me.cashForDelivery.Location = New System.Drawing.Point(432, 230)
        Me.cashForDelivery.Name = "cashForDelivery"
        Me.cashForDelivery.Size = New System.Drawing.Size(104, 17)
        Me.cashForDelivery.TabIndex = 5
        Me.cashForDelivery.Text = "Cash for delivery"
        Me.cashForDelivery.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cost:"
        '
        'calculatedCost
        '
        Me.calculatedCost.AutoSize = True
        Me.calculatedCost.BackColor = System.Drawing.Color.Transparent
        Me.calculatedCost.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculatedCost.Location = New System.Drawing.Point(86, 30)
        Me.calculatedCost.Name = "calculatedCost"
        Me.calculatedCost.Size = New System.Drawing.Size(49, 21)
        Me.calculatedCost.TabIndex = 7
        Me.calculatedCost.Text = "£0.00"
        '
        'applyDiscount
        '
        Me.applyDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.applyDiscount.Location = New System.Drawing.Point(444, 108)
        Me.applyDiscount.Name = "applyDiscount"
        Me.applyDiscount.Size = New System.Drawing.Size(91, 23)
        Me.applyDiscount.TabIndex = 8
        Me.applyDiscount.Text = "Apply Discount"
        Me.applyDiscount.UseVisualStyleBackColor = True
        '
        'discountComboBox
        '
        Me.discountComboBox.FormattingEnabled = True
        Me.discountComboBox.Items.AddRange(New Object() {"£1.00", "£2.00", "£3.00", "£4.00", "£5.00"})
        Me.discountComboBox.Location = New System.Drawing.Point(444, 81)
        Me.discountComboBox.Name = "discountComboBox"
        Me.discountComboBox.Size = New System.Drawing.Size(91, 21)
        Me.discountComboBox.TabIndex = 9
        '
        'margarita
        '
        Me.margarita.AutoSize = True
        Me.margarita.BackColor = System.Drawing.Color.Transparent
        Me.margarita.ForeColor = System.Drawing.Color.Black
        Me.margarita.Location = New System.Drawing.Point(15, 184)
        Me.margarita.Name = "margarita"
        Me.margarita.Size = New System.Drawing.Size(111, 17)
        Me.margarita.TabIndex = 10
        Me.margarita.TabStop = True
        Me.margarita.Text = "Margarita - £12.99"
        Me.margarita.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(432, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cash"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Pizza Type"
        '
        'hotnSpicy
        '
        Me.hotnSpicy.AutoSize = True
        Me.hotnSpicy.BackColor = System.Drawing.Color.Transparent
        Me.hotnSpicy.ForeColor = System.Drawing.Color.Black
        Me.hotnSpicy.Location = New System.Drawing.Point(15, 207)
        Me.hotnSpicy.Name = "hotnSpicy"
        Me.hotnSpicy.Size = New System.Drawing.Size(120, 17)
        Me.hotnSpicy.TabIndex = 10
        Me.hotnSpicy.TabStop = True
        Me.hotnSpicy.Text = "Hot-n-spicy - £15.99"
        Me.hotnSpicy.UseVisualStyleBackColor = False
        '
        'meatFeast
        '
        Me.meatFeast.AutoSize = True
        Me.meatFeast.BackColor = System.Drawing.Color.Transparent
        Me.meatFeast.ForeColor = System.Drawing.Color.Black
        Me.meatFeast.Location = New System.Drawing.Point(15, 230)
        Me.meatFeast.Name = "meatFeast"
        Me.meatFeast.Size = New System.Drawing.Size(120, 17)
        Me.meatFeast.TabIndex = 10
        Me.meatFeast.TabStop = True
        Me.meatFeast.Text = "Meat Feast - £17.19"
        Me.meatFeast.UseVisualStyleBackColor = False
        '
        'pepperoni
        '
        Me.pepperoni.AutoSize = True
        Me.pepperoni.BackColor = System.Drawing.Color.Transparent
        Me.pepperoni.ForeColor = System.Drawing.Color.Black
        Me.pepperoni.Location = New System.Drawing.Point(132, 184)
        Me.pepperoni.Name = "pepperoni"
        Me.pepperoni.Size = New System.Drawing.Size(115, 17)
        Me.pepperoni.TabIndex = 10
        Me.pepperoni.TabStop = True
        Me.pepperoni.Text = "Pepperoni - £16.99"
        Me.pepperoni.UseVisualStyleBackColor = False
        '
        'hawaiian
        '
        Me.hawaiian.AutoSize = True
        Me.hawaiian.BackColor = System.Drawing.Color.Transparent
        Me.hawaiian.ForeColor = System.Drawing.Color.Black
        Me.hawaiian.Location = New System.Drawing.Point(132, 207)
        Me.hawaiian.Name = "hawaiian"
        Me.hawaiian.Size = New System.Drawing.Size(111, 17)
        Me.hawaiian.TabIndex = 10
        Me.hawaiian.TabStop = True
        Me.hawaiian.Text = "Hawaiian - £15.49"
        Me.hawaiian.UseVisualStyleBackColor = False
        '
        'veggie
        '
        Me.veggie.AutoSize = True
        Me.veggie.BackColor = System.Drawing.Color.Transparent
        Me.veggie.ForeColor = System.Drawing.Color.Black
        Me.veggie.Location = New System.Drawing.Point(132, 230)
        Me.veggie.Name = "veggie"
        Me.veggie.Size = New System.Drawing.Size(100, 17)
        Me.veggie.TabIndex = 10
        Me.veggie.TabStop = True
        Me.veggie.Text = "Veggie - £16.19"
        Me.veggie.UseVisualStyleBackColor = False
        '
        'resetDiscount
        '
        Me.resetDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetDiscount.Location = New System.Drawing.Point(444, 137)
        Me.resetDiscount.Name = "resetDiscount"
        Me.resetDiscount.Size = New System.Drawing.Size(91, 23)
        Me.resetDiscount.TabIndex = 8
        Me.resetDiscount.Text = "Reset Discount"
        Me.resetDiscount.UseVisualStyleBackColor = True
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.BackColor = System.Drawing.Color.Transparent
        Me.addressLabel.Enabled = False
        Me.addressLabel.Location = New System.Drawing.Point(2, 91)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(48, 13)
        Me.addressLabel.TabIndex = 1
        Me.addressLabel.Text = "Address:"
        '
        'addressBox
        '
        Me.addressBox.Enabled = False
        Me.addressBox.Location = New System.Drawing.Point(56, 88)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(100, 20)
        Me.addressBox.TabIndex = 0
        '
        'unlockButton
        '
        Me.unlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.unlockButton.Location = New System.Drawing.Point(444, 7)
        Me.unlockButton.Name = "unlockButton"
        Me.unlockButton.Size = New System.Drawing.Size(91, 23)
        Me.unlockButton.TabIndex = 3
        Me.unlockButton.Text = "Unlock"
        Me.unlockButton.UseVisualStyleBackColor = True
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.BackColor = System.Drawing.Color.Transparent
        Me.dateLabel.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.Location = New System.Drawing.Point(189, 9)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(72, 19)
        Me.dateLabel.TabIndex = 12
        Me.dateLabel.Text = "date /null/"
        '
        'timeUpdate
        '
        Me.timeUpdate.Enabled = True
        Me.timeUpdate.Interval = 50
        '
        'helpButton
        '
        Me.helpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.helpButton.Location = New System.Drawing.Point(5, 7)
        Me.helpButton.Name = "helpButton"
        Me.helpButton.Size = New System.Drawing.Size(25, 23)
        Me.helpButton.TabIndex = 13
        Me.helpButton.Text = "?"
        Me.helpButton.UseVisualStyleBackColor = True
        '
        'discountLabel
        '
        Me.discountLabel.AutoSize = True
        Me.discountLabel.BackColor = System.Drawing.Color.Transparent
        Me.discountLabel.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountLabel.Location = New System.Drawing.Point(141, 35)
        Me.discountLabel.Name = "discountLabel"
        Me.discountLabel.Size = New System.Drawing.Size(37, 15)
        Me.discountLabel.TabIndex = 12
        Me.discountLabel.Text = "/null/"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(5, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 83)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'PizzaSize
        '
        Me.PizzaSize.FormattingEnabled = True
        Me.PizzaSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.PizzaSize.Location = New System.Drawing.Point(276, 184)
        Me.PizzaSize.Name = "PizzaSize"
        Me.PizzaSize.Size = New System.Drawing.Size(121, 21)
        Me.PizzaSize.TabIndex = 15
        '
        'CrustType
        '
        Me.CrustType.FormattingEnabled = True
        Me.CrustType.Items.AddRange(New Object() {"Thin Base", "Stonebaked", "Stuffed Crust"})
        Me.CrustType.Location = New System.Drawing.Point(276, 228)
        Me.CrustType.Name = "CrustType"
        Me.CrustType.Size = New System.Drawing.Size(121, 21)
        Me.CrustType.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(273, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Pizza Size"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(273, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Crust Type"
        '
        'pizzaSizeLabel
        '
        Me.pizzaSizeLabel.AutoSize = True
        Me.pizzaSizeLabel.BackColor = System.Drawing.Color.Transparent
        Me.pizzaSizeLabel.Location = New System.Drawing.Point(399, 188)
        Me.pizzaSizeLabel.Name = "pizzaSizeLabel"
        Me.pizzaSizeLabel.Size = New System.Drawing.Size(0, 13)
        Me.pizzaSizeLabel.TabIndex = 16
        '
        'crustTypeLabel
        '
        Me.crustTypeLabel.AutoSize = True
        Me.crustTypeLabel.BackColor = System.Drawing.Color.Transparent
        Me.crustTypeLabel.Location = New System.Drawing.Point(401, 232)
        Me.crustTypeLabel.Name = "crustTypeLabel"
        Me.crustTypeLabel.Size = New System.Drawing.Size(0, 13)
        Me.crustTypeLabel.TabIndex = 17
        '
        'ResetButton
        '
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Location = New System.Drawing.Point(444, 35)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(91, 23)
        Me.ResetButton.TabIndex = 18
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'toppingsBox
        '
        Me.toppingsBox.BackColor = System.Drawing.SystemColors.Window
        Me.toppingsBox.FormattingEnabled = True
        Me.toppingsBox.Items.AddRange(New Object() {"Extra Cheese", "Olives", "Pepperoni", "Mushrooms", "Ham", "Anchovies"})
        Me.toppingsBox.Location = New System.Drawing.Point(276, 67)
        Me.toppingsBox.Name = "toppingsBox"
        Me.toppingsBox.Size = New System.Drawing.Size(125, 94)
        Me.toppingsBox.TabIndex = 19
        '
        'toppingsLbl
        '
        Me.toppingsLbl.AutoSize = True
        Me.toppingsLbl.BackColor = System.Drawing.Color.Transparent
        Me.toppingsLbl.Location = New System.Drawing.Point(276, 50)
        Me.toppingsLbl.Name = "toppingsLbl"
        Me.toppingsLbl.Size = New System.Drawing.Size(51, 13)
        Me.toppingsLbl.TabIndex = 11
        Me.toppingsLbl.Text = "Toppings"
        '
        'phoneInput
        '
        Me.phoneInput.Location = New System.Drawing.Point(56, 110)
        Me.phoneInput.Name = "phoneInput"
        Me.phoneInput.Size = New System.Drawing.Size(100, 20)
        Me.phoneInput.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(8, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Phone:"
        '
        'OrderScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(547, 263)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.phoneInput)
        Me.Controls.Add(Me.toppingsBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.crustTypeLabel)
        Me.Controls.Add(Me.pizzaSizeLabel)
        Me.Controls.Add(Me.CrustType)
        Me.Controls.Add(Me.PizzaSize)
        Me.Controls.Add(Me.helpButton)
        Me.Controls.Add(Me.discountLabel)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.toppingsLbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.veggie)
        Me.Controls.Add(Me.hawaiian)
        Me.Controls.Add(Me.pepperoni)
        Me.Controls.Add(Me.meatFeast)
        Me.Controls.Add(Me.hotnSpicy)
        Me.Controls.Add(Me.margarita)
        Me.Controls.Add(Me.discountComboBox)
        Me.Controls.Add(Me.resetDiscount)
        Me.Controls.Add(Me.applyDiscount)
        Me.Controls.Add(Me.calculatedCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cashForDelivery)
        Me.Controls.Add(Me.cashOverCounter)
        Me.Controls.Add(Me.unlockButton)
        Me.Controls.Add(Me.purchaseButton)
        Me.Controls.Add(Me.enterButton)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.nameInput)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OrderScreen"
        Me.Text = "Order System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameInput As System.Windows.Forms.TextBox
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents enterButton As System.Windows.Forms.Button
    Friend WithEvents purchaseButton As System.Windows.Forms.Button
    Friend WithEvents cashOverCounter As System.Windows.Forms.CheckBox
    Friend WithEvents cashForDelivery As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents calculatedCost As System.Windows.Forms.Label
    Friend WithEvents applyDiscount As System.Windows.Forms.Button
    Friend WithEvents discountComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents margarita As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents hotnSpicy As System.Windows.Forms.RadioButton
    Friend WithEvents meatFeast As System.Windows.Forms.RadioButton
    Friend WithEvents pepperoni As System.Windows.Forms.RadioButton
    Friend WithEvents hawaiian As System.Windows.Forms.RadioButton
    Friend WithEvents veggie As System.Windows.Forms.RadioButton
    Friend WithEvents resetDiscount As System.Windows.Forms.Button
    Friend WithEvents addressLabel As System.Windows.Forms.Label
    Friend WithEvents addressBox As System.Windows.Forms.TextBox
    Friend WithEvents unlockButton As System.Windows.Forms.Button
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents timeUpdate As System.Windows.Forms.Timer
    Friend WithEvents helpButton As System.Windows.Forms.Button
    Friend WithEvents discountLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PizzaSize As System.Windows.Forms.ComboBox
    Friend WithEvents CrustType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pizzaSizeLabel As System.Windows.Forms.Label
    Friend WithEvents crustTypeLabel As System.Windows.Forms.Label
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents toppingsBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents toppingsLbl As System.Windows.Forms.Label
    Friend WithEvents phoneInput As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
