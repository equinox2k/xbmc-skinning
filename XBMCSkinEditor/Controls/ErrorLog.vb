Imports System.IO
Imports WeifenLuo.WinFormsUI

Public Class ErrorLogWindow
    Inherits DockContent

    Public Sub ErrLog(ByVal errortxt As String)
        Me.lstErrors.Items.Add(errortxt)
    End Sub

    'Public Property ErrorItems()
    '    Get
    '        Return strID
    '    End Get
    '    Set(ByVal Value As String)
    '        strID = Value
    '    End Set
    'End Property
End Class
