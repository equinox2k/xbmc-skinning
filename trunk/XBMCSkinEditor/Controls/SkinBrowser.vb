Imports System.IO
Imports WeifenLuo.WinFormsUI

Public Class SkinBrowser
    Inherits DockContent
    Private objSkin As New Skin
    Public Enum FileType
        File = 0
        Directory = 1
        XPR = 2
    End Enum

    Public Structure XPRInfo
        Dim XPRProtected As Boolean
        Dim XPRFile As String
    End Structure

    Public Structure FileInfo
        Dim FileType As FileType
        Dim XPRInfo As XPRInfo
        Dim DisplayName As String
        Dim Name As String
        Dim Path As String
    End Structure

    Private Function FixPath(ByVal Path As String) As String
        If Path.EndsWith("\") Then Return Path
        Return Path & "\"
    End Function

    Public Function OpenSkin(ByVal SkinPath As String) As Boolean

        SkinBrowser_TV.Nodes.Clear()
        If Not SkinPath.EndsWith("\") Then SkinPath &= "\"
        objSkin.OpenSkin(SkinPath)

        Dim objTreeNode As New TreeNode
        objTreeNode.Text = objSkin.SkinName
        SkinBrowser_TV.Nodes.Add(objTreeNode)
        RecurseTree(SkinPath, SkinBrowser_TV.Nodes(0))
        Return True

    End Function
    Private Sub RecurseTree(ByVal Folder As String, ByVal Node As TreeNode)

        Dim strDirectories() As String = System.IO.Directory.GetDirectories(Folder)
        For intLoop As Integer = strDirectories.GetLowerBound(0) To strDirectories.GetUpperBound(0)
            If Not Path.GetFileName(strDirectories(intLoop)).Equals("CVS", StringComparison.CurrentCultureIgnoreCase) Then

                Dim objFileInfo As New FileInfo
                objFileInfo.FileType = FileType.Directory
                objFileInfo.XPRInfo = Nothing
                objFileInfo.DisplayName = Path.GetFileName(strDirectories(intLoop))
                objFileInfo.Name = Path.GetFileName(strDirectories(intLoop))
                objFileInfo.Path = FixPath(strDirectories(intLoop))

                Dim objTN As New TreeNode ' = Node.Nodes.Add
                objTN.Text = objFileInfo.DisplayName
                'objTreeNode.Override.NodeAppearance.Image = 1
                'objTN.ImageIndex 
                objTN.Tag = objFileInfo
                RecurseTree(strDirectories(intLoop) & "\", objTN)
                Node.Nodes.Add(objTN)
            End If
        Next intLoop

        Dim strFiles() As String = Directory.GetFiles(Folder)
        For intLoop As Integer = strFiles.GetLowerBound(0) To strFiles.GetUpperBound(0)

            If Path.GetExtension(strFiles(intLoop)).ToLower = ".xpr" Then
                Try

                    Dim objXPRTool As New XPRTool
                    objXPRTool.OpenXPR(strFiles(intLoop))

                    Dim objFileInfo1 As New FileInfo
                    objFileInfo1.FileType = FileType.File
                    objFileInfo1.XPRInfo = Nothing
                    objFileInfo1.DisplayName = Path.GetFileName(strFiles(intLoop)) & IIf(objXPRTool.ProtectionEnabled, " (Protected)", "")
                    objFileInfo1.Name = Path.GetFileName(strFiles(intLoop))
                    objFileInfo1.Path = FixPath(Path.GetDirectoryName(strFiles(intLoop)))

                    Dim objTreeNode1 As New TreeNode ' = Node.Nodes.Add
                    objTreeNode1.Text = objFileInfo1.DisplayName
                    objTreeNode1.Tag = objFileInfo1

                    For intloop1 As Integer = 1 To objXPRTool.FileCount
                        Dim objFileInfo2 As New FileInfo
                        objFileInfo2.FileType = FileType.XPR

                        Dim objXPRInfo As New XPRInfo
                        objXPRInfo.XPRProtected = objXPRTool.ProtectionEnabled
                        objXPRInfo.XPRFile = objXPRTool.FileName(intloop1)
                        objFileInfo2.XPRInfo = objXPRInfo
                        objFileInfo2.DisplayName = objXPRTool.FileName(intloop1)
                        objFileInfo2.Name = Path.GetFileName(strFiles(intLoop))
                        objFileInfo2.Path = FixPath(Path.GetDirectoryName(strFiles(intLoop)))

                        Dim objTreeNode2 As New TreeNode ' objTreeNode1.Nodes.Add
                        objTreeNode2.Text = objFileInfo2.DisplayName
                        objTreeNode2.Tag = objFileInfo2
                        objTreeNode2.ImageKey = "image"
                        objTreeNode2.SelectedImageKey = "image"
                        Node.Nodes.Add(objTreeNode2)
                    Next intloop1

                    objXPRTool.CloseXPR()

                Catch ex As Exception

                    'RaiseEvent ErrorOccurred(ex.Message)
                    Continue For

                End Try

            Else

                Dim objFileInfo As New FileInfo
                objFileInfo.FileType = FileType.File
                objFileInfo.XPRInfo = Nothing
                objFileInfo.DisplayName = Path.GetFileName(strFiles(intLoop))
                objFileInfo.Name = Path.GetFileName(strFiles(intLoop))
                objFileInfo.Path = FixPath(Path.GetDirectoryName(strFiles(intLoop)))

                Dim objFileNode As New TreeNode
                objFileNode.Text = objFileInfo.DisplayName
                objFileNode.Tag = objFileInfo
                objFileNode.ImageKey = "file"
                objFileNode.SelectedImageKey = "file"
                Node.Nodes.Add(objFileNode)
            End If

        Next intLoop

    End Sub
    Public Sub InitShow(ByVal DockPanel As WeifenLuo.WinFormsUI.DockPanel, ByVal DockState As WeifenLuo.WinFormsUI.DockState)
        Show(DockPanel, DockState)
    End Sub

End Class
