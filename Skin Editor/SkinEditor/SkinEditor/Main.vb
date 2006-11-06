Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Imports SkinEditor.Interfaces

Public Class Main

    Private WithEvents objHost As New Host
    Private Plugins() As PluginServices.AvailablePlugin = PluginServices.FindPlugins(objHost.AppPath, "SkinEditor.Interfaces.IPlugin")

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Plugins IsNot Nothing Then
            For intIndex As Integer = 0 To Plugins.Length - 1
                Dim objPlugin As IPlugin = DirectCast(PluginServices.CreateInstance(Plugins(intIndex)), IPlugin)
                lstPlugins.Items.Add(objPlugin.PluginDetails.Name)
            Next intIndex
            lstPlugins.SelectedIndex = 0
        Else
            btnRun.Enabled = False
        End If

        objHost.LoadSettings()

    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Dim objPlugin As IPlugin = DirectCast(PluginServices.CreateInstance(Plugins(lstPlugins.SelectedIndex)), IPlugin)
        objPlugin.Initialize(objHost)
        objPlugin.Start()
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        Dim objPlugin As IPlugin = DirectCast(PluginServices.CreateInstance(Plugins(lstPlugins.SelectedIndex)), IPlugin)
        objPlugin.Initialize(objHost)
        objPlugin.Settings()
    End Sub

    Private Sub objHost_ErrorEvent(ByVal ErrorLevel As Integer, ByVal Message As String, ByVal File As String, ByVal Line As Integer, ByVal Pos As Integer) Handles objHost.ErrorEvent
        txtError.Text &= Message & ControlChars.CrLf
    End Sub

End Class
