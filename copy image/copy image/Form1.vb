Imports System.IO
Public Class Form1
    Dim path As String = "D:\"




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        OpenFileDialog1.ShowDialog()

        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Name = OpenFileDialog1.FileName

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim dfile As String = TextBox1.Text
            File.Copy(Name, dfile)
            MsgBox("file copy successfully" + dfile)

        Catch ex As Exception
            MsgBox("Please enter the destination path first " + ex.ToString)

        Finally

        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
