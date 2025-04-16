Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_Agent_Update
        Inherits UserControl
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()

            If Not MyBase.Page.IsPostBack Then
                cmbAgent.DataSource = theNotificationSystem.GetAgents()
                cmbAgent.DataTextField = "AgentID"
                cmbAgent.DataValueField = "FirstN"
                cmbAgent.DataBind()
            End If
        End Sub
        Public Sub ClearControl()
            cmbAgent.Value = String.Empty
            cmbAgent.Text = "--"
        End Sub
    End Class
End Namespace
