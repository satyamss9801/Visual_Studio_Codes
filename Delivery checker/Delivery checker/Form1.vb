Public Class Form1
    Dim n As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = Val(TextBox1.Text)
        If (n.Length < 7) Then

            Select Case n
                Case "854301"
                    Label5.Text = "PURNIA , BIHAR"
                Case "211001"
                    Label5.Text = "ALLAHABAD , UTTAR PRADESH"
                Case "799001"
                    Label5.Text = "Agartala G.P.O ,Tripura"
                Case "305001"
                    Label5.Text = "Ajmer, Rajasthan"
                Case "560002"
                    Label5.Text = "Bangalore city"
                Case "364001"
                    Label5.Text = "Bhavnagar, calcutta "
                Case "803101"
                    Label5.Text = "Bihar Shariff ,Bihar"
                Case "799155"
                    Label5.Text = "Bolomia , Tripura "
                Case "495001"
                    Label5.Text = "Bilaspur , Madhy Pradesh"
                Case "841301"
                    Label5.Text = "Ramnagar Chapra , Bihar"
            End Select
        Else
            Label5.Text = "Product not deleverable"
        End If


    End Sub
End Class
