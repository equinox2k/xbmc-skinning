Imports System.Xml

Public Class XmlTextWriterNoDeclaration

    Inherits XmlTextWriter

    Public Sub New(ByVal filename As String)
        MyBase.New(filename, System.Text.Encoding.Default)
        Me.Formatting = Xml.Formatting.Indented
    End Sub

    Public Overrides Sub WriteStartDocument()
    End Sub

End Class


