Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class ColorWheel
  Implements IDisposable

    Private PageGraphics As Graphics
    Private ColorRegion As Region
    Private BrightnessRegion As Region
    Private ColorImage As Bitmap

    Public Event ColorChanged(ByVal sender As Object, ByVal e As ColorChangedEventArgs)

    Public Enum MouseState
        MouseUp
        ClickOnColor
        DragInColor
        ClickOnBrightness
        DragInBrightness
        ClickOutsideRegion
        DragOutsideRegion
    End Enum

    Private CurrentState As MouseState = MouseState.MouseUp

    Private Const DEGREES_PER_RADIAN As Double = 180.0 / Math.PI
    Private Const COLOR_COUNT As Integer = 6 * 256

    Private CenterPoint As Point
    Private Radius As Integer

    Private ColorRectangle As Rectangle
    Private BrightnessRectangle As Rectangle
    Private SelectedColorRectangle As Rectangle
    Private BrightnessX As Integer
    Private BrightnessScaling As Double

    Private SelectedColor As Color = Drawing.Color.White
    Private FullColor As Color = SelectedColor

    Private RGB As ColorHandler.RGB
    Private HSV As ColorHandler.HSV

    Private ColorPoint As Point
    Private BrightnessPoint As Point

    Private Brightness As Integer
    Private BrightnessMin As Integer
    Private BrightnessMax As Integer

    Protected Overridable Sub OnColorChanged(ByVal RGB As ColorHandler.RGB, ByVal HSV As ColorHandler.HSV)
        Dim e As New ColorChangedEventArgs(RGB, HSV)
        RaiseEvent ColorChanged(Me, e)
    End Sub

    Public ReadOnly Property Color() As Color
        Get
            Return SelectedColor
        End Get
    End Property

    Private Sub Dispose() Implements IDisposable.Dispose

        If ColorImage IsNot Nothing Then ColorImage.Dispose()
        If ColorRegion IsNot Nothing Then ColorRegion.Dispose()
        If BrightnessRegion IsNot Nothing Then BrightnessRegion.Dispose()
        If PageGraphics IsNot Nothing Then PageGraphics.Dispose()

    End Sub

    Public Sub New(ByVal ColorRectangle As Rectangle, ByVal BrightnessRectangle As Rectangle, ByVal SelectedColorRectangle As Rectangle)

        Dim GraphicsPath As GraphicsPath = Nothing

        Try

            Me.ColorRectangle = ColorRectangle
            Me.BrightnessRectangle = BrightnessRectangle
            Me.SelectedColorRectangle = SelectedColorRectangle

            Me.Radius = Math.Min(ColorRectangle.Width, ColorRectangle.Height) \ 2
            Me.CenterPoint = ColorRectangle.Location
            Me.CenterPoint.Offset(Radius, Radius)

            Me.ColorPoint = Me.CenterPoint

            GraphicsPath = New GraphicsPath()
            GraphicsPath.AddEllipse(ColorRectangle)
            ColorRegion = New Region(GraphicsPath)

            Me.BrightnessMin = Me.BrightnessRectangle.Top
            Me.BrightnessMax = Me.BrightnessRectangle.Bottom

            With BrightnessRectangle
                GraphicsPath = New GraphicsPath()
                GraphicsPath.AddRectangle(New Rectangle(.Left, .Top - 10, .Width + 10, .Height + 20))
            End With

            BrightnessRegion = New Region(GraphicsPath)

            BrightnessX = BrightnessRectangle.Left + BrightnessRectangle.Width
            BrightnessScaling = 255 / (BrightnessMax - BrightnessMin)

            BrightnessPoint = New Point(BrightnessX, BrightnessMax)

            CreateGradient()

        Finally

            If GraphicsPath IsNot Nothing Then GraphicsPath.Dispose()

        End Try

    End Sub

    Public Sub SetMouseUp()
        CurrentState = MouseState.MouseUp
    End Sub

    Public Overloads Sub Draw(ByVal g As Graphics, ByVal HSV As ColorHandler.HSV)
        PageGraphics = g
        Me.HSV = HSV
        CalcCoordsAndUpdate(Me.HSV)
        UpdateDisplay()
    End Sub

    Public Overloads Sub Draw(ByVal g As Graphics, ByVal RGB As ColorHandler.RGB)
        PageGraphics = g
        Me.HSV = ColorHandler.RGBtoHSV(RGB)
        CalcCoordsAndUpdate(Me.HSV)
        UpdateDisplay()
    End Sub

    Public Overloads Sub Draw(ByVal g As Graphics, ByVal MousePoint As Point)

        Dim Distance As Double
        Dim Degrees As Integer
        Dim Delta As Point
        Dim NewColorPoint As Point
        Dim NewBrightnessPoint As Point
        Dim NewPoint As Point

        NewColorPoint = ColorPoint
        NewBrightnessPoint = BrightnessPoint

        PageGraphics = g

        If CurrentState = MouseState.MouseUp Then
            If Not mousePoint.IsEmpty Then
                If ColorRegion.IsVisible(mousePoint) Then
                    CurrentState = MouseState.ClickOnColor
                ElseIf BrightnessRegion.IsVisible(mousePoint) Then
                    CurrentState = MouseState.ClickOnBrightness
                Else
                    CurrentState = MouseState.ClickOutsideRegion
                End If
            End If
        End If

        Select Case CurrentState
            Case MouseState.ClickOnBrightness, MouseState.DragInBrightness

                NewPoint = MousePoint

                If NewPoint.Y < BrightnessMin Then
                    NewPoint.Y = BrightnessMin
                ElseIf NewPoint.Y > BrightnessMax Then
                    NewPoint.Y = BrightnessMax
                End If

                NewBrightnessPoint = New Point(BrightnessX, NewPoint.Y)
                Brightness = CInt((BrightnessMax - NewPoint.Y) * BrightnessScaling)
                HSV.Value = Brightness
                RGB = ColorHandler.HSVtoRGB(HSV)

            Case MouseState.ClickOnColor, MouseState.DragInColor
              
                NewColorPoint = MousePoint

                Delta = New Point(MousePoint.X - CenterPoint.X, MousePoint.Y - CenterPoint.Y)
                Degrees = CalcDegrees(Delta)
                Distance = Math.Sqrt(Delta.X * Delta.X + Delta.Y * Delta.Y) / Radius

                If CurrentState = MouseState.DragInColor Then
                    If Distance > 1 Then
                        Distance = 1
                        NewColorPoint = GetPoint(Degrees, Radius, CenterPoint)
                    End If
                End If

                HSV.Hue = CInt(Degrees * 255 / 360)
                HSV.Saturation = CInt(Distance * 255)
                HSV.Value = Brightness
                RGB = ColorHandler.HSVtoRGB(HSV)
                FullColor = ColorHandler.HSVtoColor(HSV.Hue, HSV.Saturation, 255)

        End Select

        SelectedColor = ColorHandler.HSVtoColor(HSV)

        OnColorChanged(RGB, HSV)

        Select Case CurrentState
            Case MouseState.ClickOnBrightness
                CurrentState = MouseState.DragInBrightness
            Case MouseState.ClickOnColor
                CurrentState = MouseState.DragInColor
            Case MouseState.ClickOutsideRegion
                CurrentState = MouseState.DragOutsideRegion
        End Select

        ColorPoint = NewColorPoint
        BrightnessPoint = NewBrightnessPoint

        UpdateDisplay()

    End Sub

    Private Function CalcBrightnessPoint(ByVal Brightness As Integer) As Point
        Return New Point(BrightnessX, CInt(BrightnessMax - Brightness / BrightnessScaling))
    End Function

    Private Sub UpdateDisplay()

        Dim SelectedBrush As Brush = Nothing

        Try

            SelectedBrush = New SolidBrush(SelectedColor)

            PageGraphics.DrawImage(ColorImage, ColorRectangle)

            PageGraphics.FillRectangle(SelectedBrush, SelectedColorRectangle)

            DrawLinearGradient(FullColor)

            DrawColorPointer(ColorPoint)
            DrawBrightnessPointer(BrightnessPoint)

        Finally

            If Not SelectedBrush IsNot Nothing Then SelectedBrush.Dispose()

        End Try

    End Sub

    Private Sub CalcCoordsAndUpdate(ByVal HSV As ColorHandler.HSV)

        ColorPoint = GetPoint(HSV.Hue / 255 * 360, HSV.Saturation / 255 * Radius, CenterPoint)

        BrightnessPoint = CalcBrightnessPoint(HSV.Value)

        Brightness = HSV.Value
        SelectedColor = ColorHandler.HSVtoColor(HSV)
        RGB = ColorHandler.HSVtoRGB(HSV)

        FullColor = ColorHandler.HSVtoColor(HSV.Hue, HSV.Saturation, 255)

    End Sub

    Private Sub DrawLinearGradient(ByVal TopColor As Color)

        Dim LinearGradientBrush As LinearGradientBrush = Nothing
        Try
            LinearGradientBrush = New LinearGradientBrush(BrightnessRectangle, TopColor, Drawing.Color.Black, LinearGradientMode.Vertical)
            PageGraphics.FillRectangle(LinearGradientBrush, BrightnessRectangle)
        Finally
            If Not LinearGradientBrush IsNot Nothing Then LinearGradientBrush.Dispose()
        End Try

    End Sub

    Private Function CalcDegrees(ByVal Point As Point) As Integer

        Dim Degrees As Integer

        If Point.X = 0 Then
            If Point.Y > 0 Then
                Degrees = 270
            Else
                Degrees = 90
            End If
        Else
            Degrees = CInt(-Math.Atan(Point.Y / Point.X) * DEGREES_PER_RADIAN)
            If Point.X < 0 Then
                Degrees += 180
            End If
            Degrees = (Degrees + 360) Mod 360
        End If

        Return Degrees

    End Function

    Private Sub CreateGradient()

        Dim NewGraphics As Graphics = Nothing
        Dim PathGradientBrush As PathGradientBrush = Nothing

        Try

            PathGradientBrush = New PathGradientBrush(GetPoints(Radius, New Point(Radius, Radius)))

            PathGradientBrush.CenterColor = Drawing.Color.White
            PathGradientBrush.CenterPoint = New PointF(Radius, Radius)
            PathGradientBrush.SurroundColors = GetColors()

            ColorImage = New Bitmap(ColorRectangle.Width, ColorRectangle.Height, PixelFormat.Format32bppArgb)

            NewGraphics = Graphics.FromImage(ColorImage)
            NewGraphics.FillEllipse(PathGradientBrush, 0, 0, ColorRectangle.Width, ColorRectangle.Height)

        Finally

            If PathGradientBrush IsNot Nothing Then PathGradientBrush.Dispose()
            If NewGraphics IsNot Nothing Then NewGraphics.Dispose()

        End Try

    End Sub

    Private Function GetColors() As Color()

        Dim Colors(COLOR_COUNT - 1) As Color
        For intLoop As Integer = 0 To COLOR_COUNT - 1
            Colors(intLoop) = ColorHandler.HSVtoColor(intLoop * 255 \ COLOR_COUNT, 255, 255)
        Next
        Return Colors

    End Function

    Private Function GetPoints(ByVal Radius As Double, ByVal CenterPoint As Point) As Point()

        Dim Points(COLOR_COUNT - 1) As Point
        For intLoop As Integer = 0 To COLOR_COUNT - 1
            Points(intLoop) = GetPoint(intLoop * 360 / COLOR_COUNT, Radius, CenterPoint)
        Next
        Return Points

    End Function

    Private Function GetPoint(ByVal Degrees As Double, ByVal Radius As Double, ByVal CenterPoint As Point) As Point

        Dim Radians As Double = Degrees / DEGREES_PER_RADIAN
        Return New Point(CInt(CenterPoint.X + Math.Floor(Radius * Math.Cos(Radians))), CInt(CenterPoint.Y - Math.Floor(Radius * Math.Sin(Radians))))

    End Function

    Private Sub DrawColorPointer(ByVal Point As Point)

        Const SIZE As Integer = 3
        PageGraphics.DrawRectangle(Pens.Black, Point.X - SIZE, Point.Y - SIZE, SIZE * 2, SIZE * 2)

    End Sub

    Private Sub DrawBrightnessPointer(ByVal Point As Point)

        Const HEIGHT As Integer = 10
        Const WIDTH As Integer = 7

        Dim Points(2) As Point
        Points(0) = Point
        Points(1) = New Point(Point.X + WIDTH, Point.Y + HEIGHT \ 2)
        Points(2) = New Point(Point.X + WIDTH, Point.Y - HEIGHT \ 2)
        PageGraphics.FillPolygon(Brushes.Black, Points)

    End Sub

End Class

