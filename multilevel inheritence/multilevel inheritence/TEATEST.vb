Public Class TEATEST
    Dim teaprice As Integer = 7
    Function getteabill(qty As Integer) As Single
        Return qty * teaprice
    End Function

End Class

Class COFFEETEST : Inherits TEATEST
    Dim coffeeprice As Single = 25.5

    Function getcoffeebill(qty As Integer) As Single
        Return qty * coffeeprice

    End Function

    Function getsamoshabill(qty As Integer) As Single
        Dim samoshaprice = 7
        Return qty * samoshaprice
    End Function

    Function getmomobill(qty As Integer) As Single
        Dim momoprice = 40
        Return qty * momoprice

    End Function
End Class

Class BILLTEST : Inherits COFFEETEST
    Function calculatebill(m As Integer, q As Integer) As Single
        Dim res As Single
        If (m = 0) Then
            res = getteabill(q)
        ElseIf m = 1 Then
            res = getcoffeebill(q)
        ElseIf m = 2 Then
            res = getsamoshabill(q)
        ElseIf m = 3 Then
            res = getmomobill(q)


        End If
        Return res

    End Function
End Class
