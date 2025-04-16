Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_Customer_Update
        Inherits UserControl
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()

            If Not MyBase.Page.IsPostBack Then
                cmbCustomer.DataSource = theNotificationSystem.GetCustomers()
                cmbCustomer.DataTextField = "CustomerID"
                cmbCustomer.DataValueField = "FirstN"
                cmbCustomer.DataBind()
            End If
        End Sub

        Public Sub ClearControl()
            cmbCustomer.Value = String.Empty
            cmbCustomer.Text = "--"
        End Sub
    End Class

End Namespace
