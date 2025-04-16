Imports System
Imports System.Web.UI

Public Partial Class ctrCustomer_Search
    Inherits UserControl
    Public m_CustomerID As Integer = 0

    Public Property CustomerID As Integer
        Get
            Return m_CustomerID
        End Get
        Set(value As Integer)
            m_CustomerID = value
        End Set
    End Property
    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub

    Public Sub PopulateSearchControl()
        m_CustomerID = Integer.Parse(txtcustomerid.Text)
    End Sub
End Class
