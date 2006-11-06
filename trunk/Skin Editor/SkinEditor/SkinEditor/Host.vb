Imports System.Drawing.Imaging
Imports SkinEditor.XPRDecoder

Public Class Host
    Implements SkinEditor.Interfaces.IHost

    Public Event ErrorEvent(ByVal ErrorLevel As Integer, ByVal Message As String, ByVal File As String, ByVal Line As Integer, ByVal Pos As Integer)

#Region "Misc Functions"

    Public Sub ShowMessage(ByVal Message As String) Implements SkinEditor.Interfaces.IHost.ShowMessage
        MsgBox(Message)
    End Sub

    Public Sub ShowForm(ByVal Form As Form) Implements SkinEditor.Interfaces.IHost.ShowForm
        Form.Show()
    End Sub

    Public Function ShowDialog(ByVal Form As Form) As DialogResult Implements SkinEditor.Interfaces.IHost.ShowDialog
        Return Form.ShowDialog()
    End Function

    Public Sub ErrorOccured(ByVal ErrorLevel As Integer, ByVal Message As String, ByVal File As String, ByVal Line As Integer, ByVal Pos As Integer) Implements SkinEditor.Interfaces.IHost.ErrorOccured
        RaiseEvent ErrorEvent(ErrorLevel, Message, File, Line, Pos)
    End Sub

    Public Function ExecuteCommand(ByVal Command As String, ByVal Parameters() As Object) As Object() Implements SkinEditor.Interfaces.IHost.ExecuteCommand
        Return Nothing
    End Function

#End Region

#Region "XPR Functions"

    Public Function GetXPRImageCount(ByVal FileName As String) As Integer Implements SkinEditor.Interfaces.IHost.GetXPRImageCount
        Dim objDecoder As New Decoder
        objDecoder.OpenXPR(FileName)
        GetXPRImageCount = objDecoder.FileCount
        objDecoder.CloseXPR()
    End Function

    Public Function GetXPRImageName(ByVal FileName As String, ByVal ImageIndex As Integer) As String Implements SkinEditor.Interfaces.IHost.GetXPRImageName
        Dim objDecoder As New Decoder
        objDecoder.OpenXPR(FileName)
        GetXPRImageName = objDecoder.FileName(ImageIndex)
        objDecoder.CloseXPR()
    End Function

    Public Function GetXPRImageLoops(ByVal FileName As String, ByVal ImageIndex As Integer) As Integer Implements SkinEditor.Interfaces.IHost.GetXPRImageLoops
        Dim objDecoder As New Decoder
        objDecoder.OpenXPR(FileName)
        GetXPRImageLoops = objDecoder.GetImage(ImageIndex).Loops
        objDecoder.CloseXPR()
    End Function

    Public Function GetXPRImageFrameCount(ByVal FileName As String, ByVal ImageIndex As Integer) As Integer Implements SkinEditor.Interfaces.IHost.GetXPRImageFrameCount
        Dim objDecoder As New Decoder
        objDecoder.OpenXPR(FileName)
        GetXPRImageFrameCount = objDecoder.GetImage(ImageIndex).Frames.Count
        objDecoder.CloseXPR()
    End Function

    Public Function GetXPRImageFrameDelay(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal FrameIndex As Integer) As Integer Implements SkinEditor.Interfaces.IHost.GetXPRImageFrameDelay
        Dim objDecoder As New Decoder
        objDecoder.OpenXPR(FileName)
        GetXPRImageFrameDelay = objDecoder.GetImage(ImageIndex).Frames(FrameIndex).Delay
        objDecoder.CloseXPR()
    End Function

    Public Function GetXPRImageFrame(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal FrameIndex As Integer) As Image Implements SkinEditor.Interfaces.IHost.GetXPRImageFrame
        Dim objDecoder As New Decoder
        objDecoder.OpenXPR(FileName)
        GetXPRImageFrame = objDecoder.GetImage(ImageIndex).Frames(FrameIndex).Frame
        objDecoder.CloseXPR()
    End Function

    Public Sub SaveXPRImage(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal DestFileName As String) Implements SkinEditor.Interfaces.IHost.SaveXPRImage
        Dim objDecoder As New Decoder
        objDecoder.OpenXPR(FileName)
        objDecoder.SaveImage(ImageIndex, DestFileName)
        objDecoder.CloseXPR()
    End Sub

    Public Sub SaveXPRImageFrame(ByVal FileName As String, ByVal ImageIndex As Integer, ByVal FrameIndex As Integer, ByVal DestFileName As String) Implements SkinEditor.Interfaces.IHost.SaveXPRImageFrame
        Dim objDecoder As New Decoder
        objDecoder.OpenXPR(FileName)
        objDecoder.GetImage(ImageIndex).Frames(FrameIndex).Frame.Save(DestFileName)
        objDecoder.CloseXPR()
    End Sub

