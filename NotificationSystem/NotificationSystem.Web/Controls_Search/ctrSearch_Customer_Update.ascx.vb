Imports System
Imports System.Web.UI
Imports NotificationSystem.NotificationSystem.Data.Classes

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_Customer_Update
        Inherits UserControl
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Dim theNotificationSystem As New clsNotificationSystem

            If Not Me.Page.IsPostBack Then
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
