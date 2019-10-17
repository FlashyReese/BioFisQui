Public Class FGame1
    Public score As Integer = 0
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles AB1.Click
        If result.ToLower = AB1.Text.ToLower Then
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            MessageBox.Show("Respuesta Correcta")
            score = score + 1
            NextQuestion()

        Else
            ''NextQuestion()
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub
    Dim questions As Integer = 1
    Dim result As String = ""
    Private Sub BGame1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PB.Image = My.Resources.ResourceManager.GetObject("campoelectrico")
        result = "campo electrico"
        AB1.Text = "Campo Magnetico"
        AB2.Text = "Electrodinamica"
        AB3.Text = "Campo Electrico"
        AB4.Text = "Electroscopio"
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles AB2.Click
        If result.ToLower = AB2.Text.ToLower Then
            MessageBox.Show("Respuesta Correcta")
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            score = score + 1
            NextQuestion()

        Else
            ''NextQuestion()
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles AB3.Click
        If result.ToLower = AB3.Text.ToLower Then
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            MessageBox.Show("Respuesta Correcta")
            score = score + 1
            NextQuestion()

        Else
            ''NextQuestion()
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles AB4.Click
        If result.ToLower = AB4.Text.ToLower Then
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            MessageBox.Show("Respuesta Correcta")
            score = score + 1
            NextQuestion()

        Else
            ''NextQuestion()
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub

    Public Sub NextQuestion()
        If result.ToLower = "campo electrico" Then
            PB.Image = My.Resources.ResourceManager.GetObject("escalasdetemperatura")
            result = "escalas de temperatura"
            AB1.Text = "Escalas de temperatura"
            AB2.Text = "Electroscopio"
            AB3.Text = "Campo Magnetico"
            AB4.Text = "Campo Electrico"
            questions = 2
        ElseIf result.ToLower = "escalas de temperatura" Then
            PB.Image = My.Resources.ResourceManager.GetObject("campomagnetico")
            result = "campo magnetico"
            AB1.Text = "Campo Magnetico"
            AB2.Text = "Campo Electrico"
            AB3.Text = "Escalas de Temperatura"
            AB4.Text = "Electrodinamica"
            questions = 3
        ElseIf result.ToLower = "campo magnetico" Then
            PB.Image = My.Resources.ResourceManager.GetObject("electroscopio")
            result = "electroscopio"
            AB1.Text = "Electrodinamica"
            AB2.Text = "Campo Electrico"
            AB3.Text = "Campo Magnetico"
            AB4.Text = "Electroscopio"
            questions = 4
        ElseIf result.ToLower = "electroscopio" Then
            PB.Image = My.Resources.ResourceManager.GetObject("transistor")
            result = "transistor"
            AB1.Text = "Transistor"
            AB2.Text = "Conductor"
            AB3.Text = "Aislador"
            AB4.Text = "Solido"
            questions = 5
        ElseIf result.ToLower = "transistor" Then
            PB.Image = My.Resources.ResourceManager.GetObject("aislador")
            result = "aislador"
            AB1.Text = "Gas"
            AB2.Text = "Aislador"
            AB3.Text = "Transistor"
            AB4.Text = "Conductor"
            questions = 6
        ElseIf result.ToLower = "aislador" Then
            PB.Image = My.Resources.ResourceManager.GetObject("conveccion")
            result = "conveccion"
            AB1.Text = "Liquido"
            AB2.Text = "Induccion"
            AB3.Text = "Conveccion"
            AB4.Text = "Radiacion"
            questions = 7
        ElseIf result.ToLower = "conveccion" Then
            PB.Image = My.Resources.ResourceManager.GetObject("conduccion")
            result = "conduccion"
            AB1.Text = "Radiacion"
            AB2.Text = "Conduccion"
            AB3.Text = "Induccion"
            AB4.Text = "Conveccion"
            questions = 8
        ElseIf result.ToLower = "conduccion" Then
            PB.Image = My.Resources.ResourceManager.GetObject("lenz")
            result = "ley de lenz"
            AB1.Text = "Ley de Coulomb"
            AB2.Text = "Ley de Ohm"
            AB3.Text = "Ley de Faraday"
            AB4.Text = "Ley de Lenz"
            questions = 9
        ElseIf result.ToLower = "ley de lenz" Then
            PB.Image = My.Resources.ResourceManager.GetObject("radiacion")
            result = "radiacion"
            AB1.Text = "Radiacion"
            AB2.Text = "Conduccion"
            AB3.Text = "Induccion"
            AB4.Text = "Conveccion"
            questions = 10
        ElseIf result.ToLower = "radiacion" Then
            MessageBox.Show("Nivel 2 Desbloqueado")
            GameStartMenu.FN2.Enabled = True
            Me.Close()
            GameStartMenu.Show()
            GameStartMenu.FlatLabel40.Text = "10/10"
            ''GameStartMenu.FlatLabel36.Text = score

            GameStartMenu.Timer4.Stop()
            GameStartMenu.UDDUpdate()
        End If

        AB1.Update()
        AB2.Update()
        AB3.Update()
        AB4.Update()
        AB1.Refresh()
        AB2.Refresh()
        AB3.Refresh()
        AB4.Refresh()
        FlatLabel1.Text = questions.ToString + "/10"
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Hide()
        GameStartMenu.Show()
        GameStartMenu.FlatLabel40.Text = FlatLabel1.Text
        ''GameStartMenu.FlatLabel36.Text = "0.0"
        GameStartMenu.Timer4.Stop()
        GameStartMenu.UDDUpdate()

    End Sub
End Class