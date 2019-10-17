Public Class BGame1
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
    Public questions As Integer = 1
    Dim result As String = ""
    Private Sub BGame1_Load(sender As Object, e As EventArgs) Handles Me.Load
        PB.Image = My.Resources.ResourceManager.GetObject("pulmones")
        result = "Pulmones"
        AB1.Text = "Pulmones"
        AB2.Text = "Traquea"
        AB3.Text = "Faringe"
        AB4.Text = "Laringe"
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
        If result.ToLower = "pulmones" Then
            PB.Image = My.Resources.ResourceManager.GetObject("corazon")
            result = "corazon"
            AB1.Text = "Pulmones"
            AB2.Text = "Corazon"
            AB3.Text = "Traquea"
            AB4.Text = "Laringe"
            questions = 2
        ElseIf result.ToLower = "corazon" Then
            PB.Image = My.Resources.ResourceManager.GetObject("pancreas")
            result = "pancreas"
            AB1.Text = "Higado"
            AB2.Text = "Estomago"
            AB3.Text = "Intestino Delgado"
            AB4.Text = "Pancreas"
            questions = 3
        ElseIf result.ToLower = "pancreas" Then
            PB.Image = My.Resources.ResourceManager.GetObject("estomago")
            result = "estomago"
            AB1.Text = "Estomago"
            AB2.Text = "Esofago"
            AB3.Text = "Intestino Delgado"
            AB4.Text = "Intestino Grueso"
            questions = 4
        ElseIf result.ToLower = "estomago" Then
            PB.Image = My.Resources.ResourceManager.GetObject("higado")
            result = "higado"
            AB1.Text = "Intestino Grueso"
            AB2.Text = "Intestino Delgado"
            AB3.Text = "Higado"
            AB4.Text = "Pancreas"
            questions = 5
        ElseIf result.ToLower = "higado" Then
            PB.Image = My.Resources.ResourceManager.GetObject("intestino delgado")
            result = "intestino delgado"
            AB1.Text = "Intestino Grueso"
            AB2.Text = "Intestino Delgado"
            AB3.Text = "Corazon"
            AB4.Text = "Esofago"
            questions = 6
        ElseIf result.ToLower = "intestino delgado" Then
            PB.Image = My.Resources.ResourceManager.GetObject("intestino grueso")
            result = "intestino grueso"
            AB1.Text = "Intestino Grueso"
            AB2.Text = "Intestino Delgado"
            AB3.Text = "Esofago"
            AB4.Text = "Corazon"
            questions = 7
        ElseIf result.ToLower = "intestino grueso" Then
            PB.Image = My.Resources.ResourceManager.GetObject("apendice")
            result = "apendice"
            AB1.Text = "Higado"
            AB2.Text = "Estomago"
            AB3.Text = "Intestino Delgado"
            AB4.Text = "Apendice"
            questions = 8
        ElseIf result.ToLower = "apendice" Then
            PB.Image = My.Resources.ResourceManager.GetObject("colon")
            result = "colon"
            AB1.Text = "Higado"
            AB2.Text = "Estomago"
            AB3.Text = "Intestino Delgado"
            AB4.Text = "Colon"
            questions = 9
        ElseIf result.ToLower = "colon" Then
            PB.Image = My.Resources.ResourceManager.GetObject("vejiga")
            result = "vejiga"
            AB1.Text = "Vejiga"
            AB2.Text = "Estomago"
            AB3.Text = "Pene"
            AB4.Text = "Vagina"
            questions = 10
        ElseIf result.ToLower = "vejiga" Then
            MessageBox.Show("Nivel 2 Desbloqueado")
            GameStartMenu.BN2.Enabled = True
            Me.Close()
            GameStartMenu.Show()
            GameStartMenu.FlatLabel4.Text = "10/10"
            ''GameStartMenu.FlatLabel9.Text = score
            GameStartMenu.Timer1.Stop()
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
        GameStartMenu.FlatLabel4.Text = FlatLabel1.Text
        ''result = "Pulmones"
        ''GameStartMenu.FlatLabel9.Text = "0.0"
        GameStartMenu.Timer1.Stop()
        GameStartMenu.UDDUpdate()
        ''questions = 1
    End Sub
End Class