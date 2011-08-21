Module Module1

    Sub Main()
        Dim shipping As BaseClass = New DerivedClass()
        Dim result = shipping.CalculateShipping(3, 3)
        Console.WriteLine(result)
    End Sub

End Module
