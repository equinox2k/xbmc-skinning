Public Class Host
    Implements SkinEditor.Interfaces.IHost

    Public Event ErrorEvent(ByVal ErrorLevel As Integer, ByVal Message As String, ByVal File As String, ByVal Line As Integer, ByVal Pos As Integer)

#Region "Misc Functions"

    Public Sub ShowMessage(ByVal Message As String) Implements SkinEditor.Interfaces.IHost.ShowMessage
        MsgBox(Message)
    End Sub

    Public Sub ShowForm(ByVal Form As Form) Implements SkinEditor.Interfaces.IHost.ShowForm

    End Sub

    Public Sub ErrorOccured(ByVal ErrorLevel As Integer, ByVal Message As String, ByVal File As String, ByVal Line As Integer, ByVal Pos As Integer) Implements SkinEditor.Interfaces.IHost.ErrorOccured
        RaiseEvent ErrorEvent(ErrorLevel, Message, File, Line, Pos)
    End Sub

    Public Function ExecuteCommand(ByVal Command As String, ByVal Parameters() As Object) As Object() Implements SkinEditor.Interfaces.IHost.ExecuteCommand

    End Function

#End Region

#Region "XPR Functions"

    Public Function GetXPRImageCount(ByVal FileName As String) As Integer Implements SkinEditor.Interfaces.IHost.GetXPRImageCount

    End Function

    Public Function GetXPRImageName(ByVal FileName As String, ByVal ImageIndex As Integer) As String Implements SkinEditor.Interfaces.IHost.GetXPRImageName

    End Function

    Public Function GetXPRImageFrameCount(ByVal FileName As String, ByVal ImageIndex As Integer) As Integer Implements SkinEditor.Interfaces.IHost.GetXPRImageFrameCount

    End Function

    Public Function GetXPRImageFrameDelay(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal FrameIndex As Integer) As Integer Implements SkinEditor.Interfaces.IHost.GetXPRImageFrameDelay

    End Function

    Public Function GetXPRImageFrame(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal FrameIndex As Integer) As Image Implements SkinEditor.Interfaces.IHost.GetXPRImageFrame

    End Function

    Public Sub SaveXPRImage(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal DestFileName As String) Implements SkinEditor.Interfaces.IHost.SaveXPRImage

    End Sub

    Public Sub SaveXPRImageFrame(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal FrameIndex As Integer, ByVal DestFileName As String) Implements SkinEditor.Interfaces.IHost.SaveXPRImageFrame

    End Sub

#End Region

#Region "GIF Functions"

    Public Function GetGIFImageFrameCount(ByVal FileName As String) As Integer Implements SkinEditor.Interfaces.IHost.GetGIFImageFrameCount

    End Function

    Public Function GetGIFImageFrameDelay(ByVal FileName As String, ByVal FrameIndex As Integer) As Integer Implements SkinEditor.Interfaces.IHost.GetGIFImageFrameDelay

    End Function

    Public Function GetGIFImageFrame(ByVal FileName As String, ByVal FrameIndex As Integer) As Image Implements SkinEditor.Interfaces.IHost.GetGIFImageFrame

    End Function

#End Region

#Region "XML Functions"

    Public Function XMLClean(ByVal XML As String) As String Implements SkinEditor.Interfaces.IHost.XMLClean

    End Function

    Public Function XMLValidate(ByVal XML As String) As Boolean Implements SkinEditor.Interfaces.IHost.XMLValidate

    End Function

    Public Function XMLMergeIncludes(ByVal IncludeXML As String, ByVal XML As String) As String Implements SkinEditor.Interfaces.IHost.XMLMergeIncludes

    End Function

    Public Function XMLMergeReferences(ByVal ReferencesXML As String, ByVal XML As String) As String Implements SkinEditor.Interfaces.IHost.XMLMergeReferences

    End Function

#End Region

#Region "Settings Functions"

    Public Function GetSetting(ByVal Name As String) As String Implements SkinEditor.Interfaces.IHost.GetSetting

    End Function

    Public Sub SetSetting(ByVal Name As String, ByVal Value As String) Implements SkinEditor.Interfaces.IHost.SetSetting

    End Sub

    Public Function GetPluginSetting(ByVal Plugin As String, ByVal Name As String) As String Implements SkinEditor.Interfaces.IHost.GetPluginSetting

    End Function

    Public Sub SetPluginSetting(ByVal Plugin As String, ByVal Name As String, ByVal Value As String) Implements SkinEditor.Interfaces.IHost.SetPluginSetting

    End Sub

#End Region

End Class
