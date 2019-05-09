Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score As Integer

        score = Val(TextBox2.Text)

        If score >= 80 Then
            MsgBox(TextBox1.Text & "님은 합격입니다.")
        Else
            MsgBox(TextBox1.Text & "님은 불합격입니다")
        End If
    End Sub
End Class
