Module Module1

    Sub Main()
        ' Arithmethic Operator
        Dim x As Integer
        x = 43 + 57 ' Plus Value
        Console.WriteLine(x)
        x = 100 - 50 ' Subtract Value
        Console.WriteLine(x)

        Dim y As Integer
        y = -x ' Negative Value using "-"
        Console.WriteLine(x)

        ' Divition in Integer type use \ (is carried out)
        Console.WriteLine(y \ 2.23)
        ' If use / it convert Integer to Floating-point type

        ' Notes ******
        '   If Integer division by zero it's return DivideByZeroException
        '   But Double type is return not Exception
        ' If divide by 0 return Infinity
        Console.WriteLine(2.5 / 0)
        ' Exponentiation use ^
        Console.WriteLine(5 ^ 3) ' return 125
        ' Shift bits use >> to shift right or << to shift left
        Console.WriteLine(12 << 3) ' return 96
        Console.WriteLine(12 >> 3) ' return 1
    End Sub

End Module
