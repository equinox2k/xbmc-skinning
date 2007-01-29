Imports System.Xml.Serialization

<XmlRoot("button")> _
Public Class Button

    Private strID As String = Nothing
    Private strLabel As String = Nothing
    Private strInfo As String = Nothing
    Private strOnClick As String = Nothing
    Private strTextureFocus As String = Nothing
    Private strTextureNoFocus As String = Nothing

    <XmlAttributeAttribute(AttributeName:="id")> _
    Public Property ID() As String
        Get
            Return strID
        End Get
        Set(ByVal Value As String)
            strID = Value
        End Set
    End Property

    <XmlElement(ElementName:="label", IsNullable:=False)> _
    Public Property Label() As String
        Get
            Return strLabel
        End Get
        Set(ByVal Value As String)
            strLabel = Value
        End Set
    End Property

    <XmlElement(ElementName:="info", IsNullable:=False)> _
    Public Property Info() As String
        Get
            Return strInfo
        End Get
        Set(ByVal Value As String)
            strInfo = Value
        End Set
    End Property

    <XmlElement(ElementName:="onclick", IsNullable:=False)> _
    Public Property OnClick() As String
        Get
            Return strOnClick
        End Get
        Set(ByVal Value As String)
            strOnClick = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturefocus", IsNullable:=False)> _
    Public Property TextureFocus() As String
        Get
            Return strTextureFocus
        End Get
        Set(ByVal Value As String)
            strTextureFocus = Value
        End Set
    End Property

    <XmlElement(ElementName:="texturenofocus", IsNullable:=False)> _
    Public Property TextureNoFocus() As String
        Get
            Return strTextureNoFocus
        End Get
        Set(ByVal Value As String)
            strTextureNoFocus = Value
        End Set
    End Property

End Class