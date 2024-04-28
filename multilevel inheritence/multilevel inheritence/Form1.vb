Public Class Form1

    Dim itm As Integer
    Dim qty As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        itm = ComboBox1.SelectedIndex
        qty = Val(TextBox1.Text)
        Dim obj As New GETBILL
        obj.bill(itm, qty)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class

Class GETBILL
    Sub bill(ByVal itm As Integer, qty As Integer)

        Dim obj As New BILLTEST
        obj.calculatebill(itm, qty)
        Form1.RichTextBox1.Text = "------------YOUR BILL---------   " & vbNewLine & "   ITEM  :" & Form1.ComboBox1.SelectedItem & vbNewLine & "  QUANTITY  :-" & qty & vbNewLine & "TOTAL PAYABLE AMOUNT :-" & obj.calculatebill(itm, qty)


    End Sub
End Class
