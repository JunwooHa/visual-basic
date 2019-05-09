Public Class Form1
    Private intx, inty, result As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        intx = Val(TextBox1.Text)
        inty = Val(TextBox2.Text)
        result = intx + inty
        TextBox3.Text = result
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        intx = Val(TextBox1.Text)
        inty = Val(TextBox2.Text)
        result = intx - inty
        TextBox3.Text = result
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        intx = Val(TextBox1.Text)
        inty = Val(TextBox2.Text)
        result = intx * inty
        TextBox3.Text = result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        intx = Val(TextBox1.Text)
        inty = Val(TextBox2.Text)
        result = intx / inty
        TextBox3.Text = result
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub
End Class
