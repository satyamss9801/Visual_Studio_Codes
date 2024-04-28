Imports System.Console
Module Module1

    Sub Main()
        Dim q As Integer
        Dim cname As String
        Dim ta, da, pa As Single

        cname = InputBox("ENTER CUSTOMER NAME")
        q = InputBox("ENTER QUANTITY OF PRODUCT")
        ta = q * 100
        If (ta > 1000) Then
            da = ta / 10
        Else
            da = 0

        End If

        pa = ta - da
        WriteLine("*******************************BILL*********************************")
        WriteLine("NAME OF CUSTOMER=" & cname)
        WriteLine("PRODUCT QUANTITY=" & q)
        WriteLine("TOTAL AMOUNT=" & ta)
        WriteLine("DISCOUNT AMOUNT=" & da)
        WriteLine("___________________________________________________________________")
        WriteLine(" TOTAL PAYABLE AMOUNT =  " & pa & ".RS")
        ReadKey()


    End Sub

End Module
