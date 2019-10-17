Public Class QGame3
    Public score As Integer = 0
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
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

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
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

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
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

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
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
    Dim result As String = ""
    Public question As Integer = 1
    Private Sub BGame3_Load(sender As Object, e As EventArgs) Handles Me.Load
        FlatLabel1.Text = "Rama de la quimica que permite realizar un analisis cuantitativo de las reacciones quimicas."
        result = "3"
        question = 1
        FlatButton1.Text = "Fotometria"
        FlatButton2.Text = "Calorimetria"
        FlatButton3.Text = "Estequiometria"
        FlatButton4.Text = "Colorimetria"
    End Sub

    Public Sub NextQuestion()
        If question = 1 Then
            FlatLabel1.Text = "Sistema que considera al mol como una unidad de medicion"
            result = "3"
            question = 2
            FlatButton1.Text = "Sistema Ingles"
            FlatButton2.Text = "Sistema Metrico Decimal"
            FlatButton3.Text = "Sistem Internacional"
            FlatButton4.Text = "Sistem Frances de Unidades"
        ElseIf question = 2 Then
            FlatLabel1.Text = "El mol es una unidad para medir:"
            result = "1"
            question = 3
            FlatButton1.Text = "Cantidad"
            FlatButton2.Text = "Cantidad de luz"
            FlatButton3.Text = "Cantidad de volumen"
            FlatButton4.Text = "Cantidad de energia"
        ElseIf question = 3 Then
            FlatLabel1.Text = "Leyes consideradas la base de la estequiometria"
            result = "2"
            question = 4
            FlatButton1.Text = "Estequiometricas"
            FlatButton2.Text = "Ponderales"
            FlatButton3.Text = "Cuantitativas"
            FlatButton4.Text = "De medicion"
        ElseIf question = 4 Then
            FlatLabel1.Text = "Al 6.022 x 10²³ se le conoce como:"
            result = "3"
            question = 5
            FlatButton1.Text = "Numero cuantico"
            FlatButton2.Text = "Numero de Dalton"
            FlatButton3.Text = "Numero de Avogadro"
            FlatButton4.Text = "Numero de atomos"
        ElseIf question = 5 Then
            FlatLabel1.Text = "Valor que corresponde a 1 mol de atomos de azufre."
            result = "1"
            question = 6
            FlatButton1.Text = "32.06g"
            FlatButton2.Text = "33.06g"
            FlatButton3.Text = "33.60g"
            FlatButton4.Text = "32.60g"
        ElseIf question = 6 Then
            FlatLabel1.Text = "El hidrogeno y el oxigeno se combinan en dos proporciones distintas y cada una corresponde a un compuesto diferente; el agua(H2O) y el peroxido de hidrogeno (H2O2), respectivamente. Que ley ponderal soporta esta afirmacion?"
            result = "3"
            question = 7
            FlatButton1.Text = "Conversacion de la masa"
            FlatButton2.Text = "Proporciones definidas"
            FlatButton3.Text = "Proporciones multiples"
            FlatButton4.Text = "Proporciones Reciprocas"
        ElseIf question = 7 Then
            FlatLabel1.Text = "Cantidad de atomos de sodio que hay en 1 mol de este elemento."
            result = "2"
            question = 8
            FlatButton1.Text = "6.044 x 10-²³"
            FlatButton2.Text = "6.022 x 10²³"
            FlatButton3.Text = "6.022 x 10-²³"
            FlatButton4.Text = "6.044 x 10²³"
        ElseIf question = 8 Then
            FlatLabel1.Text = "Valor que corresponde a la masa molar de una molecula de Cl2"
            result = "1"
            question = 9
            FlatButton1.Text = "70.9g"
            FlatButton2.Text = "80.9g"
            FlatButton3.Text = "35.5g"
            FlatButton4.Text = "36.0g"
        ElseIf question = 9 Then
            FlatLabel1.Text = "Fuente principal de los contaminantes atmosfericos"
            result = "4"
            question = 10
            FlatButton1.Text = "Erupciones volcanicas"
            FlatButton2.Text = "Reacciones fotoquimicas"
            FlatButton3.Text = "Humo de las industrias"
            FlatButton4.Text = "Quema de combustibles fosiles"
        ElseIf question = 10 Then
            MessageBox.Show("Nivel 3 Completo")
            Me.Close()
            GameStartMenu.Show()
            GameStartMenu.FlatLabel26.Text = "10/10"
            ''GameStartMenu.FlatLabel22.Text = score
            GameStartMenu.Timer9.Stop()
            GameStartMenu.UDDUpdate()
        End If
        FlatButton1.Refresh()
        FlatButton2.Refresh()
        FlatButton3.Refresh()
        FlatButton4.Refresh()
        FlatLabel2.Text = question.ToString + "/10"
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        Me.Hide()
        GameStartMenu.Show()

        GameStartMenu.FlatLabel26.Text = FlatLabel2.Text
        ''GameStartMenu.FlatLabel22.Text = 0.0

        GameStartMenu.Timer9.Stop()
        GameStartMenu.UDDUpdate()
    End Sub

    Private Sub GameSkin_Click(sender As Object, e As EventArgs) Handles GameSkin.Click

    End Sub
End Class