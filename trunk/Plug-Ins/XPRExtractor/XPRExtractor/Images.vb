Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Collections.Generic

Namespace Images

    Public Class ImageFrame

        Private _Frame As Drawing.Image
        Private _Delay As Integer

        Public Property Frame() As Drawing.Image
            Get
                Return _Frame
            End Get
            Set(ByVal Value As Drawing.Image)
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

    Public Class Image

        Private _Loops As Integer
        Private _Frames As New List(Of ImageFrame)

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

        Public Property Frames() As List(Of ImageFrame)
            Get
                Return _Frames
            End Get
            Set(ByVal Value As List(Of ImageFrame))
                _Frames = Value
            End Set
        End Property

        Public Sub Load(ByVal FileName As String)

            Dim bytDelays() As Byte = Nothing
            Dim objImage As Drawing.Image = Drawing.Image.FromFile(FileName)
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

    End Class

End Namespace