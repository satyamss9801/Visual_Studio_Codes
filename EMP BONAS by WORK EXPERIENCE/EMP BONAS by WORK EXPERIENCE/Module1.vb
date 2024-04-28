Imports System.Console
Module Module1

    Sub Main()
        Dim s As Single
        Dim cname As String
        Dim y, ts, ba As Single

        cname = InputBox("ENTER EMPLOYEE NAME ")
        y = InputBox("ENTER WORK EXPERIENCE ")
        s = InputBox("ENTER SALARY OF EMPLOYEE")
        If (y > 4) Then
            ba = s / 100 * 5
            ts = s + ba
        Else
            ts = s
            MsgBox("SORRY,YOU ARE NOT ELIGIBLE BECAUSE YOUR WORK EXPERIENCE IS BELOW 5 YEARS")
        End If
        WriteLine("**********CONGRETULATION " & cname & "  : YOU ARTE ELIGIBLE FOR BONAS************")
        WriteLine("TOTAL WORKING YEARS:" & y)
        WriteLine("BASIC SALARY :" & s)
        WriteLine("BONAS AMOUNT :" & ba)
        WriteLine("______________________________________________________________________________")
        WriteLine("NEW SALARY :" & ts)
        ReadKey()

    End Sub

End Module
