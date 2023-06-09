Public Class HelpScreen

    ' I wanted to add changing of prices
    ' But I only ended up adding a open orders button which should always open.

    Public Sub enable(ByVal bool As Boolean)

    End Sub

    Private Sub HelpScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub priceChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim price As Prices = New Prices()
        price.loadPrices()
        price.Show()
    End Sub

    Private Sub ordersButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ordersButton.Click
        If (My.Computer.FileSystem.FileExists("orders.csv") = False) Then
            LogFile.AppendLineToLog("orders.csv", "")
        End If
        Process.Start("orders.csv")
    End Sub
End Class