' Name:         Circle Project
' Purpose:      Calculate and display the circle's area.
' Programmer:   Jorge on 03/07/2021

Public Class frmMain
    'Class-level named costant.
    Private Const dplIPI As Double = 3.14159
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate and display the circle's area.

        Dim dblRadius As Double
        Dim dblArea As Double

        Double.TryParse(txtRadius.Text, dblRadius)
        dblArea = dplIPI * dblRadius ^ 2
        lblArea.Text = dblArea.ToString("N2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtRadius_TextChanged(sender As Object, e As EventArgs) Handles txtRadius.TextChanged
        'Clear the Area box.
        lblArea.Text = String.Empty
    End Sub
End Class
