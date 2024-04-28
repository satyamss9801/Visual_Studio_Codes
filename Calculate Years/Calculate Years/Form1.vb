Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim doj As Date = DateTimePicker1.Text
        Dim dor As Date = DateTimePicker2.Text


        Dim nod As TimeSpan = dor.Subtract(doj)
        Dim totaldays As Integer = nod.TotalDays
        Dim yr As Single

        yr = totaldays / 365.2425
        TextBox1.Text = yr

      





    End Sub
End Class
