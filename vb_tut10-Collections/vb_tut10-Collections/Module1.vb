Module Module1

    Sub Main()
        Dim list As ICollection(Of String) = New LinkedList(Of String)
        list.Add("Hello")
        list.Add("World")
        list.Add("Grean")

        For Each word In list
            Console.Write(word & " ")
        Next
        Console.WriteLine()

        Dim map As New Dictionary(Of String, String)
        map.Add("name", "wingyplus")
        map.Add("username", "grean")
        Console.WriteLine(map.Item("name"))
    End Sub

End Module
