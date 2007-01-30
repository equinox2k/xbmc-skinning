<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorLogWindow
    Inherits WeifenLuo.WinFormsUI.DockContent

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
        Me.lstErrors = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lstErrors
        '
        Me.lstErrors.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstErrors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstErrors.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstErrors.FormattingEnabled = True
        Me.lstErrors.ItemHeight = 16
        Me.lstErrors.Location = New System.Drawing.Point(0, 0)
        Me.lstErrors.Name = "lstErrors"
        Me.lstErrors.Size = New System.Drawing.Size(601, 208)
        Me.lstErrors.TabIndex = 0
        '
        'ErrorLogWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 209)
        Me.Controls.Add(Me.lstErrors)
        Me.Name = "ErrorLogWindow"
        Me.ShowIcon = False
        Me.TabText = "ErrorLog"
        Me.Text = "ErrorLog"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstErrors As System.Windows.Forms.ListBox

End Class
