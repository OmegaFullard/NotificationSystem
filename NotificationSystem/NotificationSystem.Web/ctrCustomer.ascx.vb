Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports Microsoft.VisualBasic

Namespace NotificationSystem.NotificationSystem.Web
    Public Partial Class ctrCustomer
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
        Protected Sub Page_Load(sender As Object, e As EventArgs)
            Dim theNotificationSystem As NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem = New NotificationSystem.NotificationSystem.Data.Classes.clsNotificationSystem()
            Dim tblCustomer As NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable = New NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable()
            '''int customerID = m_CustomerID;

            Try
                If Equals(Request.Form("ctl00$MainContent$ctrCustomer_Search$btnSearch"), "Search") Then ctrHiddebField.Value = Convert.ToString(m_CustomerID)

                If MyBase.Page.IsPostBack And lblSearchResult.Text.Length > 0 Then
                    tblCustomer = CType(theNotificationSystem.GetCustomer(m_CustomerID), NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable)
                Else

                    tblCustomer = CType(theNotificationSystem.GetCustomers(), NotificationSystem.NotificationSystem.Data.NotificationSystem.CustomerDataTable)
                End If


                lblSearchResult.Text = tblCustomer.Rows.Count.ToString() & " Result(s)"
                grdCustomers.DataSource = tblCustomer.DefaultView
                grdCustomers.DataBind()

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



        Protected Sub grdCustomers_PageIndexChanging(sender As Object, e As GridViewPageEventArgs)
            Try
                If Not (IsNothing(MyBase.ViewState("columnname")) Or IsNothing(MyBase.ViewState("direction"))) Then
                    Dim m_DataView = CType(grdCustomers.DataSource, DataView)

                    If m_DataView Is Nothing Then
                        m_DataView.Sort = MyBase.ViewState("columnname").ToString() & " " & MyBase.ViewState("direction").ToString()
                        grdCustomers.DataSource = m_DataView
                    End If
                End If

                grdCustomers.PageIndex = e.NewPageIndex
                grdCustomers.DataBind()
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub

        Protected Sub grdCustomers_Sorting(sender As Object, e As GridViewSortEventArgs)
            Try
                Dim m_Dataview = CType(grdCustomers.DataSource, DataView)

                If m_Dataview Is Nothing Then
                    m_Dataview.Sort = e.SortExpression & " " & ConvertSortDirection(e)
                    grdCustomers.DataSource = m_Dataview
                    grdCustomers.DataBind()
                End If
            Catch __unusedException1__ As Exception
                Throw
            End Try
        End Sub
    End Class
End Namespace
