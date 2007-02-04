Imports SkinEditor.Interfaces
Imports WeifenLuo.WinFormsUI
Public Class Main
    Private WithEvents objHost As New Host
    Private m_SkinBrowser As New SkinBrowser
    Private m_OutputWindow As New OutputWindow
    Private m_ErrorLogWindow As New ErrorLogWindow
    Private m_PropertiesWindow As New Skinproperty
    Public m_LegacyConf As Scintilla.Legacy.Configuration.Scintilla
    Private m_CurrentProject As String

    Private Plugins() As PluginServices.AvailablePlugin = PluginServices.FindPlugins(objHost.AppPath, "SkinEditor.Interfaces.IPlugin")


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objAbout As New About
        objAbout.ShowDialog(Me)
    End Sub

    Private Sub OSTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSTSMI.Click
        Dim objOFD As New OpenFileDialog
        objOFD.CheckFileExists = True
        objOFD.FileName = "Skin.xml"
        objOFD.Filter = "Skin File (Skin.xml)|Skin.xml"
        objOFD.Title = "Please select desired skin to open:"
        If objOFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If System.IO.Path.GetFileName(objOFD.FileName).ToUpper = "SKIN.XML" Then
                m_CurrentProject = (System.IO.Path.GetDirectoryName(objOFD.FileName))
                Me.m_SkinBrowser.OpenSkin(System.IO.Path.GetDirectoryName(objOFD.FileName))
            End If
        End If
    End Sub

    Private Sub SBTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBTSMI.Click
        If SBTSMI.Checked Then
            SBTSMI.Checked = False
            m_SkinBrowser.Hide()
        Else
            SBTSMI.Checked = True
            m_SkinBrowser.Show(DockingPanel, DockState.DockLeft)
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        m_SkinBrowser.Text = "Skin Browser"
        If Plugins IsNot Nothing Then

            For intIndex As Integer = 0 To Plugins.Length - 1
                Dim objPlugin As IPlugin = DirectCast(PluginServices.CreateInstance(Plugins(intIndex)), IPlugin)
                Dim newItem As New ToolStripMenuItem
                newItem.Text = objPlugin.PluginDetails.Name
                newItem.Tag = Str(intIndex)
                PluginMenu.DropDownItems.Add(newItem)
                If objPlugin.PluginDetails.HasSettings Then
                    Dim newItem2 As New ToolStripMenuItem
                    newItem2.Text = objPlugin.PluginDetails.Name
                    newItem2.Tag = Str(intIndex)

                    TSMI_PluginsSettings.DropDownItems.Add(newItem2)
                End If
            Next intIndex
        End If

        objHost.LoadSettings()
        m_SkinBrowser.Show(DockingPanel, DockState.DockLeft)
        m_OutputWindow.Show(DockingPanel, DockState.DockBottom)
        m_ErrorLogWindow.Show(DockingPanel, DockState.DockBottom)
        Dim cu = New Scintilla.Legacy.Configuration.ConfigurationUtility([GetType]().[Module].Assembly)
        m_LegacyConf = DirectCast(cu.LoadConfiguration(GetType(Scintilla.Legacy.Configuration.Scintilla), "LegacyScintillaNET.xml"), Scintilla.Legacy.Configuration.Scintilla)

        For Each x As Scintilla.Legacy.Configuration.Language In m_LegacyConf.languages
            Dim ts As New ToolStripMenuItem
            ts.Text = x.name
            ts.Tag = x.fileextensions
            Me.TSMI_Lang.DropDownItems.Add(ts)
        Next
        m_OutputWindow.OuputText = "========== XBMC Skin Editor Loaded =========="
    End Sub
    Private Function HasLang(ByVal LName As String) As Boolean
        For Each x As Scintilla.Legacy.Configuration.Language In m_LegacyConf.languages
            If x.name = LName Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub objHost_ErrorEvent(ByVal ErrorLevel As Integer, ByVal Message As String, ByVal File As String, ByVal Line As Integer, ByVal Pos As Integer) Handles objHost.ErrorEvent
        'txtError.Text &= Message & ControlChars.CrLf
        m_OutputWindow.OuputText = Message
    End Sub

    Private Sub PluginMenu_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles PluginMenu.DropDownItemClicked
        If (Plugins.Length > 0) Then
            Dim objPlugin As IPlugin = DirectCast(PluginServices.CreateInstance(Plugins(Int(e.ClickedItem.Tag))), IPlugin)
            objPlugin.Initialize(objHost)
            objPlugin.Start()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dummyDoc As SkinDoc = CreateNewDocument()

        If DockingPanel.DocumentStyle = DocumentStyles.SystemMdi Then
            dummyDoc.MdiParent = Me
            dummyDoc.Show()
        Else
            dummyDoc.Show(DockingPanel)
        End If
    End Sub
    Public Sub LoadXPRImage(ByVal FIFYI As SkinBrowser.FileInfo)
        Dim newPC As New SkinImageView()
        'Dim objViewImage As New SkinImageView
        newPC.Text = FIFYI.XPRInfo.XPRFile
        Try
            Dim objXPRTool As New XPRTool
            objXPRTool.OpenXPR(FIFYI.Path & FIFYI.Name)
            newPC.Image = objXPRTool.GetImage(FIFYI.XPRInfo.XPRFile)
            objXPRTool.CloseXPR()
        Catch ex As Exception
        End Try
        newPC.Show(DockingPanel)
    End Sub
    Public Sub Loadmage(ByVal strPath As String)
        Dim newPC As New SkinImageView()
        newPC.Text = System.IO.Path.GetFileName(strPath)
        newPC.LoadImage(strPath)
        newPC.Show(DockingPanel)
    End Sub
    Public Sub LoadDocument(ByVal strPath As String)
        Dim dummyDoc As New SkinDoc()
        dummyDoc.LoadText(strPath)
        dummyDoc.Text = System.IO.Path.GetFileName(strPath)
        dummyDoc.Show(DockingPanel)
    End Sub

    Private Function CreateNewDocument() As SkinDoc
        Dim dummyDoc As New SkinDoc()

        Dim count As Integer = 1
        Dim text As String = "Document" + count.ToString()

        dummyDoc.Text = text
        Return dummyDoc
    End Function

    Private Sub TSB_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dummyDoc As SkinDoc = CreateNewDocument()

        If DockingPanel.DocumentStyle = DocumentStyles.SystemMdi Then
            dummyDoc.MdiParent = Me
            dummyDoc.Show()
        Else
            dummyDoc.Show(DockingPanel)
        End If
    End Sub

    Private Sub TSMI_ErrorLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_ErrorLog.Click
        If TSMI_ErrorLog.Checked Then
            TSMI_ErrorLog.Checked = False
            m_ErrorLogWindow.Hide()
        Else
            TSMI_ErrorLog.Checked = True
            m_ErrorLogWindow.Show(DockingPanel, DockState.DockBottom)
        End If
    End Sub

    Private Sub TSMI_Output_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_Output.Click
        If TSMI_Output.Checked Then
            TSMI_Output.Checked = False
            m_OutputWindow.Hide()
        Else
            TSMI_Output.Checked = True
            m_OutputWindow.Show(DockingPanel, DockState.DockBottom)
        End If
    End Sub
    Private Sub TSMI_PluginsSettings_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles TSMI_PluginsSettings.DropDownItemClicked
        If (Plugins.Length > 0) Then
            Dim objPlugin As IPlugin = DirectCast(PluginServices.CreateInstance(Plugins(Int(e.ClickedItem.Tag))), IPlugin)
            objPlugin.Initialize(objHost)
            objPlugin.Settings()
        End If
    End Sub

    Private Sub TMSI_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMSI_Refresh.Click
        Me.m_SkinBrowser.OpenSkin(m_CurrentProject)
    End Sub


    Private Sub TSMI_Properties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_Properties.Click
        If TSMI_Properties.Checked Then
            TSMI_Properties.Checked = False
            m_PropertiesWindow.Hide()
        Else
            TSMI_Properties.Checked = True
            m_PropertiesWindow.Show(DockingPanel, DockState.DockRight)
        End If
    End Sub
End Class
