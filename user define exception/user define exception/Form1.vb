Imports user_define_exception.Class1

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        age = Val(TextBox1.Text)


        Try
            If (age < 18) Then
                Throw New voteexception("  age<18")

            Else
                MsgBox("WELCOME ELIGIBLE FOR VOTE")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
End Class
