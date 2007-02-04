<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkinProperty
    Inherits WeifenLuo.WinFormsUI.DockContent

    'UserControl overrides dispose to clean up the component list.
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
        Me.pg = New System.Windows.Forms.PropertyGrid
        Me.SuspendLayout()
        '
        'pg
        '
        Me.pg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pg.Location = New System.Drawing.Point(0, 0)
        Me.pg.Name = "pg"
        Me.pg.Size = New System.Drawing.Size(365, 359)
        Me.pg.TabIndex = 2
        '
        'Skinproperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 359)
        Me.Controls.Add(Me.pg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SkinProperty"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TabText = "Properties"
        Me.Text = "Properties"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pg As System.Windows.Forms.PropertyGrid
End Class
