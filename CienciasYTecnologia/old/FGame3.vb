Public Class FGame3
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
    Dim question As Integer = 1
    Private Sub BGame3_Load(sender As Object, e As EventArgs) Handles Me.Load
        FlatLabel1.Text = "Indica cual de las siguientes magnitudes relacionadas con el movimiento no es un vector"
        result = "2"
        question = 1
        FlatButton1.Text = "Aceleracion media"
        FlatButton2.Text = "Frecuencia"
        FlatButton3.Text = "Velocidad instantanea"
        FlatButton4.Text = "Aceleracion angular"
    End Sub

    Public Sub NextQuestion()
        If question = 1 Then
            FlatLabel1.Text = "Cual de las siguientes informaciones no puede ser aportada por el vector desplazamiento"
            result = "1"
            question = 2
            FlatButton1.Text = "Trayectoria entre el punto inicial y el punto final"
            FlatButton2.Text = "Distancia entre el punto inicial y el punto final"
            FlatButton3.Text = "Posicion inicial del punto"
            FlatButton4.Text = "Posicion final del punto"
        ElseIf question = 2 Then
            FlatLabel1.Text = "Cual es la unidad de medida que el Sistema Internacional utiliza para indicar el cambio de velocidad por unidad de tiempo?"
            result = "4"
            question = 3
            FlatButton1.Text = "m/s"
            FlatButton2.Text = "m.s"
            FlatButton3.Text = "km/h"
            FlatButton4.Text = "m/s²"
        ElseIf question = 3 Then
            FlatLabel1.Text = "Que variable debemos eliminar de la ecuacion de movimiento para obtener la ecuacion de trayectoria?"
            result = "3"
            question = 4
            FlatButton1.Text = "Aceleracion"
            FlatButton2.Text = "Masa"
            FlatButton3.Text = "Tiempo"
            FlatButton4.Text = "Espacio recorrido"
        ElseIf question = 4 Then
            FlatLabel1.Text = "Para analizar el moviemiento de un cuerpo hay que tener en cuenta su cambio de posicion con respecto a otro cuerpo. Como se denomina a este?"
            result = "2"
            question = 5
            FlatButton1.Text = "Origen"
            FlatButton2.Text = "Sistema de referencia"
            FlatButton3.Text = "Punto cero"
            FlatButton4.Text = "Coordenadas"
        ElseIf question = 5 Then
            FlatLabel1.Text = "Que mide la aceleracion?"
            result = "4"
            question = 6
            FlatButton1.Text = "La distancia recorrida por unidad de tiempo"
            FlatButton2.Text = "La diferencia entre la velocidad maxima y la minima de un movil"
            FlatButton3.Text = "La velocidad de un cuerpo en un punto concreto"
            FlatButton4.Text = "El cambio de velocidad por unidad de tiempo"
        ElseIf question = 6 Then
            FlatLabel1.Text = "Que unidad de medida se utiliza para la velocidad angular, segun el Sistema Internacional"
            result = "2"
            question = 7
            FlatButton1.Text = "Revoluciones por minuto"
            FlatButton2.Text = "rad/s"
            FlatButton3.Text = "Grados sexagesimales por segundo"
            FlatButton4.Text = "rad/s²"
        ElseIf question = 7 Then
            FlatLabel1.Text = "La variacion de cual de los siguientes valores del vector velocidad provoca una variacion en la aceleracion de un movil?"
            result = "2"
            question = 8
            FlatButton1.Text = "Direccion"
            FlatButton2.Text = "Los tres"
            FlatButton3.Text = "Sentido"
            FlatButton4.Text = "Modulo"
        ElseIf question = 8 Then
            FlatLabel1.Text = "Segun el Sistema Internacional de Medidas, que unidad se utiliza para medir el numero de vueltas que un movil de en unidad de tiempo?"
            result = "1"
            question = 9
            FlatButton1.Text = "Hercios"
            FlatButton2.Text = "Radianes"
            FlatButton3.Text = "m/s²"
            FlatButton4.Text = "Revoluciones por minuto"
        ElseIf question = 9 Then
            FlatLabel1.Text = "Establece que un objeto permanecerá en reposo o con movimiento uniforme rectilíneo al menos que sobre él actúe una fuerza externa. Esto es la.."
            result = "4"
            question = 10
            FlatButton1.Text = "Ley de Newton"
            FlatButton2.Text = "Segunda Ley de Newton"
            FlatButton3.Text = "Tercera Ley de Newton"
            FlatButton4.Text = "Primera Ley de Newton"
        ElseIf question = 10 Then
            MessageBox.Show("Nivel 3 Completo")
            Me.Close()
            GameStartMenu.Show()
            GameStartMenu.FlatLabel38.Text = "10/10"
            ''GameStartMenu.FlatLabel34.Text = score
            GameStartMenu.Timer6.Stop()
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
        GameStartMenu.Timer6.Stop()
        GameStartMenu.FlatLabel38.Text = FlatLabel2.Text
        ''GameStartMenu.FlatLabel34.Text = 0.0
        GameStartMenu.UDDUpdate()
    End Sub
End Class