Imports System.Xml.Serialization

<XmlRoot("credits")> _
Public Class Credits

    Private strSkinName As String = Nothing
    Private strName() As String = Nothing

    <XmlElement(ElementName:="skinname", IsNullable:=False)> _
    Public Property SkinName() As String
        Get
            Return strSkinName
        End Get
        Set(ByVal Value As String)
            strSkinName = Value
        End Set
    End Property

    <XmlElement(ElementName:="name", IsNullable:=False)> _
    Public Property Name() As String()
        Get
            Return strName
        End Get
        Set(ByVal Value As String())
            strName = Value
        End Set
    End Property

End Class