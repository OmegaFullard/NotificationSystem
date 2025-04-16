Imports System
Imports System.Web.UI
Imports NotificationSystem.NotificationSystem.Data.Classes

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_Agent_Update
        Inherits UserControl
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Dim theNotificationSystem As New clsNotificationSystem

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
