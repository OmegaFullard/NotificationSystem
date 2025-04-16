Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Admin_Delete
        Inherits Page
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Try
                If MyBase.Page.IsPostBack Then
                    Dim strAdmin = Request.Form("ctl00_MainContent_ctrAdmin_Update_UserName_ClientState").Replace("""", "").Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&")

                    If strAdmin.Length > 2 Then
                        Dim arrAdmins = strAdmin.Split(Convert.ToChar(":"))
                        ctrAdmin_Delete.UserName = arrAdmins(1)
                        ctrAdmin_Delete.UserName = arrAdmins(2)
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
