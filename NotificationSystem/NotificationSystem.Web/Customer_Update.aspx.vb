Imports System
Imports System.Web.UI
Imports Microsoft.VisualBasic

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Customer_Update
        Inherits Page


        Private m_CustomerID As Integer = 0

        Public Property CustomerID As Integer
            Get
                Return m_CustomerID
            End Get
            Set(value As Integer)
                m_CustomerID = value
            End Set
        End Property
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Try
                If MyBase.Page.IsPostBack Then
                    Dim strCustomer = Request.Form("ctl00_MainContent_ctrCustomer_Update_CustomerID_ClientState").Replace("""", "").Replace("{", "").Replace("}", "").Replace(",", "").Replace("text", "").Replace("value", "").Replace("%20", " ").Replace("%26", "&")

                    If strCustomer.Length > 3 Then
                        Dim arrCustomers = strCustomer.Split(Convert.ToChar(":"))
                        ctrCustomer_Update.CustomerID = Integer.Parse(arrCustomers(1))
                        ctrCustomer_Update.CustomerID = Integer.Parse(arrCustomers(2))
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
