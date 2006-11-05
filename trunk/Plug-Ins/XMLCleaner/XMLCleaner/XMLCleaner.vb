Public Class XMLCleaner
    Implements SkinEditor.Interfaces.IPlugin

#Region "Host Events"

    Private objHost As SkinEditor.Interfaces.IHost

    Public Sub Initialize(ByVal Host As SkinEditor.Interfaces.IHost) Implements SkinEditor.Interfaces.IPlugin.Initialize
        objHost = Host
    End Sub

    Public Sub HostClosing(ByRef Cancel As Boolean) Implements SkinEditor.Interfaces.IPlugin.HostClosing
        Cancel = False
    End Sub

#End Region

#Region "Plugin Details"

    Public ReadOnly Property Plugin_Name() As String Implements SkinEditor.Interfaces.IPlugin.Plugin_Name
        Get
            Return "XML Cleaner"
        End Get
    End Property

    Public ReadOnly Property Plugin_Author() As String Implements SkinEditor.Interfaces.IPlugin.Plugin_Author
        Get
            Return "EqUiNoX & Donno"
        End Get
    End Property

    Public ReadOnly Property Plugin_Description() As String Implements SkinEditor.Interfaces.IPlugin.Plugin_Description
        Get
            Return "XML Cleaner Application"
        End Get
    End Property

    Public ReadOnly Property Plugin_Version_Major() As Integer Implements SkinEditor.Interfaces.IPlugin.Plugin_Version_Major
        Get
            Return 1
        End Get
    End Property

    Public ReadOnly Property Plugin_Version_Minor() As Integer Implements SkinEditor.Interfaces.IPlugin.Plugin_Version_Minor
        Get
            Return 0
        End Get
    End Property

#End Region

#Region "Plugin Parameters"

    Public Property Input_Param(ByVal Index As Integer) As Object Implements SkinEditor.Interfaces.IPlugin.Input_Param
        Get
            Return Nothing
        End Get
        Set(ByVal Value As Object)
        End Set
    End Property

    Public ReadOnly Property Input_Param_Count() As Integer Implements SkinEditor.Interfaces.IPlugin.Input_Param_Count
        Get
            Return 0
        End Get
    End Property

    Public ReadOnly Property Input_Param_Description(ByVal Index As Integer) As String Implements SkinEditor.Interfaces.IPlugin.Input_Param_Description
        Get
            Return ""
        End Get
    End Property

    Public ReadOnly Property Input_Param_Type(ByVal Index As Integer) As Integer Implements SkinEditor.Interfaces.IPlugin.Input_Param_Type
        Get
            Return 0
        End Get
    End Property

    Public ReadOnly Property Input_Param_Optional(ByVal Index As Integer) As Boolean Implements SkinEditor.Interfaces.IPlugin.Input_Param_Optional
        Get
            Return False
        End Get
    End Property

    Public ReadOnly Property Output_Param(ByVal Index As Integer) As Object Implements SkinEditor.Interfaces.IPlugin.Output_Param
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property Output_Param_Count() As Integer Implements SkinEditor.Interfaces.IPlugin.Output_Param_Count
        Get
            Return 0
        End Get
    End Property

    Public ReadOnly Property Output_Param_Description(ByVal Index As Integer) As String Implements SkinEditor.Interfaces.IPlugin.Output_Param_Description
        Get
            Return ""
        End Get
    End Property

    Public ReadOnly Property Output_Param_Type(ByVal Index As Integer) As Integer Implements SkinEditor.Interfaces.IPlugin.Output_Param_Type
        Get
            Return 0
        End Get
    End Property

#End Region

    Public Sub Start() Implements SkinEditor.Interfaces.IPlugin.Start
        'objHost.ShowMessage("hello from plugin")
        'objHost.ErrorOccured(0, "No error really just pretending :)", "", 0, 0)
        'objHost.XMLClean << does not lower case tags

        Dim objForm As New Main
        objHost.ShowForm(objForm)
    End Sub

End Class
