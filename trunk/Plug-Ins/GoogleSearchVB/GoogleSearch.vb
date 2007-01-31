Imports SkinEditor.Interfaces

Public Class GoogleSearchPlug
    Implements IPlugin

    Private objHost As SkinEditor.Interfaces.IHost
    Private lstInputParameters As New Generic.List(Of InputParameter)
    Private lstOutputParameters As New Generic.List(Of OutputParameter)
    Const GoogleAPIKey As String = "fU/C0EhQFHLvQyQY3BGT1PaMceA0xXW7" ' Donno's Google SOAP API, don't use it else where.

    'Plugin Details
    ReadOnly Property PluginDetails() As PluginDetails Implements IPlugin.PluginDetails
        Get
            Dim strName As String = "GoogleSearch"
            Dim strDescription As String = "Google Search Plugin, powered by the API provided by Google"
            Dim strAuthor As String = "Donno"
            Dim intVersionMajor As Integer = "1"
            Dim inVersionMinor As Integer = "0"
            Return New PluginDetails(strName, strDescription, strAuthor, intVersionMajor, inVersionMinor, False)
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
    End Sub

    'Plugin Start
    Public Sub Start() Implements IPlugin.Start

        Dim s As New googleapi.GoogleSearchService
        'Dim objWebProxy As New System.Net.WebProxy(ProxyAddress, ProxyPort)
        'objWebProxy.UseDefaultCredentials = True
        's.Proxy = System.Net.WebProxy.GetDefaultProxy
        's.Proxy = objWebProxy
        's.Proxy.Credentials.GetCredential
        Dim searchQuery As String
        searchQuery = InputBox("Enter Search Query", "GoogleSearch", "xbmc")
        objHost.ErrorOccured(0, "Attemping search for " & searchQuery & " to display 5 matches", "", 0, 0)
        ' Expantion accept   Number of results to display and search item
        Try
            ' Invoke the search method
            Dim r As googleapi.GoogleSearchResult = s.doGoogleSearch(GoogleAPIKey, searchQuery, 0, 5, False, "", False, "", "", "")
            Dim estResults As Integer = r.estimatedTotalResultsCount
            objHost.ErrorOccured(0, "Number of Results Found: " & CStr(estResults), "", 0, 0)
            Dim x As googleapi.ResultElement
            For Each x In r.resultElements
                x.title = x.title.Replace("<b>", "")
                x.title = x.title.Replace("</b>", "")
                objHost.ErrorOccured(0, "Title: " & x.title & " Url: " & x.URL, "", 0, 0)
            Next
        Catch ex As System.Web.Services.Protocols.SoapException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
