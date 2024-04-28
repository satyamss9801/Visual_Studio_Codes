Public Class Form1

    Dim qty As Integer
    Dim prc As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        qty = Val(TextBox1.Text)
        prc = Val(TextBox2.Text)

        Dim t As New TEST
        t.showbill(qty, prc)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        qty = Val(TextBox1.Text)
        prc = Val(TextBox2.Text)

        Dim r As New TEST
        r.showbillc(qty, prc)
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class

Class TEST : Inherits calculatebill
    Dim res As Integer

    Sub showbill(ByVal q As Integer, ByVal p As Single)
        res = getteabill(q, p)
        Form1.Label4.Text = " YOUR TOTAL TEA BILL  IS:- " & res
    End Sub

    Sub showbillc(ByVal q As Integer, p As Single)
        res = getcoffeebill(q, p)
        Form1.Label4.Text = "YOUR TOTAL COFFEE BILL IS:-" & res
    End Sub

    Sub showbilld(ByVal q As Integer, p As Single)
        res = getsamoshabill(q, p)
        Form1.Label4.Text = "YOUR TOTAL SAMOSHA BILL IS:-" & res
    End Sub
    Sub showbille(ByVal q As Integer, p As Single)
        res = getmomobill(q, p)
        Form1.Label4.Text = "YOUR TOTAL MOMO BILL IS:-" & res
    End Sub


End Class


