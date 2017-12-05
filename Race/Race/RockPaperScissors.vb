Public Class RockPaperScissors

    Private Sub btnScissors_Click(sender As Object, e As EventArgs) Handles btnScissors.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("Pc Choose- Rock. You Lose!")
        ElseIf intShoot = 1 Then
            lblResult.Text = ("Pc Choose- Paper. You Win!")
        ElseIf intShoot = 2 Then
            lblResult.Text = ("Pc Choose- Scissors. You Tie!")
        End If
    End Sub

    Private Sub btnPaper_Click(sender As Object, e As EventArgs) Handles btnPaper.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("Pc Choose- Rock. You Win!")
        ElseIf intShoot = 1 Then
            lblResult.Text = ("Pc Choose- Paper. You Tie!")
        ElseIf intShoot = 2 Then
            lblResult.Text = ("Pc Choose- Scissors. You Lose!")
        End If
    End Sub


    Private Sub btnRock_Click(sender As Object, e As EventArgs) Handles btnRock.Click
        Dim intShoot As Integer
        Dim rand As New Random

        intShoot = rand.Next(3)
        '0 Rock
        '1 Paper
        '2 Scissors

        If intShoot = 0 Then
            lblResult.Text = ("Pc Choose- Rock. You Tie!")
        ElseIf intShoot = 1 Then
            lblResult.Text = ("Pc Choose- Paper. You Lose!")
        ElseIf intShoot = 2 Then
            lblResult.Text = ("Pc Choose- Scissors. You Win!")
        End If
    End Sub

End Class