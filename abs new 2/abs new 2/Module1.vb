Imports System.Console
Module Module1
    MustInherit Class ABSTEST
        MustOverride Function showresult() As Integer

    End Class
    Class TEST : Inherits ABSTEST
        Dim n As Integer
        Public Overrides Function showresult() As Integer
            Return n * n

        End Function
        Sub getvalue(n As Integer)
            Me.n = n
        End Sub
    End Class
    Class BAC : Inherits ABSTEST
        Dim m As Integer
        Public Overrides Function showresult() As Integer
            Return m * m * m

        End Function
        Sub getvalue(n As Integer)
            n = m
        End Sub
    End Class
    Sub Main()
        Dim obj As New BAC
        obj.getvalue(8)
        WriteLine(obj.showresult)
        ReadKey()

    End Sub

End Module
