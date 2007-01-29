Imports System.Xml.Serialization

<XmlRoot("animation")> _
Public Class Animation

    Private strEffect As String = Nothing
    Private strTime As String = Nothing
    Private strDelay As String = Nothing
    Private strStartState As String = Nothing
    Private strEndState As String = Nothing
    Private strAcceleration As String = Nothing
    Private strCenter As String = Nothing
    Private strReversible As String = Nothing
    Private strCondition As String = Nothing
    Private strAnimation As String = Nothing

    <XmlAttributeAttribute(AttributeName:="effect")> _
    Public Property Effect() As String
        Get
            Return strEffect
        End Get
        Set(ByVal Value As String)
            strEffect = Value
        End Set
    End Property

    <XmlAttributeAttribute(AttributeName:="time")> _
    Public Property Time() As String
        Get
            Return strTime
        End Get
        Set(ByVal Value As String)
            strTime = Value
        End Set
    End Property

    <XmlAttributeAttribute(AttributeName:="delay")> _
    Public Property Delay() As String
        Get
            Return strDelay
        End Get
        Set(ByVal Value As String)
            strDelay = Value
        End Set
    End Property

    <XmlAttributeAttribute(AttributeName:="start")> _
    Public Property StartState() As String
        Get
            Return strStartState
        End Get
        Set(ByVal Value As String)
            strStartState = Value
        End Set
    End Property

    <XmlAttributeAttribute(AttributeName:="end")> _
       Public Property EndState() As String
        Get
            Return strEndState
        End Get
        Set(ByVal Value As String)
            strEndState = Value
        End Set
    End Property

    <XmlAttributeAttribute(AttributeName:="acceleration")> _
    Public Property Acceleration() As String
        Get
            Return strAcceleration
        End Get
        Set(ByVal Value As String)
            strAcceleration = Value
        End Set
    End Property

    <XmlAttributeAttribute(AttributeName:="center")> _
    Public Property Center() As String
        Get
            Return strCenter
        End Get
        Set(ByVal Value As String)
            strCenter = Value
        End Set
    End Property

    <XmlAttributeAttribute(AttributeName:="reversible")> _
    Public Property Reversible() As String
        Get
            Return strReversible
        End Get
        Set(ByVal Value As String)
            strReversible = Value
        End Set
    End Property

    <XmlAttributeAttribute(AttributeName:="condition")> _
    Public Property Condition() As String
        Get
            Return strCondition
        End Get
        Set(ByVal Value As String)
            strCondition = Value
        End Set
    End Property

    <XmlTextAttribute(DataType:="string")> _
    Public Property Animation() As String
        Get
            Return strAnimation
        End Get
        Set(ByVal Value As String)
            strAnimation = Value
        End Set
    End Property

End Class
