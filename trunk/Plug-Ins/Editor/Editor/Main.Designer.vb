<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.HtmlParser = New QWhale.Syntax.Parser
        Me.PythonParser = New QWhale.Syntax.Parser
        Me.JavascriptParser = New QWhale.Syntax.Parser
        Me.TextSource = New QWhale.Editor.TextSource(Me.components)
        Me.EditorMenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.CloseMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PageSetupMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintOptionsMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditorToolStrip = New System.Windows.Forms.ToolStrip
        Me.FindToolItem = New System.Windows.Forms.ToolStripButton
        Me.ReplaceToolItem = New System.Windows.Forms.ToolStripButton
        Me.GotoToolItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.SyntaxComboToolItem = New System.Windows.Forms.ToolStripComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblPos = New System.Windows.Forms.Label
        Me.lblLine = New System.Windows.Forms.Label
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.SyntaxEdit1 = New QWhale.Editor.SyntaxEdit(Me.components)
        Me.EditorMenuStrip.SuspendLayout()
        Me.EditorToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HtmlParser
        '
        Me.HtmlParser.DefaultState = 0
        Me.HtmlParser.XmlScheme = resources.GetString("HtmlParser.XmlScheme")
        '
        'PythonParser
        '
        Me.PythonParser.DefaultState = 0
        Me.PythonParser.XmlScheme = resources.GetString("PythonParser.XmlScheme")
        '
        'JavascriptParser
        '
        Me.JavascriptParser.DefaultState = 0
        Me.JavascriptParser.XmlScheme = resources.GetString("JavascriptParser.XmlScheme")
        '
        'EditorMenuStrip
        '
        Me.EditorMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenuItem})
        Me.EditorMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.EditorMenuStrip.Name = "EditorMenuStrip"
        Me.EditorMenuStrip.Size = New System.Drawing.Size(652, 24)
        Me.EditorMenuStrip.TabIndex = 18
        Me.EditorMenuStrip.Text = "Editor Menu"
        '
        'FileMenuItem
        '
        Me.FileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMenuItem, Me.OpenMenuItem, Me.SaveMenuItem, Me.SaveAsMenuItem, Me.ToolStripSeparator3, Me.CloseMenuItem, Me.ToolStripSeparator1, Me.PageSetupMenuItem, Me.PrintOptionsMenuItem, Me.PrintPreviewMenuItem, Me.PrintMenuItem})
        Me.FileMenuItem.Name = "FileMenuItem"
        Me.FileMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileMenuItem.Text = "File"
        '
        'NewMenuItem
        '
        Me.NewMenuItem.Name = "NewMenuItem"
        Me.NewMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.NewMenuItem.Text = "New"
        '
        'OpenMenuItem
        '
        Me.OpenMenuItem.Name = "OpenMenuItem"
        Me.OpenMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.OpenMenuItem.Text = "Open"
        '
        'SaveMenuItem
        '
        Me.SaveMenuItem.Name = "SaveMenuItem"
        Me.SaveMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SaveMenuItem.Text = "Save"
        '
        'SaveAsMenuItem
        '
        Me.SaveAsMenuItem.Name = "SaveAsMenuItem"
        Me.SaveAsMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SaveAsMenuItem.Text = "Save As"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(145, 6)
        '
        'CloseMenuItem
        '
        Me.CloseMenuItem.Name = "CloseMenuItem"
        Me.CloseMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CloseMenuItem.Text = "Close"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'PageSetupMenuItem
        '
        Me.PageSetupMenuItem.Name = "PageSetupMenuItem"
        Me.PageSetupMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PageSetupMenuItem.Text = "Page Setup"
        '
        'PrintOptionsMenuItem
        '
        Me.PrintOptionsMenuItem.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.printer_options
        Me.PrintOptionsMenuItem.Name = "PrintOptionsMenuItem"
        Me.PrintOptionsMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PrintOptionsMenuItem.Text = "Print Options"
        '
        'PrintPreviewMenuItem
        '
        Me.PrintPreviewMenuItem.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.print_preview
        Me.PrintPreviewMenuItem.Name = "PrintPreviewMenuItem"
        Me.PrintPreviewMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PrintPreviewMenuItem.Text = "Print Preview"
        '
        'PrintMenuItem
        '
        Me.PrintMenuItem.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.print
        Me.PrintMenuItem.Name = "PrintMenuItem"
        Me.PrintMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PrintMenuItem.Text = "Print"
        '
        'EditorToolStrip
        '
        Me.EditorToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolItem, Me.ReplaceToolItem, Me.GotoToolItem, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.SyntaxComboToolItem})
        Me.EditorToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.EditorToolStrip.Name = "EditorToolStrip"
        Me.EditorToolStrip.Size = New System.Drawing.Size(652, 25)
        Me.EditorToolStrip.TabIndex = 19
        Me.EditorToolStrip.Text = "Editor Tools"
        '
        'FindToolItem
        '
        Me.FindToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FindToolItem.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.find
        Me.FindToolItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FindToolItem.Name = "FindToolItem"
        Me.FindToolItem.Size = New System.Drawing.Size(23, 22)
        Me.FindToolItem.Text = "ToolStripButton1"
        '
        'ReplaceToolItem
        '
        Me.ReplaceToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReplaceToolItem.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.replace
        Me.ReplaceToolItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReplaceToolItem.Name = "ReplaceToolItem"
        Me.ReplaceToolItem.Size = New System.Drawing.Size(23, 22)
        Me.ReplaceToolItem.Text = "ToolStripButton2"
        '
        'GotoToolItem
        '
        Me.GotoToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GotoToolItem.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources._goto
        Me.GotoToolItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GotoToolItem.Name = "GotoToolItem"
        Me.GotoToolItem.Size = New System.Drawing.Size(23, 22)
        Me.GotoToolItem.Text = "ToolStripButton3"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(41, 22)
        Me.ToolStripLabel1.Text = "Syntax"
        '
        'SyntaxComboToolItem
        '
        Me.SyntaxComboToolItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SyntaxComboToolItem.Name = "SyntaxComboToolItem"
        Me.SyntaxComboToolItem.Size = New System.Drawing.Size(121, 25)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPos)
        Me.Panel1.Controls.Add(Me.lblLine)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 411)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 31)
        Me.Panel1.TabIndex = 20
        '
        'lblPos
        '
        Me.lblPos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPos.BackColor = System.Drawing.Color.Transparent
        Me.lblPos.Location = New System.Drawing.Point(579, 9)
        Me.lblPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(60, 13)
        Me.lblPos.TabIndex = 19
        Me.lblPos.Text = "Pos 1"
        '
        'lblLine
        '
        Me.lblLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLine.BackColor = System.Drawing.Color.Transparent
        Me.lblLine.Location = New System.Drawing.Point(511, 9)
        Me.lblLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(60, 13)
        Me.lblLine.TabIndex = 18
        Me.lblLine.Text = "Ln 1"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'SyntaxEdit1
        '
        Me.SyntaxEdit1.BackColor = System.Drawing.SystemColors.Window
        Me.SyntaxEdit1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SyntaxEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SyntaxEdit1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.SyntaxEdit1.Gutter.Options = CType((QWhale.Editor.GutterOptions.PaintLineNumbers Or QWhale.Editor.GutterOptions.PaintLinesOnGutter), QWhale.Editor.GutterOptions)
        Me.SyntaxEdit1.Location = New System.Drawing.Point(0, 49)
        Me.SyntaxEdit1.Name = "SyntaxEdit1"
        Me.SyntaxEdit1.Size = New System.Drawing.Size(652, 362)
        Me.SyntaxEdit1.Source = Me.TextSource
        Me.SyntaxEdit1.TabIndex = 21
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(652, 442)
        Me.Controls.Add(Me.SyntaxEdit1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EditorToolStrip)
        Me.Controls.Add(Me.EditorMenuStrip)
        Me.MainMenuStrip = Me.EditorMenuStrip
        Me.Name = "Main"
        Me.Text = "Editor"
        Me.EditorMenuStrip.ResumeLayout(False)
        Me.EditorMenuStrip.PerformLayout()
        Me.EditorToolStrip.ResumeLayout(False)
        Me.EditorToolStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HtmlParser As QWhale.Syntax.Parser
    Friend WithEvents PythonParser As QWhale.Syntax.Parser
    Friend WithEvents JavascriptParser As QWhale.Syntax.Parser
    Friend WithEvents TextSource As QWhale.Editor.TextSource
    Friend WithEvents EditorMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PageSetupMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintOptionsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditorToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FindToolItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReplaceToolItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GotoToolItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblPos As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents NewMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveAsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SyntaxComboToolItem As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SyntaxEdit1 As QWhale.Editor.SyntaxEdit
End Class
