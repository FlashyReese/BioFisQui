Public Class FisicaGame1
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
        myAL.Add(New Question("campoelectrico", "Campo Magnetico", "Electrodinamica", "Campo Electrico", "Electroscopio", 3))
        myAL.Add(New Question("escalasdetemperatura", "Escalas de Temperatura", "Electroscopio", "Campo Magnetico", "Campo Electrico", 1))
        myAL.Add(New Question("campomagnetico", "Campo Magnetico", "Campo Electrico", "Escalas de Temperatura", "Electrodinamica", 1))
        myAL.Add(New Question("electroscopio", "Electrodinamica", "Campo Electrico", "Campo Magnetico", "Electroscopio", 4))
        myAL.Add(New Question("transistor", "Transistor", "Conductor", "Aislador", "Solido", 1))
        myAL.Add(New Question("aislador", "Gas", "Aislador", "Transistor", "Conductor", 2))
        myAL.Add(New Question("conveccion", "Liquido", "Induccion", "Conveccion", "Radiacion", 3))
        myAL.Add(New Question("conduccion", "Radiacion", "Conduccion", "Induccion", "Conveccion", 2))
        myAL.Add(New Question("lenz", "Ley de Coulomb", "Ley de Ohm", "Ley de Faraday", "Ley de Lenz", 4))
        myAL.Add(New Question("radiacion", "Radiacion", "Conduccion", "Conveccion", "Induccion", 1))
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
                GameStartMenu.FN2.Enabled = True
                Me.Close()
                GameStartMenu.Show()
                GameStartMenu.FlatLabel40.Text = "10/10"
                GameStartMenu.Timer4.Stop()
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
        GameStartMenu.FlatLabel40.Text = FlatLabel1.Text
        GameStartMenu.Timer4.Stop()
        GameStartMenu.UDDUpdate()
    End Sub
End Class