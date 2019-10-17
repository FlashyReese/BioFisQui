Public Class BiologiaGame2
    Public score As Integer = 0
    Dim cQuestion As Integer = 0
    Dim cAnswer As Integer = 0
    Dim myAL As New ArrayList()

    Public Sub onLoadUp()
        myAL.Add(New Question("¿Cual es la Telofase de la Mitosis?", "mitosisprofase", "mitosisinterfase", "mitosistelofase", "mitosismetafase", 3))
        myAL.Add(New Question("¿Cual es la Anafase en la Meiosis?", "meiosismetafase", "meiosisanafase", "meiosisprofase", "meiosistelofase", 2))
        myAL.Add(New Question("¿Cual es el Sistema Muscular?", "sistemamuscular", "sistemadigestivo", "sistemaurinario", "sistemanervioso", 1))
        myAL.Add(New Question("¿Cual es el Sistema Respiratorio?", "sistemacirculatorio", "sistemanervioso", "sistemamuscular", "sistemarespiratorio", 4))
        myAL.Add(New Question("¿Cual es la Metafase en la Meiosis?", "meiosismetafase", "meiosisanafase", "meiosisprofase", "meiosistelofase", 1))
        myAL.Add(New Question("¿Cual es el Sistema Circulatorio?", "sistemacirculatorio", "sistemamuscular", "sistemanervioso", "sistemaesqueleto", 1))
        myAL.Add(New Question("¿Cual es el Sistema Nervioso?", "sistemadigestivo", "sistemamuscular", "sistemanervioso", "sistemarespiratorio", 3))
        myAL.Add(New Question("¿Cual es el Sistema Digestivo?", "sistemarespiratorio", "sistemamuscular", "sistemadigestivo", "sistemaesqueleto", 3))
        myAL.Add(New Question("¿Cual es la Metafase en la Mitosis?", "mitosisprofase", "mitosisinterfase", "mitosistelofase", "mitosismetafase", 4))
        myAL.Add(New Question("¿Cual es el Sistema Urinario?", "sistemacirculatorio", "sistemaurinario", "sistemanervioso", "sistemaesqueleto", 2))
        Dim ul As New Utilities
        myAL = ul.ShuffleItems(myAL)
    End Sub

    Public Sub GetQuestion()
        Dim obj As Question = myAL.Item(cQuestion)
        PictureBox1.Image = My.Resources.ResourceManager.GetObject(obj.getA1)
        PictureBox2.Image = My.Resources.ResourceManager.GetObject(obj.getA2)
        PictureBox3.Image = My.Resources.ResourceManager.GetObject(obj.getA3)
        PictureBox4.Image = My.Resources.ResourceManager.GetObject(obj.getA4)
        FlatLabel1.Text = obj.getQuestion
        cAnswer = obj.getCorrectAnswer
        FlatLabel2.Text = (cQuestion + 1).ToString + "/10"
    End Sub

    Public Sub checkAnswer(ByVal current As Integer)
        If current = cAnswer Then
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            MessageBox.Show("Respuesta Correcta")
            score = score + 1
            If cQuestion = 9 Then
                MessageBox.Show("Nivel 2 Desbloqueado")
                GameStartMenu.BN3.Enabled = True
                Me.Close()
                GameStartMenu.Show()
                GameStartMenu.FlatLabel5.Text = "10/10"
                GameStartMenu.Timer2.Stop()
                GameStartMenu.UDDUpdate()
                Return
            End If
            cQuestion = cQuestion + 1
            GetQuestion()
        Else
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        checkAnswer(1)
    End Sub

    Private Sub BGame2_Load(sender As Object, e As EventArgs) Handles Me.Load
        onLoadUp()
        GetQuestion()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        checkAnswer(2)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        checkAnswer(3)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        checkAnswer(4)
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Hide()
        GameStartMenu.Show()
        GameStartMenu.FlatLabel5.Text = FlatLabel2.Text
        GameStartMenu.Timer2.Stop()
        GameStartMenu.UDDUpdate()
    End Sub
End Class