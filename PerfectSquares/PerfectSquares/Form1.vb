Public Class Form1

    Private Sub btnDisplay_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplay.Click

        lstResult.Items.Clear()

        Dim a As Integer
        a = 1
        Do While a <= 10

            lstResult.Items.Add(a ^ 2)
            a = a + 1
        Loop
    End Sub
End Class
