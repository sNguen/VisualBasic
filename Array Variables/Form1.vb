Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bntStartClick.Click

        Dim astFruits(4) As String
        astFruits(0) = "LEMON"
        astFruits(1) = "BANANA"
        astFruits(2) = "PINEAPPLE"
        astFruits(3) = "APPLE"
        astFruits(4) = "MANGO"
        ''MsgBox(astFruits(2))

        ''  Dim i As Integer
        ''  i = 3
        ''  MsgBox(astFruits(i))


        For i = 0 To 4   '' shte mine prez vsichki
            MsgBox(astFruits(i))
        Next





    End Sub
End Class
