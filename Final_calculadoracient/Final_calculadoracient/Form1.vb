Public Class Form1
    Dim num1 As Integer
    Dim num2 As Integer
    Dim op As String
    Dim memoryVariable As Double = 0
    Dim sign_Indicator As Integer = 0
  

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & 9

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & "."
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = TextBox1.Text & "13,1416"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        End
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox1.Text.Length <> 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        num1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        op = "+"
        TextBox1.Focus()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        num1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        op = "-"
        TextBox1.Focus()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        num1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        op = "/"

        TextBox1.Focus()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        num1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        op = "x"

        TextBox1.Focus()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        num1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        op = "%"

        TextBox1.Focus()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = Val(TextBox1.Text) * Val(TextBox1.Text)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.Text = Val(TextBox1.Text) * Val(TextBox1.Text) * Val(TextBox1.Text)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox1.Text = Math.Sin(TextBox1.Text)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox1.Text = Math.Cos(TextBox1.Text)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TextBox1.Text = Math.Tan(TextBox1.Text)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        TextBox1.Text = Math.Sqrt(TextBox1.Text)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = Math.Log(TextBox1.Text)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        num2 = TextBox1.Text
        If op = "+" Then
            TextBox1.Text = num1 + num2
        End If
        If op = "-" Then
            TextBox1.Text = num1 - num2
        End If
        If op = "/" Then
            TextBox1.Text = num1 / num2
        End If
        If op = "x" Then
            TextBox1.Text = num1 * num2
        End If
        If op = "%" Then
            TextBox1.Text = num1 / 100
        End If
        If op = "x^y" Then
            TextBox1.Text = num1 ^ num2
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox1.Text = Math.PI
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        num1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        op = "x^y"
        TextBox1.Focus()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If memoryVariable <> 0 Then
            memoryVariable = memoryVariable - memoryVariable
        End If
        sign_Indicator = 1
        TextBox1.Text = CStr(memoryVariable)
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If memoryVariable <> 0 Then
            memoryVariable = memoryVariable + memoryVariable
        End If
        sign_Indicator = 1
        TextBox1.Text = CStr(memoryVariable)
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If TextBox1.Text.Length <> 0 Then
            If memoryVariable = 0 Then
                memoryVariable = CDbl(TextBox1.Text)
            End If
        End If
        sign_Indicator = 1
        TextBox1.Text = CStr(memoryVariable)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    

    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        Form2.Show()
    End Sub
End Class
