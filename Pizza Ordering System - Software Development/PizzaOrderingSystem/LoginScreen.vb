Public Class LoginScreen

    ' This class was more todo with the fact I tried to add as much as I can
    ' it would hide the orderscreen until the correct details were entered.

    Dim username As String = "admin"
    Dim password As String = "password"
    Dim parentScreen As Form

    Public Sub setForm(ByVal forms As Form)
        parentScreen = forms
    End Sub

    Public Sub updateCredits(ByVal iUsername, ByVal iPassword)
        If (iUsername <> vbNullString And iPassword <> vbNullString) Then
            username = iUsername
            password = iPassword
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (usernameInput.Text.ToLower <> username.ToLower) Then
            MsgBox("Wrong username.", MsgBoxStyle.OkOnly, "Error")
            Return
        End If
        If (password.ToLower <> passwordInput.Text.ToLower) Then
            MsgBox("Wrong password.", MsgBoxStyle.OkOnly, "Error")
            Return
        End If
        Close()
        parentScreen.Opacity = 1
    End Sub

    Private Sub LoginScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        parentScreen.Opacity = 0
    End Sub
End Class