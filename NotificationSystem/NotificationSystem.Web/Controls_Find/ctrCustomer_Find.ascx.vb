Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem
Imports NotificationSystem.NotificationSystem.Data.Classes
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.IO

Public Partial Class ctrCustomer_Find
    Inherits UserControl

    Private m_CustomerID As Integer = 0

    Public Property CustomerID As Integer
        Get
            Return m_CustomerID
        End Get
        Set(value As Integer)
            m_CustomerID = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack Then

            Try
                If m_CustomerID > 0 Then
                    lblSearchResult.Text = "ID" & m_CustomerID.ToString()

                    If m_CustomerID = 2 Then Exit Sub

                    If New clsNotificationSystem().GetCustomer(Integer.Parse(Replace(lblSearchResult.Text, "ID", ""))).Rows.Count = 0 Then Exit Sub

                    If Request.Form("ctl00$MainContent$ctrCustomer_Find$btnExcel") IsNot Nothing Then
                        CreateExcelFiles()
                    End If
                End If
                If Request.Form("ctl00$MainContent$ctrSearch_Customer_Find$btnSearch") = "Search" Then
                        lblSearchResult.Text = "ID" & m_CustomerID.ToString()
                    End If

                    Dim theNotificationSystem As New clsNotificationSystem
                    Dim tblCustomer As CustomerDataTable

                    If Page.IsPostBack AndAlso lblSearchResult.Text.Length > 0 Then
                        tblCustomer = CType(theNotificationSystem.GetCustomer(Integer.Parse(lblSearchResult.Text.Replace("ID", ""))), CustomerDataTable)
                    Else
                        tblCustomer = CType(theNotificationSystem.GetCustomers(), CustomerDataTable)
                    End If


                    lblSearchResult.Text = tblCustomer.Rows.Count.ToString()
                    grdCustomer.DataSource = tblCustomer.DefaultView
                    grdCustomer.DataBind()


        Catch ex As Exception

                Dim SendError As clsNotificationSystem_Web = New clsNotificationSystem_Web()
                Dim NotificationBody = ex.Message & "  " & ex.StackTrace
                SendError.SendMailMessage(NotificationBody)
                Response.Redirect("ErrorPage.aspx", False)
            End Try

        End If
    End Sub



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
            Response.AddHeader("content-disposition", "attachment;filename=Customer_Information.xls")
            Response.Charset = ""
            Response.ContentType = "application/vnd.ms-excel"
            Dim sw As StringWriter = New StringWriter()
            Dim hw As HtmlTextWriter = New HtmlTextWriter(sw)
            grdCustomer.AllowPaging = False
            grdCustomer.DataBind()

            For y = 0 To 12
                grdCustomer.HeaderRow.Cells(y).Style.Add("background-color", "#cfdbe6")
            Next

            For x As Integer = 0 To grdCustomer.Rows.Count - 1
                For y = 0 To 12
                    If x Mod 2 > 0 Then grdCustomer.Rows(x).Cells(y).Style.Add("background-color", "#e0ebea")
                Next
            Next

            grdCustomer.Attributes.Add("style", "vnd.ms-excel.numberformat:@")
            grdCustomer.RenderControl(hw)
            Response.Output.Write(sw.ToString())
            Response.Flush()
            Response.End()




        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)
        CreateExcelFiles()
    End Sub

    Protected Sub grdCustomer_PageIndexChanging(sender As Object, e As GridViewPageEventArgs)
        Try
            If Not (IsNothing(MyBase.ViewState("columnname")) Or IsNothing(MyBase.ViewState("direction"))) Then
                Dim m_DataView = CType(grdCustomer.DataSource, DataView)

                If m_DataView Is Nothing Then
                    m_DataView.Sort = MyBase.ViewState("columnname").ToString() & " " & MyBase.ViewState("direction").ToString()
                    grdCustomer.DataSource = m_DataView
                End If
            End If

            grdCustomer.PageIndex = e.NewPageIndex
            grdCustomer.DataBind()
        Catch __unusedException1__ As Exception
            Throw
        End Try
    End Sub

    Protected Sub grdCustomer_Sorting(sender As Object, e As GridViewSortEventArgs)
        Try
            Dim m_Dataview = CType(grdCustomer.DataSource, DataView)

            If m_Dataview Is Nothing Then
                m_Dataview.Sort = e.SortExpression & " " & ConvertSortDirection(e)
                grdCustomer.DataSource = m_Dataview
                grdCustomer.DataBind()
            End If
        Catch __unusedException1__ As Exception
            Throw
        End Try
    End Sub


End Class
