﻿Public Class DerivedClass
    Inherits BaseClass

    Public Overrides Function CalculateShipping(ByVal Dist As Double, ByVal Rate As Double) As Double
        Console.WriteLine("CalculateShipping on DerivedClass")
        Return MyBase.CalculateShipping(Dist, Rate) * 2
    End Function

End Class
