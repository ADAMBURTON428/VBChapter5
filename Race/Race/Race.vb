Public Class Race

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim intCount1, intCount2, intCount3 As Integer
        Dim rand As New Random

        For intCount1 = 16 To rand.Next(250) + 510
            picOldrunner.Left = intCount1
        Next

        For intCount2 = 16 To rand.Next(250) + 510
            picRunnerGuy.Left = intCount2
        Next

        For intCount3 = 16 To rand.Next(250) + 510
            picBillNye.Left = intCount3
        Next

        If intCount2 > intCount1 And intCount2 > intCount3 Then
            lblWinner.Text = ("Runner Guy Wins")
        ElseIf intCount3 > intCount1 And intCount3 > intCount2 Then
            lblWinner.Text = ("Science Rules")
        ElseIf intCount1 > intCount2 And intCount1 > intCount3 Then
            lblWinner.Text = ("Old Man Wins???")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim intCount As Integer

        For intCount = 0 To 0
            picRunnerGuy.Left = intCount
            picOldrunner.Left = intCount
            picBillNye.Left = intCount
        Next
        lblWinner.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
