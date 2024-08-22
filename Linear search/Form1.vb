Public Class Form1
    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click
        Dim stTarget As String
        Dim astFruit(9) As String
        Dim bFound As Boolean

        astFruit(0) = ("Banana")
        astFruit(1) = ("Strawberry")
        astFruit(2) = ("Mango")
        astFruit(3) = ("Blueberry")
        astFruit(4) = ("Cranberry")
        astFruit(5) = ("Appricot")
        astFruit(6) = ("Apple")
        astFruit(7) = ("Dragon fruit")
        astFruit(8) = ("Kiwi")
        astFruit(9) = ("Lemon")


        stTarget = InputBox("Which fruit are you looking for? ")

        Dim i As Integer

        For i = 0 To 9
            If UCase(astFruit(i)) = UCase(stTarget) Then ''or astFruit.ToUpper  stTarget.ToUpper  for case sensitivity
                bFound = True
                Exit For
            End If
        Next

        If bFound = True Then
            MsgBox("Found it ")
        Else
            MsgBox("not found ")
        End If


    End Sub
End Class
