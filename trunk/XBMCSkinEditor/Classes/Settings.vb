Imports System.IO
Imports System.Xml.Serialization

Public Class Settings

    Private objSettings As New Settings

    Public Sub Load(ByVal FileName As String)
        If File.Exists(FileName) Then
            Dim objXmlSerializer As New XmlSerializer(GetType(Settings))
            Dim objStreamWriter As New StreamReader(FileName)
            objSettings = objXmlSerializer.Deserialize(objStreamWriter)
            objStreamWriter.Close()
        End If
    End Sub

    Public Sub Save(ByVal FileName As String)
        Dim objXmlSerializer As New XmlSerializer(GetType(Settings))
        Dim objStreamWriter As New StreamWriter(FileName, False)
        objXmlSerializer.Serialize(objStreamWriter, objSettings)
        objStreamWriter.Close()
    End Sub

    Public Function GetSetting(ByVal SettingName As String) As String
        For intLoop As Integer = 0 To objSettings.ApplicationSettings.Count - 1
            With objSettings.ApplicationSettings(intLoop)
                If .SettingName = SettingName Then Return .Value
            End With
        Next intLoop
        Return ""
    End Function

    Public Sub SetSetting(ByVal SettingName As String, ByVal Value As String)
        For intLoop As Integer = 0 To objSettings.ApplicationSettings.Count - 1
            With objSettings.ApplicationSettings(intLoop)
                If .SettingName = SettingName Then
                    .Value = Value
                    Exit Sub
                End If
            End With
        Next intLoop
        Dim objApplicationSetting As New Settings.ApplicationSetting
        objApplicationSetting.SettingName = SettingName
        objApplicationSetting.Value = Value
        objSettings.ApplicationSettings.Add(objApplicationSetting)
    End Sub

    Public Function GetPluginSetting(ByVal PluginName As String, ByVal SettingName As String) As String
        For intLoop As Integer = 0 To objSettings.PluginSettings.Count - 1
            With objSettings.PluginSettings(intLoop)
                If .PluginName = PluginName AndAlso .SettingName = SettingName Then Return .Value
            End With
        Next intLoop
        Return ""
    End Function

    Public Sub SetPluginSetting(ByVal PluginName As String, ByVal SettingName As String, ByVal Value As String)
        For intLoop As Integer = 0 To objSettings.PluginSettings.Count - 1
            With objSettings.PluginSettings(intLoop)
                If .PluginName = PluginName AndAlso .SettingName = SettingName Then
                    .Value = Value
                    Exit Sub
                End If
            End With
        Next intLoop
        Dim objPluginSetting As New Settings.PluginSetting
        objPluginSetting.PluginName = PluginName
        objPluginSetting.SettingName = SettingName
        objPluginSetting.Value = Value
        objSettings.PluginSettings.Add(objPluginSetting)
    End Sub

    <Serializable()> _
    Public Class Settings

        Public Class ApplicationSetting

            Private strSettingName As String
            Private strValue As String

            <System.Xml.Serialization.XmlAttributeAttribute()> _
            Public Property SettingName() As String
                Get
                    Return strSettingName
                End Get
                Set(ByVal Value As String)
                    strSettingName = Value
                End Set
            End Property

            <System.Xml.Serialization.XmlTextAttribute()> _
            Public Property Value() As String
                Get
                    Return strValue
                End Get
                Set(ByVal Value As String)
                    strValue = Value
                End Set
            End Property

        End Class

        Public Class PluginSetting

            Private strPluginName As String
            Private strSettingName As String
            Private strValue As String

            <System.Xml.Serialization.XmlAttributeAttribute()> _
            Public Property PluginName() As String
                Get
                    Return strPluginName
                End Get
                Set(ByVal Value As String)
                    strPluginName = Value
                End Set
            End Property

            <System.Xml.Serialization.XmlAttributeAttribute()> _
            Public Property SettingName() As String
                Get
                    Return strSettingName
                End Get
                Set(ByVal Value As String)
                    strSettingName = Value
                End Set
            End Property

            <System.Xml.Serialization.XmlTextAttribute()> _
            Public Property Value() As String
                Get
                    Return strValue
                End Get
                Set(ByVal Value As String)
                    strValue = Value
                End Set
            End Property

        End Class

        Private objApplicationSettings As New List(Of ApplicationSetting)
        Private objPluginSettings As New List(Of PluginSetting)

        Public Property ApplicationSettings() As List(Of ApplicationSetting)
            Get
                Return objApplicationSettings
            End Get
            Set(ByVal Value As List(Of ApplicationSetting))
                objApplicationSettings = Value
            End Set
        End Property

        Public Property PluginSettings() As List(Of PluginSetting)
            Get
                Return objPluginSettings
            End Get
            Set(ByVal Value As List(Of PluginSetting))
                objPluginSettings = Value
            End Set
        End Property

    End Class

End Class




