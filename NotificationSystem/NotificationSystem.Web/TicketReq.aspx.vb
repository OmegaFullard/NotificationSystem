Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class TicketReq
        Inherits Page


        Protected Sub Page_Load(sender As Object, e As EventArgs)

            If MyBase.Page.IsPostBack Then
                If Equals(MyBase.Page.Request.Form("ctl00$MainContent$ctrTroubleTicketReq_Search$btnSearch"), "Search") Then

                    'ctrTroubleTicketReq_Search.PopulateSearchControl();
                    'ctrTroubleTicketReq.TroubleTicketNo = ctrTroubleTicketReq_Search.TroubleTicketNo;
                End If
            End If
        End Sub


    End Class
End Namespace
