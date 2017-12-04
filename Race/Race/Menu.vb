Public Class Menu

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim box = New Race()
        box.Show()
    End Sub

    Private Sub btnCoin_Click(sender As Object, e As EventArgs) Handles btnCoin.Click
        Dim box = New CoinToss()
        box.Show()
    End Sub
End Class