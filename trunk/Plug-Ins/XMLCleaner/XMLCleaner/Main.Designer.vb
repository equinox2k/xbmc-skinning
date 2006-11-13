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
        Me.btnProcess = New System.Windows.Forms.Button
        Me.btnDest = New System.Windows.Forms.Button
        Me.btnSource = New System.Windows.Forms.Button
        Me.btnSRC2Dest = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDest = New System.Windows.Forms.TextBox
        Me.txtSource = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnDefault = New System.Windows.Forms.Button
        Me.txtDefault = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.cbTabs.AutoSize = True
        Me.cbTabs.Checked = True
        Me.cbTabs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTabs.Location = New System.Drawing.Point(29, 256)
        Me.cbTabs.Name = "cbTabs"
        Me.cbTabs.Size = New System.Drawing.Size(50, 17)
        Me.cbTabs.TabIndex = 35
        Me.cbTabs.Text = "Tabs"
        Me.cbTabs.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Formats a XML by reindents all the tags"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Progress"
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(6, 125)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(317, 23)
        Me.Progress.TabIndex = 31
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(248, 154)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(75, 23)
        Me.btnProcess.TabIndex = 28
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnDest
        '
        Me.btnDest.Location = New System.Drawing.Point(298, 70)
        Me.btnDest.Name = "btnDest"
        Me.btnDest.Size = New System.Drawing.Size(25, 22)
        Me.btnDest.TabIndex = 27
        Me.btnDest.Text = "..."
        Me.btnDest.UseVisualStyleBackColor = True
        '
        'btnSource
        '
        Me.btnSource.Location = New System.Drawing.Point(298, 19)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(25, 22)
        Me.btnSource.TabIndex = 26
        Me.btnSource.Text = "..."
        Me.btnSource.UseVisualStyleBackColor = True
        '
        'btnSRC2Dest
        '
        Me.btnSRC2Dest.Location = New System.Drawing.Point(97, 256)
        Me.btnSRC2Dest.Name = "btnSRC2Dest"
        Me.btnSRC2Dest.Size = New System.Drawing.Size(24, 23)
        Me.btnSRC2Dest.TabIndex = 33
        Me.btnSRC2Dest.Text = "V"
        Me.btnSRC2Dest.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(337, 209)
        Me.TabControl1.TabIndex = 36
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(329, 183)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Single File"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Progress)
        Me.TabPage2.Controls.Add(Me.btnProcess)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.btnDest)
        Me.TabPage2.Controls.Add(Me.txtDest)
        Me.TabPage2.Controls.Add(Me.btnSource)
        Me.TabPage2.Controls.Add(Me.txtSource)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(329, 183)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Batch"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Destination Path"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Source Path"
        '
        'txtDest
        '
        Me.txtDest.Location = New System.Drawing.Point(6, 70)
        Me.txtDest.Name = "txtDest"
        Me.txtDest.Size = New System.Drawing.Size(286, 20)
        Me.txtDest.TabIndex = 32
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(6, 19)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(286, 20)
        Me.txtSource.TabIndex = 31
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(329, 183)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Settings"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 92)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Indenting"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Size :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(62, 65)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(38, 20)
        Me.TextBox1.TabIndex = 43
        Me.TextBox1.Text = "4"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(101, 17)
        Me.RadioButton2.TabIndex = 42
        Me.RadioButton2.Text = "Space Indented"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(89, 17)
        Me.RadioButton1.TabIndex = 41
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Tab Indented"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDefault)
        Me.GroupBox1.Controls.Add(Me.txtDefault)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 46)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Default Path"
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(281, 18)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(25, 22)
        Me.btnDefault.TabIndex = 42
        Me.btnDefault.Text = "..."
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'txtDefault
        '
        Me.txtDefault.Location = New System.Drawing.Point(6, 19)
        Me.txtDefault.Name = "txtDefault"
        Me.txtDefault.Size = New System.Drawing.Size(269, 20)
        Me.txtDefault.TabIndex = 41
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 301)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbTabs)
        Me.Controls.Add(Me.btnSRC2Dest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.Text = "XML Cleaner"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cbTabs As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnDest As System.Windows.Forms.Button
    Friend WithEvents btnSource As System.Windows.Forms.Button
    Friend WithEvents btnSRC2Dest As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtDefault As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDest As System.Windows.Forms.TextBox
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnDefault As System.Windows.Forms.Button
End Class
