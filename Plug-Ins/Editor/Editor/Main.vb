Imports System.IO
Imports System.Drawing
Imports QWhale.Syntax

Public Class Main

    Public Sub New()

        InitializeComponent()

        SyntaxComboToolItem.Items.Clear()
        SyntaxComboToolItem.Items.Add("Text)")
        SyntaxComboToolItem.Items.Add("XML")
        SyntaxComboToolItem.Items.Add("Python")
        SyntaxComboToolItem.Items.Add("CSS")
        SyntaxComboToolItem.Items.Add("HTML")
        SyntaxComboToolItem.Items.Add("Javascript")
        SyntaxComboToolItem.SelectedIndex = 0
        'SaveMenuItem.Visible = True

    End Sub

    Private Sub SetSyntax(ByVal Syntax As String)
        Select Case Syntax.ToUpper
            Case "XML", ".XML"
                SyntaxComboToolItem.SelectedIndex = 1
                TextSource.Lexer = New XmlParser
            Case "PYTHON", ".PY"
                SyntaxComboToolItem.SelectedIndex = 2
                Dim objLexer As New Lexer
                objLexer.XmlScheme = My.Resources.Python
                TextSource.Lexer = objLexer
            Case "CSS", ".CSS"
                SyntaxComboToolItem.SelectedIndex = 3
                Dim objLexer As New Lexer
                objLexer.XmlScheme = My.Resources.Css
                TextSource.Lexer = objLexer
            Case "HTML", ".HTML", ".HTM", ".ASP", ".PHP"
                SyntaxComboToolItem.SelectedIndex = 4
                Dim objLexer As New Lexer
                objLexer.XmlScheme = My.Resources.Html
                TextSource.Lexer = objLexer
            Case "JAVASCRIPT", ".JS"
                SyntaxComboToolItem.SelectedIndex = 5
                Dim objLexer As New Lexer
                objLexer.XmlScheme = My.Resources.Javascript
                TextSource.Lexer = objLexer
            Case Else
                SyntaxComboToolItem.SelectedIndex = 0
        End Select
    End Sub

    Private Sub SyntaxComboToolItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SyntaxComboToolItem.SelectedIndexChanged
        SetSyntax(SyntaxComboToolItem.SelectedText)
    End Sub

    Public Sub LoadFile(ByVal FileName As String)
        TextSource.LoadFile(FileName)
        TextSource.FileName = FileName
        SetSyntax(Path.GetExtension(FileName))
        SaveMenuItem.Text = "Save " & Path.GetFileName(FileName)
        SaveAsMenuItem.Text = "Save " & Path.GetFileName(FileName) & " As..."
    End Sub

    Public Sub SaveFile(ByVal FileName As String)
        'if filename blank ask
        TextSource.SaveFile(FileName)
    End Sub

    Private Sub SyntaxEdit1_SourceStateChanged(ByVal sender As Object, ByVal e As QWhale.Editor.NotifyEventArgs)
        Dim objPosition As Point = TextSource.Position
        lblLine.Text = "Ln " & objPosition.Y + 1
        lblPos.Text = "Pos " & objPosition.X + 1
    End Sub

    Private Sub SyntaxEdit1_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Text = Path.GetFileName(TextSource.FileName) & IIf(TextSource.Modified, "*", "")
    End Sub

    'Private Sub UltraToolbarsManager_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager.ToolClick
    '    Select Case e.Tool.Key
    '        Case "Split Vert"
    '            UltraToolbarsManager.EventManager.SetEnabled(Infragistics.Win.UltraWinToolbars.ToolbarEventIds.ToolClick, False)
    '            Dim StateButtonVert As Infragistics.Win.UltraWinToolbars.StateButtonTool
    '            StateButtonVert = UltraToolbarsManager.Tools("Split Vert")
    '            Dim StateButtonHoriz As Infragistics.Win.UltraWinToolbars.StateButtonTool
    '            StateButtonHoriz = UltraToolbarsManager.Tools("Split Horiz")
    '            If StateButtonVert.Checked = True Then
    '                StateButtonHoriz.Checked = False
    '                SplitContainer.Orientation = Orientation.Horizontal
    '                SplitContainer.SplitterDistance = SplitContainer.Height / 2
    '                SplitContainer.Panel2Collapsed = False
    '            Else
    '                SplitContainer.Panel2Collapsed = True
    '            End If
    '            UltraToolbarsManager.EventManager.SetEnabled(Infragistics.Win.UltraWinToolbars.ToolbarEventIds.ToolClick, True)
    '        Case "Split Horiz"
    '            UltraToolbarsManager.EventManager.SetEnabled(Infragistics.Win.UltraWinToolbars.ToolbarEventIds.ToolClick, False)
    '            Dim StateButtonHoriz As Infragistics.Win.UltraWinToolbars.StateButtonTool
    '            StateButtonHoriz = UltraToolbarsManager.Tools("Split Horiz")
    '            Dim StateButtonVert As Infragistics.Win.UltraWinToolbars.StateButtonTool
    '            StateButtonVert = UltraToolbarsManager.Tools("Split Vert")
    '            If StateButtonHoriz.Checked = True Then
    '                StateButtonVert.Checked = False
    '                SplitContainer.Orientation = Orientation.Vertical
    '                SplitContainer.SplitterDistance = SplitContainer.Width / 2
    '                SplitContainer.Panel2Collapsed = False
    '            Else
    '                SplitContainer.Panel2Collapsed = True
    '            End If
    '            UltraToolbarsManager.EventManager.SetEnabled(Infragistics.Win.UltraWinToolbars.ToolbarEventIds.ToolClick, True)
    '    End Select
    'End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMenuItem.Click
        SetSyntax("Text")
        TextSource.FileName = ""
        TextSource.Text = ""
        SaveMenuItem.Text = "Save"
        SaveAsMenuItem.Text = "Save As..."
    End Sub

    Private Sub OpenMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMenuItem.Click
        'ask file and open etc
    End Sub

    Private Sub SaveAsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsMenuItem.Click
        'ask file then change file caption
        SaveFile(TextSource.FileName)
        'SaveMenuItem.Text = "Save " & Path.GetFileName(FileName)
        'SaveAsMenuItem.Text = "Save " & Path.GetFileName(FileName) & " As..."
    End Sub

    Private Sub SaveMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveMenuItem.Click
        SaveFile(TextSource.FileName)
        'SaveMenuItem.Text = "Save " & Path.GetFileName(FileName)
        'SaveAsMenuItem.Text = "Save " & Path.GetFileName(FileName) & " As..."
    End Sub

    Private Sub CloseMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PageSetupMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupMenuItem.Click
        SyntaxEdit1.Printing.ExecutePageSetupDialog()
    End Sub

    Private Sub PrintOptionsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintOptionsMenuItem.Click
        If SyntaxEdit1.Printing.ExecutePrintOptionsDialog = Windows.Forms.DialogResult.OK Then SyntaxEdit1.Printing.Options = SyntaxEdit1.Printing.PrintOptionsDialog.Options
    End Sub

    Private Sub PrintPreviewMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewMenuItem.Click
        SyntaxEdit1.Printing.ExecutePrintPreviewDialog()
    End Sub

    Private Sub PrintMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintMenuItem.Click
        If SyntaxEdit1.Printing.ExecutePrintDialog() = Windows.Forms.DialogResult.OK Then SyntaxEdit1.Printing.Print()
    End Sub

    Private Sub FindToolItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolItem.Click
        SyntaxEdit1.DisplaySearchDialog()
    End Sub

    Private Sub ReplaceToolItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceToolItem.Click
        SyntaxEdit1.DisplayReplaceDialog()
    End Sub

    Private Sub GotoToolItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GotoToolItem.Click
        SyntaxEdit1.DisplayGotoLineDialog()
    End Sub

    Private Sub SplitHorizToolItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplitHorizToolItem.Click

    End Sub

    Private Sub SplitVertToolItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SplitVertToolItem.Click

    End Sub

End Class