Public Class DistanceCalculator
    Dim Speed As Decimal
    Dim Time As Decimal
    Dim Distance As Decimal
    Dim Hours As Decimal
    Sub Calc()
        Hours = Hours + 1
        Distance = Speed * Hours
        listResults.Items.Add(Hours & "              " & Distance.ToString)
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Speed = InputBox("Enter the speed in miles-per-hour")
        Time = InputBox("Enter the Time in hours")

        listResults.Items.Add("Vehicle Speed: " & Speed & " MPH")
        listResults.Items.Add("Time Traveled: " & Time & " hours")
        listResults.Items.Add("Hours         Distance Traveled ")
        listResults.Items.Add("----------------------------------")
        Do While Hours < Time
            Calc()
        Loop
        listResults.Items.Add("Total Distance: " & Distance.ToString)
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class