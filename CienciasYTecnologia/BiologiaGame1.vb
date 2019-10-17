Public Class BiologiaGame1
    Public score As Integer = 0
    Dim cQuestion As Integer = 0
    Dim cAnswer As Integer = 0
    Dim myAL As New ArrayList()

    Private Sub BGame1_Load(sender As Object, e As EventArgs) Handles Me.Load
        onLoadUp()
        GetQuestion()
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles AB1.Click
        checkAnswer(1)
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles AB2.Click
        checkAnswer(2)
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles AB3.Click
        checkAnswer(3)
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles AB4.Click
        checkAnswer(4)
    End Sub

    Public Sub GetQuestion()
        Dim obj As Question = myAL.Item(cQuestion)
        PB.Image = My.Resources.ResourceManager.GetObject(obj.getQuestion)
        AB1.Text = obj.getA1
        AB2.Text = obj.getA2
        AB3.Text = obj.getA3
        AB4.Text = obj.getA4
        cAnswer = obj.getCorrectAnswer
        AB1.Update()
        AB2.Update()
        AB3.Update()
        AB4.Update()
        AB1.Refresh()
        AB2.Refresh()
        AB3.Refresh()
        AB4.Refresh()
        FlatLabel1.Text = (cQuestion + 1).ToString + "/10"
    End Sub

    Public Sub onLoadUp()
        myAL.Add(New Question("pulmones", "Pulmones", "Traquea", "Faringe", "Laringe", 1))
        myAL.Add(New Question("corazon", "Pulmones", "Corazon", "Traquea", "Laringe", 2))
        myAL.Add(New Question("pancreas", "Higado", "Estomago", "Intestino Delgado", "Pancreas", 4))
        myAL.Add(New Question("estomago", "Estomago", "Esofago", "Intestino Delgado", "Intestino Grueso", 1))
        myAL.Add(New Question("higado", "Intestino Grueso", "Intestino Delgado", "Higado", "Pancreas", 3))
        myAL.Add(New Question("intestino delgado", "Intestino Grueso", "Intestino Delgado", "Corazon", "Esofago", 2))
        myAL.Add(New Question("intestino grueso", "Intestino Grueso", "Intestino Delgado", "Esofago", "Corazon", 1))
        myAL.Add(New Question("apendice", "Higado", "Estomago", "Intestino Delgado", "Apendice", 4))
        myAL.Add(New Question("colon", "Higado", "Estomago", "Intestino Delgado", "Colon", 4))
        myAL.Add(New Question("vejiga", "Vejiga", "Estomago", "Pene", "Vagina", 1))
        Dim ul As New Utilities
        myAL = ul.ShuffleItems(myAL)
    End Sub
    Public Sub checkAnswer(ByVal current As Integer)
        If current = cAnswer Then
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            MessageBox.Show("Respuesta Correcta")
            score = score + 1
            If cQuestion = 9 Then
                MessageBox.Show("Nivel 2 Desbloqueado")
                GameStartMenu.BN2.Enabled = True
                Me.Close()
                GameStartMenu.Show()
                GameStartMenu.FlatLabel4.Text = "10/10"
                GameStartMenu.Timer1.Stop()
                GameStartMenu.UDDUpdate()
                Return
            End If
            cQuestion = cQuestion + 1
            GetQuestion()
        Else
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Hide()
        GameStartMenu.Show()
        GameStartMenu.FlatLabel4.Text = FlatLabel1.Text
        GameStartMenu.Timer1.Stop()
        GameStartMenu.UDDUpdate()
    End Sub
End Class