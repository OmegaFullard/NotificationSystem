Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Data
Imports NotificationSystem.NotificationSystem.Data.Classes
Imports NotificationSystem.NotificationSystem.Data.NotificationSystem

Namespace NotificationSystem.NotificationSystem.Web.Controls_Find
    Partial Public Class ctrAdmin_Find
        Inherits UserControl
        Private m_UserName As String = String.Empty

        Public Property UserName As String
            Get
                Return m_UserName
            End Get
            Set(value As String)
                m_UserName = value
            End Set
        End Property

        Protected Sub Page_Load(ByVal sender As Object, e As System.EventArgs) Handles Me.Load

            If Page.IsPostBack Then
                Try
                    If m_UserName.Length > 0 Then
                        lblUserName.Text = "UserName" & m_UserName
                        If m_UserName.Length = 2 Then Exit Sub

                        If New clsNotificationSystem().GetAdmin(m_UserName).Rows.Count = 0 Then Exit Sub

                        If Request.Form("ctl00$MainContent$ctrSearch_Admin_Find$btnSearch") = "Search" Then lblUserName.Text = "UserName" & m_UserName

                    End If


                    Dim theNotificationSystem As New clsNotificationSystem
                    Dim tblAdmin As AdminDataTable = New AdminDataTable

                    If Page.IsPostBack AndAlso lblSearchResult.Text.Length > 0 Then

                        tblAdmin = CType(theNotificationSystem.GetAdmin(m_UserName), AdminDataTable)
                    Else
                        tblAdmin = CType(theNotificationSystem.GetAdmins(), AdminDataTable)
                    End If


                    lblSearchResult.Text = tblAdmin.Rows.Count.ToString()
                    grdAdmin.DataSource = tblAdmin.DefaultView
                    grdAdmin.DataBind()

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
                Response.AddHeader("content-disposition", "attachment;filename=Admin_Information.xls")
                Response.Charset = ""
                Response.ContentType = "application/vnd.ms-excel"
                Dim sw As StringWriter = New StringWriter()
                Dim hw As HtmlTextWriter = New HtmlTextWriter(sw)
                grdAdmin.AllowPaging = False
                grdAdmin.DataBind()

                For y = 0 To 12
                    grdAdmin.HeaderRow.Cells(y).Style.Add("background-color", "#cfdbe6")
                Next

                For x As Integer = 0 To grdAdmin.Rows.Count - 1
                    For y = 0 To 12
                        If x Mod 2 > 0 Then grdAdmin.Rows(x).Cells(y).Style.Add("background-color", "#e0ebea")
                    Next
                Next

                grdAdmin.Attributes.Add("style", "vnd.ms-excel.numberformat:@")
                grdAdmin.RenderControl(hw)
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

        Protected Sub grdAdmin_PageIndexChanging(sender As Object, e As GridViewPageEventArgs)
            Try
                If Not (IsNothing(MyBase.ViewState("columnname")) Or IsNothing(MyBase.ViewState("direction"))) Then
                    Dim m_DataView = CType(grdAdmin.DataSource, DataView)

                    If m_DataView Is Nothing Then
                        m_DataView.Sort = MyBase.ViewState("columnname").ToString() & " " & MyBase.ViewState("direction").ToString()
                        grdAdmin.DataSource = m_DataView
                    End If
                End If

                grdAdmin.PageIndex = e.NewPageIndex
                grdAdmin.DataBind()
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub

        Protected Sub grdAdmin_Sorting(sender As Object, e As GridViewSortEventArgs)

            Try
                Dim m_Dataview = CType(grdAdmin.DataSource, DataView)

                If m_Dataview Is Nothing Then
                    m_Dataview.Sort = e.SortExpression & " " & ConvertSortDirection(e)
                    grdAdmin.DataSource = m_Dataview
                    grdAdmin.DataBind()
                End If
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub
    End Class
End Namespace
