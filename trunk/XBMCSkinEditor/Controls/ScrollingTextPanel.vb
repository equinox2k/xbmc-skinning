'Imports System.Drawing
'Imports System.Drawing.Drawing2D

Public Class ScrollingTextPanel
    Inherits Panel

    Private WithEvents Timer As New Timer

    Private intScrollSpeed As Integer = 2
    Private intSinOffset As Integer = 0
    Private intCharWidth As Integer = 0
    Private intPixelOffset As Integer = 0
    Private intCharPos As Integer = 0
    Private strMessage As String = ""

    Public Sub New()
        DoubleBuffered = True
        Timer.Interval = 100
        Timer.Enabled = False
        AddHandler Timer.Tick, AddressOf Timer_Tick
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        If strMessage = "" Then Exit Sub

        Dim strChar As String
        Dim objGraphics As Graphics = e.Graphics
        objGraphics.PageUnit = GraphicsUnit.Pixel

        intSinOffset += 20
        If intSinOffset >= 360 Then intSinOffset -= 360

        If intPixelOffset >= intCharWidth Then
            intCharPos += 1
            If intCharPos < strMessage.Length Then
                strChar = strMessage.Substring(intCharPos, 1)
            Else
                strChar = strMessage.Substring(0, 1)
            End If
            Dim objSizeF As SizeF = objGraphics.MeasureString(strChar, Me.Font)
            intPixelOffset -= intCharWidth
            intCharWidth = objSizeF.Width
        End If

        If intCharPos >= strMessage.Length Then intCharPos = 0
        Dim intCurChar As Integer = intCharPos
        Dim intCurPosX As Integer = 0

        Do

            If intCurChar >= strMessage.Length Then intCurChar = 0
            strChar = strMessage.Substring(intCurChar, 1)

            Dim objSizeF As SizeF = objGraphics.MeasureString(strChar, Me.Font)
            Dim intYOffset = Math.Sin(Math.PI * ((intSinOffset + (intCurPosX * 2)) / 180.0)) * ((Me.Height - (objSizeF.Height * 2)) / 2)
            objGraphics.DrawString(strChar, Me.Font, New SolidBrush(Me.ForeColor), intCurPosX - intPixelOffset, 0 + (Me.Height / 2) - (objSizeF.Height / 2) + intYOffset)

            intCurPosX += CInt(objSizeF.Width)
            intCurChar += 1

        Loop Until intCurPosX - intPixelOffset > Me.Width

        intPixelOffset += intScrollSpeed
        MyBase.OnPaint(e)

    End Sub

    Public Property Started() As Boolean
        Get
            Return Timer.Enabled
        End Get
        Set(ByVal Value As Boolean)
            Timer.Enabled = Value
        End Set
    End Property

    Public Property Message() As String
        Get
            Return strMessage
        End Get
        Set(ByVal Value As String)
            strMessage = Value
        End Set
    End Property

    Public Property Interval() As Integer
        Get
            Return Timer.Interval
        End Get
        Set(ByVal Value As Integer)
            Timer.Interval = Value
        End Set
    End Property

    Public Property ScrollSpeed() As Integer
        Get
            Return intScrollSpeed
        End Get
        Set(ByVal Value As Integer)
            intScrollSpeed = Value
        End Set
    End Property

End Class
