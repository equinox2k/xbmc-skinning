<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorPicker
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.nudSaturation = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.nudBrightness = New System.Windows.Forms.NumericUpDown
        Me.nudRed = New System.Windows.Forms.NumericUpDown
        Me.pnlColor = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlSelectedColor = New System.Windows.Forms.Panel
        Me.pnlBrightness = New System.Windows.Forms.Panel
        Me.nudBlue = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.nudGreen = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.nudHue = New System.Windows.Forms.NumericUpDown
        Me.txtColorValue = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.nudSaturation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(156, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 14)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "B"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSaturation
        '
        Me.nudSaturation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSaturation.Location = New System.Drawing.Point(57, 143)
        Me.nudSaturation.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudSaturation.Name = "nudSaturation"
        Me.nudSaturation.Size = New System.Drawing.Size(48, 20)
        Me.nudSaturation.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(108, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 14)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "V"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudBrightness
        '
        Me.nudBrightness.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBrightness.Location = New System.Drawing.Point(111, 143)
        Me.nudBrightness.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudBrightness.Name = "nudBrightness"
        Me.nudBrightness.Size = New System.Drawing.Size(48, 20)
        Me.nudBrightness.TabIndex = 27
        '
        'nudRed
        '
        Me.nudRed.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudRed.Location = New System.Drawing.Point(159, 20)
        Me.nudRed.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudRed.Name = "nudRed"
        Me.nudRed.Size = New System.Drawing.Size(48, 20)
        Me.nudRed.TabIndex = 18
        '
        'pnlColor
        '
        Me.pnlColor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlColor.Location = New System.Drawing.Point(3, 3)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Size = New System.Drawing.Size(120, 120)
        Me.pnlColor.TabIndex = 31
        Me.pnlColor.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 14)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "S"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 14)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "R"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 14)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "H"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlSelectedColor
        '
        Me.pnlSelectedColor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlSelectedColor.Location = New System.Drawing.Point(162, 143)
        Me.pnlSelectedColor.Name = "pnlSelectedColor"
        Me.pnlSelectedColor.Size = New System.Drawing.Size(45, 20)
        Me.pnlSelectedColor.TabIndex = 33
        Me.pnlSelectedColor.Visible = False
        '
        'pnlBrightness
        '
        Me.pnlBrightness.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlBrightness.Location = New System.Drawing.Point(129, 3)
        Me.pnlBrightness.Name = "pnlBrightness"
        Me.pnlBrightness.Size = New System.Drawing.Size(16, 120)
        Me.pnlBrightness.TabIndex = 32
        Me.pnlBrightness.Visible = False
        '
        'nudBlue
        '
        Me.nudBlue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudBlue.Location = New System.Drawing.Point(159, 100)
        Me.nudBlue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudBlue.Name = "nudBlue"
        Me.nudBlue.Size = New System.Drawing.Size(48, 20)
        Me.nudBlue.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Color"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudGreen
        '
        Me.nudGreen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudGreen.Location = New System.Drawing.Point(159, 60)
        Me.nudGreen.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudGreen.Name = "nudGreen"
        Me.nudGreen.Size = New System.Drawing.Size(48, 20)
        Me.nudGreen.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(156, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 14)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "G"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudHue
        '
        Me.nudHue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudHue.Location = New System.Drawing.Point(3, 143)
        Me.nudHue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudHue.Name = "nudHue"
        Me.nudHue.Size = New System.Drawing.Size(48, 20)
        Me.nudHue.TabIndex = 21
        '
        'txtColorValue
        '
        Me.txtColorValue.Location = New System.Drawing.Point(153, 169)
        Me.txtColorValue.MaxLength = 6
        Me.txtColorValue.Name = "txtColorValue"
        Me.txtColorValue.Size = New System.Drawing.Size(54, 20)
        Me.txtColorValue.TabIndex = 34
        Me.txtColorValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 14)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Color Value #"
        '
        'ColorPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtColorValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudSaturation)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudBrightness)
        Me.Controls.Add(Me.nudRed)
        Me.Controls.Add(Me.pnlColor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pnlSelectedColor)
        Me.Controls.Add(Me.pnlBrightness)
        Me.Controls.Add(Me.nudBlue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudGreen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudHue)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ColorPicker"
        Me.Size = New System.Drawing.Size(215, 195)
        CType(Me.nudSaturation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudSaturation As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudBrightness As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudRed As System.Windows.Forms.NumericUpDown
    Friend WithEvents pnlColor As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnlSelectedColor As System.Windows.Forms.Panel
    Friend WithEvents pnlBrightness As System.Windows.Forms.Panel
    Friend WithEvents nudBlue As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudGreen As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudHue As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtColorValue As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
