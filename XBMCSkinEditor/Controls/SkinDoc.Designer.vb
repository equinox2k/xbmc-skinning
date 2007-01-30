<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkinDoc
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
        Me.ScintillaControl2 = New Scintilla.ScintillaControl
        Me.SuspendLayout()
        '
        'ScintillaControl2
        '
        Me.ScintillaControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScintillaControl2.LegacyConfiguration = Nothing
        Me.ScintillaControl2.Location = New System.Drawing.Point(0, 0)
        Me.ScintillaControl2.Name = "ScintillaControl2"
        Me.ScintillaControl2.Size = New System.Drawing.Size(292, 266)
        Me.ScintillaControl2.SmartIndentingEnabled = False
        Me.ScintillaControl2.TabIndex = 1
        Me.ScintillaControl2.Text = "ScintillaControl2"
        '
        'SkinDoc
        '
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.ScintillaControl2)
        Me.Name = "SkinDoc"
        Me.ResumeLayout(False)

        ' Add Scintilla.Net Legacy Support

        ' create the configuration utility.
        ' you need to pass a type that exists int the assembly where the class that you use as
        ' a base node for configuration.
        'Dim cu As New Scintilla.Legacy.Configuration.ConfigurationUtility([GetType]().[Module].Assembly)

        ' set the configuration to scintilla
        'Me.config = DirectCast(cu.LoadConfiguration(GetType(Scintilla.Legacy.Configuration.Scintilla), "LegacyScintillaNET.xml"), Scintilla.Legacy.Configuration.Scintilla)

        'ScintillaControl2.LegacyConfiguration = DirectCast(cu.LoadConfiguration(GetType(Scintilla.Legacy.Configuration.Scintilla), "LegacyScintillaNET.xml"), Scintilla.Legacy.Configuration.Scintilla)


        ' change the language. It automatically changes the lexer for you based on the settings
        ' in the config file.
        'ScintillaControl2.LegacyConfigurationLanguage = "C#"

        ' Enable smart indenting
        Me.ScintillaControl2.SmartIndentingEnabled = True

        'ScintillaControl2.MarginWidthN(1, 100)
        'ScintillaControl2.MarginSensitiveN(1, True)

        'scintillaControl.StyleSetBack(33, Scintilla.Utilities.ColorToRgb(Color.Red))
        'AddHandler scintillaControl.MarginClick, AddressOf scintillaControl_MarginClick


    End Sub
    Friend WithEvents ScintillaControl2 As Scintilla.ScintillaControl
End Class
