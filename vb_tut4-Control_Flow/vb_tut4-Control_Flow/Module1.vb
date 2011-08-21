Module Module1

    Sub Main()
        ' If condition [ Then ]
        '    [ statements ]
        ' [ ElseIf elseifcondition [ Then ]
        '    [ elseifstatements ] ]
        ' [ Else
        '    [ elsestatements ] ]
        ' End If
        ' -or-
        ' If condition Then [ statements ] [ Else [ elsestatements ] ]
        Dim test As Integer = Integer.Parse(Console.ReadLine())

        If test >= 80 And test <= 100 Then
            Console.WriteLine("A")
        ElseIf test >= 70 And test < 80 Then
            Console.WriteLine("B")
        ElseIf test >= 60 And test < 70 Then
            Console.WriteLine("C")
        ElseIf test >= 50 And test < 60 Then
            Console.WriteLine("D")
        Else
            Console.WriteLine("F")
        End If
    End Sub

End Module
