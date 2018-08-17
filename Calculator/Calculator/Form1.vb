Public Class Form1
    Dim a
    Dim v As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button18.Click
        Label1.Text = Label1.Text + "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button19.Click
        Label1.Text = Label1.Text + "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, Button20.Click
        Label1.Text = Label1.Text + "3"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, Button21.Click
        Label1.Text = Label1.Text + "4"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click, Button22.Click
        Label1.Text = Label1.Text + "5"

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click, Button23.Click
        Label1.Text = Label1.Text + "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click, Button24.Click
        Label1.Text = Label1.Text + "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click, Button25.Click
        Label1.Text = Label1.Text + "8"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click, Button26.Click
        Label1.Text = Label1.Text + "9"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click, Button27.Click
        If v = 0 Then
            Label1.Text = Label1.Text + "."
            v = 1
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If Label3.Text = Nothing Then
            Label3.Text = Label1.Text
        End If
        Label4.Text = "-"
        a = "-"
        Label1.Text = Nothing
        v = 0
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If Label3.Text = Nothing Then
            Label3.Text = Label1.Text
        End If
        Label4.Text = "+"
        a = "+"
        Label1.Text = Nothing
        v = 0
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If Label3.Text = Nothing Then
            Label3.Text = Label1.Text
        End If
        Label4.Text = "X"
        a = "X"
        Label1.Text = Nothing
        v = 0
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If Label3.Text = Nothing Then
            Label3.Text = Label1.Text
        End If
        Label4.Text = "/"
        a = "/"
        Label1.Text = Nothing
        v = 0
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If a = "+" Then
            Label5.Text = Val(Label1.Text) + Val(Label3.Text)
        End If
        If a = "-" Then
            Label5.Text = Val(Label3.Text) - Val(Label1.Text)
        End If
        If a = "X" Then
            Label5.Text = Val(Label1.Text) * Val(Label3.Text)
        End If
        If a = "/" Then
            Label5.Text = Val(Label3.Text) / Val(Label1.Text)
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Label1.Text = Nothing
        Label5.Text = Nothing
        Label3.Text = Nothing
        Label4.Text = Nothing
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
23:
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click, Button28.Click
        Label1.Text = Label1.Text + "0"
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C.Click
        Dim x As Double
        x = Val(Label1.Text)
        If x <> 0 Then
            Label1.Text = Label1.Text.Remove(Label1.Text.Length - 1)
            If Label1.Text = "-" Then Label1.Text = Label1.Text.Remove(Label1.Text.Length - 1)
        End If
        If x = 0 Then
            Label1.Text = Nothing
        End If
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Label1.Text = 0 - Val(Label1.Text)
    End Sub
End Class
