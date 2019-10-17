Public Class BGame3
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
        FlatLabel1.Text = "Las caracteristicas que se pueden observar en un individuo constituyen su:"
        result = "2"
        question = 1
        FlatButton1.Text = "genotipo"
        FlatButton2.Text = "fenotipo"
        FlatButton3.Text = "cariotipo"
        FlatButton4.Text = "diploide"
    End Sub

    Public Sub NextQuestion()
        If question = 1 Then
            FlatLabel1.Text = "Las caracteristicas que usualmente no aparecen en la primera generacion, sino en la segunda, se llaman:"
            result = "3"
            question = 2
            FlatButton1.Text = "dominantes"
            FlatButton2.Text = "ocultos"
            FlatButton3.Text = "recesivos"
            FlatButton4.Text = "constantes"
        ElseIf question = 2 Then
            FlatLabel1.Text = "Es una enfermedad ligada al sexo, que se hereda:"
            result = "1"
            question = 3
            FlatButton1.Text = "hemofilia"
            FlatButton2.Text = "albinismo"
            FlatButton3.Text = "sida"
            FlatButton4.Text = "anemia falciforme"
        ElseIf question = 3 Then
            FlatLabel1.Text = "Investigador considerado el padre de la genetica:"
            result = "2"
            question = 4
            FlatButton1.Text = "Darwin"
            FlatButton2.Text = "Mendel"
            FlatButton3.Text = "Morgan"
            FlatButton4.Text = "Punnett"
        ElseIf question = 4 Then
            FlatLabel1.Text = "Para que se forme un bebe del sexo femenino, los cromosomas sexuales deben ser:"
            result = "4"
            question = 5
            FlatButton1.Text = "XY"
            FlatButton2.Text = "XXY"
            FlatButton3.Text = "YY"
            FlatButton4.Text = "XX"
        ElseIf question = 5 Then
            FlatLabel1.Text = "Enfermedades ocacionadas por diversas causas entre las que se encuentran: geneticas, toxinas, virus, etcetera. Provocan afectaciones en equilibrio, memoria, moviemiento, habla, etcetera:"
            result = "3"
            question = 6
            FlatButton1.Text = "Apoptosis"
            FlatButton2.Text = "Aneuploidia"
            FlatButton3.Text = "Enfermedades Degenerativas"
            FlatButton4.Text = "Trisomias"
        ElseIf question = 6 Then
            FlatLabel1.Text = "Sucede cuando en lugar de que una celula tenga un solo par de cromosomas, se encuentran tres, por lo que causa diversas afecciones:"
            result = "2"
            question = 7
            FlatButton1.Text = "Celulas Madre"
            FlatButton2.Text = "Trisomias"
            FlatButton3.Text = "Enfermedades Degenerativas"
            FlatButton4.Text = "Clonacion"
        ElseIf question = 7 Then
            FlatLabel1.Text = "Obtencion de un individuo identico al progenitor, debido a que se utiliza el nucleo del progenitor, para obtener las mismas caracteristicas:"
            result = "1"
            question = 8
            FlatButton1.Text = "Clonacion"
            FlatButton2.Text = "Celulas Madre"
            FlatButton3.Text = "Aneuploidia"
            FlatButton4.Text = "Apoptosis"
        ElseIf question = 8 Then
            FlatLabel1.Text = "Cuantos pares de cromosomas tiene un ser humano?"
            result = "3"
            question = 9
            FlatButton1.Text = "18 pares"
            FlatButton2.Text = "26 pares"
            FlatButton3.Text = "23 pares"
            FlatButton4.Text = "20 pares"
        ElseIf question = 9 Then
            FlatLabel1.Text = "¿Qué almacena el tejido adiposo?"
            result = "4"
            question = 10
            FlatButton1.Text = "Triglicéridos"
            FlatButton2.Text = "Glicerol"
            FlatButton3.Text = "Esteres de ácidos grasos"
            FlatButton4.Text = "Todos"
        ElseIf question = 10 Then
            MessageBox.Show("Nivel 3 Completo")
            Me.Close()
            GameStartMenu.Show()
            GameStartMenu.FlatLabel6.Text = "10/10"
            ''GameStartMenu.FlatLabel11.Text = score
            GameStartMenu.Timer3.Stop()
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
        GameStartMenu.FlatLabel6.Text = FlatLabel2.Text
        ''GameStartMenu.FlatLabel11.Text = "0.0"
        ''question = 1
        GameStartMenu.Timer3.Stop()
        GameStartMenu.UDDUpdate()
    End Sub
End Class