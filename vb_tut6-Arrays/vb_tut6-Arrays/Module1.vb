Module Module1

    Sub Main()
        ' Index is begin 0 to Range + 1
        ' When use students.Length in Loop must be -1
        Dim students(7) As Integer
        For counter = 0 To students.Length - 1
            students(counter) = counter
            Console.WriteLine(students(counter))
        Next

        ' Arrays two dimension
        ' 40 + 1 * 5 + 1 = 41 * 6 = 246
        Dim person(40, 5) As Integer
        Console.WriteLine(person.Length)
        Console.WriteLine(person.GetLength(0))
    End Sub

End Module
