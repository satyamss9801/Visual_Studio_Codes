Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, x As Integer
        n = Val(TextBox1.Text)
        For x = 2 To n
            If n Mod x = 0 Then
                ListBox1.Items.Add(x)

            End If
        Next


    End Sub
End Class
