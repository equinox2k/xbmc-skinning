Public Class PluginDetails

    Dim strName As String
    Dim strDescription As String
    Dim strAuthor As String
    Dim intVersionMajor As Integer
    Dim intVersionMinor As Integer
    Dim bolhasSettings As Boolean
    Public Sub New(ByVal Name As String, ByVal Description As String, ByVal Author As String, ByVal VersionMajor As Integer, ByVal VersionMinor As Integer, ByVal HasSettings As Boolean)
        strName = Name
        strDescription = Description
        strAuthor = Author
        intVersionMajor = VersionMajor
        intVersionMinor = VersionMinor
        bolhasSettings = HasSettings
    End Sub

    Public ReadOnly Property Name() As String
        Get
            Return strName
        End Get
    End Property

    Public ReadOnly Property Description() As String
        Get
            Return strDescription
        End Get
    End Property

    Public ReadOnly Property Author() As String
        Get
            Return strAuthor
        End Get
    End Property

    Public ReadOnly Property VersionMajor() As String
        Get
            Return intVersionMajor
        End Get
    End Property

    Public ReadOnly Property VersionMinor() As String
        Get
            Return intVersionMinor
        End Get
    End Property
    Public ReadOnly Property HasSettings() As Boolean
        Get
            Return bolhasSettings
        End Get
    End Property
End Class
