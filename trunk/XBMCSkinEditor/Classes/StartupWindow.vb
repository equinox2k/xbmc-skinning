Imports System.Xml.Serialization

<XmlRoot("window")> _
Public Class StartupWindow

    Private strID As String = Nothing
    Private strValue As String = Nothing

    <XmlAttributeAttribute(AttributeName:="id")> _
    Public Property ID() As String
        Get
            Return strID
        End Get
        Set(ByVal Value As String)
            strID = Value
        End Set
    End Property

    <XmlTextAttribute(DataType:="string")> _
    Public Property Value() As Integer
        Get
            Return strValue
        End Get
        Set(ByVal Value As Integer)
            strValue = Value
        End Set
    End Property

End Class
