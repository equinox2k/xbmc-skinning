Imports System.Xml.Serialization

<XmlRoot("controls")> _
Public Class Controls

    Private objControl() As Control = Nothing
    Private objControlGroup() As ControlGroup = Nothing
    Private strInclude() As String = Nothing

    <XmlElement(ElementName:="control", IsNullable:=False)> _
    Public Property Control() As Control()
        Get
            Return objControl
        End Get
        Set(ByVal Value As Control())
            objControl = Value
        End Set
    End Property

    <XmlElement(ElementName:="controlgroup", IsNullable:=False)> _
    Public Property ControlGroup() As ControlGroup()
        Get
            Return objControlGroup
        End Get
        Set(ByVal Value As ControlGroup())
            objControlGroup = Value
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