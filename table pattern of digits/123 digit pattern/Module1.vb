Imports System.Console
Module Module1

    Sub Main()
        Dim i, j, k As Integer
        k = 0

        For i = 1 To 5
            For j = 1 To i
                k = (i + 1) * j
                Write(k & "  ")
            Next
            WriteLine()

        Next
        ReadKey()
    End Sub

End Module
