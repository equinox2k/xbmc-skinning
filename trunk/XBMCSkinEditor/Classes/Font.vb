Imports System.Xml.Serialization

<XmlRoot("font")> _
Public Class Font

    Private strName As String = Nothing
    Private strFileName As String = Nothing
    Private strSize As String = Nothing
    Private strStyle As String = Nothing

    <XmlElement(ElementName:="name", IsNullable:=False)> _
    Public Property Name() As String
        Get
            Return strName
        End Get
        Set(ByVal Value As String)
            strName = Value
        End Set
    End Property

    <XmlElement(ElementName:="filename", IsNullable:=False)> _
    Public Property FileName() As String
        Get
            Return strFileName
        End Get
        Set(ByVal Value As String)
            strFileName = Value
        End Set
    End Property

    <XmlElement(ElementName:="size", IsNullable:=False)> _
    Public Property Size() As String
        Get
            Return strSize
        End Get
        Set(ByVal Value As String)
            strSize = Value
        End Set
    End Property

    <XmlElement(ElementName:="style", IsNullable:=False)> _
    Public Property Style() As String
        Get
            Return strStyle
        End Get
        Set(ByVal Value As String)
            strStyle = Value
        End Set
    End Property

End Class