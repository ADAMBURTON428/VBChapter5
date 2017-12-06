Public Class SumNumbers

   
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim inttwice As Integer
        Dim intNumber1 As Integer
        Dim intNumber2 As Integer
        Dim intSum As Integer
        Do Until inttwice = 2
            InputBox("enter a positive integer value.")
            inttwice += 1
        Loop
        intSum = intNumber1 + intNumber2


    End Sub
End Class