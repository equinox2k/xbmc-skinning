Imports System.Xml.Serialization

<XmlRoot("coordinates")> _
Public Class Coordinates

    Private strSystem As String = Nothing
    Private strPosX As String = Nothing
    Private strPosY As String = Nothing
    Private strOrigin As String = Nothing
    Private strInclude() As String = Nothing

    <XmlElement(ElementName:="system", IsNullable:=False)> _
    Public Property System() As String
        Get
            Return strSystem
        End Get
        Set(ByVal Value As String)
            strSystem = Value
        End Set
    End Property

    <XmlElement(ElementName:="posx", IsNullable:=False)> _
    Public Property PosX() As String
        Get
            Return strPosX
        End Get
        Set(ByVal Value As String)
            strPosX = Value
        End Set
    End Property

    <XmlElement(ElementName:="posy", IsNullable:=False)> _
    Public Property PosY() As String
        Get
            Return strPosY
        End Get
        Set(ByVal Value As String)
            strPosY = Value
        End Set
    End Property

    <XmlElement(ElementName:="origin", IsNullable:=False)> _
    Public Property Origin() As String
        Get
            Return strOrigin
        End Get
        Set(ByVal Value As String)
            strOrigin = Value
        End Set
    End Property

    <XmlElement(ElementName:="include", IsNullable:=False)> _
    Public Property Include() As String()
        Get
            Return strInclude
        End Get
        Set(ByVal Value As String())
            strInclude = Value
        End Set
    End Property

End Class