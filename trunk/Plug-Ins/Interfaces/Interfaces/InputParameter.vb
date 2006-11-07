Public Class InputParameter

    Dim strDescription As String
    Dim intType As Integer
    Dim objValue As Object
    Dim strParameters As String
    Dim blnOptionalValue As Boolean

    Public Enum ValueType
        Text = 0
        Number = 1
        Hex = 2
        Color = 3
        File = 4
    End Enum

    Public Sub New(ByVal Description As String, ByVal ValueType As ValueType, ByVal OptionalValue As Boolean)
        strDescription = Description
        intType = Type
        blnOptionalValue = OptionalValue
        objValue = Nothing
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

    Public ReadOnly Property OptionalValue() As Boolean
        Get
            Return blnOptionalValue
        End Get
    End Property

    Public ReadOnly Property Value() As Object
        Get
            Return objValue
        End Get
    End Property

End Class
