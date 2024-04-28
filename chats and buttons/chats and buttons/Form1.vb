Public Class Form1

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        RichTextBox2.Text = RichTextBox1.Text

    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox1.Text
        Dim msg As String = RichTextBox1.Text

        RichTextBox3.Text = RichTextBox3.Text + vbNewLine + name + ":" + msg

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ckb As String = ""

        If CheckBox1.Checked Then
            ckb += CheckBox1.Text + " "

        End If
        If CheckBox2.Checked Then
            ckb += CheckBox2.Text + " "

        End If
        If CheckBox3.Checked Then
            ckb += CheckBox3.Text + " "

        End If
        If CheckBox4.Checked Then
            ckb += CheckBox4.Text + " "

        End If
        MsgBox("YOU CHECKED: " + ckb)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ckb As String = ""

        If RadioButton1.Checked Then
            ckb += RadioButton1.Text + " "

        End If
        If RadioButton2.Checked Then
            ckb += RadioButton2.Text + " "

        End If
        If RadioButton3.Checked Then
            ckb += RadioButton3.Text + " "

        End If
        MsgBox("YOU CHECKED: " + ckb)
    End Sub
End Class
