Module Module1

    Sub Main()
        Dim toyota As New Car("Toyota")
        toyota.ColorCar = "red"

        Console.WriteLine("color of " & toyota.NameCar & " is " & toyota.ColorCar)
        toyota.Drive()
    End Sub

End Module
