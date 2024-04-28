Imports System.Console
Module Module1
    Interface ITEST
        Function getvalue() As Integer
        Sub showvalue(ByVal n As Integer)
    End Interface
    Class TEST : Implements ITEST

        Public Function getvalue() As Integer Implements ITEST.getvalue
            Dim s As Integer
            s = InputBox("ENTER ANY NUMBER")
            Return s * s
        End Function

        Public Sub showvalue(n As Integer) Implements ITEST.showvalue
            WriteLine(" value is " & n)
        End Sub
    End Class
    Sub Main()
        Dim obj As New TEST
        Dim s As Integer
        s = obj.getvalue()
        obj.showvalue(s)
        ReadKey()

    End Sub

End Module
