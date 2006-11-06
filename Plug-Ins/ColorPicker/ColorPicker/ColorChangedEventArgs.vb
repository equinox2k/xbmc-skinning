Public Class ColorChangedEventArgs
  Inherits EventArgs

    Private RGBColor As ColorHandler.RGB
    Private HSVColor As ColorHandler.HSV

    Sub New(ByVal RGB As ColorHandler.RGB, ByVal HSV As ColorHandler.HSV)
        RGBColor = RGB
        HSVColor = HSV
    End Sub

    ReadOnly Property RGB() As ColorHandler.RGB
        Get
            Return RGBColor
        End Get
    End Property

    ReadOnly Property HSV() As ColorHandler.HSV
        Get
            Return HSVColor
        End Get
    End Property

End Class