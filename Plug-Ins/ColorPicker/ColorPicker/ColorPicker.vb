Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class ColorPicker

    Private Enum ChangeStyle
        MouseMove
        RGB
        HSV
        None
    End Enum

    Private ChangeType As ChangeStyle = ChangeStyle.None
    Private SelectedPoint As Point
    Private WithEvents MyColorWheel As ColorWheel

    Private RGB As ColorHandler.RGB
    Private HSV As ColorHandler.HSV
    Private IsInUpdate As Boolean = False
    Private LastColorValue As String

    Public Sub New()

        InitializeComponent()

        Me.DoubleBuffered = True

        pnlSelectedColor.Visible = False
        pnlBrightness.Visible = False
        pnlColor.Visible = False

        Dim SelectedColorRectangle As Rectangle = New Rectangle(pnlSelectedColor.Location, pnlSelectedColor.Size)
        Dim BrightnessRectangle As Rectangle = New Rectangle(pnlBrightness.Location, pnlBrightness.Size)
        Dim ColorRectangle As Rectangle = New Rectangle(pnlColor.Location, pnlColor.Size)

        MyColorWheel = New ColorWheel(ColorRectangle, BrightnessRectangle, SelectedColorRectangle)

        SetRGB(RGB)
        SetHSV(HSV)

    End Sub

    Private Sub HandleMouse(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove, MyBase.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ChangeType = ChangeStyle.MouseMove
            SelectedPoint = New Point(e.X, e.Y)
            Me.Invalidate()
        End If
    End Sub

    Private Sub HandleMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        MyColorWheel.SetMouseUp()
        ChangeType = ChangeStyle.None
    End Sub

    Private Sub HandleRGBChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudRed.ValueChanged, nudBlue.ValueChanged, nudGreen.ValueChanged
        If Not IsInUpdate Then
            ChangeType = ChangeStyle.RGB
            RGB = New ColorHandler.RGB(CInt(nudRed.Value), CInt(nudGreen.Value), CInt(nudBlue.Value))
            SetHSV(ColorHandler.RGBtoHSV(RGB))
            Me.Invalidate()
        End If
    End Sub

    Private Sub txtColorValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtColorValue.LostFocus

        If Not IsNumeric("&H" & txtColorValue.Text) Then
            txtColorValue.Text = LastColorValue
            Exit Sub
        Else
            txtColorValue.Text = txtColorValue.Text.PadLeft(6, "0").ToUpper
        End If

        If Not IsInUpdate Then
            ChangeType = ChangeStyle.RGB
            Dim ColorValue As String = txtColorValue.Text.PadLeft(6, "0")
            RGB = New ColorHandler.RGB(CInt("&H" & ColorValue.Substring(0, 2)), CInt("&H" & ColorValue.Substring(2, 2)), CInt("&H" & ColorValue.Substring(4, 2)))
            SetHSV(ColorHandler.RGBtoHSV(RGB))
            Me.Invalidate()
        End If

    End Sub

    Private Sub HandleHSVChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudHue.ValueChanged, nudSaturation.ValueChanged, nudBrightness.ValueChanged
        If Not IsInUpdate Then
            ChangeType = ChangeStyle.HSV
            HSV = New ColorHandler.HSV(CInt(nudHue.Value), CInt(nudSaturation.Value), CInt(nudBrightness.Value))
            SetRGB(ColorHandler.HSVtoRGB(HSV))
            Me.Invalidate()
        End If
    End Sub

    Private Sub SetRGB(ByVal RGB As ColorHandler.RGB)
        IsInUpdate = True
        RefreshValue(nudRed, RGB.Red)
        RefreshValue(nudBlue, RGB.Blue)
        RefreshValue(nudGreen, RGB.Green)
        LastColorValue = txtColorValue.Text
        txtColorValue.Text = Hex(RGB.Red).PadLeft(2, "0") & Hex(RGB.Green).PadLeft(2, "0") & Hex(RGB.Blue).PadLeft(2, "0")
        IsInUpdate = False
    End Sub

    Private Sub SetHSV(ByVal HSV As ColorHandler.HSV)
        IsInUpdate = True
        RefreshValue(nudHue, HSV.Hue)
        RefreshValue(nudSaturation, HSV.Saturation)
        RefreshValue(nudBrightness, HSV.Value)
        IsInUpdate = False
    End Sub

    Private Sub HandleTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudRed.TextChanged, nudBlue.TextChanged, nudGreen.TextChanged, nudHue.TextChanged, nudSaturation.TextChanged, nudBrightness.TextChanged
        Dim x As Decimal = DirectCast(sender, NumericUpDown).Value
    End Sub

    Private Sub RefreshValue(ByVal nud As NumericUpDown, ByVal Value As Integer)
        If nud.Value <> Value Then
            nud.Value = Value
            nud.Refresh()
        End If
    End Sub

    Public Property Color() As Color
        Get
            Return MyColorWheel.Color
        End Get
        Set(ByVal Value As Color)
            ChangeType = ChangeStyle.RGB
            RGB = New ColorHandler.RGB(Value.R, Value.G, Value.B)
            HSV = ColorHandler.RGBtoHSV(RGB)
        End Set
    End Property

    Private Sub MyColorWheel_ColorChanged(ByVal sender As Object, ByVal e As ColorChangedEventArgs) Handles MyColorWheel.ColorChanged
        SetRGB(e.RGB)
        SetHSV(e.HSV)
    End Sub

    Private Sub HandlePaint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
        Select Case ChangeType
            Case ChangeStyle.HSV
                MyColorWheel.Draw(e.Graphics, HSV)
            Case ChangeStyle.MouseMove, ChangeStyle.None
                MyColorWheel.Draw(e.Graphics, SelectedPoint)
            Case ChangeStyle.RGB
                MyColorWheel.Draw(e.Graphics, RGB)
        End Select
    End Sub

    Private Sub ColorPicker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class
