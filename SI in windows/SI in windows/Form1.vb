Public Class Form1
    Dim ba, r, t, extra As Single
    Dim memi, si, ta As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

        Catch ex As Exception

            ba = Val(TextBox1.Text)
            r = Val(TextBox2.Text)
            t = Val(TextBox3.Text) / 12
            If (t > 5) Then
                MsgBox("LOAN NOT AVAILABLE FOR MORE THAN 5 YEARS")

            Else
                si = (ba * r * t) / 100
                ta = si + ba
                extra = (ta - ba)
                memi = ta / (t * 12)


                TextBox4.Text = ta
                TextBox5.Text = extra
                TextBox6.Text = memi
            End If
        End Try
      

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
