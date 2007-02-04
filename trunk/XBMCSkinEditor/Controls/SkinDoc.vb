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
        '        Me.ScintillaControl2.LegacyConfigurationLanguage = ""
        '    Case ".xml"
        '        Me.ScintillaControl2.LegacyConfigurationLanguage = "hypertext"
        '    Case ".py"
        '        Me.ScintillaControl2.LegacyConfigurationLanguage = "PY"
        '    Case ".cs"
        '        Me.ScintillaControl2.LegacyConfigurationLanguage = "C#"
        'End Select
        Me.m_fileName = FileNamePath
        Me.ScintillaControl2.SetText(System.IO.File.ReadAllText(FileNamePath, Encoding.ASCII))
    End Sub


    Private Sub SkinDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ScintillaControl2.LegacyConfiguration = Main.m_LegacyConf
        'Dim lc = Main.m_LegacyConf.GetLanguage("C#") as 
        'Dim lc As Scintilla.Lexers.Xml
        'ScintillaControl2.LegacyConfigurationLanguage = "C#"

        For Each x As Scintilla.Legacy.Configuration.Language In Main.m_LegacyConf.languages
            'MsgBox(x.name)
        Next

        ''lang = _legacyConfiguration.GetLanguage(value);
    End Sub

    Private Sub TSMI_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_Save.Click
        System.IO.File.WriteAllText(m_fileName, ScintillaControl2.Text)
    End Sub

    Private Sub TSMI_SaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_SaveAs.Click
        ' save as means save it to a new file
        sfd.Filter = "All Files (*.*)|*.*"
        sfd.Title = "Save File As"
        If (sfd.ShowDialog() = DialogResult.OK) Then
            Me.m_fileName = sfd.FileName
            Me.Text = System.IO.Path.GetFileName(m_fileName)
            System.IO.File.WriteAllText(Me.m_fileName, ScintillaControl2.Text)
        End If
    End Sub

    Private Sub TSMI_SaveCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_SaveCopy.Click
        ' save as means save it to a new file but keep workign on the oringally
        sfd.Filter = "All Files (*.*)|*.*"
        sfd.Title = "Save a Copy"
        If (sfd.ShowDialog() = DialogResult.OK) Then
            System.IO.File.WriteAllText(sfd.FileName, ScintillaControl2.Text)
        End If
    End Sub
End Class