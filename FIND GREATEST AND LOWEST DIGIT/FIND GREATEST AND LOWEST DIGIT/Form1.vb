Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim x, y As Integer
        Dim g, s As Integer
        y = 0
        n = Val(TextBox1.Text)
        While (n <> 0)
            x = n Mod 10
            n = n / 10

            If (x >= y) Then
                g = x

            Else
                g = y

            End If
            y = x
            x = 0
        End While

        Label4.Text = g
        Label5.Text = s
    End Sub
End Class
