Imports System
Imports System.Web.UI

Public Partial Class TroubleTicketReq_Add
    Inherits Page
    Protected Sub Page_Load(sender As Object, e As EventArgs)
        If IsPostBack Then
            If Equals(Request.Form("ctl00$MainContent$ctrTroubleTicketReq_Search$btnSearch"), "Search") Then
                ctrTroubleTicketReq_Search.PopulateSearchControl()
                If ctrTroubleTicketReq_Search.TroubleTicketNo = 0 Then Return
                ctrTroubleTicketReq_Add.ClearControls()
                ctrTroubleTicketReq_Add.TroubleTicketNo = ctrTroubleTicketReq_Search.TroubleTicketNo
            ElseIf Equals(Request.Form("ctl00$MainContent$ctrTroubleTicketReq_Add$btnCreate"), "Add") Then
                ctrTroubleTicketReq_Add.AddTroubleTicket()
                If ctrTroubleTicketReq_Search.TroubleTicketNo = 0 Then Return
            End If
        End If
    End Sub
End Class
