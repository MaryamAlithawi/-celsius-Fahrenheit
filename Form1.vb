Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim celsius As Double = Val(textCelsius.Text)
        Dim Fahrenheit As Double = (celsius * 9 / 5) + 32
        lblResult.Text = Fahrenheit.ToString()
    End Sub



End Class
