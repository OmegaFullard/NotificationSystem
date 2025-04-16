Imports System
Imports System.Web.UI
Imports Microsoft.VisualBasic

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Agent_Update
        Inherits Page
        Private m_AgentID As Integer = 0

        Public Property AgentID As Integer
            Get
                Return m_AgentID
            End Get
            Set(value As Integer)
                m_AgentID = value
            End Set
        End Property
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Try
                If MyBase.Page.IsPostBack Then
                    Try
                        Dim strAgent = Request.Form("ctl00_MainContent_ctrAgent_Update_AgentID_ClientState")
                        If Equals(strAgent, "Search") Then
                            strAgent = strAgent.Replace("""", "").Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&")

                            If strAgent.Length > 2 Then
                                Dim arrAgents = strAgent.Split(Convert.ToChar(":"))
                                ctrAgent_Update.AgentID = Integer.Parse(arrAgents(1))
                                ctrAgent_Update.AgentID = Integer.Parse(arrAgents(2))
                                'this.ctrSearch_Agent_Update.ClearControl();
                            End If
                        End If
                    Catch ex As Exception
                        Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
                        Dim NotificationBody = ex.Message & vbCrLf & ex.StackTrace
                        SendError.SendMailMessage(NotificationBody)
                        Response.Redirect("ErrorPage.aspx", False)
                    End Try
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
