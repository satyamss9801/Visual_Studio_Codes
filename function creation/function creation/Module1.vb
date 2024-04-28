Imports System.Console
Module Module1
    Class totalcount

        Sub coun(ByVal num As Single, ByVal num2 As Single)

            If (num > num2) Then
                WriteLine("greater number Is =" & num)
            Else
                WriteLine("greater number is =" & num2)
            End If

        End Sub

      
    End Class

    Sub Main()
        Dim obj As New totalcount
        Dim num, num2 As Single
        num = InputBox("ENTER VALUE")
        num2 = InputBox("ENTER VALUE 2")
        obj.coun(num, num2)
        ReadKey()


    End Sub

End Module
