Imports System.IO
Public Class Form1
    Dim dname As String
    Dim dpath As String = "D:\"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dname = TextBox1.Text
        Directory.CreateDirectory(dpath + dname)
        MsgBox("Directory created at D:\" + dname)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dname = TextBox1.Text
        Directory.Delete(dpath + dname)
        MsgBox("FILE DELETED SUUCCESSFULLY FROM D:\" + dname)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dname = TextBox1.Text
        If Directory.Exists(dpath + dname) Then
            MsgBox("Directory found")
        End If
        MsgBox("Directory not found")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim src As String = TextBox1.Text
        Dim dest As String = TextBox2.Text
        dname = TextBox1.Text

        Directory.Move(src, dest)
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dir() As String
        dname = TextBox1.Text
        RichTextBox1.Clear()

        dir = Directory.GetDirectories("D:\" + dname)
        For Each dname As String In dir
            RichTextBox1.Text += vbNewLine + dname
        Next
    End Sub

End Class
