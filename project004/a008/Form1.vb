Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Static x, sum As Integer
        sum = sum + 100

        TextBox1.Text = sum

    End Sub
End Class
