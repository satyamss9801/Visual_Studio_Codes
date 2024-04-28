Imports System.IO
Public Class Form1
    Dim sfile As String = "D:\vbfile\myfile.txt"
    Dim dname As String
    Dim dpath As String = "D:\"
    Dim finfo As New FileInfo(sfile)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dfile As String = TextBox2.Text

            File.Create(sfile)
            MsgBox("file is created at " + sfile)

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim dfile As String = TextBox2.Text

            File.AppendAllText(sfile, RichTextBox1.Text)
            MsgBox("text added to file ")

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            Dim dfile As String = TextBox2.Text
            File.Copy(sfile, dfile)
            MsgBox("file copy successfully" + dfile)

        Catch ex As Exception
            MsgBox("Please enter the destination path first " + ex.ToString)

        Finally

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim dfile As String = TextBox2.Text

            File.Move(sfile, dfile)
            MsgBox("FILE MOVED to " + dfile)

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim dfile As String = TextBox2.Text

            File.Delete("D:\vbfile\myfile.txt")
            MsgBox("file deleted")

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim dfile As String = TextBox2.Text

            RichTextBox1.Text = File.ReadAllText(sfile)

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally

        End Try
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = finfo.FullName

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = finfo.DirectoryName
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = finfo.Extension

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = finfo.Name

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = finfo.LastAccessTime

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = finfo.LastWriteTime

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = finfo.Length


    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
