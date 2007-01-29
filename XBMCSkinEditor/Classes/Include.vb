Imports System.Xml
Imports System.Xml.Serialization

<XmlRoot("include")> _
Public Class Include

    Private strName As String = Nothing
    Private objAny() As XmlElement = Nothing

    <XmlAttributeAttribute(AttributeName:="name")> _
    Public Property Name() As String
        Get
            Return strName
        End Get
        Set(ByVal Value As String)
            strName = Value
        End Set
    End Property

    <XmlAnyElementAttribute()> _
    Public Property Any() As XmlElement()
        Get
            Return objAny
        End Get
        Set(ByVal Value As XmlElement())
            objAny = Value
        End Set

    End Property

End Class