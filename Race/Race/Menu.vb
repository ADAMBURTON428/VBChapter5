Public Class Menu

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim box = New Race()
        box.Show()
    End Sub

    Private Sub btnRockPaperScissors_Click(sender As Object, e As EventArgs) Handles btnRockPaperScissors.Click
        Dim box = New RockPaperScissors()
        box.Show()
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim box = New SumNumbers()
        box.Show()
    End Sub

    Private Sub btnDistance_Click(sender As Object, e As EventArgs) Handles btnDistance.Click
        Dim box = New DistanceCalculator()
        box.Show()
    End Sub

  
    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        Dim box = New RandomNumber()
        box.Show()
    End Sub
End Class