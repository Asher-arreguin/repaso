Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "click en el botton"
        Label1.ForeColor = Color.Red
        Label1.BackColor = Color.Purple
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = "click en el label"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label1.Visible = True Then
            Label1.Visible = False
            Button1.Visible = False
        ElseIf Label1.Visible = False Then
            Label1.Visible = True
            Button1.Visible = True

        End If

    End Sub
End Class
