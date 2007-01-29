﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.42.
'
Namespace googleapi
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="GoogleSearchBinding", [Namespace]:="urn:GoogleSearch"),  _
     System.Xml.Serialization.SoapIncludeAttribute(GetType(ResultElement))>  _
    Partial Public Class GoogleSearchService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private doGetCachedPageOperationCompleted As System.Threading.SendOrPostCallback
        
        Private doSpellingSuggestionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private doGoogleSearchOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.SkinEditor.Plugin.GoogleSearch.My.MySettings.Default.SkinEditor_Plugin_GoogleSearch_googleapi_GoogleSearchService
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event doGetCachedPageCompleted As doGetCachedPageCompletedEventHandler
        
        '''<remarks/>
        Public Event doSpellingSuggestionCompleted As doSpellingSuggestionCompletedEventHandler
        
        '''<remarks/>
        Public Event doGoogleSearchCompleted As doGoogleSearchCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:GoogleSearchAction", RequestNamespace:="urn:GoogleSearch", ResponseNamespace:="urn:GoogleSearch")>  _
        Public Function doGetCachedPage(ByVal key As String, ByVal url As String) As <System.Xml.Serialization.SoapElementAttribute("return", DataType:="base64Binary")> Byte()
            Dim results() As Object = Me.Invoke("doGetCachedPage", New Object() {key, url})
            Return CType(results(0),Byte())
        End Function
        
        '''<remarks/>
        Public Overloads Sub doGetCachedPageAsync(ByVal key As String, ByVal url As String)
            Me.doGetCachedPageAsync(key, url, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub doGetCachedPageAsync(ByVal key As String, ByVal url As String, ByVal userState As Object)
            If (Me.doGetCachedPageOperationCompleted Is Nothing) Then
                Me.doGetCachedPageOperationCompleted = AddressOf Me.OndoGetCachedPageOperationCompleted
            End If
            Me.InvokeAsync("doGetCachedPage", New Object() {key, url}, Me.doGetCachedPageOperationCompleted, userState)
        End Sub
        
        Private Sub OndoGetCachedPageOperationCompleted(ByVal arg As Object)
            If (Not (Me.doGetCachedPageCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent doGetCachedPageCompleted(Me, New doGetCachedPageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:GoogleSearchAction", RequestNamespace:="urn:GoogleSearch", ResponseNamespace:="urn:GoogleSearch")>  _
        Public Function doSpellingSuggestion(ByVal key As String, ByVal phrase As String) As <System.Xml.Serialization.SoapElementAttribute("return")> String
            Dim results() As Object = Me.Invoke("doSpellingSuggestion", New Object() {key, phrase})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub doSpellingSuggestionAsync(ByVal key As String, ByVal phrase As String)
            Me.doSpellingSuggestionAsync(key, phrase, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub doSpellingSuggestionAsync(ByVal key As String, ByVal phrase As String, ByVal userState As Object)
            If (Me.doSpellingSuggestionOperationCompleted Is Nothing) Then
                Me.doSpellingSuggestionOperationCompleted = AddressOf Me.OndoSpellingSuggestionOperationCompleted
            End If
            Me.InvokeAsync("doSpellingSuggestion", New Object() {key, phrase}, Me.doSpellingSuggestionOperationCompleted, userState)
        End Sub
        
        Private Sub OndoSpellingSuggestionOperationCompleted(ByVal arg As Object)
            If (Not (Me.doSpellingSuggestionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent doSpellingSuggestionCompleted(Me, New doSpellingSuggestionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:GoogleSearchAction", RequestNamespace:="urn:GoogleSearch", ResponseNamespace:="urn:GoogleSearch")>  _
        Public Function doGoogleSearch(ByVal key As String, ByVal q As String, ByVal start As Integer, ByVal maxResults As Integer, ByVal filter As Boolean, ByVal restrict As String, ByVal safeSearch As Boolean, ByVal lr As String, ByVal ie As String, ByVal oe As String) As <System.Xml.Serialization.SoapElementAttribute("return")> GoogleSearchResult
            Dim results() As Object = Me.Invoke("doGoogleSearch", New Object() {key, q, start, maxResults, filter, restrict, safeSearch, lr, ie, oe})
            Return CType(results(0),GoogleSearchResult)
        End Function
        
        '''<remarks/>
        Public Overloads Sub doGoogleSearchAsync(ByVal key As String, ByVal q As String, ByVal start As Integer, ByVal maxResults As Integer, ByVal filter As Boolean, ByVal restrict As String, ByVal safeSearch As Boolean, ByVal lr As String, ByVal ie As String, ByVal oe As String)
            Me.doGoogleSearchAsync(key, q, start, maxResults, filter, restrict, safeSearch, lr, ie, oe, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub doGoogleSearchAsync(ByVal key As String, ByVal q As String, ByVal start As Integer, ByVal maxResults As Integer, ByVal filter As Boolean, ByVal restrict As String, ByVal safeSearch As Boolean, ByVal lr As String, ByVal ie As String, ByVal oe As String, ByVal userState As Object)
            If (Me.doGoogleSearchOperationCompleted Is Nothing) Then
                Me.doGoogleSearchOperationCompleted = AddressOf Me.OndoGoogleSearchOperationCompleted
            End If
            Me.InvokeAsync("doGoogleSearch", New Object() {key, q, start, maxResults, filter, restrict, safeSearch, lr, ie, oe}, Me.doGoogleSearchOperationCompleted, userState)
        End Sub
        
        Private Sub OndoGoogleSearchOperationCompleted(ByVal arg As Object)
            If (Not (Me.doGoogleSearchCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent doGoogleSearchCompleted(Me, New doGoogleSearchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.SoapTypeAttribute([Namespace]:="urn:GoogleSearch")>  _
    Partial Public Class GoogleSearchResult
        
        Private documentFilteringField As Boolean
        
        Private searchCommentsField As String
        
        Private estimatedTotalResultsCountField As Integer
        
        Private estimateIsExactField As Boolean
        
        Private resultElementsField() As ResultElement
        
        Private searchQueryField As String
        
        Private startIndexField As Integer
        
        Private endIndexField As Integer
        
        Private searchTipsField As String
        
        Private directoryCategoriesField() As DirectoryCategory
        
        Private searchTimeField As Double
        
        '''<remarks/>
        Public Property documentFiltering() As Boolean
            Get
                Return Me.documentFilteringField
            End Get
            Set
                Me.documentFilteringField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property searchComments() As String
            Get
                Return Me.searchCommentsField
            End Get
            Set
                Me.searchCommentsField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property estimatedTotalResultsCount() As Integer
            Get
                Return Me.estimatedTotalResultsCountField
            End Get
            Set
                Me.estimatedTotalResultsCountField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property estimateIsExact() As Boolean
            Get
                Return Me.estimateIsExactField
            End Get
            Set
                Me.estimateIsExactField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property resultElements() As ResultElement()
            Get
                Return Me.resultElementsField
            End Get
            Set
                Me.resultElementsField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property searchQuery() As String
            Get
                Return Me.searchQueryField
            End Get
            Set
                Me.searchQueryField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property startIndex() As Integer
            Get
                Return Me.startIndexField
            End Get
            Set
                Me.startIndexField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property endIndex() As Integer
            Get
                Return Me.endIndexField
            End Get
            Set
                Me.endIndexField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property searchTips() As String
            Get
                Return Me.searchTipsField
            End Get
            Set
                Me.searchTipsField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property directoryCategories() As DirectoryCategory()
            Get
                Return Me.directoryCategoriesField
            End Get
            Set
                Me.directoryCategoriesField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property searchTime() As Double
            Get
                Return Me.searchTimeField
            End Get
            Set
                Me.searchTimeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.SoapTypeAttribute([Namespace]:="urn:GoogleSearch")>  _
    Partial Public Class ResultElement
        
        Private summaryField As String
        
        Private uRLField As String
        
        Private snippetField As String
        
        Private titleField As String
        
        Private cachedSizeField As String
        
        Private relatedInformationPresentField As Boolean
        
        Private hostNameField As String
        
        Private directoryCategoryField As DirectoryCategory
        
        Private directoryTitleField As String
        
        '''<remarks/>
        Public Property summary() As String
            Get
                Return Me.summaryField
            End Get
            Set
                Me.summaryField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property URL() As String
            Get
                Return Me.uRLField
            End Get
            Set
                Me.uRLField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property snippet() As String
            Get
                Return Me.snippetField
            End Get
            Set
                Me.snippetField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property title() As String
            Get
                Return Me.titleField
            End Get
            Set
                Me.titleField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property cachedSize() As String
            Get
                Return Me.cachedSizeField
            End Get
            Set
                Me.cachedSizeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property relatedInformationPresent() As Boolean
            Get
                Return Me.relatedInformationPresentField
            End Get
            Set
                Me.relatedInformationPresentField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property hostName() As String
            Get
                Return Me.hostNameField
            End Get
            Set
                Me.hostNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property directoryCategory() As DirectoryCategory
            Get
                Return Me.directoryCategoryField
            End Get
            Set
                Me.directoryCategoryField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property directoryTitle() As String
            Get
                Return Me.directoryTitleField
            End Get
            Set
                Me.directoryTitleField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.SoapTypeAttribute([Namespace]:="urn:GoogleSearch")>  _
    Partial Public Class DirectoryCategory
        
        Private fullViewableNameField As String
        
        Private specialEncodingField As String
        
        '''<remarks/>
        Public Property fullViewableName() As String
            Get
                Return Me.fullViewableNameField
            End Get
            Set
                Me.fullViewableNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property specialEncoding() As String
            Get
                Return Me.specialEncodingField
            End Get
            Set
                Me.specialEncodingField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")>  _
    Public Delegate Sub doGetCachedPageCompletedEventHandler(ByVal sender As Object, ByVal e As doGetCachedPageCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class doGetCachedPageCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Byte()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Byte())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")>  _
    Public Delegate Sub doSpellingSuggestionCompletedEventHandler(ByVal sender As Object, ByVal e As doSpellingSuggestionCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class doSpellingSuggestionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")>  _
    Public Delegate Sub doGoogleSearchCompletedEventHandler(ByVal sender As Object, ByVal e As doGoogleSearchCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class doGoogleSearchCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As GoogleSearchResult
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),GoogleSearchResult)
            End Get
        End Property
    End Class
End Namespace
