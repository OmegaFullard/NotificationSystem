Imports System
Imports System.Web.UI
Imports Microsoft.VisualBasic

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Admin_Find
        Inherits Page
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Try
                If MyBase.Page.IsPostBack Then
                    If Equals(Request.Form("ctl00$MainContent$ctrSearch_Admin$btnSearch"), "Search") Then
                        ctrSearch_Admin.PopulateSearchControl()
                        ctrAdmin_Find.UserName = ctrSearch_Admin.UserName

                    End If
                End If

            Catch ex As Exception
                Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
                Dim NotificationBody = ex.Message & vbCrLf & ex.StackTrace
                SendError.SendMailMessage(NotificationBody)
                Response.Redirect("ErrorPage.aspx", False)
            End Try
        End Sub


        Public Overrides Property EnableEventValidation As Boolean
            Get
                Return False
            End Get
            Set(value As Boolean)
            End Set
        End Property
    End Class
End Namespace
