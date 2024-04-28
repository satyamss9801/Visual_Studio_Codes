Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i As Integer
        Dim fact As Single

        fact = 1
        n = Val(TextBox1.Text)
        For i = 1 To n
            fact = fact * i
        Next
        Label3.Text = fact
    End Sub
End Class
