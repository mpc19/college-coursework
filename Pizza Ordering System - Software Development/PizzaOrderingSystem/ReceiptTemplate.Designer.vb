<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptTemplate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReceiptTemplate))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.driverLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.pizzaLabel = New System.Windows.Forms.Label()
        Me.costLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.deliveryLabel = New System.Windows.Forms.Label()
       ' Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.randomUUID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.toppingsLbl = New System.Windows.Forms.Label()
        Me.toppingsList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KATE'S PIZZA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dateLabel
        '
        Me.dateLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateLabel.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.Location = New System.Drawing.Point(0, 39)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(432, 19)
        Me.dateLabel.TabIndex = 0
        Me.dateLabel.Text = "07:30 24/01/19"
        Me.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Address:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Pizza Type:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cost:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'driverLabel
        '
        Me.driverLabel.AutoSize = True
        Me.driverLabel.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.driverLabel.Location = New System.Drawing.Point(31, 381)
        Me.driverLabel.Name = "driverLabel"
        Me.driverLabel.Size = New System.Drawing.Size(56, 21)
        Me.driverLabel.TabIndex = 0
        Me.driverLabel.Text = "Driver:"
        Me.driverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(85, 96)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(46, 21)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Liam"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLabel.Location = New System.Drawing.Point(98, 126)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(79, 21)
        Me.addressLabel.TabIndex = 0
        Me.addressLabel.Text = "LN13 8QA"
        Me.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pizzaLabel
        '
        Me.pizzaLabel.AutoSize = True
        Me.pizzaLabel.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pizzaLabel.Location = New System.Drawing.Point(111, 189)
        Me.pizzaLabel.Name = "pizzaLabel"
        Me.pizzaLabel.Size = New System.Drawing.Size(81, 21)
        Me.pizzaLabel.TabIndex = 0
        Me.pizzaLabel.Text = "Pepperoni"
        Me.pizzaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'costLabel
        '
        Me.costLabel.AutoSize = True
        Me.costLabel.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.costLabel.Location = New System.Drawing.Point(77, 213)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(58, 21)
        Me.costLabel.TabIndex = 0
        Me.costLabel.Text = "£18.99"
        Me.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 351)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Order Type:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'deliveryLabel
        '
        Me.deliveryLabel.AutoSize = True
        Me.deliveryLabel.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deliveryLabel.Location = New System.Drawing.Point(117, 351)
        Me.deliveryLabel.Name = "deliveryLabel"
        Me.deliveryLabel.Size = New System.Drawing.Size(104, 21)
        Me.deliveryLabel.TabIndex = 0
        Me.deliveryLabel.Text = "Over Counter"
        Me.deliveryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintForm1
        '
        'Me.PrintForm1.DocumentName = "Receipt"
        'Me.PrintForm1.Form = Me
        'Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        'Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        'Me.PrintForm1.PrintFileName = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "---------"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 430)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Order ID:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'randomUUID
        '
        Me.randomUUID.AutoSize = True
        Me.randomUUID.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.randomUUID.Location = New System.Drawing.Point(109, 323)
        Me.randomUUID.Name = "randomUUID"
        Me.randomUUID.Size = New System.Drawing.Size(0, 21)
        Me.randomUUID.TabIndex = 0
        Me.randomUUID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(30, 456)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "VAT: 20%"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 661)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Phone: 023 8043 5636"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneLabel.Location = New System.Drawing.Point(31, 153)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(0, 21)
        Me.phoneLabel.TabIndex = 0
        Me.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'toppingsLbl
        '
        Me.toppingsLbl.AutoSize = True
        Me.toppingsLbl.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toppingsLbl.Location = New System.Drawing.Point(31, 243)
        Me.toppingsLbl.Name = "toppingsLbl"
        Me.toppingsLbl.Size = New System.Drawing.Size(75, 21)
        Me.toppingsLbl.TabIndex = 1
        Me.toppingsLbl.Text = "Toppings:"
        '
        'toppingsList
        '
        Me.toppingsList.AutoSize = True
        Me.toppingsList.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toppingsList.Location = New System.Drawing.Point(107, 246)
        Me.toppingsList.Name = "toppingsList"
        Me.toppingsList.Size = New System.Drawing.Size(0, 19)
        Me.toppingsList.TabIndex = 2
        '
        'ReceiptTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(432, 691)
        Me.Controls.Add(Me.toppingsList)
        Me.Controls.Add(Me.toppingsLbl)
        Me.Controls.Add(Me.deliveryLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.randomUUID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.driverLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.costLabel)
        Me.Controls.Add(Me.pizzaLabel)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.phoneLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReceiptTemplate"
        Me.Text = "ReceiptTemplate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents driverLabel As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents addressLabel As System.Windows.Forms.Label
    Friend WithEvents pizzaLabel As System.Windows.Forms.Label
    Friend WithEvents costLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents deliveryLabel As System.Windows.Forms.Label
    ' Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents randomUUID As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents phoneLabel As System.Windows.Forms.Label
    Friend WithEvents toppingsLbl As System.Windows.Forms.Label
    Friend WithEvents toppingsList As System.Windows.Forms.Label
End Class
