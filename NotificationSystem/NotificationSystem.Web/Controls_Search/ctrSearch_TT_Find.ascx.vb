Imports System
Imports System.Web.UI

Namespace NotificationSystem.NotificationSystem.Web.Controls_Search
    Public Partial Class ctrSearch_TT_Find
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
        Protected Sub Page_Load(sender As Object, e As EventArgs)

        End Sub

        Public Sub PopulateSearchControl()
            m_TroubleTicketNo = Integer.Parse(txttroubleticketno.Text)
        End Sub
    End Class
End Namespace
