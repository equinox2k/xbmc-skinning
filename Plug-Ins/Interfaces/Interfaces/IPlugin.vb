Imports System.Windows.Forms

Public Interface IPlugin

    ReadOnly Property PluginDetails() As PluginDetails
    WriteOnly Property InputParameters() As Generic.List(Of InputParameter)
    ReadOnly Property OutputParameters() As Generic.List(Of OutputParameter)

    Sub Initialize(ByVal Host As IHost)
    Sub Start()
    Sub HostClosing(ByRef Cancel As Boolean)
    Sub Close()
    Sub About()
    Sub Settings()

End Interface