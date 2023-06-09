<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prices))
        Me.margaritaPrice = New System.Windows.Forms.TextBox()
        Me.spicyPrice = New System.Windows.Forms.TextBox()
        Me.pepperoniPrice = New System.Windows.Forms.TextBox()
        Me.feastPrice = New System.Windows.Forms.TextBox()
        Me.wainPrice = New System.Windows.Forms.TextBox()
        Me.veggiePrice = New System.Windows.Forms.TextBox()
        Me.margarita = New System.Windows.Forms.Label()
        Me.pepperoni = New System.Windows.Forms.Label()
        Me.hotnspicy = New System.Windows.Forms.Label()
        Me.hawaiian = New System.Windows.Forms.Label()
        Me.meatfeast = New System.Windows.Forms.Label()
        Me.veggie = New System.Windows.Forms.Label()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'margaritaPrice
        '
        Me.margaritaPrice.Location = New System.Drawing.Point(127, 12)
        Me.margaritaPrice.Name = "margaritaPrice"
        Me.margaritaPrice.Size = New System.Drawing.Size(100, 20)
        Me.margaritaPrice.TabIndex = 0
        '
        'spicyPrice
        '
        Me.spicyPrice.Location = New System.Drawing.Point(127, 144)
        Me.spicyPrice.Name = "spicyPrice"
        Me.spicyPrice.Size = New System.Drawing.Size(100, 20)
        Me.spicyPrice.TabIndex = 0
        '
        'pepperoniPrice
        '
        Me.pepperoniPrice.Location = New System.Drawing.Point(127, 78)
        Me.pepperoniPrice.Name = "pepperoniPrice"
        Me.pepperoniPrice.Size = New System.Drawing.Size(100, 20)
        Me.pepperoniPrice.TabIndex = 0
        '
        'feastPrice
        '
        Me.feastPrice.Location = New System.Drawing.Point(391, 78)
        Me.feastPrice.Name = "feastPrice"
        Me.feastPrice.Size = New System.Drawing.Size(100, 20)
        Me.feastPrice.TabIndex = 1
        '
        'wainPrice
        '
        Me.wainPrice.Location = New System.Drawing.Point(391, 12)
        Me.wainPrice.Name = "wainPrice"
        Me.wainPrice.Size = New System.Drawing.Size(100, 20)
        Me.wainPrice.TabIndex = 0
        '
        'veggiePrice
        '
        Me.veggiePrice.Location = New System.Drawing.Point(391, 144)
        Me.veggiePrice.Name = "veggiePrice"
        Me.veggiePrice.Size = New System.Drawing.Size(100, 20)
        Me.veggiePrice.TabIndex = 0
        '
        'margarita
        '
        Me.margarita.AutoSize = True
        Me.margarita.Location = New System.Drawing.Point(48, 15)
        Me.margarita.Name = "margarita"
        Me.margarita.Size = New System.Drawing.Size(51, 13)
        Me.margarita.TabIndex = 2
        Me.margarita.Text = "Margarita"
        '
        'pepperoni
        '
        Me.pepperoni.AutoSize = True
        Me.pepperoni.Location = New System.Drawing.Point(48, 81)
        Me.pepperoni.Name = "pepperoni"
        Me.pepperoni.Size = New System.Drawing.Size(55, 13)
        Me.pepperoni.TabIndex = 2
        Me.pepperoni.Text = "Pepperoni"
        '
        'hotnspicy
        '
        Me.hotnspicy.AutoSize = True
        Me.hotnspicy.Location = New System.Drawing.Point(48, 147)
        Me.hotnspicy.Name = "hotnspicy"
        Me.hotnspicy.Size = New System.Drawing.Size(62, 13)
        Me.hotnspicy.TabIndex = 2
        Me.hotnspicy.Text = "Hot-n-Spicy"
        '
        'hawaiian
        '
        Me.hawaiian.AutoSize = True
        Me.hawaiian.Location = New System.Drawing.Point(323, 15)
        Me.hawaiian.Name = "hawaiian"
        Me.hawaiian.Size = New System.Drawing.Size(51, 13)
        Me.hawaiian.TabIndex = 2
        Me.hawaiian.Text = "Hawaiian"
        '
        'meatfeast
        '
        Me.meatfeast.AutoSize = True
        Me.meatfeast.Location = New System.Drawing.Point(323, 81)
        Me.meatfeast.Name = "meatfeast"
        Me.meatfeast.Size = New System.Drawing.Size(60, 13)
        Me.meatfeast.TabIndex = 2
        Me.meatfeast.Text = "Meat Feast"
        '
        'veggie
        '
        Me.veggie.AutoSize = True
        Me.veggie.Location = New System.Drawing.Point(334, 147)
        Me.veggie.Name = "veggie"
        Me.veggie.Size = New System.Drawing.Size(40, 13)
        Me.veggie.TabIndex = 2
        Me.veggie.Text = "Veggie"
        '
        'saveButton
        '
        Me.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveButton.Location = New System.Drawing.Point(337, 172)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(154, 23)
        Me.saveButton.TabIndex = 3
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'Prices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 207)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.veggie)
        Me.Controls.Add(Me.meatfeast)
        Me.Controls.Add(Me.hawaiian)
        Me.Controls.Add(Me.hotnspicy)
        Me.Controls.Add(Me.pepperoni)
        Me.Controls.Add(Me.margarita)
        Me.Controls.Add(Me.feastPrice)
        Me.Controls.Add(Me.pepperoniPrice)
        Me.Controls.Add(Me.veggiePrice)
        Me.Controls.Add(Me.spicyPrice)
        Me.Controls.Add(Me.wainPrice)
        Me.Controls.Add(Me.margaritaPrice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Prices"
        Me.Text = "Prices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents margaritaPrice As System.Windows.Forms.TextBox
    Friend WithEvents spicyPrice As System.Windows.Forms.TextBox
    Friend WithEvents pepperoniPrice As System.Windows.Forms.TextBox
    Friend WithEvents feastPrice As System.Windows.Forms.TextBox
    Friend WithEvents wainPrice As System.Windows.Forms.TextBox
    Friend WithEvents veggiePrice As System.Windows.Forms.TextBox
    Friend WithEvents margarita As System.Windows.Forms.Label
    Friend WithEvents pepperoni As System.Windows.Forms.Label
    Friend WithEvents hotnspicy As System.Windows.Forms.Label
    Friend WithEvents hawaiian As System.Windows.Forms.Label
    Friend WithEvents meatfeast As System.Windows.Forms.Label
    Friend WithEvents veggie As System.Windows.Forms.Label
    Friend WithEvents saveButton As System.Windows.Forms.Button
End Class
