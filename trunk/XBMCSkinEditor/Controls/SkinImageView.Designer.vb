<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkinImageView
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
        Me.SkinImageView_PB = New System.Windows.Forms.PictureBox
        CType(Me.SkinImageView_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkinImageView_PB
        '
        Me.SkinImageView_PB.BackgroundImage = Global.XBMCSkinEditor.My.Resources.Resources.Grid
        Me.SkinImageView_PB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkinImageView_PB.Location = New System.Drawing.Point(0, 0)
        Me.SkinImageView_PB.Name = "SkinImageView_PB"
        Me.SkinImageView_PB.Size = New System.Drawing.Size(484, 352)
        Me.SkinImageView_PB.TabIndex = 0
        Me.SkinImageView_PB.TabStop = False
        '
        'SkinImageView
        '
        Me.ClientSize = New System.Drawing.Size(484, 352)
        Me.Controls.Add(Me.SkinImageView_PB)
        Me.Name = "SkinImageView"
        CType(Me.SkinImageView_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkinImageView_PB As System.Windows.Forms.PictureBox
End Class
