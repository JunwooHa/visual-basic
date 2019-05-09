Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1
            .Items.Add("도착역")
            .Items.Add("대구")
            .Text = .Items(0)
        End With

        With ComboBox2
            .Items.Add("열차종류")
            .Items.Add("새마을")
            .Text = .Items(0)
        End With

        With ListBox1
            .Items.Add("영화 관람")
            .Items.Add("동반석")
            .Items.Add("유아 동반")
            .Items.Add("할인석")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "도착역" Or ComboBox2.Text = "열차종류" Or ListBox1.Text = "" Then
            MsgBox("모두 선택하세요.")
        Else
            TextBox1.Text = "도착역은 " & ComboBox1.Text & "입니다. 기차 종류는" & ComboBox2.Text & "이고 " & ListBox1.Text & "을 선택하셨습니다."
        End If
    End Sub
End Class
