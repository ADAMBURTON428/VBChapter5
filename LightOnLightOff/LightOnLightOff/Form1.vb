Public Class Form1
    Dim lightTurnOn As Integer
    Private Sub btnLightSwitch_Click(sender As Object, e As EventArgs) Handles btnLightSwitch.Click
        Dim intLightOn As Integer
        Dim intLightBroken As Integer = 10
        Dim rand As New Random

        intLightOn = rand.Next(2)

        If intLightOn = 0 Then
            picLightOn.Visible = True
            picLightOff.Visible = False
            lightTurnOn = lightTurnOn + 1
        Else
            picLightOn.Visible = False
            picLightOff.Visible = True
        End If
        If lightTurnOn = intLightBroken Then
            picLightOn.Visible = False
            picLightOff.Visible = False
            picBroken.Visible = True
            btnLightSwitch.Visible = False
        End If
        lblTimes.Text = lightTurnOn.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
