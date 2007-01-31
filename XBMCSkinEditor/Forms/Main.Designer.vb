<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Button1 = New System.Windows.Forms.Button
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OSTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SBTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_ErrorLog = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_Output = New System.Windows.Forms.ToolStripMenuItem
        Me.MS = New System.Windows.Forms.MenuStrip
        Me.PluginMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_Lang = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_PluginsSettings = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DockingPanel = New WeifenLuo.WinFormsUI.DockPanel
        AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MS.SuspendLayout()
        Me.SuspendLayout()
        '
        'AboutToolStripMenuItem
        '
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        AboutToolStripMenuItem.Text = "About"
        AddHandler AboutToolStripMenuItem.Click, AddressOf Me.AboutToolStripMenuItem_Click
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 103)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OSTSMI})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OSTSMI
        '
        Me.OSTSMI.Name = "OSTSMI"
        Me.OSTSMI.Size = New System.Drawing.Size(133, 22)
        Me.OSTSMI.Text = "Open Skin"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Checked = True
        Me.WindowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SBTSMI, Me.TSMI_ErrorLog, Me.TSMI_Output})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'SBTSMI
        '
        Me.SBTSMI.Checked = True
        Me.SBTSMI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SBTSMI.Name = "SBTSMI"
        Me.SBTSMI.Size = New System.Drawing.Size(143, 22)
        Me.SBTSMI.Text = "SkinBrowser"
        '
        'TSMI_ErrorLog
        '
        Me.TSMI_ErrorLog.Checked = True
        Me.TSMI_ErrorLog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TSMI_ErrorLog.Name = "TSMI_ErrorLog"
        Me.TSMI_ErrorLog.Size = New System.Drawing.Size(143, 22)
        Me.TSMI_ErrorLog.Text = "Error Log"
        '
        'TSMI_Output
        '
        Me.TSMI_Output.Checked = True
        Me.TSMI_Output.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TSMI_Output.Name = "TSMI_Output"
        Me.TSMI_Output.Size = New System.Drawing.Size(143, 22)
        Me.TSMI_Output.Text = "Output"
        '
        'MS
        '
        Me.MS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem, Me.PluginMenu, Me.TSMI_Lang, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MS.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MS.Location = New System.Drawing.Point(0, 0)
        Me.MS.Name = "MS"
        Me.MS.Size = New System.Drawing.Size(692, 24)
        Me.MS.TabIndex = 0
        '
        'PluginMenu
        '
        Me.PluginMenu.Name = "PluginMenu"
        Me.PluginMenu.Size = New System.Drawing.Size(52, 20)
        Me.PluginMenu.Text = "Plugins"
        '
        'TSMI_Lang
        '
        Me.TSMI_Lang.Name = "TSMI_Lang"
        Me.TSMI_Lang.Size = New System.Drawing.Size(71, 20)
        Me.TSMI_Lang.Text = "Languages"
        Me.TSMI_Lang.Visible = False
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_PluginsSettings})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'TSMI_PluginsSettings
        '
        Me.TSMI_PluginsSettings.Name = "TSMI_PluginsSettings"
        Me.TSMI_PluginsSettings.Size = New System.Drawing.Size(118, 22)
        Me.TSMI_PluginsSettings.Text = "Plugins"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'DockingPanel
        '
        Me.DockingPanel.ActiveAutoHideContent = Nothing
        Me.DockingPanel.BackColor = System.Drawing.Color.White
        Me.DockingPanel.BackgroundImage = CType(resources.GetObject("DockingPanel.BackgroundImage"), System.Drawing.Image)
        Me.DockingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockingPanel.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.DockingPanel.Location = New System.Drawing.Point(0, 24)
        Me.DockingPanel.Name = "DockingPanel"
        Me.DockingPanel.Size = New System.Drawing.Size(692, 342)
        Me.DockingPanel.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 366)
        Me.Controls.Add(Me.DockingPanel)
        Me.Controls.Add(Me.MS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MS
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XBMC Skin Editor"
        Me.MS.ResumeLayout(False)
        Me.MS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OSTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SBTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MS As System.Windows.Forms.MenuStrip
    Friend WithEvents PluginMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DockingPanel As WeifenLuo.WinFormsUI.DockPanel
    Friend WithEvents TSMI_ErrorLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_Output As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_PluginsSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_Lang As System.Windows.Forms.ToolStripMenuItem
End Class
