Public Class InputParameter

    Dim strDescription As String
    Dim intType As Integer
    Dim blnOptionalValue As Boolean
    Dim objValue As Object

    Public Sub New(ByVal Description As String, ByVal Type As Integer, ByVal OptionalValue As Integer)
        strDescription = Description
        intType = Type
        blnOptionalValue = OptionalValue
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
