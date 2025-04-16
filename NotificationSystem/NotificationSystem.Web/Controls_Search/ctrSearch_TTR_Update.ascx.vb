Imports System
Imports System.Web.UI
Imports NotificationSystem.NotificationSystem.Data.Classes

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_TTR_Update
        Inherits UserControl
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Dim theNotificationSystem As New clsNotificationSystem
            If Not Me.Page.IsPostBack Then
                cmbTicket.DataSource = theNotificationSystem.GetTT()
                cmbTicket.DataTextField = "TroubleTicketNo"
                cmbTicket.DataValueField = "Status"
                cmbTicket.DataValueField = "Type"
                cmbTicket.DataBind()

                '	cmbType.DataSource = theNotificationSystem.GetTypeList();
                '	cmbType.DataTextField = "TroubleTicket";
                '	cmbType.DataValueField = "Type";
                '	cmbType.DataBind();
            End If
        End Sub

        Public Sub ClearControl()
            cmbTicket.Value = String.Empty
            cmbTicket.Text = "--"
            'this.cmbType.Value = string.Empty; 
            'cmbType.Text = "--";
        End Sub
    End Class
End Namespace
