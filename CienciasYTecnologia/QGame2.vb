Public Class QGame2
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
        FlatLabel1.Text = "Cual de estos groups de elementos son Halogenos?"
        result = "3"
        question = 1
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("metaloides")
        PictureBox2.Image = My.Resources.ResourceManager.GetObject("alcantinoterreos")
        PictureBox3.Image = My.Resources.ResourceManager.GetObject("halogenos")
        PictureBox4.Image = My.Resources.ResourceManager.GetObject("alcalinos")
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
            FlatLabel1.Text = "Cual de estos grupos de elementos son Metaloides?"
            result = "2"
            question = 2
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("gases nobles")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("metaloides")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("grupo 10")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("grupo 1")
        ElseIf question = 2 Then
            FlatLabel1.Text = "Cual de estos grupos de elementos son Alcalinoterreos?"
            result = "1"
            question = 3
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("alcantinoterreos")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("grupo 1")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("metaloides")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("alcalinos")
        ElseIf question = 3 Then
            FlatLabel1.Text = "Cual de estos grupos de elementos son Alcalinos"
            result = "4"
            question = 4
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("halogenos")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("metales de transicion")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("lantanidos")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("alcalinos")
        ElseIf question = 4 Then
            FlatLabel1.Text = "Cual de estos grupos de elementos son Metales de Transicion?"
            result = "1"
            question = 5
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("metales de transicion")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("Actinidos")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("grupo 10")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("grupo 1")
        ElseIf question = 5 Then
            FlatLabel1.Text = "Cual de estos grupos de elementos son Lantanidos?"
            result = "1"
            question = 6
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("lantanidos")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("Actinidos")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("metaloides")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("halogenos")
        ElseIf question = 6 Then
            FlatLabel1.Text = "Cual de estos grupos de elementos son Actinidos?"
            result = "3"
            question = 7
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("alcantinoterreos")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("grupo 10")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("Actinidos")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("grupo 1")
        ElseIf question = 7 Then
            FlatLabel1.Text = "Cual de estos grupos de elementos son los Gases Nobles?"
            result = "3"
            question = 8
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("Actinidos")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("alcalinos")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("gases nobles")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("grupo 10")
        ElseIf question = 8 Then
            FlatLabel1.Text = "Cual grupo corresponde en el grupo 10?"
            result = "4"
            question = 9
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("grupo 1")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("halogenos")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("alcantinoterreos")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("grupo 10")
        ElseIf question = 9 Then
            FlatLabel1.Text = "Cual grupo corresponde en el grupo 1?"
            result = "2"
            question = 10
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("grupo 10")
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("grupo 1")
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("Actinidos")
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("lantanidos")
        ElseIf question = 10 Then

            MessageBox.Show("Nivel 3 Desbloqueado")
            GameStartMenu.QN3.Enabled = True
            Me.Close()
            GameStartMenu.Show()
            GameStartMenu.FlatLabel27.Text = "10/10"
            ''GameStartMenu.FlatLabel23.Text = score

            GameStartMenu.Timer8.Stop()
            GameStartMenu.UDDUpdate()
        End If

        FlatLabel2.Text = question.ToString + "/10"
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Hide()
        GameStartMenu.Show()

        GameStartMenu.FlatLabel27.Text = FlatLabel2.Text
        ''GameStartMenu.FlatLabel23.Text = 0.0
        GameStartMenu.UDDUpdate()
        GameStartMenu.Timer8.Stop()

    End Sub
End Class