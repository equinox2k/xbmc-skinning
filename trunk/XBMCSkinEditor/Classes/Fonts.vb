Imports System.Xml.Serialization

<XmlRoot("fonts")> _
Public Class Fonts

    Private objFontSet() As FontSet = Nothing

    <XmlElement(ElementName:="fontset", IsNullable:=False)> _
    Public Property FontSet() As FontSet()
        Get
            Return objFontSet
        End Get
        Set(ByVal Value As FontSet())
            objFontSet = Value
        End Set
    End Property

End Class