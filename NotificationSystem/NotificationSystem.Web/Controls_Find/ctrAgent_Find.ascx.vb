Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Data
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem
Imports NotificationSystem.NotificationSystem.Data.Classes


Public Partial Class ctrAgent_Find
    Inherits UserControl
    Private m_AgentID As Integer = 0

    Public Property AgentID As Integer
        Get
            Return m_AgentID
        End Get
        Set(value As Integer)
            m_AgentID = value
        End Set
    End Property


    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim theNotificationSystem As clsNotificationSystem = New clsNotificationSystem()
        Dim tblAgent As AgentDataTable = New AgentDataTable()

        Try


            If Equals(Request.Form("ctl00$MainContent$ctrSearch_Agent_Find$btnSearch"), "Search") Then lblSearchResult.Text = "ID" & m_AgentID.ToString()

            If MyBase.Page.IsPostBack And lblSearchResult.Text.Length > 0 Then


                tblAgent = CType(theNotificationSystem.GetAgent(Integer.Parse(lblSearchResult.Text.Replace("ID", ""))), AgentDataTable)
            Else
                tblAgent = CType(theNotificationSystem.GetAgents(), AgentDataTable)
            End If

            lblSearchResult.Text = tblAgent.Rows.Count.ToString()
            grdAgent.DataSource = tblAgent.DefaultView
            grdAgent.DataBind()

        Catch ex As Exception
            Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
            Dim NotificationBody = ex.Message & "  " & ex.StackTrace
            SendError.SendMailMessage(NotificationBody)
            Response.Redirect("ErrorPage.aspx", False)
        End Try
    End Sub

    'protected void Page_Load(object sender, EventArgs e)
    '{
    '    try
    '    {
    '        var tblAgent = GetAgentData();
    '        this.lblSearchResult.Text = tblAgent.Rows.Count.ToString();
    '        this.grdAgent.DataSource = tblAgent.DefaultView;
    '        this.grdAgent.DataBind();
    '    }
    '    catch (Exception ex)
    '    {
    '        HandleError(ex);
    '    }
    '}

    'private AgentDataTable GetAgentData()
    '{
    '    clsNotificationSystem theNotificationSystem = new clsNotificationSystem();
    '    if (Request.Form["btnSearch"] == "Search" && lblSearchResult.Text.StartsWith("ID") &&
    '        int.TryParse(lblSearchResult.Text.Replace("ID", ""), out int agentId))
    '    {
    '        return (AgentDataTable)theNotificationSystem.GetAgent(agentId);
    '    }
    '    return (AgentDataTable)theNotificationSystem.GetAgents();
    '}

    'private void HandleError(Exception ex)
    '{
    '    clsNotificationSystem_Web sendError = new clsNotificationSystem_Web();
    '    string notificationBody = $"{ex.Message}\n{ex.StackTrace}";
    '    sendError.SendMailMessage(notificationBody);
    '    Debug.WriteLine(notificationBody);
    '    Response.Redirect("ErrorPage.aspx", true);
    '}
    Private Function ConvertSortDirection(e As GridViewSortEventArgs) As String
        MyBase.ViewState.Add("columnname", e.SortExpression)

        If MyBase.ViewState("direction") Is Nothing Then
            MyBase.ViewState.Add("direction", "asc")
        Else
            MyBase.ViewState("direction") = IIf(Equals(MyBase.ViewState("direction").ToString().ToLower(), "desc"), "asc", "desc")
        End If

        Return MyBase.ViewState("direction").ToString()
    End Function
    Public Sub CreateExcelFiles()
        Try
            Response.Clear()
            Response.Buffer = True
            Response.AddHeader("content-disposition", "attachment;filename=Agent_Information.xls")
            Response.Charset = ""
            Response.ContentType = "application/vnd.ms-excel"
            Dim sw As StringWriter = New StringWriter()
            Dim hw As HtmlTextWriter = New HtmlTextWriter(sw)
            grdAgent.AllowPaging = False
            grdAgent.DataBind()

            For y = 0 To 12
                grdAgent.HeaderRow.Cells(y).Style.Add("background-color", "#cfdbe6")
            Next

            For x As Integer = 0 To grdAgent.Rows.Count - 1
                For y = 0 To 12
                    If x Mod 2 > 0 Then grdAgent.Rows(x).Cells(y).Style.Add("background-color", "#e0ebea")
                Next
            Next

            grdAgent.Attributes.Add("style", "vnd.ms-excel.numberformat:@")
            grdAgent.RenderControl(hw)
            Response.Output.Write(sw.ToString())
            Response.Flush()
            Response.End()




        Catch __unusedException1__ As Exception
            Throw
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)
        CreateExcelFiles()
    End Sub

    Protected Sub grdAgent_PageIndexChanging(sender As Object, e As GridViewPageEventArgs)
        Try
            If Not (IsNothing(MyBase.ViewState("columnname")) Or IsNothing(MyBase.ViewState("direction"))) Then
                Dim m_DataView = CType(grdAgent.DataSource, DataView)

                If m_DataView Is Nothing Then
                    m_DataView.Sort = MyBase.ViewState("columnname").ToString() & " " & MyBase.ViewState("direction").ToString()
                    grdAgent.DataSource = m_DataView
                End If
            End If

            grdAgent.PageIndex = e.NewPageIndex
            grdAgent.DataBind()
        Catch __unusedException1__ As Exception
            Throw
        End Try
    End Sub

    Protected Sub grdAgent_Sorting(sender As Object, e As GridViewSortEventArgs)
        Try
            Dim m_Dataview = CType(grdAgent.DataSource, DataView)

            If m_Dataview Is Nothing Then
                m_Dataview.Sort = e.SortExpression & " " & ConvertSortDirection(e)
                grdAgent.DataSource = m_Dataview
                grdAgent.DataBind()
            End If
        Catch __unusedException1__ As Exception
            Throw
        End Try
    End Sub
End Class
