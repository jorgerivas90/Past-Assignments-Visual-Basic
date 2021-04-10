' Name:        Chopkins Project
' Purpose:      Accumulates and displays the sales of beer
' Programmer:   Jorge on 03/07/2021

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    'Class level variable for accumlating scores.
    Private dbl12Pack As Double = 14.99
    Private dbl5Pack As Double = 6.99
    Private dbl2Pack As Double = 2.4

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Accumulates and displays the scores.

        ' Procedure-level variable for storing a score.
        Dim dbl12PackAmount As Double
        Dim dbl5PackAmount As Double
        Dim dbl2PackAmount As Double

        'Static Varibale for acuumlating scores.
        Static dblTotalOrdered As Double
        Static dblTotalCost As Double

        ' Accumulate the scores and display the results.
        Double.TryParse(txt12Pack.Text, dbl12PackAmount)
        Double.TryParse(txt5Pack.Text, dbl5PackAmount)
        Double.TryParse(txt2Pack.Text, dbl2PackAmount)


        dblTotalOrdered = dbl12PackAmount + dbl5PackAmount + dbl2PackAmount
        lblTotalOrdered.Text = dblTotalOrdered.ToString

        dblTotalCost = dbl12Pack * dbl12PackAmount + dbl5Pack * dbl5PackAmount + dbl2Pack * dbl2PackAmount
        lblCost.Text = dblTotalCost.ToString("C")

    End Sub
End Class
