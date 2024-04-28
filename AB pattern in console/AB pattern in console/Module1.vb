Imports System.Console
Module Module1

    Sub Main()
        Dim i, j As Integer
        Dim k As Char

        For i = 1 To 5 Step +1
            For j = 1 To i Step +1
                k = ChrW(64 + j)

                Write(k & "  ")
            Next
            WriteLine()

        Next
        ReadKey()

    End Sub


End Module
