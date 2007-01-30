Imports System.IO
Imports System.Text
Imports System.Xml
Namespace XBMCGUI

    Public Class Skin

        Private strPath As String
        Private SkinXML As New XmlDocument

        Public Sub OpenSkin(ByVal Path As String)

            Dim objReader As StreamReader

            If Path.EndsWith("\") = False Then Path &= "\"
            strPath = Path

            If File.Exists(strPath & "Skin.xml") Then
                objReader = New StreamReader(strPath & "Skin.xml")
                SkinXML.LoadXml(objReader.ReadToEnd)
                objReader.Close()
            End If

        End Sub

        Public Function SkinName() As String
            SkinName = SkinXML.SelectSingleNode("//skinname").InnerXml
        End Function

        Public Function SkinVersion() As String
            SkinVersion = SkinXML.SelectSingleNode("//version").InnerXml
        End Function

    End Class
End Namespace