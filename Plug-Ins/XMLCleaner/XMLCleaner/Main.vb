Imports System.IO
Imports System.Drawing.Imaging
Imports System.Xml
Imports System.Web

Public Class Main

    Private Function FixPath(ByVal Path As String) As String
        If Path.EndsWith("\") Then Return Path
        Return Path & "\"
    End Function

    Private Function EncodeString(ByVal Value As String)
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

    Private Function CleanXML(ByVal XML As String) As String

        Dim objXmlTextReader As New XmlTextReader(XML, XmlNodeType.Document, Nothing)
        Dim objString As New StringWriter
        Dim objXmlTextWriter As New XmlTextWriter(objString)
        objXmlTextWriter.Indentation = 1
        If cbTabs.Checked = True Then objXmlTextWriter.IndentChar = ControlChars.Tab
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

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        If Not txtSource.Text.EndsWith("\") Then txtSource.Text = txtSource.Text & "\"
        If Not txtDest.Text.EndsWith("\") Then txtDest.Text = txtDest.Text & "\"
        Dim strFiles() As String = Directory.GetFiles(txtSource.Text, "*.xml")
        Progress.Value = 0
        Progress.Maximum = strFiles.GetUpperBound(0) + 1
        Try
            For Each strFile As String In strFiles

                Dim strXML As String = My.Computer.FileSystem.ReadAllText(strFile)
                My.Computer.FileSystem.WriteAllText(strFile & ".xml", CleanXML(strXML), False)

                Progress.Value = Progress.Value + 1
            Next
            MsgBox("Done")
        Catch ex As Exception
            MsgBox("Error Occured: " & ex.Message)
        End Try
    End Sub


    Private Sub RecurseFolder(ByVal Path As String, ByVal blnRecurse As Boolean)

        If Not Path.EndsWith("\") Then Path = Path & "\"

        For Each strFile As String In Directory.GetFiles(Path, "*.xml")
            'file = strpath & strfile
        Next

        If blnRecurse = True Then
            For Each strDirectory As String In Directory.GetDirectories(Path)
                RecurseFolder(strDirectory, blnRecurse)
            Next
        End If

    End Sub




    Private Sub txtSource_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSource.Validating
        If Directory.Exists(txtSource.Text) Then
            txtSource.Text = FixPath(txtSource.Text)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub txtDest_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDest.Validating
        If Directory.Exists(txtDest.Text) Then
            txtDest.Text = FixPath(txtDest.Text)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub txtDefault_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDest.Validating
        If Directory.Exists(txtDefault.Text) Then
            txtDefault.Text = FixPath(txtDefault.Text)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSource.Click
        If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtSource.Text = FolderBrowserDialog.SelectedPath & "\"
        End If
    End Sub

    Private Sub btnDest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDest.Click
        If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDest.Text = FixPath(FolderBrowserDialog.SelectedPath)
        End If
    End Sub

    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDefault.Text = FixPath(FolderBrowserDialog.SelectedPath)
        End If
    End Sub

End Class
