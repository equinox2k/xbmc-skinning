Imports WeifenLuo.WinFormsUI
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindWindow))
        Me.fc = New Scintilla.Forms.FindControl
        Me.SuspendLayout()
        '
        'fc
        '
        Me.fc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fc.Location = New System.Drawing.Point(0, 0)
        Me.fc.Name = "fc"
        Me.fc.Size = New System.Drawing.Size(413, 158)
        Me.fc.TabIndex = 0
        '
        'FindWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 158)
        Me.Controls.Add(Me.fc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FindWindow"
        Me.TabText = "Find"
        Me.Text = "Find"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fc As Scintilla.Forms.FindControl
End Class
