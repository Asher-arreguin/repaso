Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero = num1.Text
        Dim entero = Val(numero)
        Dim operacion = entero * 2
        Label2.Text = operacion

    End Sub

    Private Sub BTNSUMA_Click(sender As Object, e As EventArgs) Handles BTNSUMA.Click
        Dim numero1 = Val(num1.Text)
        Dim numero2 = Val(num2.Text)
        Dim resultado = numero1 + numero2
        Label2.Text = resultado
    End Sub

    Private Sub RESTA_Click(sender As Object, e As EventArgs) Handles RESTA.Click
        Label2.Text = Val(num1.Text) - Val(num2.Text)
    End Sub

    Private Sub MULTIPLICAR_Click(sender As Object, e As EventArgs) Handles MULTIPLICAR.Click
        Label2.Text = Val(num1.Text) * Val(num2.Text)
    End Sub

    Private Sub DIVIDIR_Click(sender As Object, e As EventArgs) Handles DIVIDIR.Click
        If num2.Text = 0 Then
            Label2.Text = "error"
        Else
            Label2.Text = Val(num1.Text) / Val(num2.Text)
        End If
    End Sub

End Class