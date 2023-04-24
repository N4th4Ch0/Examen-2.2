Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click


        Dim numero As Integer

        numero = txtNum.Text

        If numero <> 0 AndAlso numero Mod 2 = 0 Then

            lblResultado.Text = "El numero es par"
            lblResultado.ForeColor = Color.Green

        ElseIf numero Then '<> 0 Then

            lblResultado.Text = "El numero es impar"
            lblResultado.ForeColor = Color.Red

        Else
            lblResultado.Text = "El numero es cero"
            lblResultado.ForeColor = Color.DarkRed
        End If

    End Sub
End Class
