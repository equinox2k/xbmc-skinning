<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkinBrowser
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SkinBrowser))
        Me.SkinBrowser_TV = New System.Windows.Forms.TreeView
        Me.SkinBrowser_IL = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'SkinBrowser_TV
        '
        Me.SkinBrowser_TV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SkinBrowser_TV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkinBrowser_TV.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkinBrowser_TV.ImageIndex = 0
        Me.SkinBrowser_TV.ImageList = Me.SkinBrowser_IL
        Me.SkinBrowser_TV.Location = New System.Drawing.Point(0, 0)
        Me.SkinBrowser_TV.Name = "SkinBrowser_TV"
        Me.SkinBrowser_TV.SelectedImageIndex = 0
        Me.SkinBrowser_TV.Size = New System.Drawing.Size(244, 216)
        Me.SkinBrowser_TV.TabIndex = 1
        '
        'SkinBrowser_IL
        '
        Me.SkinBrowser_IL.ImageStream = CType(resources.GetObject("SkinBrowser_IL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.SkinBrowser_IL.TransparentColor = System.Drawing.Color.Transparent
        Me.SkinBrowser_IL.Images.SetKeyName(0, "folder")
        Me.SkinBrowser_IL.Images.SetKeyName(1, "file")
        Me.SkinBrowser_IL.Images.SetKeyName(2, "image")
        '
        'SkinBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 216)
        Me.Controls.Add(Me.SkinBrowser_TV)
        Me.Name = "SkinBrowser"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkinBrowser_TV As System.Windows.Forms.TreeView
    Friend WithEvents SkinBrowser_IL As System.Windows.Forms.ImageList

End Class
