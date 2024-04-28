Imports System.Console
Module Module1
    Sub addval(ByVal ParamArray arr() As Integer)
        Dim res As Integer
        For Each num As Integer In arr
            res = res + num
        Next
        MsgBox("addition = " & res)
    End Sub


    Sub Main()
        addval(5, 6, 9)
        ReadKey()
    End Sub

End Module
