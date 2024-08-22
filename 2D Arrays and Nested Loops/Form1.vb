Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRow.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Suan"
        astPeople(1, 1) = "Nguen"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "Bulgarian"
        astPeople(4, 1) = "Technical support"

        astPeople(0, 2) = "Nikolay"
        astPeople(1, 2) = "Zhechkov"
        astPeople(2, 2) = "Male"
        astPeople(3, 2) = "Bulgarian"
        astPeople(4, 2) = "CEO"

        astPeople(0, 3) = "Emiliqn"
        astPeople(1, 3) = "Aleksandrov"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Bulgarian"
        astPeople(4, 3) = "Technican"

        astPeople(0, 4) = "Galya"
        astPeople(1, 4) = "Raycheva"
        astPeople(2, 4) = "Female"
        astPeople(3, 4) = "Bulgarian"
        astPeople(4, 4) = "Breadland"

        astPeople(0, 5) = "Maria"
        astPeople(1, 5) = "Nguen"
        astPeople(2, 5) = "Female"
        astPeople(3, 5) = "Vietnamese"
        astPeople(4, 5) = "Nothing"

        Dim x As Integer
        Dim y As Integer

        For y = 0 To 5
            For x = 0 To 4
                MsgBox(astPeople(x, y))
            Next

        Next





    End Sub

    Private Sub btnColumn_Click(sender As Object, e As EventArgs) Handles btnColumn.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Suan"
        astPeople(1, 1) = "Nguen"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "Bulgarian"
        astPeople(4, 1) = "Technical support"

        astPeople(0, 2) = "Nikolay"
        astPeople(1, 2) = "Zhechkov"
        astPeople(2, 2) = "Male"
        astPeople(3, 2) = "Bulgarian"
        astPeople(4, 2) = "CEO"

        astPeople(0, 3) = "Emiliqn"
        astPeople(1, 3) = "Aleksandrov"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Bulgarian"
        astPeople(4, 3) = "Technican"

        astPeople(0, 4) = "Galya"
        astPeople(1, 4) = "Raycheva"
        astPeople(2, 4) = "Female"
        astPeople(3, 4) = "Bulgarian"
        astPeople(4, 4) = "Breadland"

        astPeople(0, 5) = "Maria"
        astPeople(1, 5) = "Nguen"
        astPeople(2, 5) = "Female"
        astPeople(3, 5) = "Vietnamese"
        astPeople(4, 5) = "Nothing"

        Dim x As Integer
        Dim y As Integer

        For x = 0 To 4
            For y = 0 To 5
                MsgBox(astPeople(x, y))
            Next
        Next



    End Sub

    Private Sub btnAtOnce_Click(sender As Object, e As EventArgs) Handles btnAtOnce.Click

        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Suan"
        astPeople(1, 1) = "Nguen"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "Bulgarian"
        astPeople(4, 1) = "Technical support"

        astPeople(0, 2) = "Nikolay"
        astPeople(1, 2) = "Zhechkov"
        astPeople(2, 2) = "Male"
        astPeople(3, 2) = "Bulgarian"
        astPeople(4, 2) = "CEO"

        astPeople(0, 3) = "Emiliqn"
        astPeople(1, 3) = "Aleksandrov"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Bulgarian"
        astPeople(4, 3) = "Technican"

        astPeople(0, 4) = "Galya"
        astPeople(1, 4) = "Raycheva"
        astPeople(2, 4) = "Female"
        astPeople(3, 4) = "Bulgarian"
        astPeople(4, 4) = "Breadland"

        astPeople(0, 5) = "Maria"
        astPeople(1, 5) = "Nguen"
        astPeople(2, 5) = "Female"
        astPeople(3, 5) = "Vietnamese"
        astPeople(4, 5) = "Nothing"

        Dim x As Integer
        Dim y As Integer
        Dim stOut As String

        For y = 0 To 5
            For x = 0 To 4
                stOut = stOut & astPeople(x, y) & " "
            Next
            stOut = stOut & vbNewLine
        Next

        MsgBox(stOut)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim astPeople(4, 5) As String

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Suan"
        astPeople(1, 1) = "Nguen"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "Bulgarian"
        astPeople(4, 1) = "Technical support"

        astPeople(0, 2) = "Nikolay"
        astPeople(1, 2) = "Zhechkov"
        astPeople(2, 2) = "Male"
        astPeople(3, 2) = "Bulgarian"
        astPeople(4, 2) = "CEO"

        astPeople(0, 3) = "Emiliqn"
        astPeople(1, 3) = "Aleksandrov"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Bulgarian"
        astPeople(4, 3) = "Technican"

        astPeople(0, 4) = "Galya"
        astPeople(1, 4) = "Raycheva"
        astPeople(2, 4) = "Female"
        astPeople(3, 4) = "Bulgarian"
        astPeople(4, 4) = "Breadland"

        astPeople(0, 5) = "Maria"
        astPeople(1, 5) = "Ng"
        astPeople(2, 5) = "Female"
        astPeople(3, 5) = "Vietnamese"
        astPeople(4, 5) = "Nothing"

        Dim x As Integer
        Dim y As Integer

        Dim bFound As Boolean '' false
        Dim stTarget As String
        Dim stOut As String

        bFound = False

        stTarget = InputBox("Please enter the surname of the person you want to find ")

        For y = 0 To 5
            If astPeople(1, y) = stTarget Then
                bFound = True
                Exit For
            End If
        Next

        If bFound = True Then
            For x = 0 To 4
                stOut = stOut & astPeople(x, y) & " "
            Next
        Else
            MsgBox("Not found")
        End If

        MsgBox(stOut)

    End Sub
End Class
