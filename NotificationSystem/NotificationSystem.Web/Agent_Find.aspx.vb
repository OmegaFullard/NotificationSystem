Imports System
Imports System.Web.UI
Imports Microsoft.VisualBasic

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class Agent_Find
        Inherits Page

        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Try
                If MyBase.Page.IsPostBack Then
                    If Equals(Request.Form("ctl00$MainContent$ctrAgent_Search$btnSearch"), "Search") Then
                        ctrAgent_Search.PopulateSearchControl()
                        ctrAgent_Find.AgentID = ctrAgent_Search.AgentID

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

