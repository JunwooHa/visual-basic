Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer

        x = Val(TextBox1.Text)

        If x Mod 2 = 0 Then
            MsgBox("입력하신 숫자는 짝수입니다.")
        Else
            MsgBox("입력하신 숫자는 홀수입니다.")
        End If
    End Sub
End Class
