Imports SkinEditor.Interfaces

Public Class XMLCleaner
    Implements IPlugin

    Private objHost As SkinEditor.Interfaces.IHost
    Private lstInputParameters As New Generic.List(Of InputParameter)
    Private lstOutputParameters As New Generic.List(Of OutputParameter)

    'Plugin Details
    ReadOnly Property PluginDetails() As PluginDetails Implements IPlugin.PluginDetails
        Get
            Dim strName As String = "XML Cleaner"
            Dim strDescription As String = "XML Cleaner Plug-in"
            Dim strAuthor As String = "Equinox & Donno"
            Dim intVersionMajor As Integer = "1"
            Dim inVersionMinor As Integer = "0"
            Return New PluginDetails(strName, strDescription, strAuthor, intVersionMajor, inVersionMinor, True)
        End Get
    End Property

    'Plugin Input Parameters
    Property InputParameters() As Generic.List(Of InputParameter) Implements IPlugin.InputParameters
        Get
            Return lstInputParameters
        End Get
        Set(ByVal Value As Generic.List(Of InputParameter))
            lstInputParameters = Value
        End Set
    End Property

    'Plugin Output Parameters
    ReadOnly Property OutputParameters() As Generic.List(Of OutputParameter) Implements IPlugin.OutputParameters
        Get
            Return lstOutputParameters
        End Get
    End Property

    'Plugin Initialise
    Public Sub Initialize(ByVal Host As SkinEditor.Interfaces.IHost) Implements IPlugin.Initialize
        objHost = Host
    End Sub

    'Plugin Closing
    Public Sub HostClosing(ByRef Cancel As Boolean) Implements IPlugin.HostClosing
        Cancel = False
    End Sub

    'Plugin Close
    Public Sub Close() Implements IPlugin.Close

    End Sub

    'Plugin About
    Public Sub About() Implements IPlugin.About

    End Sub

    'Plugin Settings
    Public Sub Settings() Implements IPlugin.Settings
        Dim objSettings As New Settings
        objSettings.objHost = objHost
        objHost.ShowDialog(objSettings)
    End Sub

    'Plugin Start
    Public Sub Start() Implements IPlugin.Start
        'objHost.ShowMessage("hello from plugin")
        'objHost.ErrorOccured(0, "No error really just pretending :)", "", 0, 0)
        'objHost.XMLClean << does not lower case tags

        Dim objForm As New Main
        objHost.ShowForm(objForm, "")
    End Sub

End Class
