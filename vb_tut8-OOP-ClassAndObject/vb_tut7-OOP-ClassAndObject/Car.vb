Public Class Car
    Public Sub New()
        Console.WriteLine("Welcome to Car Class")
    End Sub

    Public Sub New(ByVal name As String)
        Me.name = name
    End Sub

    Private name As String
    Private color As String

    Public ReadOnly Property NameCar() As String
        Get
            Return name
        End Get
    End Property

    Public Property ColorCar() As String
        Get
            Return color
        End Get
        Set(ByVal value As String)
            color = value
        End Set
    End Property

    Public Sub Drive()
        Console.WriteLine("Car is Drive")
    End Sub
End Class
