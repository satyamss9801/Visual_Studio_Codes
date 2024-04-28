Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("B.TECH")
        ComboBox1.Items.Add("M.TECH")

        ListBox1.Items.Add("BCA")
        ListBox1.Items.Add("MCA")
        ListBox1.Items.Add("BBA")
        ListBox1.Items.Add("MCA")
        ListBox1.Items.Add("B.ED")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(ComboBox1.SelectedItem)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Add(ListBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ListBox2.Items.Remove(ListBox2.SelectedItem.ToString)

        Catch ex As Exception

        End Try


    End Sub
End Class
