Imports System.Xml.Serialization

<XmlRoot("controlgroup")> _
Public Class ControlGroup

    Private strID As String = Nothing
    Private objControl() As Control = Nothing
    Private strInclude() As String = Nothing

    <XmlAttributeAttribute(AttributeName:="id")> _
    Public Property ID() As String
        Get
            Return strID
        End Get
        Set(ByVal Value As String)
            strID = Value
        End Set
    End Property

    <XmlElement(ElementName:="control", IsNullable:=False)> _
    Public Property Control() As Control()
        Get
            Return objControl
        End Get
        Set(ByVal Value As Control())
            objControl = Value
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