Imports System.Console
Module Module1

    Sub Main()
        Dim l, b As Single

        l = InputBox("ENTER LENGTH")
        b = InputBox("ENTER BREATH")

        If (l = b) Then
            MsgBox("THIS IS A SQUARE")
        Else
            MsgBox("THIS IS NOT A SUARE")

        End If
    End Sub

End Module
