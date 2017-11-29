Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Const intNUM_DAYS As Integer = 5
        Dim intCount As Integer = 1
        Dim decSales As Decimal = 0
        Dim decTotal As Decimal = 0
        Dim strInput As String

        Do While intCount <= intNUM_DAYS
            strInput = InputBox("Enter the sales for day" & intCount.ToString())
            If Decimal.TryParse(strInput, decSales) Then
                decTotal = decSales + decTotal
                intCount = intCount + 1
            Else
                MessageBox.Show("Enter a numeric value")
            End If
        Loop

        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
