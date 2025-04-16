Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports Microsoft.VisualBasic
Imports System.Data

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class ctrAdmin
        Inherits UserControl
        Private m_UserName As String = String.Empty
        Private m_Password As String = String.Empty

        Public Property UserName As String
            Get
                Return m_UserName
            End Get
            Set(value As String)
                m_UserName = value
            End Set
        End Property
        Public Property Password As String
            Get
                Return m_Password
            End Get
            Set(value As String)
                m_Password = value
            End Set
        End Property


        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
            Dim tblGetAdmin As NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable()


            Try

                If Equals(Request.Form("ctl00$MainContent$ctrAdmin_Search$btnSearch"), "Search") Then ctrHiddebField.Value = Convert.ToString(m_UserName)


                If MyBase.Page.IsPostBack And lblSearchResult.Text.Length > 0 Then
                    tblGetAdmin = CType(theNotificationSystem.GetAdmin(m_UserName), NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable)
                Else
                    tblGetAdmin = CType(theNotificationSystem.GetAdmins(), NotificationSystem.NotificationSystem.Data.NotificationSystem.AdminDataTable)
                End If

                lblSearchResult.Text = tblGetAdmin.Rows.Count.ToString() & " Result(s)"
                grdAdmin.DataSource = tblGetAdmin.DefaultView
                grdAdmin.DataBind()

            Catch __unusedException1__ As Exception
                Throw
            End Try
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
