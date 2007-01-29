Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports WeifenLuo.WinFormsUI
Imports System.IO
Public Class SkinDocument
    Inherits DockContent
    Friend WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents mainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents menuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contextMenuTabPage As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuItemCheckTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents checkedListBox1 As CheckedListBox
    Friend WithEvents components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SkinDocument))
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox
        Me.mainMenu = New System.Windows.Forms.MenuStrip
        Me.menuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItemCheckTest = New System.Windows.Forms.ToolStripMenuItem
        Me.contextMenuTabPage = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.menuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.mainMenu.SuspendLayout()
        Me.contextMenuTabPage.SuspendLayout()
        Me.SuspendLayout()
        Me.richTextBox1.AcceptsTab = True
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox1.Location = New System.Drawing.Point(0, 4)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(448, 389)
        Me.richTextBox1.TabIndex = 0
        Me.richTextBox1.Text = ""
        Me.toolTip.SetToolTip(Me.richTextBox1, "Test Tooltip")
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem1})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(200, 24)
        Me.mainMenu.TabIndex = 1
        Me.mainMenu.Visible = False
        Me.menuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem2, Me.menuItemCheckTest})
        Me.menuItem1.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.menuItem1.MergeIndex = 1
        Me.menuItem1.Name = "menuItem1"
        Me.menuItem1.Size = New System.Drawing.Size(89, 20)
        Me.menuItem1.Text = "&MDI Document"
        Me.menuItem2.Name = "menuItem2"
        Me.menuItem2.Size = New System.Drawing.Size(138, 22)
        Me.menuItem2.Text = "Test"
        AddHandler Me.menuItem2.Click, AddressOf Me.menuItem2_Click
        Me.menuItemCheckTest.Name = "menuItemCheckTest"
        Me.menuItemCheckTest.Size = New System.Drawing.Size(138, 22)
        Me.menuItemCheckTest.Text = "Check Test"
        AddHandler Me.menuItemCheckTest.Click, AddressOf Me.menuItemCheckTest_Click
        Me.contextMenuTabPage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItem3, Me.menuItem4, Me.menuItem5})
        Me.contextMenuTabPage.Name = "contextMenuTabPage"
        Me.contextMenuTabPage.Size = New System.Drawing.Size(127, 70)
        Me.menuItem3.Name = "menuItem3"
        Me.menuItem3.Size = New System.Drawing.Size(126, 22)
        Me.menuItem3.Text = "Option &1"
        Me.menuItem4.Name = "menuItem4"
        Me.menuItem4.Size = New System.Drawing.Size(126, 22)
        Me.menuItem4.Text = "Option &2"
        Me.menuItem5.Name = "menuItem5"
        Me.menuItem5.Size = New System.Drawing.Size(126, 22)
        Me.menuItem5.Text = "Option &3"
        Me.checkedListBox1.FormattingEnabled = True
        Me.checkedListBox1.Location = New System.Drawing.Point(307, 67)
        Me.checkedListBox1.Name = "checkedListBox1"
        Me.checkedListBox1.Size = New System.Drawing.Size(120, 94)
        Me.checkedListBox1.TabIndex = 2
        Me.ClientSize = New System.Drawing.Size(448, 393)
        Me.Controls.Add(Me.checkedListBox1)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.mainMenu)
        Me.DockableAreas = CType((((((WeifenLuo.WinFormsUI.DockAreas.DockLeft Or WeifenLuo.WinFormsUI.DockAreas.DockRight) Or WeifenLuo.WinFormsUI.DockAreas.DockTop) Or WeifenLuo.WinFormsUI.DockAreas.DockBottom) Or WeifenLuo.WinFormsUI.DockAreas.Document)), WeifenLuo.WinFormsUI.DockAreas)
        'Me.Icon = CType((resources.GetObject("$this.Icon")), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mainMenu
        Me.Name = "DummyDoc"
        Me.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.TabPageContextMenuStrip = Me.contextMenuTabPage
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.contextMenuTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Private m_fileName As String = String.Empty
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Public Property FileName() As String
        Get
            Return m_fileName
        End Get
        Set(ByVal value As String)
            If Not (value = String.Empty) Then
                Dim s As Stream = New FileStream(value, FileMode.Open)
                Dim efInfo As FileInfo = New FileInfo(value)
                Dim fext As String = efInfo.Extension.ToUpper
                If fext.Equals(".RTF") Then
                    richTextBox1.LoadFile(s, RichTextBoxStreamType.RichText)
                Else
                    richTextBox1.LoadFile(s, RichTextBoxStreamType.PlainText)
                End If
                s.Close()
            End If
            m_fileName = value
            Me.ToolTipText = value
        End Set
    End Property
    Private m_resetText As Boolean = True

    Protected Overloads Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        If m_resetText Then
            m_resetText = False
            FileName = FileName
        End If
    End Sub

    Protected Overloads Overrides Function GetPersistString() As String
        Return ""
    End Function

    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        MessageBox.Show("This is to demostrate menu item has been successfully merged into the main form. Form Text=" + Text)
    End Sub

    Private Sub menuItemCheckTest_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        menuItemCheckTest.Checked = Not menuItemCheckTest.Checked
    End Sub

    Protected Overloads Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e)
        If FileName = String.Empty Then
            Me.richTextBox1.Text = Text
        End If
    End Sub
End Class
