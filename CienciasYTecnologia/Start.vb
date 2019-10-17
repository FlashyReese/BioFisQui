Imports System
Imports System.IO

Public Class Start
    Sub ReadFile()
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
            If Not inputString = "" Then
                UsernameTB.Text = inputString
            Else
                UsernameTB.Text = "Visitante"
            End If

            Console.WriteLine(Directory.GetCurrentDirectory)
        Catch ex As Exception

        End Try

    End Sub

    Sub WriteFile()
        Try
            Dim objStreamWriter As StreamWriter
            Dim path As String = Directory.GetCurrentDirectory + "\cfg"
            Dim filename As String = path + "\lastuser.cfg"
            If Not File.Exists(filename) Then
                File.Create(filename)
            End If
            objStreamWriter = New StreamWriter(filename)
            objStreamWriter.WriteLine(UsernameTB.Text)
            objStreamWriter.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub StartB_Click(sender As Object, e As EventArgs) Handles StartB.Click
        Me.Hide()
        GameStartMenu.Show()
        WriteFile()
        GameStartMenu.username = UsernameTB.Text
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadFile()
    End Sub
End Class
