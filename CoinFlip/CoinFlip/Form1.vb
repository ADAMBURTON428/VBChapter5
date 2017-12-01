Public Class Form1
    Dim tailTotal As Integer
    Dim headTotal As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCoinFlip.Click
        Dim intSideUp As Integer

        Dim rand As New Random

        intSideUp = rand.Next(2)

        If intSideUp = 0 Then
            picTails.Visible = True
            picHeads.Visible = False
            tailTotal = 1 + tailTotal

        Else
            picHeads.Visible = True
            picTails.Visible = False
            headTotal = 1 + headTotal

        End If
        lblTailsScore.Text = tailTotal.ToString
        lblHeadScore.Text = headTotal.ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
