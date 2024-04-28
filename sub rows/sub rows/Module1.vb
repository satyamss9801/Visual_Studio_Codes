Imports System.Console
Module Module1

    Sub Main()
        Dim num(1, 1, 2) As Integer
        Dim row, srow, cols As Integer

        For row = 0 To 1
            For srow = 0 To 1
                For cols = 0 To 2
                    WriteLine("ENTER ELEMENT")
                    num(row, srow, cols) = ReadLine()

                Next
            Next
        Next
        WriteLine()

        For row = 0 To 1
            For srow = 0 To 1
                For cols = 0 To 2
                    Write(num(row, srow, cols) & "  ")


                Next
                WriteLine()

            Next
            WriteLine(vbNewLine)

        Next
        ReadLine()

    End Sub

End Module
