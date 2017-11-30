Public Class Form1

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lblCountry.Text = cboCountry.Text
        lblArtist.Text = cboArtist.Text
        lblPlay.Text = cboPlays.Text

    End Sub
End Class
