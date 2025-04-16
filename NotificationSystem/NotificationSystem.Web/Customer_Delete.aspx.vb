Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Customer_Delete
        Inherits Page
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Try
                If MyBase.Page.IsPostBack Then
                    Dim strCustomer = Request.Form("ctl00_MainContent_ctrCustomer_Update_CustomerID_ClientState").Replace("""", "").Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&")

                    If strCustomer.Length > 3 Then
                        Dim arrCustomers = strCustomer.Split(Convert.ToChar(":"))
                        ctrCustomer_Delete.CustomerID = Integer.Parse(arrCustomers(1))
                        ctrCustomer_Delete.CustomerID = Integer.Parse(arrCustomers(2))
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
