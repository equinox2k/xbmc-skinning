Imports System.Xml.Serialization

<XmlRoot("buttons")> _
Public Class Buttons

    Private objButton() As Button = Nothing

    <XmlElement(ElementName:="button", IsNullable:=False)> _
    Public Property Button() As Button()
        Get
            Return objButton
        End Get
        Set(ByVal Value As Button())
            objButton = Value
        End Set
    End Property

End Class