Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String

        If CheckBox1.Checked = True Then str = TextBox1.Font.Bold & Chr(13)
        If CheckBox2.Checked = True Then str = TextBox1.Font.Underline
        If CheckBox3.Checked = True Then str = TextBox1.Font.Italic
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
