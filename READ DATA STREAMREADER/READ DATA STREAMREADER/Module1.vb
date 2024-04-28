Imports System.IO
Imports System.Console
Module Module1

    Sub Main()
        Dim sr As New StreamReader("D:/vbfile/myfile.txt")
        Dim str As String
        Try
            str = sr.ReadLine
            While (str <> Nothing)
                WriteLine(str)
                str = sr.ReadLine

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            sr.Close()

        End Try
        ReadKey()
    End Sub

End Module
