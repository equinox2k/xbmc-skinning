Imports WeifenLuo.WinFormsUI
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Text
Public Class SkinImageView
    Inherits DockContent
    Private WithEvents objSkinImage As SkinImage
    Private m_fileName As String = String.Empty

    Public Sub LoadImage(ByVal strPath As String)
        Me.SkinImageView_PB.Load(strPath)
    End Sub

    Public Sub LoadXPRImage(ByVal strPath As String)
        Dim xpr As New ImageFrame

        Me.SkinImageView_PB.Load(strPath)
    End Sub
    Private Sub objSkinImage_ShowFrame(ByVal Image As System.Drawing.Image) Handles objSkinImage.ShowFrame
        Me.SkinImageView_PB.Image = Image
    End Sub

    Public Property Image() As SkinImage
        Get
            Return objSkinImage
        End Get
        Set(ByVal Value As SkinImage)
            objSkinImage = Value
            Me.SkinImageView_PB.Width = objSkinImage.Frames(0).Frame.Width
            Me.SkinImageView_PB.Height = objSkinImage.Frames(0).Frame.Height
            Me.SkinImageView_PB.Image = objSkinImage.Frames(0).Frame
            If objSkinImage.Frames.Count > 1 Then objSkinImage.Animate()
        End Set
    End Property
End Class
