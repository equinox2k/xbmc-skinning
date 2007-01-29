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
        Me.ScrollingTextPanel1 = New XBMCSkinEditor.ScrollingTextPanel
        Me.SuspendLayout()
        '
        'ScrollingTextPanel1
        '
        Me.ScrollingTextPanel1.BackColor = System.Drawing.Color.Transparent
        Me.ScrollingTextPanel1.ForeColor = System.Drawing.Color.White
        Me.ScrollingTextPanel1.Interval = 100
        Me.ScrollingTextPanel1.Location = New System.Drawing.Point(12, 12)
        Me.ScrollingTextPanel1.Message = ""
        Me.ScrollingTextPanel1.Name = "ScrollingTextPanel1"
        Me.ScrollingTextPanel1.ScrollSpeed = 2
        Me.ScrollingTextPanel1.Size = New System.Drawing.Size(275, 52)
        Me.ScrollingTextPanel1.Started = False
        Me.ScrollingTextPanel1.TabIndex = 0
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(293, 71)
        Me.Controls.Add(Me.ScrollingTextPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ScrollingTextPanel1 As XBMCSkinEditor.ScrollingTextPanel
End Class
