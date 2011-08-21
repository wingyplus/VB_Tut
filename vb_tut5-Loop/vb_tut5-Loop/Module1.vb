Module Module1

    Sub Main()
        ' If not keyword Step it's plus 1 to counter
        Dim finish As Integer = Integer.Parse(Console.ReadLine())
        For i = 1 To finish
            For j = 1 To i
                Console.Write("*")
            Next j
            Console.WriteLine()
        Next i

        ' While Loop
        Dim counter = 0
        While counter <= 100
            Console.WriteLine(counter & " ")
            counter += 7
        End While

        counter = 0
        Do
            Console.WriteLine(counter)
            counter += 1
        Loop Until counter > 10

        counter = 0
        Do
            Console.WriteLine(counter)
            counter += 1
        Loop While counter <= 10
    End Sub

End Module
