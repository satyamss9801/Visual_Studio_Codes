Imports System.Console
Module Module1

    Sub Main()
        Dim cid As Integer
        Dim cname As String
        Dim unit As Single
        Dim price As Single = 7

        WriteLine("ENTER CONSUMER ID ")
        cid = ReadLine()
        WriteLine("ENTER CONSUMER NAME")
        cname = ReadLine()
        WriteLine("ENTER unit")
        unit = ReadLine()

        WriteLine("********************BILL**********************")
        WriteLine("________________________________________________")
        WriteLine("CONSUMER ID =" & cid)
        WriteLine("CONSUMER NAME=" & cname)
        WriteLine("price per unit= " & price)
        WriteLine("PAYABLE AMOUNT= " & (unit * price))

        ReadKey()

    End Sub

End Module
