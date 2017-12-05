Public Class Menu

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim box = New Race()
        box.Show()
    End Sub

    Private Sub btnRockPaperScissors_Click(sender As Object, e As EventArgs) Handles btnRockPaperScissors.Click
        Dim box = New RockPaperScissors()
        box.Show()
    End Sub
End Class