Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class TicketMgt
        Inherits Page
        Protected Sub Page_Load(sender As Object, e As EventArgs)

        End Sub

        Private Sub PopulateControls()
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()


            'this.cmbStatus.DataSource = theNotificationSystem.GetStatusList();
            'this.cmbStatus.DataTextField = "Status";
            'this.cmbStatus.DataBind();
            'this.cmbStatus.Text = "Open";


            'this.cmbType.DataSource = theNotificationSystem.GetTypeList();
            'this.cmbType.DataTextField = "Type";
            'this.cmbType.DataBind();


        End Sub
    End Class


End Namespace
