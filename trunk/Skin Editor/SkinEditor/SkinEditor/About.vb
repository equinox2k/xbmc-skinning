Imports BASSMusic = Un4seen.Bass.BASSMusic
Imports Bass = Un4seen.Bass.Bass
Imports System.Runtime.InteropServices

Public Class About

    Dim intHand As Integer

    Private Sub About_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Bass.BASS_ChannelStop(intHand)
        Bass.BASS_MusicFree(intHand)
        Bass.BASS_Free()
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ScrollingTextPanel.Message = "--------------------------------- XBMC Skin Editor was " & _
                                      "created and designed by EqUiNox & Donno... GFX by Blackbolt... " & _
                                      "Big thanks go to: XBMC Team for creating such a great " & _
                                      "program and giving me inspiration to create this program. " & _
                                      "J Marshall who put up with me asking continuous questions " & _
                                      "regarding the XBMC spec. "
        ScrollingTextPanel.Interval = 50
        ScrollingTextPanel.ScrollSpeed = 2
        ScrollingTextPanel.Started = True

        Bass.BASS_Init(1, 44100, Un4seen.Bass.BASSInit.BASS_DEVICE_DEFAULT, 0, Nothing)
        intHand = Bass.BASS_MusicLoad(System.AppDomain.CurrentDomain.BaseDirectory & "train.mod", 0, 0, BASSMusic.BASS_DEFAULT, 0)
        Bass.BASS_ChannelPlay(intHand, True)
    End Sub


End Class