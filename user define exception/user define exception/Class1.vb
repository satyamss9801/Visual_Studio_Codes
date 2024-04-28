Public Class Class1
    Class voteexception : Inherits ApplicationException
        Sub New()
            MsgBox("ERROR OCCURED")

        End Sub

        Sub New(ByVal msg As String)
            MsgBox("ERROR" & msg)

        End Sub
    End Class
End Class
