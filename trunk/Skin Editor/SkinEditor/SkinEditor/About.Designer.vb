<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.ScrollingTextPanel = New SkinEditor.ScrollingTextPanel
        Me.SuspendLayout()
        '
        'ScrollingTextPanel
        '
        Me.ScrollingTextPanel.BackColor = System.Drawing.Color.Black
        Me.ScrollingTextPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScrollingTextPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScrollingTextPanel.ForeColor = System.Drawing.Color.White
        Me.ScrollingTextPanel.Interval = 100
        Me.ScrollingTextPanel.Location = New System.Drawing.Point(0, 0)
        Me.ScrollingTextPanel.Message = ""
        Me.ScrollingTextPanel.Name = "ScrollingTextPanel"
        Me.ScrollingTextPanel.ScrollSpeed = 2
        Me.ScrollingTextPanel.Size = New System.Drawing.Size(276, 105)
        Me.ScrollingTextPanel.Started = False
        Me.ScrollingTextPanel.TabIndex = 0
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 105)
        Me.Controls.Add(Me.ScrollingTextPanel)
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ScrollingTextPanel As SkinEditor.ScrollingTextPanel
End Class
