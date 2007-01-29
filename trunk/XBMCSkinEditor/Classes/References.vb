Imports System.Xml.Serialization

<XmlRoot("controls")> _
Public Class References

    Private objControl() As Control = Nothing

    <XmlElement(ElementName:="control", IsNullable:=False)> _
    Public Property Control() As Control()
        Get
            Return objControl
        End Get
        Set(ByVal Value As Control())
            objControl = Value
        End Set
    End Property

End Class