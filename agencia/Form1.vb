Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "kevin" And TextBox2.Text = "777" Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("USUARIO O CONTRASEÑA INCORRECTA")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox2_TabIndexChanged(sender As Object, e As EventArgs) Handles TextBox2.TabIndexChanged
        Button2.Focus()
    End Sub

   
End Class
