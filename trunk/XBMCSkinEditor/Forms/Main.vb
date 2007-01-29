Imports SkinEditor.Interfaces
Public Class Main
    Private WithEvents objHost As New Host
    Private Plugins() As PluginServices.AvailablePlugin = PluginServices.FindPlugins(objHost.AppPath, "SkinEditor.Interfaces.IPlugin")

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
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
                SkinBrowser.OpenSkin(System.IO.Path.GetDirectoryName(objOFD.FileName))
            End If
        End If
    End Sub

    Private Sub SBTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SBTSMI.Click
        Me.SplitContainer1.Panel1Collapsed = SBTSMI.Checked
        If SBTSMI.Checked Then
            SBTSMI.Checked = False
        Else
            SBTSMI.Checked = True
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        txtError.Text &= Message & ControlChars.CrLf
    End Sub



    Private Sub PluginMenu_DropDownItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles PluginMenu.DropDownItemClicked
        If (lstPlugins.Items.Count > 0) Then
            Dim objPlugin As IPlugin = DirectCast(PluginServices.CreateInstance(Plugins(Int(e.ClickedItem.Tag))), IPlugin)
            objPlugin.Initialize(objHost)
            objPlugin.Start()
        End If
    End Sub
End Class
