Imports System.Console
Module Module1

    MustInherit Class ABSTEST

        MustOverride Function showresult() As Integer
        MustOverride Sub cube(m As Integer)
    End Class

    Class TEST : Inherits ABSTEST
        Dim n As Integer
        Public Overrides Function showresult() As Integer
            Return n * n
        End Function
        Public Overrides Sub cube(m As Integer)
            WriteLine(m * m * m)
        End Sub


        Sub getvalue(n As Integer)
            Me.n = n
        End Sub
    End Class
    Sub main()
        Dim obj As New TEST
        obj.getvalue(5)
        WriteLine(obj.showresult)
        obj.cube(5)
        ReadKey()

    End Sub
End Module
