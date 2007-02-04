Imports WeifenLuo.WinFormsUI
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReplaceWindow
    Inherits DockContent
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
        Me.ReplaceControl1 = New Scintilla.Forms.ReplaceControl
        Me.SuspendLayout()
        '
        'ReplaceControl1
        '
        Me.ReplaceControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReplaceControl1.Location = New System.Drawing.Point(0, 0)
        Me.ReplaceControl1.Name = "ReplaceControl1"
        Me.ReplaceControl1.Size = New System.Drawing.Size(434, 158)
        Me.ReplaceControl1.TabIndex = 0
        '
        'ReplaceWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 158)
        Me.Controls.Add(Me.ReplaceControl1)
        Me.DockableAreas = CType(((((WeifenLuo.WinFormsUI.DockAreas.Float Or WeifenLuo.WinFormsUI.DockAreas.DockLeft) _
                    Or WeifenLuo.WinFormsUI.DockAreas.DockRight) _
                    Or WeifenLuo.WinFormsUI.DockAreas.DockTop) _
                    Or WeifenLuo.WinFormsUI.DockAreas.DockBottom), WeifenLuo.WinFormsUI.DockAreas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReplaceWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TabText = "Find"
        Me.Text = "Replace"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReplaceControl1 As Scintilla.Forms.ReplaceControl
End Class
