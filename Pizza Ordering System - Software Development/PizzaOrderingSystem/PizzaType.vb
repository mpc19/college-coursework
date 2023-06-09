Public Class PizzaType

    Public Shared NONE As Double = 0.0
    Public Shared MARGARITA As Double = 12.99
    Public Shared PEPPERONI As Double = 16.99
    Public Shared HOTNSPICY As Double = 15.99
    Public Shared HAWAIIAN As Double = 15.49
    Public Shared MEATFEAST As Double = 17.19
    Public Shared VEGGIE As Double = 16.19

    Public Shared Function matchPrice(ByVal price As Double) As String
        If (price = NONE) Then
            Return "None"
        ElseIf (price = MARGARITA) Then
            Return "Margarita"
        ElseIf (price = PEPPERONI) Then
            Return "Pepperoni"
        ElseIf (price = HOTNSPICY) Then
            Return "Hot `n` spicy"
        ElseIf (price = HAWAIIAN) Then
            Return "Hawaiian"
        ElseIf (price = MEATFEAST) Then
            Return "Meatfeast"
        ElseIf (price = VEGGIE) Then
            Return "Veggie"
        End If
        Return "None"
    End Function

End Class
