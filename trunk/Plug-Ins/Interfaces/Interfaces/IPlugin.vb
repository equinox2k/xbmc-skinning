Public Interface IPlugin

    Sub Initialize(ByVal Host As IHost)
    Sub HostClosing(ByRef Cancel As Boolean)

    ReadOnly Property Plugin_Name() As String
    ReadOnly Property Plugin_Description() As String
    ReadOnly Property Plugin_Author() As String
    ReadOnly Property Plugin_Version_Major() As Integer
    ReadOnly Property Plugin_Version_Minor() As Integer

    Property Input_Param(ByVal Index As Integer) As Object
    ReadOnly Property Input_Param_Count() As Integer
    ReadOnly Property Input_Param_Description(ByVal Index As Integer) As String
    ReadOnly Property Input_Param_Type(ByVal Index As Integer) As Integer
    ReadOnly Property Input_Param_Optional(ByVal Index As Integer) As Boolean

    ReadOnly Property Output_Param(ByVal Index As Integer) As Object
    ReadOnly Property Output_Param_Count() As Integer
    ReadOnly Property Output_Param_Description(ByVal Index As Integer) As String
    ReadOnly Property Output_Param_Type(ByVal Index As Integer) As Integer

    Sub Start()

End Interface