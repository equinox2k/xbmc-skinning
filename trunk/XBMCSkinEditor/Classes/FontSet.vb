Imports System.Xml.Serialization

<XmlRoot("fontset")> _
Public Class FontSet

    Private strID As String = Nothing
    Private strUnicode As String = Nothing
    Private objFont() As Font = Nothing

    <XmlAttributeAttribute(AttributeName:="id")> _
    Public Property ID() As String
        Get
            Return strID
        End Get
        Set(ByVal Value As String)
            strID = Value
        End Set
    End Property

    <XmlAttributeAttribute(AttributeName:="unicode")> _
    Public Property Unicode() As String
        Get
            Return strUnicode
        End Get
        Set(ByVal Value As String)
            strUnicode = Value
        End Set
    End Property

    <XmlElement(ElementName:="font", IsNullable:=False)> _
    Public Property Font() As Font()
        Get
            Return objFont
        End Get
        Set(ByVal Value As Font())
            objFont = Value
        End Set
    End Property

End Class