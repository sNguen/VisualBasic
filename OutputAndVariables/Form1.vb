Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("course")
        MsgBox("VB.NET")
        MsgBox("programming")
        MsgBox("to")
        MsgBox("Welcome")

        MessageBox.Show("this is another message")


    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String


        stFirstName = "Sunny"
        stLastName = "Nguen"
        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")

        stFirstName = "Maria"
        stLastName = "Nguen"
        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & " I hope you are well")


    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date


        iDoors = 5
        stMake = "Mercedes"
        stModel = "CLS"
        stColor = "Black"
        bTaxed = True
        iEngineSize = 5000
        decPrice = 220.369
        dtDateRegistered = #10/22/2023#

        MsgBox("the car is" & vbNewLine & stMake & vbNewLine & stModel & vbNewLine & iDoors & vbNewLine & stColor &
            vbNewLine & bTaxed & vbNewLine & iEngineSize & vbNewLine & decPrice & vbNewLine & dtDateRegistered)











    End Sub


End Class
