Public Class Form1
    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click


        ''for next - iteration - повторение


        Dim iCount As Integer

        ''For iCount = 1 To 5
        ''MsgBox("Hello " & iCount)
        ''Beep()
        ''reading.Thread.Sleep(3000) 'pause for 3 sec
        ''Next




        '' For iCount = 0 To 50 Step 5
        '' MsgBox(iCount)
        ''Next




        For iCount = 50 To 0 Step -5
            MsgBox(iCount)
        Next



    End Sub
End Class
