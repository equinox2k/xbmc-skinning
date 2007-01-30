Imports System.Drawing
Imports System.Windows.Forms
Public Interface IHost
    Sub ShowDockContent(ByVal Form As WeifenLuo.WinFormsUI.DockContent, ByVal DDockStyle As WeifenLuo.WinFormsUI.DockState) ' Requires WeifenLuo.WinFormsUI Reference  WeifenLuo.WinFormsUI.Docking.dll
    Sub ShowMessage(ByVal Message As String)
    Function ShowDialog(ByVal Form As Form) As DialogResult
    Sub ShowForm(ByVal Form As Form, ByVal DockLocation As String)
    Sub ErrorOccured(ByVal ErrorLevel As Integer, ByVal Message As String, ByVal File As String, ByVal Line As Integer, ByVal Pos As Integer)
    Function ExecuteCommand(ByVal Command As String, ByVal Parameters() As Object) As Object()

    Function GetXPRImageCount(ByVal FileName As String) As Integer
    Function GetXPRImageName(ByVal FileName As String, ByVal ImageIndex As Integer) As String
    Function GetXPRImageLoops(ByVal FileName As String, ByVal ImageIndex As Integer) As Integer
    Function GetXPRImageFrameCount(ByVal FileName As String, ByVal ImageIndex As Integer) As Integer
    Function GetXPRImageFrameDelay(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal FrameIndex As Integer) As Integer
    Function GetXPRImageFrame(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal FrameIndex As Integer) As Image

    Function GetGIFImageLoops(ByVal FileName As String) As Integer
    Function GetGIFImageFrameCount(ByVal FileName As String) As Integer
    Function GetGIFImageFrameDelay(ByVal FileName As String, ByVal FrameIndex As Integer) As Integer
    Function GetGIFImageFrame(ByVal FileName As String, ByVal FrameIndex As Integer) As Image

    Sub SaveXPRImage(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal DestFileName As String)
    Sub SaveXPRImageFrame(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal FrameIndex As Integer, ByVal DestFileName As String)

    Function XMLClean(ByVal XML As String) As String
    Function XMLValidate(ByVal XML As String) As Boolean
    Function XMLMergeIncludes(ByVal IncludeXML As String, ByVal XML As String) As String
    Function XMLMergeReferences(ByVal ReferencesXML As String, ByVal XML As String) As String

    Sub LoadSettings()
    Sub SaveSettings()
    Function GetSetting(ByVal SettingName As String) As String
    Sub SetSetting(ByVal SettingName As String, ByVal Value As String)
    Function GetPluginSetting(ByVal PluginName As String, ByVal SettingName As String) As String
    Sub SetPluginSetting(ByVal PluginName As String, ByVal SettingName As String, ByVal Value As String)

End Interface
