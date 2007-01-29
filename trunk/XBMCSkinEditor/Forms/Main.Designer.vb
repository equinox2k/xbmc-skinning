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
        Me.Button1 = New System.Windows.Forms.Button
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OSTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SBTSMI = New System.Windows.Forms.ToolStripMenuItem
        Me.MS = New System.Windows.Forms.MenuStrip
        Me.PluginMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnRun = New System.Windows.Forms.Button
        Me.DockingPanel = New WeifenLuo.WinFormsUI.DockPanel
        Me.lstPlugins = New System.Windows.Forms.ListBox
        Me.btnSettings = New System.Windows.Forms.Button
        Me.txtError = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.TSB_New = New System.Windows.Forms.ToolStripButton
        Me.MS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OSTSMI, Me.NewToolStripMenuItem})
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
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Checked = True
        Me.WindowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SBTSMI})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'SBTSMI
        '
        Me.SBTSMI.Name = "SBTSMI"
        Me.SBTSMI.Size = New System.Drawing.Size(143, 22)
        Me.SBTSMI.Text = "SkinBrowser"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(110, 15)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(72, 28)
        Me.btnRun.TabIndex = 1
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'DockingPanel
        '
        Me.DockingPanel.ActiveAutoHideContent = Nothing
        Me.DockingPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DockingPanel.BackgroundImage = Global.XBMCSkinEditor.My.Resources.Resources.Back
        Me.DockingPanel.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.DockingPanel.Location = New System.Drawing.Point(0, 48)
        Me.DockingPanel.Name = "DockingPanel"
        Me.DockingPanel.Size = New System.Drawing.Size(655, 278)
        Me.DockingPanel.TabIndex = 0
        '
        'lstPlugins
        '
        Me.lstPlugins.FormattingEnabled = True
        Me.lstPlugins.Location = New System.Drawing.Point(6, 15)
        Me.lstPlugins.Name = "lstPlugins"
        Me.lstPlugins.Size = New System.Drawing.Size(98, 108)
        Me.lstPlugins.TabIndex = 0
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(110, 95)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(72, 28)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(6, 129)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtError.Size = New System.Drawing.Size(176, 51)
        Me.txtError.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSettings)
        Me.GroupBox1.Controls.Add(Me.btnRun)
        Me.GroupBox1.Controls.Add(Me.lstPlugins)
        Me.GroupBox1.Controls.Add(Me.txtError)
        Me.GroupBox1.Location = New System.Drawing.Point(334, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 186)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSB_New})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(655, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSB_New
        '
        Me.TSB_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSB_New.Image = Global.XBMCSkinEditor.My.Resources.Resources.document_plain
        Me.TSB_New.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSB_New.Name = "TSB_New"
        Me.TSB_New.Size = New System.Drawing.Size(23, 22)
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 332)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MS)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DockingPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MS
        Me.Name = "Main"
        Me.Text = "XBMC Skin Editor"
        Me.MS.ResumeLayout(False)
        Me.MS.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents lstPlugins As System.Windows.Forms.ListBox
    Friend WithEvents btnSettings As System.Windows.Forms.Button
    Friend WithEvents txtError As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DockingPanel As WeifenLuo.WinFormsUI.DockPanel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TSB_New As System.Windows.Forms.ToolStripButton
End Class
