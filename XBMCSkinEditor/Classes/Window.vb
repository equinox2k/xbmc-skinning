Imports System.Xml.Serialization

<XmlRoot("window")> _
Public Class Window

    Private strID As String = Nothing
    Private strDefaultControl As String = Nothing
    Private strAllowOverlay As String = Nothing
    Private strType As String = Nothing
    Private objVisible As Visible = Nothing
    Private objAnimation() As Animation = Nothing
    Private strZOrder As String = Nothing
    Private objCoordinates As Coordinates = Nothing
    Private objControls As Controls = Nothing
    Private strInclude() As String = Nothing

    <XmlElement(ElementName:="id", IsNullable:=False)> _
    Public Property ID() As String
        Get
            Return strID
        End Get
        Set(ByVal Value As String)
            strID = Value
        End Set
    End Property

    <XmlElement(ElementName:="defaultcontrol", IsNullable:=False)> _
    Public Property DefaultControl() As String
        Get
            Return strDefaultControl
        End Get
        Set(ByVal Value As String)
            strDefaultControl = Value
        End Set
    End Property

    <XmlElement(ElementName:="allowoverlay", IsNullable:=False)> _
    Public Property AllowOverlay() As String
        Get
            Return strAllowOverlay
        End Get
        Set(ByVal Value As String)
            strAllowOverlay = Value
        End Set
    End Property

    <XmlElement(ElementName:="type", IsNullable:=False)> _
    Public Property Type() As String
        Get
            Return strType
        End Get
        Set(ByVal Value As String)
            strType = Value
        End Set
    End Property

    <XmlElement(ElementName:="visible", IsNullable:=False)> _
    Public Property Visible() As Visible
        Get
            Return objVisible
        End Get
        Set(ByVal Value As Visible)
            objVisible = Value
        End Set
    End Property

    <XmlElement(ElementName:="animation", IsNullable:=False)> _
    Public Property Animation() As Animation()
        Get
            Return objAnimation
        End Get
        Set(ByVal Value As Animation())
            objAnimation = Value
        End Set
    End Property

    <XmlElement(ElementName:="zorder", IsNullable:=False)> _
    Public Property ZOrder() As String
        Get
            Return strZOrder
        End Get
        Set(ByVal Value As String)
            strZOrder = Value
        End Set
    End Property

    <XmlElement(ElementName:="coordinates", IsNullable:=False)> _
    Public Property Coordinates() As Coordinates
        Get
            Return objCoordinates
        End Get
        Set(ByVal Value As Coordinates)
            objCoordinates = Value
        End Set
    End Property

    <XmlElement(ElementName:="controls", IsNullable:=False)> _
    Public Property Controls() As Controls
        Get
            Return objControls
        End Get
        Set(ByVal Value As Controls)
            objControls = Value
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