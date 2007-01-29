Imports System.Xml.Serialization

<XmlRoot("includes")> _
Public Class Includes

    Private objInclude() As Include = Nothing

    <XmlElement(ElementName:="include", IsNullable:=False)> _
    Public Property Include() As Include()
        Get
            Return objInclude
        End Get
        Set(ByVal Value As Include())
            objInclude = Value
        End Set
    End Property

End Class