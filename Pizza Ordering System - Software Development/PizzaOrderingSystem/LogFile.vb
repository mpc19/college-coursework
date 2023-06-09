''''''''''''''''''''''''''''''''''''''''
' A module to append strings to log file.
' Written by Chris Surawy, September 2009.
' CopyRight (c) Surawy, 2009.
'
' Use: AppendLineToLog( "C:\Log.txt", "string you want to save" )
'
' If the string you want to save has data fields separated by commas,
' then the resulting file can be imported into Microsoft Excel for calculations.
'
''''''''''''''''''''''''''''''''''''''''
Imports System.IO

Module LogFile

    ''''''''''''''''''''''''''''''''''''''''
    ' AppendLineToLog
    ' Given a filename and a PIN number, this appends the given string on the end of the file.
    ''''''''''''''''''''''''''''''''''''''''
    Public Sub AppendLineToLog(ByRef FullPath As String, ByVal strLine As String)
        Dim objWriter As StreamWriter = New StreamWriter(FullPath, True)  ' True is append to end of file, false would be overwrite.

        objWriter.Write(strLine)
        objWriter.WriteLine()

        objWriter.Close()
    End Sub

End Module