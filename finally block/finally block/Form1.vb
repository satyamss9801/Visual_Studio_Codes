Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2 As Integer
        Dim res As Integer

        Try
            n1 = Val(TextBox1.Text)
            n2 = Val(TextBox2.Text)
            If (n2 = 0) Then
                Throw New DivideByZeroException
            End If
            res = n1 / n2
            Label3.Text = res
        Catch ex As DivideByZeroException

            MsgBox(" denum value can not be zero  " & ex.ToString)

        Catch ex1 As FormatException

            MsgBox("   ")

        Catch ex2 As Exception
            MsgBox("error in code")
        Finally
            MsgBox("FINALLY BLOCK EXECUTED")
        End Try


    End Sub
End Class
