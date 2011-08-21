Public Class BaseClass
    Public Overridable Function CalculateShipping(ByVal Dist As Double, ByVal Rate As Double) As Double
        Return (Dist + Rate) / 2
    End Function
End Class
