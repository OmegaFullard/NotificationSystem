Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Admin
        Inherits Page
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            If MyBase.Page.IsPostBack Then
                If Equals(MyBase.Page.Request.Form("ctl00$MainContent$ctrAdmin_Search$btnSearch"), "Search") Then
                    ctrSearch_Admin.PopulateSearchControl()
                    ctrAdmin.UserName = ctrSearch_Admin.UserName
                End If
            End If
        End Sub
    End Class
End Namespace
