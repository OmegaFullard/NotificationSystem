Imports System
Imports System.Web.UI

Public Partial Class ctrTroubleTicketReq_Search
    Inherits UserControl

    Private m_TroubleTicketNo As Integer = 0

    Public Property TroubleTicketNo As Integer
        Get
            Return m_TroubleTicketNo
        End Get
        Set(value As Integer)
            m_TroubleTicketNo = value
        End Set
    End Property
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' Initialize controls or load data if necessary
        End If

    End Sub

    Public Sub PopulateSearchControl()
        m_TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
    End Sub
End Class
