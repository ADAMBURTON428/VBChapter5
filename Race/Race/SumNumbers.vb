Public Class SumNumbers

   
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click 
        Dim intSum As Integer
        Dim input As Integer

        input = InputBox("Enter a positive integer value.")
        For i As Integer = 0 To input
            intSum += i
        Next

        MessageBox.Show("The sum of the numbers " & input & " is " & intSum)


    End Sub
End Class