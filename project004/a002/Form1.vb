Public Class Form1
    Private mood As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim var As Integer

        var = var + 1
        mood = mood + 10

        TextBox1.Text = var
        TextBox2.Text = mood
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mood = mood + 100
        TextBox3.Text = mood
    End Sub
End Class
