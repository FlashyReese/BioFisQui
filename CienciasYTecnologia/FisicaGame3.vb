Public Class FisicaGame3
    Public score As Integer = 0
    Dim cQuestion As Integer = 0
    Dim cAnswer As Integer = 0
    Dim myAL As New ArrayList()

    Public Sub onLoadUp()
        myAL.Add(New Question("Indica cual de las siguientes magnitudes relacionadas con el movimiento no es un vector", "Aceleracion media", "Frecuencia", "Velocidad instantanea", "Aceleracion angular", 2))
        myAL.Add(New Question("Cual de las siguientes informaciones no puede ser aportada por el vector desplazamiento", "Trayectoria entre el punto inicial y el punto final", "Distancia entre el punto inicial y el punto final", "Posicion inicial del punto", "Posicion final del punto", 1))
        myAL.Add(New Question("Cual es la unidad de medida que el Sistema Internacional utiliza para indicar el cambio de velocidad por unidad de tiempo?", "m/s", "m.s", "km/h", "m/s²", 4))
        myAL.Add(New Question("Que variable debemos eliminar de la ecuacion de movimiento para obtener la ecuacion de trayectoria?", "Aceleracion", "Masa", "Tiempo", "Espacio recorrido", 3))
        myAL.Add(New Question("Para analizar el moviemiento de un cuerpo hay que tener en cuenta su cambio de posicion con respecto a otro cuerpo. Como se denomina a este?", "Origen", "Sistema de referencia", "Punto cero", "Coordenadas", 2))
        myAL.Add(New Question("Que mide la aceleracion?", "La distancia recorrida por unidad de tiempo", "La diferencia entre la velocidad maxima y la minima de un movil", "La velocidad de un cuerpo en un punto concreto", "El cambio de velocidad por unidad de tiempo", 4))
        myAL.Add(New Question("Que unidad de medida se utiliza para la velocidad angular, segun el Sistema Internacional", "Revoluciones por minuto", "rad/s", "Grados sexagesimales por segundo", "rad/s²", 2))
        myAL.Add(New Question("La variacion de cual de los siguientes valores del vector velocidad provoca una variacion en la aceleracion de un movil?", "Direccion", "Los Tres", "Sentido", "Modulo", 2))
        myAL.Add(New Question("Segun el Sistema Internacional de Medidas, que unidad se utiliza para medir el numero de vueltas que un movil de en unidad de tiempo?", "Hercios", "Radianes", "m/s²", "Revoluciones por minuto", 1))
        myAL.Add(New Question("Establece que un objeto permanecerá en reposo o con movimiento uniforme rectilíneo al menos que sobre él actúe una fuerza externa. Esto es la..", "Ley de Newton", "Segunda Ley de Newton", "Tercera Ley de Newton", "Primera Ley de Newton", 4))
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
                GameStartMenu.FlatLabel38.Text = "10/10"
                GameStartMenu.Timer6.Stop()
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
        GameStartMenu.FlatLabel38.Text = FlatLabel2.Text
        GameStartMenu.Timer6.Stop()
        GameStartMenu.UDDUpdate()
    End Sub
End Class