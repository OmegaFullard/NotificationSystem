Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Agent
        Inherits Page
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            If MyBase.Page.IsPostBack Then
                If Equals(MyBase.Page.Request.Form("ctl00$MainContent$ctrAgent_Search$btnSearch"), "Search") Then
                    ctrAgent_Search.PopulateSearchControl()
                    ctrAgent.AgentID = ctrAgent_Search.AgentID
                End If
            End If
        End Sub
    End Class
End Namespace
