Imports System
Imports System.Linq
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Reflection
Imports Microsoft.Reporting.WebForms

Namespace NotificationSystem.NotificationSystem.Web


    Public Partial Class rptAgent
        Inherits Page

        Private m_AgentID As Integer = 0

        Public Property AgentID As Integer
            Get
                Return m_AgentID
            End Get
            Set(value As Integer)
                m_AgentID = value
            End Set
        End Property
        Private theSearch As NotificationSystem.NotificationSystem.Web.clsSearch = New NotificationSystem.NotificationSystem.Web.clsSearch()
        Private theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()

        Public Function IsNumeric(value As String) As Boolean
            Return value.All(New Func(Of Char, Boolean)(AddressOf Char.IsNumber))
        End Function
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            If MyBase.Page.IsPostBack Then
                If Equals(Request.Form("ctl00$MainContent$ctrAgent_Search$btnSearch"), "Search") Then
                    ctrAgent_Search.PopulateSearchControl()
                    theSearch.ReportPath = "~/NotificationSystem.Web/rptAgent.rdlc"
                    theSearch.AgentID = ctrAgent_Search.AgentID
                    ShowAgReport()
                End If
            End If
        End Sub

        Private Sub ShowAgReport()

            Try
                Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
                Dim dt As NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable()


                Dim ReportDataSource As ReportDataSource = New ReportDataSource()
                Dim strTitle = String.Empty
                Dim dtReport As NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable

                ReportDataSource.Name = "DataSet1"


                ReportViewer1.ProcessingMode = ProcessingMode.Local
                ReportViewer1.LocalReport.ReportPath = Server.MapPath(theSearch.ReportPath)

                If theSearch.AgentID Is 0 Then theSearch.AgentID = 0
                If Me.IsNumeric(Convert.ToString(theSearch.AgentID)) Then Convert.ToString(theSearch.AgentID)

                Dim numAgentID As Integer = theSearch.AgentID

                dtReport = CType(theNotificationSystem.GetAgReport(numAgentID), NotificationSystem.NotificationSystem.Data.NotificationSystem.AgentDataTable)
                ReportDataSource.Value = dtReport


                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)

                ReportViewer1.LocalReport.Refresh()


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
