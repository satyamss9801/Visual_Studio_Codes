Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(DateTimePicker1.Text)
        Dim doj As Date = DateTimePicker1.Value
        Dim dor As Date = DateTimePicker2.Value


        Dim nod As TimeSpan = dor.Subtract(doj)
        Dim totalday As Integer = nod.TotalDays
        TextBox1.Text = totalday

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()

        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        TextBox2.Text = OpenFileDialog1.FileName


    End Sub
End Class
