Public Class RandomNumber


    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim rand As New Random
        Dim CNum As Integer
        Dim Guess As Integer
        Dim Wrong As Integer
        Guess = (txtInput.Text)
        CNum = rand.Next(100)

        If Guess = CNum Then
            MessageBox.Show("Correct")

        ElseIf Guess < CNum Then
            lblGuessWrong.Text = Wrong + 1
        ElseIf Guess > CNum Then
            lblGuessWrong.Text = Wrong + 1
        End If





    End Sub
End Class