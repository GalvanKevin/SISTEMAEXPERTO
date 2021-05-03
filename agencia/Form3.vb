Public Class Form3
    Dim Vmarca As String
    Dim Vmodelo As String
    Dim Vanio As String
    Dim comodin As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        

        If ComboBox1.Text = "CHEVROLET" Then
            ComboBox2.Items.Add("AVEO")
            ComboBox2.Items.Add("CAMARO")
            ComboBox2.Items.Add("CORVETE")
            ComboBox2.Items.Add("ORLANDO")

            ComboBox2.Items.Remove("FIESTA")
            ComboBox2.Items.Remove("FOCUS")
            ComboBox2.Items.Remove("MODEO")
            ComboBox2.Items.Remove("KUGA")

            ComboBox2.Items.Remove("LANCER")
            ComboBox2.Items.Remove("LANCER EVO")
            ComboBox2.Items.Remove("ECLIPSE")
            ComboBox2.Items.Remove("SPACE STARD")

            ComboBox2.Items.Remove("CX-3")
            ComboBox2.Items.Remove("CX-30")
            ComboBox2.Items.Remove("MX-5")
            ComboBox2.Items.Remove("Mazda3")
        End If
        If ComboBox1.Text = "FORD" Then
            ComboBox2.Items.Add("FIESTA")
            ComboBox2.Items.Add("FOCUS")
            ComboBox2.Items.Add("MODEO")
            ComboBox2.Items.Add("KUGA")

            ComboBox2.Items.Remove("AVEO")
            ComboBox2.Items.Remove("CAMARO")
            ComboBox2.Items.Remove("CORVETE")
            ComboBox2.Items.Remove("ORLANDO")

            ComboBox2.Items.Remove("LANCER")
            ComboBox2.Items.Remove("LANCER EVO")
            ComboBox2.Items.Remove("ECLIPSE")
            ComboBox2.Items.Remove("SPACE STARD")

            ComboBox2.Items.Remove("CX-3")
            ComboBox2.Items.Remove("CX-30")
            ComboBox2.Items.Remove("MX-5")
            ComboBox2.Items.Remove("Mazda3")
        End If
        If ComboBox1.Text = "MITSUBISHI" Then
            ComboBox2.Items.Add("LANCER")
            ComboBox2.Items.Add("LANCER EVO")
            ComboBox2.Items.Add("ECLIPSE")
            ComboBox2.Items.Add("SPACE STARD")

            ComboBox2.Items.Remove("AVEO")
            ComboBox2.Items.Remove("CAMARO")
            ComboBox2.Items.Remove("CORVETE")
            ComboBox2.Items.Remove("ORLANDO")

            ComboBox2.Items.Remove("FIESTA")
            ComboBox2.Items.Remove("FOCUS")
            ComboBox2.Items.Remove("MODEO")
            ComboBox2.Items.Remove("KUGA")

            ComboBox2.Items.Remove("CX-3")
            ComboBox2.Items.Remove("CX-30")
            ComboBox2.Items.Remove("MX-5")
            ComboBox2.Items.Remove("Mazda3")
        End If
        If ComboBox1.Text = "MAZDA" Then
            ComboBox2.Items.Add("CX-3")
            ComboBox2.Items.Add("CX-30")
            ComboBox2.Items.Add("MX-5")
            ComboBox2.Items.Add("Mazda3")

            ComboBox2.Items.Remove("AVEO")
            ComboBox2.Items.Remove("CAMARO")
            ComboBox2.Items.Remove("CORVETE")
            ComboBox2.Items.Remove("ORLANDO")

            ComboBox2.Items.Remove("FIESTA")
            ComboBox2.Items.Remove("FOCUS")
            ComboBox2.Items.Remove("MODEO")
            ComboBox2.Items.Remove("KUGA")

            ComboBox2.Items.Remove("LANCER")
            ComboBox2.Items.Remove("LANCER EVO")
            ComboBox2.Items.Remove("ECLIPSE")
            ComboBox2.Items.Remove("SPACE STARD")

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Compraras un: " + ComboBox1.Text + "siendo el modelo un " + ComboBox2.Text + " y el año " + ComboBox3.Text)
        ComboBox1.Text = "MARCA"
        ComboBox2.Text = "MODELO"
        ComboBox3.Text = "AÑO"
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox3.Items.Add("2016")
        ComboBox3.Items.Add("2017")
        ComboBox3.Items.Add("2018")
        ComboBox3.Items.Add("2019")
        ComboBox3.Items.Add("2020")

        ComboBox1.Items.Add("CHEVROLET")
        ComboBox1.Items.Add("FORD")
        ComboBox1.Items.Add("MITSUBISHI")
        ComboBox1.Items.Add("MAZDA")
    End Sub

End Class