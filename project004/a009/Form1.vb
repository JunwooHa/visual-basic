Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z As Integer

        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = (x * y) / 2
        TextBox3.Text = z
    End Sub
End Class
