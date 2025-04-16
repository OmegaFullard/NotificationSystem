Imports System
Imports System.Linq
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Reflection
Imports Microsoft.Reporting.WebForms

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class rptCustomer
        Inherits Page
        Private theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()

        Public Function IsNumeric(value As String) As Boolean
            Return value.All(New Func(Of Char, Boolean)(AddressOf Char.IsNumber))
        End Function
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            If MyBase.Page.IsPostBack Then
                If Equals(Request.Form("ctl00$MainContent$ctrCustomer_Search$btnSearch"), "Search") Then
                    ctrCustomer_Search.PopulateSearchControl()
                    theNotificationSystem.ReportPath = "~/NotificationSystem.Web/rptCustomer.rdlc"
                    theNotificationSystem.CustomerID = ctrCustomer_Search.CustomerID
                    ShowCustReport()
                End If
            End If
        End Sub

        Private Sub ShowCustReport()
            Try
                Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()

                Dim ReportDataSource As ReportDataSource = New ReportDataSource()
                Dim strTitle = String.Empty
                Dim dtReport As NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable

                ReportDataSource.Name = "DataSet1"


                ReportViewer1.ProcessingMode = ProcessingMode.Local
                ReportViewer1.LocalReport.ReportPath = MyBase.Page.Server.MapPath(theNotificationSystem.ReportPath)

                If theNotificationSystem.CustomerID.ToString().Length = 0 Then
                    theNotificationSystem.CustomerID = Integer.Parse("XXXXXX")



                    'implicit cast
                    Dim numCustomerID As Integer = theNotificationSystem.CustomerID
                    dtReport = CType(theNotificationSystem.GetCustomer(theNotificationSystem.CustomerID), NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable)

                    'strTitle = "Customer Report: " + theSearch.TroubleTicketNo + " Activity by Customer ID ";

                    ReportDataSource.Value = dtReport
                    'ReportParameter param1 = new ReportParameter("Title", strTitle);
                    'ReportViewer1.LocalReport.SetParameters(new ReportParameter[] { param1 });

                    'ReportViewer1.LocalReport.DataSources.Clear();
                    ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
                    ReportViewer1.LocalReport.Refresh()
                End If


            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub

        Protected Sub ReportViewer1_Load(sender As Object, e As EventArgs)

            ' string exportOption = "Excel";
            ' string exportOption = "Word";
            Dim exportOption = "PDF"
            Dim extension As RenderingExtension = Enumerable.ToList(Of RenderingExtension)(ReportViewer1.LocalReport.ListRenderingExtensions()).Find(Function(x) x.Name.Equals(exportOption, StringComparison.CurrentCultureIgnoreCase))
            If extension IsNot Nothing Then
                Dim fieldInfo As FieldInfo = extension.GetType().GetField("m_isVisible", BindingFlags.Instance Or BindingFlags.NonPublic)
                fieldInfo.SetValue(extension, False)
            End If
        End Sub
    End Class
End Namespace
