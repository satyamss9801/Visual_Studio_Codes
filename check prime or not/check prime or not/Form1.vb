Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim i As Integer
        Dim c As Integer


        n = Val(TextBox1.Text)
        c = 0
        For i = 2 To n - 1
            If (n Mod i = 0) Then
                c = c + 1

            End If
        Next
        If (c > 0) Then
            Label2.Text = "NUMBER ENTERED IS NOT PRIME NUMBER"
        Else
            Label2.Text = "NUMBER ENTERED IS PRIME NUMBER"
        End If
    End Sub
End Class
