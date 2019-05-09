Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kor, eng, mat, Total As Integer

        kor = TextBox1.Text
        eng = TextBox2.Text
        mat = TextBox3.Text
        Total = kor + eng + mat

        Label5.Text = Total
    End Sub
End Class
