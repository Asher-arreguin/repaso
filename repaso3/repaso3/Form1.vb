Public Class Form1
    Dim contador = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'contador + contador + 1 = 0 
        contador += 1
        Label2.Text = contador

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contador = 0
        Label2.Text = contador
    End Sub
End Class
