Imports System.Console
Module Module1
    MustInherit Class ABSNEW


        MustOverride Function showresult() As Integer
    End Class

    Class TEST : Inherits ABSNEW
        Dim n As Integer
      
        Sub getresult(n As Integer)
            WriteLine(n * n * n)

        End Sub
        Overrides Function showresult() As Integer
            Return n * n
        End Function
        Sub getvalue(n As Integer)
            Me.n = n
        End Sub

    End Class
    Sub Main()
        Dim obj As New TEST
        Dim m As Integer
        obj.getresult(5)
        m = obj.showresult()
        WriteLine(m)
        ReadKey()
    End Sub

End Module
