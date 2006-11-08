<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.cbTabs = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Progress = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnProcess = New System.Windows.Forms.Button
        Me.SelectDestination = New System.Windows.Forms.Button
        Me.SelectXPR = New System.Windows.Forms.Button
        Me.DestinationPath = New System.Windows.Forms.TextBox
        Me.SRCPath = New System.Windows.Forms.TextBox
        Me.btnSRC2Dest = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "XPR File (*.xpr)|*.xpr"
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.FolderBrowserDialog.SelectedPath = "E:\XBMC\XBMC-DEV\skin\"
        '
        'cbTabs
        '
        Me.cbTabs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTabs.AutoSize = True
        Me.cbTabs.Checked = True
        Me.cbTabs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTabs.Location = New System.Drawing.Point(181, 158)
        Me.cbTabs.Name = "cbTabs"
        Me.cbTabs.Size = New System.Drawing.Size(50, 17)
        Me.cbTabs.TabIndex = 35
        Me.cbTabs.Text = "Tabs"
        Me.cbTabs.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Formats a XML by reindents all the tags"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Progress"
        '
        'Progress
        '
        Me.Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Progress.Location = New System.Drawing.Point(33, 117)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(278, 23)
        Me.Progress.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Destination Path"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Source Path"
        '
        'btnProcess
        '
        Me.btnProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcess.Location = New System.Drawing.Point(236, 154)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 28
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'SelectDestination
        '
        Me.SelectDestination.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectDestination.Location = New System.Drawing.Point(286, 77)
        Me.SelectDestination.Name = "SelectDestination"
        Me.SelectDestination.Size = New System.Drawing.Size(25, 22)
        Me.SelectDestination.TabIndex = 27
        Me.SelectDestination.Text = "..."
        Me.SelectDestination.UseVisualStyleBackColor = True
        '
        'SelectXPR
        '
        Me.SelectXPR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectXPR.Location = New System.Drawing.Point(286, 38)
        Me.SelectXPR.Name = "SelectXPR"
        Me.SelectXPR.Size = New System.Drawing.Size(25, 22)
        Me.SelectXPR.TabIndex = 26
        Me.SelectXPR.Text = "..."
        Me.SelectXPR.UseVisualStyleBackColor = True
        '
        'DestinationPath
        '
        Me.DestinationPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DestinationPath.Location = New System.Drawing.Point(33, 78)
        Me.DestinationPath.Name = "DestinationPath"
        Me.DestinationPath.ReadOnly = True
        Me.DestinationPath.Size = New System.Drawing.Size(247, 20)
        Me.DestinationPath.TabIndex = 25
        '
        'SRCPath
        '
        Me.SRCPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SRCPath.Location = New System.Drawing.Point(33, 39)
        Me.SRCPath.Name = "SRCPath"
        Me.SRCPath.ReadOnly = True
        Me.SRCPath.Size = New System.Drawing.Size(247, 20)
        Me.SRCPath.TabIndex = 24
        '
        'btnSRC2Dest
        '
        Me.btnSRC2Dest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSRC2Dest.Location = New System.Drawing.Point(287, 57)
        Me.btnSRC2Dest.Name = "btnSRC2Dest"
        Me.btnSRC2Dest.Size = New System.Drawing.Size(24, 23)
        Me.btnSRC2Dest.TabIndex = 33
        Me.btnSRC2Dest.Text = "V"
        Me.btnSRC2Dest.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 201)
        Me.Controls.Add(Me.cbTabs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.SelectDestination)
        Me.Controls.Add(Me.SelectXPR)
        Me.Controls.Add(Me.DestinationPath)
        Me.Controls.Add(Me.SRCPath)
        Me.Controls.Add(Me.btnSRC2Dest)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cbTabs As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents SelectDestination As System.Windows.Forms.Button
    Friend WithEvents SelectXPR As System.Windows.Forms.Button
    Friend WithEvents DestinationPath As System.Windows.Forms.TextBox
    Friend WithEvents SRCPath As System.Windows.Forms.TextBox
    Friend WithEvents btnSRC2Dest As System.Windows.Forms.Button
End Class
