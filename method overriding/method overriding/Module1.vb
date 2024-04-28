Imports System.Console
Module Module1
    Class BASE
        Overridable Function showresult(ByVal n As Single) As Single
            Return n
        End Function
    End Class

    Class SQUARE : Inherits BASE
        Public Overrides Function showresult(n As Single) As Single
            Return n * n
        End Function
    End Class

    Class cube : Inherits BASE
        Public Overrides Function showresult(n As Single) As Single
            Return n * n * n
        End Function
    End Class
    Sub main()
        Dim n As Integer
        Dim obj As New BASE
        Dim obj1 As New SQUARE
        Dim obj2 As New cube
        n = InputBox("ENTER ANY NUMBER ")
        obj.showresult(n)
        WriteLine("THE NUMBER YOU INTERED IS   " & obj.showresult(n))
        WriteLine("SQUARE OF NUMBER IS " & obj1.showresult(n))
        WriteLine("cube of number is " & obj2.showresult(n))

        ReadKey()

    End Sub
End Module
