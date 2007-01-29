Imports System.Xml.Serialization

<XmlRoot("startupwindows")> _
Public Class StartupWindows

    Private objStartupWindow() As StartupWindow = Nothing

    <XmlElement(ElementName:="window", IsNullable:=False)> _
    Public Property StartupWindow() As StartupWindow()
        Get
            Return objStartupWindow
        End Get
        Set(ByVal Value As StartupWindow())
            objStartupWindow = Value
        End Set
    End Property

End Class
