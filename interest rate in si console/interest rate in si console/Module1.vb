Imports System.Console
Module Module1

    Sub Main()
        Dim p, r, t As Single
        Dim si As VariantType

        WriteLine("ENTER PRINCIPLE VALUE")
        p = ReadLine()
        WriteLine("ENTER RATE OF INTEREST")
        r = ReadLine()
        WriteLine("ENTER TIME")
        t = ReadLine()

        si = (p * r * t) / 100
        WriteLine("SIMPLE INTEREST  = " & si)

        ReadKey()


    End Sub

End Module
