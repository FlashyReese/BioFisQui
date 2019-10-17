Imports System.IO
Public Class GameStartMenu
    Public username As String = ""
    Public scorepoint As Integer = 0

    Private Sub GameStartMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BN2.Enabled = False
        BN3.Enabled = False
        FN2.Enabled = False
        FN3.Enabled = False
        QN2.Enabled = False
        QN3.Enabled = False
        ReadFile()
    End Sub

    Private Sub BN1_Click(sender As Object, e As EventArgs) Handles BN1.Click
        Timer1.Start()
        Me.Hide()
        BiologiaGame1.Show()
        ''If (Integer.Parse(FlatLabel9.Text) > 0) And BGame1.questions >= 10 Then
        ''BGame1.score = 0
        ''End If
    End Sub

    Private Sub BN2_Click(sender As Object, e As EventArgs) Handles BN2.Click
        Timer2.Start()

        Me.Hide()
        BiologiaGame2.Show()
        ''If (Integer.Parse(FlatLabel10.Text) > 0) And BGame2.question >= 10 Then
        ''BGame2.score = 0
        ''End If
    End Sub

    Private Sub FN3_Click(sender As Object, e As EventArgs) Handles FN3.Click
        Timer6.Start()
        Me.Hide()
        FisicaGame3.Show()
    End Sub

    Private Sub BN3_Click(sender As Object, e As EventArgs) Handles BN3.Click
        Timer3.Start()
        Me.Hide()
        BiologiaGame3.Show()
        ''If (Integer.Parse(FlatLabel11.Text) > 0) And BGame3.question >= 10 Then
        ''BGame3.score = 0
        ''End If
    End Sub

    Private Sub FB1_Click(sender As Object, e As EventArgs) Handles FB1.Click
        ''MsgBox("En Proceso")
        Timer4.Start()

        Me.Hide()
        FisicaGame1.Show()
    End Sub

    Private Sub QN1_Click(sender As Object, e As EventArgs) Handles QN1.Click
        ''MsgBox("En Proceso")
        Timer7.Start()
        Me.Hide()
        QuimicaGame1.Show()
    End Sub

    Public Sub UDDUpdate()
        If Start.SaveScoreCB.Checked = True Then
            ''scorepoint = ((BGame1.score + BGame2.score + BGame3.score) * 5)

            Dim resultlist As String = ""
            For Each user As String In usersList
                resultlist = resultlist + user
            Next
            If resultlist.ToLower.Contains(username.ToLower) Then
                UpdateFile()
            Else
                usersList.Add(username + ":" + scorepoint.ToString)

            End If
        End If

    End Sub
    Dim usersList As New List(Of String)()
    Sub ReadFile()

        Try
            FlatListBox1.Clear()
            Dim path As String = Directory.GetCurrentDirectory + "\cfg"
            Dim filename As String = path + "\scoreboard.cfg"
            If Directory.Exists(path) = False Then
                Directory.CreateDirectory(path)
            End If
            If File.Exists(filename) Then
                Console.WriteLine("Good to go")
            Else
                File.CreateText(filename)
            End If
            usersList.Clear()
            Dim reader As New System.IO.StreamReader(filename)
            Do While reader.Peek() >= 0
                Dim a As String = reader.ReadLine()
                FlatListBox1.AddItem(a.Replace(":", " "))
                usersList.Add(a)
            Loop
            reader.Close()
        Catch ex As Exception

        End Try

    End Sub

    Sub UpdateFile()
        Try
            ReadUserFile()
            Dim path As String = Directory.GetCurrentDirectory + "\cfg"
            Dim filename As String = path + "\scoreboard.cfg"
            If File.Exists(filename) Then
                File.Delete(filename)
            Else
                File.CreateText(filename)
            End If
            Dim objStreamWriter As StreamWriter
            objStreamWriter = New StreamWriter(filename)
            For Each user As String In usersList
                Dim test As String = user
                If user.ToLower.Contains(username.ToLower) Then
                    test = username + ":" + scorepoint.ToString
                Else

                    test = user
                End If
                objStreamWriter.WriteLine(test)
            Next
            objStreamWriter.Close()
            Console.WriteLine(Directory.GetCurrentDirectory)
            ReadFile()

        Catch ex As Exception

        End Try
    End Sub

    Sub ReadUserFile()
        Try
            Dim path As String = Directory.GetCurrentDirectory + "\cfg"
            Dim filename As String = path + "\lastuser.cfg"
            If Directory.Exists(path) = False Then
                Directory.CreateDirectory(path)
            End If
            If File.Exists(filename) Then
                Console.WriteLine("Good to go")
            Else
                File.CreateText(filename)
            End If
            Dim reader As New System.IO.StreamReader(filename)
            Dim inputString As String = reader.ReadLine
            reader.Close()
            username = inputString
            Console.WriteLine(Directory.GetCurrentDirectory)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub QN2_Click(sender As Object, e As EventArgs) Handles QN2.Click
        Timer8.Start()
        Me.Hide()
        QuimicaGame2.Show()
    End Sub

    Private Sub QN3_Click(sender As Object, e As EventArgs) Handles QN3.Click
        Timer9.Start()
        Me.Hide()
        QuimicaGame3.Show()
    End Sub

    Private Sub FN2_Click(sender As Object, e As EventArgs) Handles FN2.Click
        Timer5.Start()
        Me.Hide()
        FisicaGame2.Show()
    End Sub

    Private Sub FlatLabel43_Click(sender As Object, e As EventArgs) Handles FlatLabel43.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FlatLabel9.Text = FlatLabel9.Text + 0.01
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        FlatLabel10.Text = FlatLabel10.Text + 0.01
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        FlatLabel11.Text = FlatLabel11.Text + 0.01
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        FlatLabel36.Text = FlatLabel36.Text + 0.01
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        FlatLabel35.Text = FlatLabel35.Text + 0.01
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        FlatLabel34.Text = FlatLabel34.Text + 0.01
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        FlatLabel24.Text = FlatLabel24.Text + 0.01
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        FlatLabel23.Text = FlatLabel23.Text + 0.01
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        FlatLabel22.Text = FlatLabel22.Text + 0.01
    End Sub

    Private Sub Biologia_Click(sender As Object, e As EventArgs) Handles Biologia.Click

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)

    End Sub
End Class