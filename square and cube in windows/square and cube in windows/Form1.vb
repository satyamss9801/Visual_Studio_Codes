Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Single
        Dim sq, cu As Single

        n = Val(TextBox1.Text)
        sq = n * n
        cu = n * n * n
        Label3.Text = sq
        Label5.Text = cu


    End Sub
End Class
