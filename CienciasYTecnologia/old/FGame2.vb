Public Class FGame2
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
        FlatLabel1.Text = "Cual de estos es un circuito en serie?"
        result = "2"
        question = 1
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("mixtos")
        PictureBox2.Image = My.Resources.ResourceManager.GetObject("serie")
        PictureBox3.Image = My.Resources.ResourceManager.GetObject("paralelo")
        PictureBox4.Image = My.Resources.ResourceManager.GetObject("jauladefaraday")
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
            FlatLabel1.Text = "Identifica el Estado liquido"
            result = "1"
            question = 2
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("liquido")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("solido")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("gas")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("escalasdetemperatura")
        ElseIf question = 2 Then
            FlatLabel1.Text = "Cual de estos es un circuito en paralelo?"
            result = "4"
            question = 3
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("mixtos")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("gas")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("serie")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("paralelo")
        ElseIf question = 3 Then
            FlatLabel1.Text = "Identifica el Estado gas"
            result = "3"
            question = 4
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("escalasdetemperatura")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("liquido")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("gas")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("solido")
        ElseIf question = 4 Then
            FlatLabel1.Text = "Cual de estos es un circuito mixto?"
            result = "1"
            question = 5
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("mixtos")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("paralelo")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("serie")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("solido")
        ElseIf question = 5 Then
            FlatLabel1.Text = "Identifica el Estado solido"
            result = "1"
            question = 6
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("solido")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("gas")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("liquido")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("escalasdetemperatura")
        ElseIf question = 6 Then
            FlatLabel1.Text = "Identifica el Teorema de Bernoulli"
            result = "3"
            question = 7
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("electroscopio")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("hidrostatica")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("hidrodinamica")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("hidraulica")
        ElseIf question = 7 Then
            FlatLabel1.Text = "Identifica el Hidrostatica"
            result = "1"
            question = 8
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("hidrostatica")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("electrodinamica")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("hidraulica")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("hidrodinamica")
        ElseIf question = 8 Then
            FlatLabel1.Text = "Identifica el Hidraulica"
            result = "4"
            question = 9
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("electrodinamica")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("hidrodinamica")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("hidrostatica")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("hidraulica")
        ElseIf question = 9 Then
            FlatLabel1.Text = "Cual es el Jaula de Faraday?"
            result = "3"
            question = 10
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("campomagnetico")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("campoelectrico")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("jauladefaraday")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("escalasdetemperatura")
        ElseIf question = 10 Then

            MessageBox.Show("Nivel 3 Desbloqueado")
            GameStartMenu.FN3.Enabled = True
            Me.Close()
            GameStartMenu.Show()
            GameStartMenu.FlatLabel39.Text = "10/10"
            ''GameStartMenu.FlatLabel35.Text = score
            GameStartMenu.Timer5.Stop()
            GameStartMenu.UDDUpdate()
        End If

        FlatLabel2.Text = question.ToString + "/10"
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Hide()
        GameStartMenu.Show()
        GameStartMenu.Timer5.Stop()

        GameStartMenu.FlatLabel39.Text = FlatLabel2.Text
        ''GameStartMenu.FlatLabel35.Text = 0.0
        GameStartMenu.UDDUpdate()

    End Sub
End Class