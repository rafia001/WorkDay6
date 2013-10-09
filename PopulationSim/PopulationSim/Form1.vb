Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click
        Dim a As Double = 7000000000
        Dim b As Integer = 2012
        Do While a > 6000000
            b = b - 50
            a = a / 2
        Loop

        MessageBox.Show("The year was " & b.ToString(), "Error")

    End Sub
End Class
