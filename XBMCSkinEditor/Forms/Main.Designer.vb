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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MS = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OSTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SBTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.PluginMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SkinBrowser = New XBMCSkinEditor.SkinBrowser
        Me.txtError = New System.Windows.Forms.TextBox
        Me.btnSettings = New System.Windows.Forms.Button
        Me.btnRun = New System.Windows.Forms.Button
        Me.lstPlugins = New System.Windows.Forms.ListBox
        Me.DockingPanel = New WeifenLuo.WinFormsUI.DockPanel
        Me.Button1 = New System.Windows.Forms.Button
        Me.MS.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MS
        '
        Me.MS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem, Me.PluginMenu, Me.HelpToolStripMenuItem})
        Me.MS.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MS.Location = New System.Drawing.Point(0, 0)
        Me.MS.Name = "MS"
        Me.MS.Size = New System.Drawing.Size(655, 24)
        Me.MS.TabIndex = 0
        Me.MS.Text = "MenuStrip1"
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
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SBTSMI})
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
        'PluginMenu
        '
        Me.PluginMenu.Name = "PluginMenu"
        Me.PluginMenu.Size = New System.Drawing.Size(52, 20)
        Me.PluginMenu.Text = "Plugins"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.XBMCSkinEditor.My.Resources.Resources.Skin
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SkinBrowser)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.XBMCSkinEditor.My.Resources.Resources.Back
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtError)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSettings)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnRun)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstPlugins)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DockingPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(655, 308)
        Me.SplitContainer1.SplitterDistance = 218
        Me.SplitContainer1.TabIndex = 1
        '
        'SkinBrowser
        '
        Me.SkinBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkinBrowser.Location = New System.Drawing.Point(0, 0)
        Me.SkinBrowser.Name = "SkinBrowser"
        Me.SkinBrowser.Size = New System.Drawing.Size(218, 308)
        Me.SkinBrowser.TabIndex = 0
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(51, 173)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtError.Size = New System.Drawing.Size(289, 91)
        Me.txtError.TabIndex = 3
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(129, 139)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(72, 28)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(51, 139)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(72, 28)
        Me.btnRun.TabIndex = 1
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'lstPlugins
        '
        Me.lstPlugins.FormattingEnabled = True
        Me.lstPlugins.Location = New System.Drawing.Point(51, 25)
        Me.lstPlugins.Name = "lstPlugins"
        Me.lstPlugins.Size = New System.Drawing.Size(289, 108)
        Me.lstPlugins.TabIndex = 0
        '
        'DockingPanel
        '
        Me.DockingPanel.ActiveAutoHideContent = Nothing
        Me.DockingPanel.BackgroundImage = Global.XBMCSkinEditor.My.Resources.Resources.Back
        Me.DockingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DockingPanel.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.DockingPanel.Location = New System.Drawing.Point(0, 0)
        Me.DockingPanel.Name = "DockingPanel"
        Me.DockingPanel.Size = New System.Drawing.Size(433, 308)
        Me.DockingPanel.TabIndex = 0
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 332)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MS
        Me.Name = "Main"
        Me.Text = "XBMC Skin Editor"
        Me.MS.ResumeLayout(False)
        Me.MS.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MS As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OSTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SkinBrowser As XBMCSkinEditor.SkinBrowser
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SBTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstPlugins As System.Windows.Forms.ListBox
    Friend WithEvents PluginMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents txtError As System.Windows.Forms.TextBox
    Friend WithEvents DockingPanel As WeifenLuo.WinFormsUI.DockPanel
End Class
