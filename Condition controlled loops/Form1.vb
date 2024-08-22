Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStartClick.Click


        Dim stAge As String
        Dim iAge As Integer

        Do While Not IsNumeric(stAge)
            stAge = InputBox("Please enter you age in years")
        Loop

        iAge = CInt(stAge)

        MsgBox("Hello you are " & iAge & " " & "years")







        ''vsichki kodove pravqt edno i syshto



        '' Dim stAge As String
        '' Dim iAge As Integer
        '' Do While IsNumeric(stAge) = False
        ''stAge = InputBox("Please enter you age in years")
        '' Loop
        '' iAge = CInt(stAge)
        '' MsgBox("Hello you are " & iAge & " " & "years")




        ''    Dim stName As String
        ''  Do While stName <> "SUAN"
        ''stName = InputBox("Please enter you name")
        ''If stName = "SUAN" Then
        ''Exit Do
        ''End If
        '' Loop
        ''          MsgBox("Hello " & stName)


    End Sub
End Class
