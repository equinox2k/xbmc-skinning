Imports System.IO
Imports System.Drawing
Imports QWhale.Syntax

Public Class Main

    Public Sub New()

        InitializeComponent()

        SyntaxComboToolItem.Items.Clear()
        SyntaxComboToolItem.Items.Add("Text")
        SyntaxComboToolItem.Items.Add("XML")
        SyntaxComboToolItem.Items.Add("Python")
        SyntaxComboToolItem.Items.Add("CSS")
        SyntaxComboToolItem.Items.Add("HTML")
        SyntaxComboToolItem.Items.Add("Javascript")
        SyntaxComboToolItem.SelectedIndex = 0

        UpdateForm()

    End Sub

    Private Sub SetSyntax(ByVal Syntax As String)
        Static Disabled As Boolean = False
        If Disabled = False Then
            Disabled = True
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
                    TextSource.Lexer = Nothing
            End Select
            Disabled = False
        End If
    End Sub

    Private Sub SyntaxComboToolItem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SyntaxComboToolItem.SelectedIndexChanged
        SetSyntax(SyntaxComboToolItem.SelectedItem)
    End Sub

    Private Sub UpdateForm()
        If TextSource.FileName = "" Then
            Me.Text = "Untitled" & IIf(TextSource.Modified, "*", "") & " - Editor"
        Else
            Me.Text = Path.GetFileName(TextSource.FileName) & IIf(TextSource.Modified, "*", "") & " - Editor"
        End If
        SaveMenuItem.Text = "Save " & Path.GetFileName(TextSource.FileName)
        SaveAsMenuItem.Text = "Save " & Path.GetFileName(TextSource.FileName) & IIf(TextSource.FileName <> "", " ", "") & "As..."
    End Sub

    Public Sub LoadFile(ByVal FileName As String)
        TextSource.LoadFile(FileName)
        TextSource.FileName = FileName
        SetSyntax(Path.GetExtension(FileName))
        UpdateForm()
    End Sub

    Public Sub SaveFile(Optional ByVal SaveAs As Boolean = False)
        If TextSource.FileName = "" Or SaveAs = True Then
            SaveFileDialog.OverwritePrompt = True
            SaveFileDialog.Filter = "Files (*.TXT,*.XML,*.CSS,*.JS,*.PY,*.HTML,*.HTM,*.ASP,*.PHP)|*.TXT;*.XML;*.CSS;*.JS;*.PY;*.HTML;*.HTM;*.ASP;*.PHP"
            If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextSource.FileName = SaveFileDialog.FileName
                TextSource.SaveFile(TextSource.FileName)
            End If
        Else
            TextSource.SaveFile(TextSource.FileName)
        End If
        UpdateForm()
    End Sub

    Private Sub SyntaxEdit1_SourceStateChanged(ByVal sender As Object, ByVal e As QWhale.Editor.NotifyEventArgs)
        Dim objPosition As Point = TextSource.Position
        lblLine.Text = "Ln " & objPosition.Y + 1
        lblPos.Text = "Pos " & objPosition.X + 1
    End Sub

    Private Sub SyntaxEdit1_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        UpdateForm()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMenuItem.Click
        SetSyntax("Text")
        TextSource.FileName = ""
        TextSource.Text = ""
        UpdateForm()
    End Sub

    Private Sub OpenMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMenuItem.Click
        OpenFileDialog.CheckFileExists = True
        OpenFileDialog.Filter = "Files (*.TXT,*.XML,*.CSS,*.JS,*.PY,*.HTML,*.HTM,*.ASP,*.PHP)|*.TXT;*.XML;*.CSS;*.JS;*.PY;*.HTML;*.HTM;*.ASP;*.PHP"
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            LoadFile(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub SaveAsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsMenuItem.Click
        SaveFile(True)
    End Sub

    Private Sub SaveMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveMenuItem.Click
        SaveFile()
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

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class