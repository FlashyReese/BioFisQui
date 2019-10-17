Public Class BGame2
    Public score As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If result.ToLower = "1" Then
            MessageBox.Show("Respuesta Correcta")
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            score = score + 1
            NextQuestion()
        Else
            ''NextQuestion()
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub
    Dim result As String = ""
    Public question As Integer = 1
    Private Sub BGame2_Load(sender As Object, e As EventArgs) Handles Me.Load
        FlatLabel1.Text = "Cual es telofase en el mitosis?"
        result = "3"
        question = 1
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("mitosisprofase")
        PictureBox2.Image = My.Resources.ResourceManager.GetObject("mitosisinterfase")
        PictureBox3.Image = My.Resources.ResourceManager.GetObject("mitosistelofase")
        PictureBox4.Image = My.Resources.ResourceManager.GetObject("mitosismetafase")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If result.ToLower = "2" Then
            MessageBox.Show("Respuesta Correcta")
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            score = score + 1
            NextQuestion()
        Else
            ''NextQuestion()
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If result.ToLower = "3" Then
            MessageBox.Show("Respuesta Correcta")
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            score = score + 1
            NextQuestion()
        Else
            ''NextQuestion()
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If result.ToLower = "4" Then
            MessageBox.Show("Respuesta Correcta")
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            score = score + 1
            NextQuestion()
        Else
            ''NextQuestion()
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub
    Public Sub NextQuestion()
        If question = 1 Then
            FlatLabel1.Text = "Cual es anafase en la meiosis?"
            result = "2"
            question = 2
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("meiosismetafase")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("meiosisanafase")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("meiosisprofase")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("meiosistelofase")
        ElseIf question = 2 Then
            FlatLabel1.Text = "Cual es el sistema muscular?"
            result = "1"
            question = 3
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("sistemamuscular")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("sistemadigestivo")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("sistemaurinario")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("sistemanervioso")
        ElseIf question = 3 Then
            FlatLabel1.Text = "Cual es el sistema respiratorio?"
            result = "4"
            question = 4
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("sistemacirculatorio")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("sistemanervioso")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("sistemamuscular")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("sistemarespiratorio")
        ElseIf question = 4 Then
            FlatLabel1.Text = "Cual es el metafase en el meiosis?"
            result = "1"
            question = 5
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("meiosismetafase")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("meiosisanafase")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("meiosisprofase")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("meiosistelofase")
        ElseIf question = 5 Then
            FlatLabel1.Text = "Cual es el sistema circulatorio?"
            result = "1"
            question = 6
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("sistemacirculatorio")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("sistemamuscular")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("sistemanervioso")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("sistemaesqueleto")
        ElseIf question = 6 Then
            FlatLabel1.Text = "Cual es el sistema nervioso?"
            result = "3"
            question = 7
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("sistemadigestivo")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("sistemamuscular")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("sistemanervioso")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("sistemarespiratorio")
        ElseIf question = 7 Then
            FlatLabel1.Text = "Cual es el sistema digestivo?"
            result = "3"
            question = 8
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("sistemarespiratorio")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("sistemamuscular")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("sistemadigestivo")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("sistemaesqueleto")
        ElseIf question = 8 Then
            FlatLabel1.Text = "Cual es el metafase en el mitosis?"
            result = "4"
            question = 9
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("mitosisprofase")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("mitosisinterfase")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("mitosistelofase")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("mitosismetafase")
        ElseIf question = 9 Then
            FlatLabel1.Text = "Cual es el sistema urinario?"
            result = "2"
            question = 10
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("sistemacirculatorio")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("sistemaurinario")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("sistemanervioso")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("sistemaesqueleto")
        ElseIf question = 10 Then

            MessageBox.Show("Nivel 3 Desbloqueado")
            GameStartMenu.BN3.Enabled = True
            Me.Close()
            GameStartMenu.Show()
            GameStartMenu.FlatLabel5.Text = "10/10"
            ''GameStartMenu.FlatLabel9.Text = score
            GameStartMenu.Timer2.Stop()
            GameStartMenu.UDDUpdate()
        End If

        FlatLabel2.Text = question.ToString + "/10"
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Hide()
        GameStartMenu.Show()

        GameStartMenu.FlatLabel5.Text = FlatLabel2.Text
        ''GameStartMenu.FlatLabel10.Text = "0.0"
        GameStartMenu.Timer2.Stop()
        ''question = 1
        GameStartMenu.UDDUpdate()

    End Sub
End Class