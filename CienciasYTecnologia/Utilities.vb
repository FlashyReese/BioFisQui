Public Class Utilities

    Public Function ShuffleItems(ByVal arrList As ArrayList) As ArrayList
        Dim Random As New System.Random
        Dim tempArray As ArrayList = arrList
        Dim a2 As New ArrayList
        While tempArray.Count > 0
            Dim Index As System.Int32 = Random.Next(0, tempArray.Count)
            a2.Add(arrList(Index))
            tempArray.RemoveAt(Index)
        End While
        Return a2
    End Function
End Class
