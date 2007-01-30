Imports SkinEditor.Interfaces
Imports WeifenLuo.WinFormsUI
Public Class Main
    Private WithEvents objHost As New Host
    Private m_SkinBrowser As New SkinBrowser
    Private m_OutputWindow As New OutputWindow
    Private m_ErrorLogWindow As New ErrorLogWindow
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
                lstPlugins.Items.Add(objPlugin.PluginDetails.Name)
                Dim newItem As New ToolStripMenuItem
                newItem.Text = objPlugin.PluginDetails.Name
                newItem.Tag = Str(lstPlugins.Items.Count - 1)
                PluginMenu.DropDownItems.Add(newItem)
            Next intIndex
            lstPlugins.SelectedIndex = 0
        Else
            btnRun.Enabled = False
        End If

        objHost.LoadSettings()
        m_SkinBrowser.Show(DockingPanel, DockState.DockLeft)
        m_OutputWindow.Show(DockingPanel, DockState.DockBottom)
        m_ErrorLogWindow.Show(DockingPanel, DockState.DockBottom)
    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        If (lstPlugins.Items.Count > 0) Then
            Dim objPlugin As IPlugin = DirectCast(PluginServices.CreateInstance(Plugins(lstPlugins.SelectedIndex)), IPlugin)
            objPlugin.Initialize(objHost)
            objPlugin.Start()
        End If
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        If (lstPlugins.Items.Count > 0) Then
            Dim objPlugin As IPlugin = DirectCast(PluginServices.CreateInstance(Plugins(lstPlugins.SelectedIndex)), IPlugin)
            objPlugin.Initialize(objHost)
            objPlugin.Settings()
        End If
    End Sub

    Private Sub objHost_ErrorEvent(ByVal ErrorLevel As Integer, ByVal Message As String, ByVal File As String, ByVal Line As Integer, ByVal Pos As Integer) Handles objHost.ErrorEvent
        'txtError.Text &= Message & ControlChars.CrLf
        m_OutputWindow.OuputText = Message
    End Sub

    Private Sub PluginMenu_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles PluginMenu.DropDownItemClicked
        If (lstPlugins.Items.Count > 0) Then
            Dim objPlugin As IPlugin = DirectCast(PluginServices.CreateInstance(Plugins(Int(e.ClickedItem.Tag))), IPlugin)
            objPlugin.Initialize(objHost)
            objPlugin.Start()
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim dummyDoc As SkinDoc = CreateNewDocument()

        If DockingPanel.DocumentStyle = DocumentStyles.SystemMdi Then
            dummyDoc.MdiParent = Me
            dummyDoc.Show()
        Else
            dummyDoc.Show(DockingPanel)
        End If
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

    Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'Me.DockingPanel.Width = Me.Width - 7
        'Me.DockingPanel.Height = Me.Height - 53
    End Sub


    Private Sub MS_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MS.ItemClicked

    End Sub
End Class
