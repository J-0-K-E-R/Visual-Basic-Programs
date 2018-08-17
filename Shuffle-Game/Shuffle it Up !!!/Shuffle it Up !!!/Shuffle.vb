Module Shuffle
    Sub Swap(ByRef But1 As Button, ByRef But2 As Button)
        If But2.Enabled = False Then
            But2.Text = But1.Text
            But1.Text = Nothing
            But1.Enabled = False
            But2.Enabled = True
            Form1.Label2.Text = Val(Form1.Label2.Text) + 1
        End If
    End Sub
    Sub Test()
        If (Form1.Button1.Text = "1" And Form1.Button2.Text = "2" And Form1.Button3.Text = "3" And Form1.Button4.Text = "4" And Form1.Button5.Text = "5" And Form1.Button6.Text = "6" And Form1.Button7.Text = "7" And Form1.Button8.Text = "8" And Form1.Button9.Text = "9" And Form1.Button10.Text = "10" And Form1.Button11.Text = "11" And Form1.Button12.Text = "12" And Form1.Button13.Text = "13" And Form1.Button14.Text = "14" And Form1.Button15.Text = "15") Then
            MsgBox("You Won !!!")
        End If
    End Sub



    Public Function Rand(ByVal low As Long, ByVal high As Long) As Long
        Rand = (((high - low + 1) * Rnd()) + low)
    End Function

    Sub Rndm(ByRef Butt As System.Windows.Forms.Button)
        Dim a, index As Integer
       While Butt.Text = 20  
       a = Rand(1, 15)
        For index = 1 To 10
            a = Rand(1, 15)
            If a < 16
            If Form1.Button1.Text <> a And Form1.Button2.Text <> a And Form1.Button3.Text <> a And Form1.Button4.Text <> a And Form1.Button5.Text <> a And Form1.Button6.Text <> a And Form1.Button7.Text <> a And Form1.Button8.Text <> a And Form1.Button9.Text <> a And Form1.Button10.Text <> a And Form1.Button11.Text <> a And Form1.Button12.Text <> a And Form1.Button13.Text <> a And Form1.Button14.Text <> a And Form1.Button15.Text <> a Then
                Butt.Text = a
                Exit For
            End If
            End If
        Next
End While

    End Sub
   
End Module
