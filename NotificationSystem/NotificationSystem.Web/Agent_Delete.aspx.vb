Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Agent_Delete
        Inherits Page
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Try
                If MyBase.Page.IsPostBack Then
                    Dim strAgent = Request.Form("ctl00_MainContent_ctrAgent_Update_AgentID_ClientState").Replace("""", "").Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&")

                    If strAgent.Length > 2 Then
                        Dim arrAgents = strAgent.Split(Convert.ToChar(":"))
                        ctrAgent_Delete.AgentID = Integer.Parse(arrAgents(1))
                        ctrAgent_Delete.AgentID = Integer.Parse(arrAgents(2))
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
End Namespace
