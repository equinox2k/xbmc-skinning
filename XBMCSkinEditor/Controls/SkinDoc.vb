Imports WeifenLuo.WinFormsUI
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Public Class SkinDoc
    Inherits DockContent
    Private m_resetText As Boolean = True

    Private m_fileName As String = String.Empty
    Public Property FileName() As String
        Get
            Return m_fileName
        End Get
        Set(ByVal value As String)
            If value <> String.Empty Then
                Dim s As IO.Stream = New FileStream(value, FileMode.Open)

                Dim efInfo As New FileInfo(value)

                Dim fext As String = efInfo.Extension.ToUpper()

                If fext.Equals(".RTF") Then
                    richTextBox1.LoadFile(s, RichTextBoxStreamType.RichText)
                Else
                    richTextBox1.LoadFile(s, RichTextBoxStreamType.PlainText)
                End If
                s.Close()
            End If

            m_fileName = value
            Me.ToolTipText = value
        End Set
    End Property

    ' workaround of RichTextbox control's bug:
    ' If load file before the control showed, all the text format will be lost
    ' re-load the file after it get showed.
    Protected Overloads Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        If m_resetText Then
            m_resetText = False
            FileName = FileName
        End If
    End Sub

    Protected Overloads Overrides Function GetPersistString() As String
        Return [GetType]().ToString() + "," + FileName + "," + Text
    End Function

    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MessageBox.Show("This is to demostrate menu item has been successfully merged into the main form. Form Text=" + Text)
    End Sub

    Private Sub menuItemCheckTest_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'menuItemCheckTest.Checked = Not menuItemCheckTest.Checked
    End Sub

    Protected Overloads Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e)
        If FileName = String.Empty Then
            Me.richTextBox1.Text = Text
        End If
    End Sub
End Class