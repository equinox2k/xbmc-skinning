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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditorToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblPos = New System.Windows.Forms.Label
        Me.lblLine = New System.Windows.Forms.Label
        Me.EditorSplitContainer = New System.Windows.Forms.SplitContainer
        Me.SyntaxEdit1 = New QWhale.Editor.SyntaxEdit(Me.components)
        Me.SyntaxEdit2 = New QWhale.Editor.SyntaxEdit(Me.components)
        Me.EditorMenuStrip.SuspendLayout()
        Me.EditorToolStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.EditorSplitContainer.Panel1.SuspendLayout()
        Me.EditorSplitContainer.Panel2.SuspendLayout()
        Me.EditorSplitContainer.SuspendLayout()
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
        Me.EditorMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.EditorMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.EditorMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.EditorMenuStrip.Name = "EditorMenuStrip"
        Me.EditorMenuStrip.Size = New System.Drawing.Size(652, 24)
        Me.EditorMenuStrip.TabIndex = 18
        Me.EditorMenuStrip.Text = "Editor Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.CloseToolStripMenuItem, Me.ToolStripSeparator1, Me.PageSetupToolStripMenuItem, Me.PrintOptionsToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup"
        '
        'PrintOptionsToolStripMenuItem
        '
        Me.PrintOptionsToolStripMenuItem.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.printer_options
        Me.PrintOptionsToolStripMenuItem.Name = "PrintOptionsToolStripMenuItem"
        Me.PrintOptionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintOptionsToolStripMenuItem.Text = "Print Options"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.print_preview
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.print
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'EditorToolStrip
        '
        Me.EditorToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.EditorToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.EditorToolStrip.Name = "EditorToolStrip"
        Me.EditorToolStrip.Size = New System.Drawing.Size(652, 25)
        Me.EditorToolStrip.TabIndex = 19
        Me.EditorToolStrip.Text = "Editor Tools"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.find
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.replace
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources._goto
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.window_split_hor
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.SkinEditor.Plugin.Editor.My.Resources.Resources.window_split_ver
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "ToolStripButton5"
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
        'EditorSplitContainer
        '
        Me.EditorSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditorSplitContainer.Location = New System.Drawing.Point(4, 52)
        Me.EditorSplitContainer.Name = "EditorSplitContainer"
        Me.EditorSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'EditorSplitContainer.Panel1
        '
        Me.EditorSplitContainer.Panel1.Controls.Add(Me.SyntaxEdit1)
        '
        'EditorSplitContainer.Panel2
        '
        Me.EditorSplitContainer.Panel2.Controls.Add(Me.SyntaxEdit2)
        Me.EditorSplitContainer.Panel2Collapsed = True
        Me.EditorSplitContainer.Size = New System.Drawing.Size(643, 356)
        Me.EditorSplitContainer.SplitterDistance = 130
        Me.EditorSplitContainer.TabIndex = 21
        '
        'SyntaxEdit1
        '
        Me.SyntaxEdit1.BackColor = System.Drawing.SystemColors.Window
        Me.SyntaxEdit1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SyntaxEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SyntaxEdit1.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.SyntaxEdit1.Gutter.Options = CType((QWhale.Editor.GutterOptions.PaintLineNumbers Or QWhale.Editor.GutterOptions.PaintLinesOnGutter), QWhale.Editor.GutterOptions)
        Me.SyntaxEdit1.Location = New System.Drawing.Point(0, 0)
        Me.SyntaxEdit1.Name = "SyntaxEdit1"
        Me.SyntaxEdit1.Size = New System.Drawing.Size(643, 356)
        Me.SyntaxEdit1.TabIndex = 16
        Me.SyntaxEdit1.Text = ""
        '
        'SyntaxEdit2
        '
        Me.SyntaxEdit2.BackColor = System.Drawing.SystemColors.Window
        Me.SyntaxEdit2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SyntaxEdit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SyntaxEdit2.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.SyntaxEdit2.Gutter.Options = CType((QWhale.Editor.GutterOptions.PaintLineNumbers Or QWhale.Editor.GutterOptions.PaintLinesOnGutter), QWhale.Editor.GutterOptions)
        Me.SyntaxEdit2.Location = New System.Drawing.Point(0, 0)
        Me.SyntaxEdit2.Name = "SyntaxEdit2"
        Me.SyntaxEdit2.Size = New System.Drawing.Size(643, 222)
        Me.SyntaxEdit2.Source = Me.TextSource
        Me.SyntaxEdit2.TabIndex = 14
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(652, 442)
        Me.Controls.Add(Me.EditorSplitContainer)
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
        Me.EditorSplitContainer.Panel1.ResumeLayout(False)
        Me.EditorSplitContainer.Panel2.ResumeLayout(False)
        Me.EditorSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HtmlParser As QWhale.Syntax.Parser
    Friend WithEvents PythonParser As QWhale.Syntax.Parser
    Friend WithEvents JavascriptParser As QWhale.Syntax.Parser
    Friend WithEvents TextSource As QWhale.Editor.TextSource
    Friend WithEvents EditorMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PageSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditorToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblPos As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents EditorSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents SyntaxEdit1 As QWhale.Editor.SyntaxEdit
    Friend WithEvents SyntaxEdit2 As QWhale.Editor.SyntaxEdit
End Class
