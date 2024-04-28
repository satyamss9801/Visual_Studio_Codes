Imports System.IO
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            SaveFileDialog1.Filter = "TXTFILES(*.txt*)|*.txt"

            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)

            ElseIf SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                MsgBox("DATA NOT SAVED OK CANCELED BY USER")

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SaveFileDialog1.Filter = "TXT FILES(*.txt)|*.TXT"
        Try
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()


        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fnt As New Font("verdana", 20, FontStyle.Bold)
        e.Graphics.DrawString(RichTextBox1.Text, fnt, Brushes.Aqua, 100, 100)

    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If RichTextBox1.Text = "" Then
            MsgBox("NO DATA ")
        Else
            PrintPreviewDialog1.ShowDialog()

        End If
    End Sub
End Class
