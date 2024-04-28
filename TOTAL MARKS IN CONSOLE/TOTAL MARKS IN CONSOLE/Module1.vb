Imports System.Console
Module Module1
    Sub main()
        Dim s1, s2, s3, tm As Single
        Dim roll As Integer
        Dim name As String

        WriteLine("ENTER YOUR NAME HERE")
        name = ReadLine()
        WriteLine("ENTER YOUR ROLL")
        roll = ReadLine()
        WriteLine("ENTER THE MARKS OBTAINED IN ALL SUBJECT ONE BY ONE")
        s1 = ReadLine()
        s2 = ReadLine()
        s3 = ReadLine()
        tm = s1 + s2 + s3
        WriteLine("TOTAL MARKS=" & tm)
        If (tm < 120) Then
            WriteLine("DIVISION = FAIL")
        ElseIf (tm > 120 And tm < 150) Then
            WriteLine("DIVISION=3RD  :PASS")
        ElseIf (tm > 150 And tm < 180) Then
            WriteLine("DIVISION =2ND  :PASS")
        ElseIf (tm > 180) Then
            WriteLine("DIVISION= 1ST :PASS")
        End If
        WriteLine("PERCENTAGE OBTAINED=" & tm / 300 * 100)
        ReadKey()



    End Sub

End Module
