Imports WeifenLuo.WinFormsUI
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Text
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

                s.Close()
            End If

            m_fileName = value
            Me.ToolTipText = value
        End Set
    End Property

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
            'Me.richTextBox1.Text = Text
        End If
    End Sub
    Public Sub LoadText(ByVal FileNamePath As String)
        Dim ext As String
        ext = System.IO.Path.GetExtension(FileNamePath.ToLower())
        'Select Case ext
        '    Case ".txt"
        '        'Me.ScintillaControl2.LegacyConfigurationLanguage = "txt"
        '    Case ".xml"
        '        Me.ScintillaControl2.LegacyConfigurationLanguage = "hypertext"
        '    Case ".py"
        '        Me.ScintillaControl2.LegacyConfigurationLanguage = "PY"
        '    Case ".cs"
        '        'Me.ScintillaControl2.LegacyConfigurationLanguage = "C#"
        'End Select
        Me.ScintillaControl2.SetText(System.IO.File.ReadAllText(FileNamePath, Encoding.ASCII))
    End Sub


    Private Sub SkinDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim cu = New Scintilla.Legacy.Configuration.ConfigurationUtility([GetType]().[Module].Assembly)
        'Me.ScintillaControl2.LegacyConfiguration = DirectCast(cu.LoadConfiguration(GetType(Scintilla.Legacy.Configuration.Scintilla), "LegacyScintillaNET.xml"), Scintilla.Legacy.Configuration.Scintilla)
    End Sub

End Class