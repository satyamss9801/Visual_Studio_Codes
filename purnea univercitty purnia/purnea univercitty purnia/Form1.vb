Public Class Form1
    Dim n, p As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = TextBox1.Text
        p = TextBox2.Text

        If (n = "Admin" And p = "123") Then
            mainform.Show()
            Me.Hide()

        Else
            Label4.Text = "INVALID LOGIN DETAILS"
        End If
    End Sub
End Class
