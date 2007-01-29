Imports System.Drawing.Imaging

Public Class ImageFrame

    Private _Frame As Drawing.Image
    Private _Delay As Integer

    Public Property Frame() As Image
        Get
            Return _Frame
        End Get
        Set(ByVal Value As Image)
            _Frame = Value
        End Set
    End Property

    Public Property Delay() As Integer
        Get
            Return _Delay
        End Get
        Set(ByVal Value As Integer)
            _Delay = Value
        End Set
    End Property

End Class

Public Class ImageFrames
    Inherits System.Collections.CollectionBase

    Public Overridable Function Add(ByVal Frame As ImageFrame) As Integer
        MyBase.List.Add(Frame)
    End Function

    Default Public Overridable Property Item(ByVal Index As Integer) As ImageFrame
        Get
            Return DirectCast(MyBase.List.Item(Index), ImageFrame)
        End Get
        Set(ByVal Frame As ImageFrame)
            MyBase.List.Item(Index) = Frame
        End Set
    End Property

End Class

Public Class SkinImage

    Public Event ShowFrame(ByVal Image As Image)

    Private _Loops As Integer
    Private _Frames As New ImageFrames

    Private _Timer As Timer
    Private _Frame As Integer = 0
    Private _Loop As Integer = 1

    Public Property Loops() As Integer
        Get
            Return _Loops
        End Get
        Set(ByVal Value As Integer)
            _Loops = Value
        End Set
    End Property

    Public Property Frames() As ImageFrames
        Get
            Return _Frames
        End Get
        Set(ByVal Value As ImageFrames)
            _Frames = Value
        End Set
    End Property

    Public Sub Load(ByVal FileName As String)

        Dim bytDelays() As Byte = Nothing
        Dim objImage As Image = Image.FromFile(FileName)
        Dim objDimension As New FrameDimension(objImage.FrameDimensionsList(0))

        _Frame = 0
        _Loops = 0

        Dim objPropertyItem As PropertyItem
        For Each objPropertyItem In objImage.PropertyItems
            Select Case objPropertyItem.Id
                Case 20736
                    bytDelays = objImage.GetPropertyItem(objPropertyItem.Id).Value
                Case 20737
                    _Loops = BitConverter.ToInt16(objImage.GetPropertyItem(objPropertyItem.Id).Value, 0)
            End Select
        Next objPropertyItem

        _Frames.Clear()
        For intLoop As Integer = 0 To objImage.GetFrameCount(objDimension) - 1

            Dim objImageFrame As New ImageFrame
            Dim objMemoryStream As New System.IO.MemoryStream()

            objImage.SelectActiveFrame(objDimension, intLoop)
            objImage.Save(objMemoryStream, System.Drawing.Imaging.ImageFormat.Png)

            If bytDelays Is Nothing Then
                objImageFrame.Delay = 0
            Else
                objImageFrame.Delay = BitConverter.ToInt32(bytDelays, intLoop * 4) * 10
            End If

            objImageFrame.Frame = System.Drawing.Image.FromStream(objMemoryStream)
            _Frames.Add(objImageFrame)

        Next intLoop

    End Sub

    Public Sub Animate()

        If _Frames.Count > 0 Then

            _Loop = _Loops
            _Frame = 0
            _Timer = New Timer
            AddHandler _Timer.Tick, AddressOf TimerTick

            _Timer.Interval = 100 '_Frames.Item(0).Delay
            _Timer.Enabled = True

        End If

    End Sub

    Private Sub TimerTick(ByVal sender As Object, ByVal e As System.EventArgs)
        RaiseEvent ShowFrame(_Frames.Item(_Frame).Frame)
        _Frame += 1
        If _Frame = _Frames.Count Then _Frame = 0
    End Sub

End Class
