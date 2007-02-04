<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkinDoc
    Inherits WeifenLuo.WinFormsUI.DockContent

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

    'Private config As Scintilla.Legacy.Configuration.Scintilla
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ScintillaControl2 = New Scintilla.ScintillaControl
        Me.ms_file = New System.Windows.Forms.MenuStrip
        Me.TSMI_File = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_Save = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_SaveAs = New System.Windows.Forms.ToolStripMenuItem
        Me.sfd = New System.Windows.Forms.SaveFileDialog
        Me.TSMI_SaveCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.ms_file.SuspendLayout()
        Me.SuspendLayout()
        '
        'ScintillaControl2
        '
        Me.ScintillaControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScintillaControl2.LegacyConfiguration = Nothing
        Me.ScintillaControl2.Location = New System.Drawing.Point(0, 24)
        Me.ScintillaControl2.Name = "ScintillaControl2"
        Me.ScintillaControl2.Size = New System.Drawing.Size(292, 242)
        Me.ScintillaControl2.SmartIndentingEnabled = True
        Me.ScintillaControl2.TabIndex = 1
        Me.ScintillaControl2.Text = "ScintillaControl2"
        '
        'ms_file
        '
        Me.ms_file.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ms_file.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_File})
        Me.ms_file.Location = New System.Drawing.Point(0, 0)
        Me.ms_file.Name = "ms_file"
        Me.ms_file.Size = New System.Drawing.Size(292, 24)
        Me.ms_file.TabIndex = 2
        Me.ms_file.Visible = False
        '
        'TSMI_File
        '
        Me.TSMI_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_Save, Me.TSMI_SaveAs, Me.TSMI_SaveCopy})
        Me.TSMI_File.Name = "TSMI_File"
        Me.TSMI_File.Size = New System.Drawing.Size(40, 20)
        Me.TSMI_File.Text = "File"
        '
        'TSMI_Save
        '
        Me.TSMI_Save.Name = "TSMI_Save"
        Me.TSMI_Save.Size = New System.Drawing.Size(178, 22)
        Me.TSMI_Save.Text = "Save"
        '
        'TSMI_SaveAs
        '
        Me.TSMI_SaveAs.Name = "TSMI_SaveAs"
        Me.TSMI_SaveAs.Size = New System.Drawing.Size(178, 22)
        Me.TSMI_SaveAs.Text = "Save As"
        '
        'TSMI_SaveCopy
        '
        Me.TSMI_SaveCopy.Name = "TSMI_SaveCopy"
        Me.TSMI_SaveCopy.Size = New System.Drawing.Size(178, 22)
        Me.TSMI_SaveCopy.Text = "Save a Copy As"
        '
        'SkinDoc
        '
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.ScintillaControl2)
        Me.Controls.Add(Me.ms_file)
        Me.MainMenuStrip = Me.ms_file
        Me.Name = "SkinDoc"
        Me.ms_file.ResumeLayout(False)
        Me.ms_file.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ScintillaControl2 As Scintilla.ScintillaControl
    Friend WithEvents ms_file As System.Windows.Forms.MenuStrip
    Friend WithEvents TSMI_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_Save As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_SaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TSMI_SaveCopy As System.Windows.Forms.ToolStripMenuItem
End Class
