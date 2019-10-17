Public Class QGame1
    Public score As Integer = 0
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles AB1.Click
        If result.ToLower = AB1.Text.ToLower Then
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            MessageBox.Show("Respuesta Correcta")
            score = score + 1
            NextQuestion()
            Dim line As String = "".Split("test")(0)
        Else
            ''NextQuestion()
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub
    Public questions As Integer = 1
    Dim result As String = ""
    Private Sub BGame1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PB.Image = My.Resources.ResourceManager.GetObject("hidrogeno")
        result = "hidrogeno"
        AB1.Text = "Hidrogeno"
        AB2.Text = "Hafnio"
        AB3.Text = "Helio"
        AB4.Text = "Mercurio"
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
        If result.ToLower = "hidrogeno" Then
            PB.Image = My.Resources.ResourceManager.GetObject("litio")
            result = "litio"
            AB1.Text = "Litio"
            AB2.Text = "Indio"
            AB3.Text = "Yodo"
            AB4.Text = "Itrio"
            questions = 2
        ElseIf result.ToLower = "litio" Then
            PB.Image = My.Resources.ResourceManager.GetObject("radon")
            result = "radon"
            AB1.Text = "Rubidio"
            AB2.Text = "Radio"
            AB3.Text = "Radon"
            AB4.Text = "Renio"
            questions = 3
        ElseIf result.ToLower = "radon" Then
            PB.Image = My.Resources.ResourceManager.GetObject("oro")
            result = "oro"
            AB1.Text = "Cobre"
            AB2.Text = "Oro"
            AB3.Text = "Plata"
            AB4.Text = "Astato"
            questions = 4
        ElseIf result.ToLower = "oro" Then
            PB.Image = My.Resources.ResourceManager.GetObject("kripton")
            result = "kripton"
            AB1.Text = "Potasio"
            AB2.Text = "Circonio"
            AB3.Text = "Cromo"
            AB4.Text = "Kripton"
            questions = 5
        ElseIf result.ToLower = "kripton" Then
            PB.Image = My.Resources.ResourceManager.GetObject("osmio")
            result = "osmio"
            AB1.Text = "Oranesson"
            AB2.Text = "Osmio"
            AB3.Text = "Oxigeno"
            AB4.Text = "Orbitanio"
            questions = 6
        ElseIf result.ToLower = "osmio" Then
            PB.Image = My.Resources.ResourceManager.GetObject("carbono")
            result = "carbono"
            AB1.Text = "Calcio"
            AB2.Text = "Cobre"
            AB3.Text = "Carbono"
            AB4.Text = "Cobalto"
            questions = 7
        ElseIf result.ToLower = "carbono" Then
            PB.Image = My.Resources.ResourceManager.GetObject("cobre")
            result = "cobre"
            AB1.Text = "Cobalto"
            AB2.Text = "Cobre"
            AB3.Text = "Cromo"
            AB4.Text = "Cesio"
            questions = 8
        ElseIf result.ToLower = "cobre" Then
            PB.Image = My.Resources.ResourceManager.GetObject("cloro")
            result = "cloro"
            AB1.Text = "Cloro"
            AB2.Text = "Carbono"
            AB3.Text = "Cromo"
            AB4.Text = "Calcio"
            questions = 9
        ElseIf result.ToLower = "cloro" Then
            PB.Image = My.Resources.ResourceManager.GetObject("yodo")
            result = "yodo"
            AB1.Text = "Indio"
            AB2.Text = "Iridio"
            AB3.Text = "Yodo"
            AB4.Text = "Azufre"
            questions = 10
        ElseIf result.ToLower = "yodo" Then
            MessageBox.Show("Nivel 2 Desbloqueado")
            GameStartMenu.QN2.Enabled = True
            Me.Close()
            GameStartMenu.Show()
            GameStartMenu.FlatLabel28.Text = "10/10"
            ''GameStartMenu.FlatLabel24.Text = score
            GameStartMenu.Timer7.Stop()
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
        GameStartMenu.FlatLabel28.Text = FlatLabel1.Text
        ''GameStartMenu.FlatLabel24.Text = 0.0
        GameStartMenu.Timer7.Stop()
        GameStartMenu.UDDUpdate()

    End Sub
End Class