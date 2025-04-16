Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Customer
        Inherits Page
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            If MyBase.Page.IsPostBack Then
                If Equals(MyBase.Page.Request.Form("ctl00$MainContent$ctrCustomer_Search$btnSearch"), "Search") Then
                    ctrCustomer_Search.PopulateSearchControl()
                    ctrCustomer.CustomerID = ctrCustomer_Search.CustomerID
                End If
            End If
        End Sub
    End Class
End Namespace
