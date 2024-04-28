Imports System.IO
Public Class Form1
    Dim u, p, bill As String
    Dim n As String
    Dim fpath As String = "D:\vbfile\"
    Dim floc As String = "myfile"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        u = Val(TextBox1.Text)
        p = Val(TextBox2.Text)
        n = TextBox4.Text

        bill = u * p
        TextBox3.Text = bill
        RichTextBox1.Text = "______________________________GO PAY___________________________" + vbNewLine + "**************************BILL***************************" + vbNewLine + "NAME  :-" & n + vbNewLine +
        "TOTAL UNITS =" & u + vbNewLine + "PRICE PER UNIT =" & p + ".RS" + vbNewLine + "-------------------------------------------------" + vbNewLine + "TOTAL BILL  =" & bill + ".RS"


    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            File.AppendAllText(fpath + floc, RichTextBox1.Text)
            MsgBox("BILL COPIED SUCCESSFULLY")
        Catch ex As Exception

        End Try


    End Sub

End Class
