Imports WeifenLuo.WinFormsUI

Public Class OutputWindow
    Inherits DockContent
    Public Property OuputText() As String
        Get
            Return Me.txtOutput.Text
        End Get
        Set(ByVal Value As String)
            Me.txtOutput.Text = Me.txtOutput.Text + Value + vbCrLf
        End Set
    End Property

End Class
