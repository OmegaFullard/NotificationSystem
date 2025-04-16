Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Customer_Add
        Inherits Page
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            If IsPostBack Then
                If Equals(Request.Form("ctl00$MainContent$ctrCustomer_Search$btnSearch"), "Search") Then
                    ctrCustomer_Search.PopulateSearchControl()
                    If ctrCustomer_Search.CustomerID = 0 Then Return
                    ctrCustomer_Add.ClearControls()
                    ctrCustomer_Add.CustomerID = ctrCustomer_Search.CustomerID
                ElseIf Equals(Request.Form("ctl00$MainContent$ctrCustomer_Add$btnCreate"), "Add") Then
                    ctrCustomer_Add.AddCustomer()
                    If ctrCustomer_Search.CustomerID = 0 Then Return
                End If
            End If
        End Sub
    End Class
End Namespace
