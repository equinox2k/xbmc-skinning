Imports System.IO
Imports System.Xml
Imports System.Web

Public Class XMLTools

    Public Function EncodeString(ByVal Value As String)
        Value = System.Web.HttpUtility.HtmlEncode(Value)
        Dim NewValue As String = ""
        For intLoop As Integer = 1 To Value.Length
            Select Case Asc(Mid(Value, intLoop, 1))
                Case 0 To 31
                    NewValue &= "&#" & Asc(Mid(Value, intLoop, 1)) & ";"
                Case Else
                    NewValue &= Mid(Value, intLoop, 1)
            End Select
        Next intLoop
        Return NewValue
    End Function

    Public Function CleanXML(ByVal XML As String) As String

        Dim objXmlTextReader As New XmlTextReader(XML, XmlNodeType.Document, Nothing)
        Dim objString As New StringWriter
        Dim objXmlTextWriter As New XmlTextWriter(objString)
        objXmlTextWriter.Indentation = 1
        objXmlTextWriter.IndentChar = ControlChars.Tab
        objXmlTextWriter.Formatting = Formatting.Indented
        While objXmlTextReader.Read()
            If objXmlTextReader.NodeType = XmlNodeType.Element Then
                objXmlTextWriter.WriteStartElement(objXmlTextReader.Name.ToLower)
                For intLoop As Integer = 0 To objXmlTextReader.AttributeCount - 1
                    objXmlTextReader.MoveToAttribute(intLoop)
                    objXmlTextWriter.WriteAttributeString(objXmlTextReader.Name.ToLower, objXmlTextReader.Value)
                Next intLoop
            ElseIf objXmlTextReader.NodeType = XmlNodeType.EndElement Then
                objXmlTextWriter.WriteEndElement()
            ElseIf objXmlTextReader.NodeType = XmlNodeType.Comment Then
                objXmlTextWriter.WriteComment(objXmlTextReader.Value)
            ElseIf objXmlTextReader.NodeType = XmlNodeType.CDATA Then
                objXmlTextWriter.WriteCData(objXmlTextReader.Value)
            ElseIf objXmlTextReader.NodeType = XmlNodeType.Text Then
                objXmlTextWriter.WriteString(EncodeString(objXmlTextReader.Value))
            End If
        End While
        objXmlTextWriter.Close()
        objXmlTextReader.Close()
        Return objString.ToString

    End Function

End Class
