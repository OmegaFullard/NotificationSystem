Imports System
Imports System.Web.UI
Imports Microsoft.VisualBasic

Public Partial Class TroubleTicketReq_Update
    Inherits Page
    Private m_TroubleTicketNo As Integer = 0

    Public Property TroubleTicketNo As Integer
        Get
            Return m_TroubleTicketNo
        End Get
        Set(value As Integer)
            m_TroubleTicketNo = value
        End Set

    End Property
    Protected Sub Page_Load(sender As Object, e As EventArgs)

        Try
            If MyBase.Page.IsPostBack Then
                Dim strTroubleTicket = Request.Form("ctl00_MainContent_ctrTroubleTicketReq_Update_TroubleTicketNo_ClientState").Replace("""", "").Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&")

                If strTroubleTicket.Length > 3 Then
                    Dim arrTicket = strTroubleTicket.Split(Convert.ToChar(":"))
                    ctrTroubleTicketReq_Update.TroubleTicketNo = Integer.Parse(arrTicket(1))
                    ctrTroubleTicketReq_Update.TroubleTicketNo = Integer.Parse(arrTicket(2))
                End If
            End If
        Catch ex As Exception
            Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
            Dim NotificationBody = ex.Message & vbCrLf & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)
        End Try
    End Sub
End Class
