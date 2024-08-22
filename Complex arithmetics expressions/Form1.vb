Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decTotalCost As Decimal
        Dim decDiscount As Decimal
        Dim decPostage As Decimal

        decPrice = 5
        iQuantity = 10
        decDiscount = 2
        decPostage = 3

        decTotalCost = (decPrice - decDiscount) * iQuantity + decPostage
        MsgBox(decTotalCost)
        'BO(DM)AS - Brackets order division multiplication addition substraction - Скоби ред деление умножение събиране изваждане
        'Please excuse me dear aunt salli PE(MD)(AS) - Parenthesis Exponentiation Multiplication Division Addition Substraction 
        'Скоби Степeнуване Умножение Деление Събиране Изваждане
        Dim iResult As Integer
        iResult = 10 - 5 + 2
        MsgBox(iResult)
        iResult = 10 + 2 - 5
        MsgBox(iResult)
        iResult = 10 - 2 + 5
        MsgBox(iResult)
        iResult = 10 / 2 * 5
        MsgBox(iResult)
        iResult = 2 * 10 / 5
        MsgBox(iResult)
        iResult = 10 * 5 / 2
        MsgBox(iResult)








    End Sub
End Class
