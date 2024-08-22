Public Class Form1
    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            MsgBox(aiData(i))
        Next


    End Sub

    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click
        Dim aiData(4) As Integer
        Dim stOut As String

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            stOut = stOut & aiData(i) & vbNewLine
        Next
        MsgBox(stOut)
    End Sub

    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click

        Dim aiData(4) As Integer
        Dim iTotal As Integer
        Dim i As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            iTotal = iTotal + aiData(i)
            MsgBox("The total is " & iTotal)
        Next

    End Sub

    Private Sub btnExercise4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click

        Dim aiData(4) As Integer
        Dim i As Integer
        Dim iTotal As Integer


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            iTotal = iTotal + aiData(i)
        Next

        ''  iTotal = (aiData(0) + aiData(1) + aiData(2) + aiData(3) + aiData(4)) / 5   ----


        MsgBox("The average of the items  " & iTotal / 5)

    End Sub

    Private Sub btnExercise5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click

        Dim aiData(4) As Integer


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iTotal As Integer

        For i = 0 To 4
            If aiData(i) > 20 Then
                iTotal = iTotal + aiData(i)
            End If
        Next

        MsgBox("The total of the items bigger then 20 is " & iTotal)



    End Sub

    Private Sub btnExercise6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iMax As Integer

        iMax = 0

        For i = 0 To 4
            If aiData(i) > iMax Then
                iMax = aiData(i)
            End If

        Next
        MsgBox("The largest number is " & iMax)


    End Sub

    Private Sub btnExercise7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click


        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iMin As Integer

        iMin = 1000

        For i = 0 To 4
            If aiData(i) < iMin Then
                iMin = aiData(i)
            End If

        Next
        MsgBox("The smallest number is " & iMin)


    End Sub

    Private Sub btnExercise8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer

        For i = 0 To 4
            aiData(i) = aiData(i) * 2
        Next

        Dim stOut As String

        For i = 0 To 4
            stOut = stOut & aiData(i) & vbNewLine
        Next

        MsgBox(stOut)




    End Sub
End Class
