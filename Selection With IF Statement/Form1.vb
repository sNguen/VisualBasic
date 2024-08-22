Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click

        Dim stCountry As String
        stCountry = txtCountry.Text
        'stCountry = stCountry.ToUpper 'държавите трябва да са с главна буква, а това премахва case sensitivity.

        If stCountry.ToUpper = "BULGARIA" Then
            MsgBox("Добър ден българко")
            MsgBox("Hello")
            MsgBox("YOU ARE BEAUTIFULL")
        ElseIf stCountry.ToUpper = "FRANCE" Then
            MsgBox("Bonjour")
            MsgBox("Comment alles-vous")
        ElseIf stCountry.ToUpper = "JAPAN" Then
            MsgBox("konichiwa")
            MsgBox("sayonara")
        Else
            MsgBox("I hope you are well")
            MsgBox("never mind")
        End If

        MsgBox("You entered " & stCountry)



    End Sub
End Class
