Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click



        Dim iTemperature As Integer
        iTemperature = CInt(txtTemperature.Text)
        Dim iWindSpeed As Integer
        iWindSpeed = 30




        Select Case iTemperature
            Case Is = 0
                MsgBox("Freezing")
                MsgBox("Water will freeze")
                MsgBox("And you can go snowboarding")
            Case Is < 0
                MsgBox("Subzero")
                If iWindSpeed > 20 Then
                    MsgBox("як клинч")
                End If
            Case 1 To 10
                MsgBox("Cold")
            Case 11 To 20
                MsgBox("Warm")
            Case Else
                MsgBox("Hot")
        End Select





    End Sub
End Class
