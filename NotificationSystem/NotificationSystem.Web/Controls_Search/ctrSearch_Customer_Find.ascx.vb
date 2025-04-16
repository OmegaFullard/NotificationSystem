Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_Customer_Find
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
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not IsPostBack Then
                ' Initialize the control here if needed
            End If

        End Sub

        Public Sub PopulateSearchControl()
            m_CustomerID = Integer.Parse(txtCustomerID.Text)
        End Sub
    End Class
End Namespace
