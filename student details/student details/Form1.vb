Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim roll(9) As String
        Dim name(9) As String


        roll(0) = TextBox1.Text
        roll(1) = TextBox2.Text
        roll(2) = TextBox3.Text
        roll(3) = TextBox4.Text
        roll(4) = TextBox5.Text
        roll(5) = TextBox6.Text
        roll(6) = TextBox7.Text
        roll(7) = TextBox8.Text
        roll(8) = TextBox9.Text
        roll(9) = TextBox10.Text


        name(0) = TextBox11.Text
        name(1) = TextBox12.Text
        name(2) = TextBox13.Text
        name(3) = TextBox14.Text
        name(4) = TextBox15.Text
        name(5) = TextBox16.Text
        name(6) = TextBox17.Text
        name(7) = TextBox18.Text
        name(8) = TextBox19.Text
        name(9) = TextBox20.Text
       
        For Each st In roll
            RichTextBox1.Text += st + "  " + vbNewLine
        Next
        For Each St In name
            RichTextBox2.Text += St + "  " + vbNewLine
        Next

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
