Imports System.Console
Module Module1

    Class desttest

        Dim roll As Integer
        Dim name As String
        Protected Overrides Sub finalize()
            MsgBox("finalize call")
        End Sub
        Sub New()
            roll = 1001
            name = "abbas"

        End Sub
        Sub showdata()
            WriteLine("roll  " & roll)
            WriteLine("name  " & name)
        End Sub
    End Class
    Sub Main()
        Dim obj As New desttest
        obj.showdata()
        ReadKey()

    End Sub

End Module
