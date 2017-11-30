Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intSideUp As Integer
        Dim tailTotal As Integer = 0
        Dim headTotal As Integer = 0
        Dim rand As New Random

            intSideUp = rand.Next(2)

            If intSideUp = 0 Then
                picTails.Visible = True
                picHeads.Visible = False
            tailTotal = 1 + tailTotal
                lblTailsScore.Text = tailTotal.ToString("n")
            Else
                picHeads.Visible = True
                picTails.Visible = False
                headTotal = 1 + headTotal
                lblHeadScore.Text = headTotal.ToString("n")
            End If
            lblTailsScore.Text = tailTotal.ToString
            lblHeadScore.Text = headTotal.ToString

    End Sub
End Class
