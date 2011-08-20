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

        ' Comparing Operators
        '   It return Boolean type (True or False)
        ' = (Equal)
        Console.WriteLine("= (Equal)")
        Console.WriteLine(23 = 33)
        Console.WriteLine(1 = 1)
        Console.WriteLine("123" = "123") ' compare String
        ' <> (Not Equal)
        Console.WriteLine("<> (Not Equal)")
        Console.WriteLine(23 <> 33)
        Console.WriteLine(1 <> 1)
        Console.WriteLine("Hello" <> "") ' If Value isn't empty String
        ' > (Greater than)
        Console.WriteLine("> (Greater than)")
        Console.WriteLine(3 > 5)
        Console.WriteLine("124" > "123")
        ' < (Less than)
        Console.WriteLine("< (Less than)")
        Console.WriteLine(3 < 5)
        Console.WriteLine("124" < "123")
        ' <= (Less than or Equal to)
        Console.WriteLine("<= (Less than or Equal to)")
        Console.WriteLine(3 <= 4)
        Console.WriteLine(4 <= 4)
        ' >= (Greater than or Equal to)
        Console.WriteLine(">= (Greater than or Equal to)")
        Console.WriteLine(5 >= 3)
        Console.WriteLine(5 >= 5)

        ' Concatenation Operators 
        '   Use for join multiple Strings into single String
        '   There are two operators is "+" and "&"
        Dim x As String = "Con" & "caten" & "ation"
        Dim y As String = "Con" + "caten" + "ation"
        ' The + operator has a complex set of rules that determine whether to add, concatenate, signal a compiler error, 
        ' or throw a run-time InvalidCastException exception.

    End Sub

End Module