Public Class Form1

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub BackcolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackcolorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color

    End Sub

    Private Sub FontcolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontcolorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()

    End Sub
End Class
