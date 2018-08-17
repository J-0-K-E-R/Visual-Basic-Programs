Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Swap(Button1, Button2)
        Swap(Button1, Button5)
        Test()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Swap(Button2, Button1)
        Swap(Button2, Button3)
        Swap(Button2, Button6)
        Test()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Swap(Button3, Button2)
        Swap(Button3, Button4)
        Swap(Button3, Button7)
        Test()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Swap(Button4, Button3)
        Swap(Button4, Button8)
        Test()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Swap(Button5, Button1)
        Swap(Button5, Button6)
        Swap(Button5, Button9)
        Test()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Swap(Button6, Button2)
        Swap(Button6, Button5)
        Swap(Button6, Button7)
        Swap(Button6, Button10)
        Test()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Swap(Button7, Button3)
        Swap(Button7, Button6)
        Swap(Button7, Button8)
        Swap(Button7, Button11)
        Test()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Swap(Button8, Button4)
        Swap(Button8, Button7)
        Swap(Button8, Button12)
        Test()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Swap(Button9, Button5)
        Swap(Button9, Button10)
        Swap(Button9, Button13)
        Test()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Swap(Button10, Button6)
        Swap(Button10, Button9)
        Swap(Button10, Button11)
        Swap(Button10, Button14)
        Test()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Swap(Button11, Button7)
        Swap(Button11, Button10)
        Swap(Button11, Button12)
        Swap(Button11, Button15)
        Test()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Swap(Button12, Button8)
        Swap(Button12, Button11)
        Swap(Button12, Button16)
        Test()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Swap(Button13, Button9)
        Swap(Button13, Button14)
        Test()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Swap(Button14, Button10)
        Swap(Button14, Button13)
        Swap(Button14, Button15)
        Test()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Swap(Button15, Button11)
        Swap(Button15, Button14)
        Swap(Button15, Button16)
        Test()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Swap(Button16, Button12)
        Swap(Button16, Button15)
        Test()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Rndm(Button1)
        Rndm(Button2)
        Rndm(Button3)
        Rndm(Button4)
        Rndm(Button5)
        Rndm(Button6)
        Rndm(Button7)
        Rndm(Button8)
        Rndm(Button9)
        Rndm(Button10)
        Rndm(Button11)
        Rndm(Button12)
        Rndm(Button13)
        Rndm(Button14)
        Rndm(Button15)


    End Sub
    
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
