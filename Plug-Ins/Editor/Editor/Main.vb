Imports System.IO
Imports System.Drawing
Imports QWhale.Syntax

Public Class Main

    Public Sub LoadFile(ByVal FileName As String)
        TextSource.LoadFile(FileName)
        TextSource.FileName = FileName
        Select Case Path.GetExtension(FileName).ToUpper
            Case ".TXT"
                TextSource.Lexer = Nothing
            Case ".XML"
                TextSource.Lexer = New XmlParser
            Case ".CSS"
                Dim objLexer As New Lexer
                objLexer.XmlScheme = My.Resources.Css
                TextSource.Lexer = objLexer
            Case ".JS"
                Dim objLexer As New Lexer
                objLexer.XmlScheme = My.Resources.Javascript
                TextSource.Lexer = objLexer
            Case ".PY"
                Dim objLexer As New Lexer
                objLexer.XmlScheme = My.Resources.Python
                TextSource.Lexer = objLexer
            Case ".HTML", ".HTM", ".ASP", ".PHP"
                Dim objLexer As New Lexer
                objLexer.XmlScheme = My.Resources.Html
                TextSource.Lexer = objLexer
        End Select
        SaveToolStripMenuItem.Text = "Save " & Path.GetFileName(FileName)
        Me.Text = Path.GetFileName(TextSource.FileName)
    End Sub

    Public Sub SaveFile()
        TextSource.SaveFile(TextSource.FileName)
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
    '        Case "Save"
    '            SaveFile()
    '        Case "Close"
    '            Me.Close()
    '        Case "Find"
    '            SyntaxEdit1.DisplaySearchDialog()
    '        Case "Replace"
    '            SyntaxEdit1.DisplayReplaceDialog()
    '        Case "Goto Line"
    '            SyntaxEdit1.DisplayGotoLineDialog()
    '        Case "Page Setup"
    '            SyntaxEdit1.Printing.ExecutePageSetupDialog()
    '        Case "Print Options"
    '            If SyntaxEdit1.Printing.ExecutePrintOptionsDialog = Windows.Forms.DialogResult.OK Then SyntaxEdit1.Printing.Options = SyntaxEdit1.Printing.PrintOptionsDialog.Options
    '        Case "Print Preview"
    '            SyntaxEdit1.Printing.ExecutePrintPreviewDialog()
    '        Case "Print"
    '            If SyntaxEdit1.Printing.ExecutePrintDialog() = Windows.Forms.DialogResult.OK Then SyntaxEdit1.Printing.Print()
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

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class