#End Region

#Region "GIF Functions"

    Public Function GetGIFImageLoops(ByVal FileName As String) As Integer Implements SkinEditor.Interfaces.IHost.GetGIFImageLoops

        Dim objImage As Drawing.Image = Drawing.Image.FromFile(FileName)
        Dim objDimension As New FrameDimension(objImage.FrameDimensionsList(0))

        GetGIFImageLoops = 0

        Dim objPropertyItem As PropertyItem
        For Each objPropertyItem In objImage.PropertyItems
            Select Case objPropertyItem.Id
                Case 20737
                    GetGIFImageLoops = BitConverter.ToInt16(objImage.GetPropertyItem(objPropertyItem.Id).Value, 0)
            End Select
        Next objPropertyItem

        objImage.Dispose()

    End Function

    Public Function GetGIFImageFrameCount(ByVal FileName As String) As Integer Implements SkinEditor.Interfaces.IHost.GetGIFImageFrameCount

        Dim objImage As Drawing.Image = Drawing.Image.FromFile(FileName)
        Dim objDimension As New FrameDimension(objImage.FrameDimensionsList(0))
        GetGIFImageFrameCount = objImage.GetFrameCount(objDimension)
        objImage.Dispose()

    End Function

    Public Function GetGIFImageFrameDelay(ByVal FileName As String, ByVal FrameIndex As Integer) As Integer Implements SkinEditor.Interfaces.IHost.GetGIFImageFrameDelay

        Dim bytDelays() As Byte = Nothing
        Dim objImage As Drawing.Image = Drawing.Image.FromFile(FileName)
        Dim objDimension As New FrameDimension(objImage.FrameDimensionsList(0))

        Dim objPropertyItem As PropertyItem
        For Each objPropertyItem In objImage.PropertyItems
            Select Case objPropertyItem.Id
                Case 20736
                    bytDelays = objImage.GetPropertyItem(objPropertyItem.Id).Value
            End Select
        Next objPropertyItem

        If bytDelays Is Nothing Then
            GetGIFImageFrameDelay = 0
        Else
            GetGIFImageFrameDelay = BitConverter.ToInt32(bytDelays, FrameIndex * 4) * 10
        End If

        objImage.Dispose()

    End Function

    Public Function GetGIFImageFrame(ByVal FileName As String, ByVal FrameIndex As Integer) As Image Implements SkinEditor.Interfaces.IHost.GetGIFImageFrame

        Dim objImage As Drawing.Image = Drawing.Image.FromFile(FileName)
        Dim objDimension As New FrameDimension(objImage.FrameDimensionsList(0))
        Dim objMemoryStream As New System.IO.MemoryStream()

        objImage.SelectActiveFrame(objDimension, FrameIndex)
        objImage.Save(objMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
        GetGIFImageFrame = System.Drawing.Image.FromStream(objMemoryStream)

        objImage.Dispose()

    End Function

#End Region

#Region "XML Functions"

    Public Function XMLClean(ByVal XML As String) As String Implements SkinEditor.Interfaces.IHost.XMLClean
        Dim objXMLTools As New XMLTools
        Return objXMLTools.CleanXML(XML)
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
        Return Nothing
    End Function

    Public Sub SetSetting(ByVal Name As String, ByVal Value As String) Implements SkinEditor.Interfaces.IHost.SetSetting

    End Sub

    Public Function GetPluginSetting(ByVal Plugin As String, ByVal Name As String) As String Implements SkinEditor.Interfaces.IHost.GetPluginSetting
        Return Nothing
    End Function

    Public Sub SetPluginSetting(ByVal Plugin As String, ByVal Name As String, ByVal Value As String) Implements SkinEditor.Interfaces.IHost.SetPluginSetting

    End Sub

#End Region

End Class
