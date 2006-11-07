Public Class OutputParameter

    Dim strDescription As String
    Dim intType As Integer
    Dim objValue As Object

    Public Enum ValueType
        Text = 0
        Number = 1
        Hex = 2
        File = 3
        Color = 4
    End Enum

    Public Sub New(ByVal Description As String, ByVal ValueType As ValueType, ByVal OptionalValue As Integer)
        strDescription = Description
        intType = Type
    End Sub

    Public ReadOnly Property Description() As String
        Get
            Return strDescription
        End Get
    End Property

    Public ReadOnly Property Type() As Integer
        Get
            Return intType
        End Get
    End Property

    Public ReadOnly Property Value() As Object
        Get
            Return objValue
        End Get
    End Property

End Class
