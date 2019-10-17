Public Class BiologiaGame3
    Public score As Integer = 0
    Dim cQuestion As Integer = 0
    Dim cAnswer As Integer = 0
    Dim myAL As New ArrayList()

    Public Sub onLoadUp()
        myAL.Add(New Question("Las caracteristicas que se pueden observar en un individuo constituyen su:", "genotipo", "fenotipo", "cariotipo", "diploide", 2))
        myAL.Add(New Question("Las caracteristicas que usualmente no aparecen en la primera generacion, sino en la segunda, se llaman:", "dominantes", "ocultos", "recesivos", "constantes", 3))
        myAL.Add(New Question("Es una enfermedad ligada al sexo, que se hereda:", "hemofilia", "albinismo", "sida", "anemia falciforme", 1))
        myAL.Add(New Question("Investigador considerado el padre de la genetica:", "Darwin", "Mendel", "Morgan", "Punnett", 2))
        myAL.Add(New Question("Para que se forme un bebe del sexo femenino, los cromosomas sexuales deben ser:", "XY", "XXY", "YY", "XX", 4))
        myAL.Add(New Question("Enfermedades ocacionadas por diversas causas entre las que se encuentran: geneticas, toxinas, virus, etcetera. Provocan afectaciones en equilibrio, memoria, moviemiento, habla, etcetera:", "Apoptosis", "Aneuploidia", "Enfermedades Degenerativas", "Trisomias", 3))
        myAL.Add(New Question("Sucede cuando en lugar de que una celula tenga un solo par de cromosomas, se encuentran tres, por lo que causa diversas afecciones:", "Celulas Madre", "Trisomias", "Enfermedades Degenerativas", "Clonacion", 2))
        myAL.Add(New Question("Obtencion de un individuo identico al progenitor, debido a que se utiliza el nucleo del progenitor, para obtener las mismas caracteristicas:", "Clonacion", "Celulas Madre", "Aneuploidia", "Apoptosis", 1))
        myAL.Add(New Question("¿Cuantos pares de cromosomas tiene un ser humano?", "18 pares", "26 pares", "23 pares", "20 pares", 3))
        myAL.Add(New Question("¿Qué almacena el tejido adiposo?", "Triglicéridos", "Glicerol", "Esteres de ácidos grasos", "Todos", 4))
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
                GameStartMenu.FlatLabel6.Text = "10/10"
                GameStartMenu.Timer3.Stop()
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
        GameStartMenu.FlatLabel6.Text = FlatLabel2.Text
        GameStartMenu.Timer3.Stop()
        GameStartMenu.UDDUpdate()
    End Sub
End Class