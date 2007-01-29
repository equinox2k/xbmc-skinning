Imports System.Xml.Serialization

<XmlRoot("visible")> _
Public Class Visible

    Private strAllowHiddenFocus As String = Nothing
    Private strVisible As String = Nothing

    <XmlAttributeAttribute(AttributeName:="allowhiddenfocus")> _
    Public Property AllowHiddenFocus() As String
        Get
            Return strAllowHiddenFocus
        End Get
        Set(ByVal Value As String)
            strAllowHiddenFocus = Value
        End Set
    End Property

    <XmlTextAttribute(DataType:="string")> _
    Public Property Visible() As String
        Get
            Return strVisible
        End Get
        Set(ByVal Value As String)
            strVisible = Value
        End Set
    End Property

End Class
