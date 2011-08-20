Module Module1

    Sub Main()
        ' Declares Variable name "var1" type Integer 
        Dim var1 As Integer
        ' Default of Integer is 0
        Console.WriteLine(var1)
        ' Set value to var1
        var1 = 1000
        Console.WriteLine(var1)
        ' Plus var1 with 1
        var1 = var1 + 1
        Console.WriteLine(var1)
        ' Or
        var1 += 1
        Console.WriteLine(var1)

        ' Declares Variable name "name" type String
        ' Variable can assign in Declare Variable
        Dim name As String = "Wingyplus"
        Console.WriteLine(name)

        Dim message As String
        ' Concatenation String with & or +
        message = "Hello My name is " & name
        Console.WriteLine(message)
        ' Output is "Hello My name is Wingyplus"

        ' Char type contain single Character
        Dim ch As Char = "z"
        Console.WriteLine(ch)
        ' But assign String type to Char type. It's contain first Character
        ch = "test character"
        Console.WriteLine(ch)
    End Sub

End Module
