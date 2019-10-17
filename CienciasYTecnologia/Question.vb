Public Class Question

    Private question As String
    Private a1 As String
    Private a2 As String
    Private a3 As String
    Private a4 As String
    Private ca As Integer

    Public Sub New(ByVal question As String, ByVal a1 As String, ByVal a2 As String, ByVal a3 As String, ByVal a4 As String, ByVal correctAnswer As Integer)
        MyBase.New
        Me.question = question
        Me.a1 = a1
        Me.a2 = a2
        Me.a3 = a3
        Me.a4 = a4
        Me.ca = correctAnswer
    End Sub

    Public Function getQuestion() As String
        Return Me.question
    End Function

    Public Function getA1() As String
        Return Me.a1
    End Function

    Public Function getA2() As String
        Return Me.a2
    End Function

    Public Function getA3() As String
        Return Me.a3
    End Function

    Public Function getA4() As String
        Return Me.a4
    End Function

    Public Function getCorrectAnswer() As Integer
        Return Me.ca
    End Function
End Class