Public Class QuimicaGame3
    Public score As Integer = 0
    Dim cQuestion As Integer = 0
    Dim cAnswer As Integer = 0
    Dim myAL As New ArrayList()

    Public Sub onLoadUp()
        myAL.Add(New Question("Rama de la quimica que permite realizar un analisis cuantitativo de las reacciones quimicas.", "Fotometria", "Calorimetria", "Estequiometria", "Colorimetria", 3))
        myAL.Add(New Question("Sistema que considera al mol como una unidad de medicion", "Sistema Ingles", "Sistema Metrico Decimal", "Sistem Internacional", "Sistem Frances de Unidades", 3))
        myAL.Add(New Question("El mol es una unidad para medir:", "Cantidad", "Cantidad de luz", "Cantidad de volumen", "Cantidad de energia", 1))
        myAL.Add(New Question("Leyes consideradas la base de la estequiometria", "Estequiometricas", "Ponderales", "Cuantitativas", "De medicion", 2))
        myAL.Add(New Question("Al 6.022 x 10²³ se le conoce como:", "Numero cuantico", "Numero de Dalton", "Numero de Avogadro", "Numero de atomos", 3))
        myAL.Add(New Question("Valor que corresponde a 1 mol de atomos de azufre.", "32.06g", "33.06g", "33.60g", "32.60g", 1))
        myAL.Add(New Question("El hidrogeno y el oxigeno se combinan en dos proporciones distintas y cada una corresponde a un compuesto diferente; el agua(H2O) y el peroxido de hidrogeno (H2O2), respectivamente. Que ley ponderal soporta esta afirmacion?", "Conversacion de la masa", "Proporciones definidas", "Proporciones multiples", "Proporciones Reciprocas", 3))
        myAL.Add(New Question("Cantidad de atomos de sodio que hay en 1 mol de este elemento.", "6.044 x 10-²³", "6.022 x 10²³", "6.022 x 10-²³", "6.044 x 10²³", 2))
        myAL.Add(New Question("Valor que corresponde a la masa molar de una molecula de Cl2", "70.9g", "80.9g", "35.5g", "36.0g", 1))
        myAL.Add(New Question("Fuente principal de los contaminantes atmosfericos", "Erupciones volcanicas", "Reacciones fotoquimicas", "Humo de las industrias", "Quema de combustibles fosiles", 4))
        Dim ul As New Utilities
        myAL = ul.ShuffleItems(myAL)
    End Sub

    Public Sub GetQuestion()
        Dim obj As Question = myAL.Item(cQuestion)
        FlatLabel1.Text = obj.getQuestion
        FlatButton1.Text = obj.getA1
        FlatButton2.Text = obj.getA2
        FlatButton3.Text = obj.getA3
        FlatButton4.Text = obj.getA4
        cAnswer = obj.getCorrectAnswer
        FlatLabel2.Text = (cQuestion + 1).ToString + "/10"
        FlatButton1.Refresh()
        FlatButton2.Refresh()
        FlatButton3.Refresh()
        FlatButton4.Refresh()
    End Sub

    Public Sub checkAnswer(ByVal current As Integer)
        If current = cAnswer Then
            GameStartMenu.scorepoint = GameStartMenu.scorepoint + 5
            MessageBox.Show("Respuesta Correcta")
            score = score + 1
            If cQuestion = 9 Then
                MessageBox.Show("Nivel 3 Completo")
                Me.Close()
                GameStartMenu.Show()
                GameStartMenu.FlatLabel26.Text = "10/10"
                GameStartMenu.Timer9.Stop()
                GameStartMenu.UDDUpdate()
                Return
            End If
            cQuestion = cQuestion + 1
            GetQuestion()
        Else
            MessageBox.Show("Respuesta Incorrecta, intente de nuevo")
        End If
    End Sub
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        checkAnswer(1)
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        checkAnswer(2)
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        checkAnswer(3)
    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        checkAnswer(4)
    End Sub
    Private Sub BGame3_Load(sender As Object, e As EventArgs) Handles Me.Load
        onLoadUp()
        GetQuestion()
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        Me.Hide()
        GameStartMenu.Show()
        GameStartMenu.FlatLabel26.Text = FlatLabel2.Text
        GameStartMenu.Timer9.Stop()
        GameStartMenu.UDDUpdate()
    End Sub
End Class