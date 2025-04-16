
Namespace NotificationSystem.NotificationSystem.Data.Classes
    Public Class clsStatusList

        Private m_Status As String = String.Empty
        Private m_TroubleTicketNo As Integer = 0

        Public Property Status As String
            Get
                Return m_Status
            End Get
            Set(value As String)
                m_Status = value
            End Set
        End Property

        Public Property TroubleTicketNo As Integer
            Get
                Return m_TroubleTicketNo
            End Get
            Set(value As Integer)
                m_TroubleTicketNo = value
            End Set
        End Property

    End Class
End Namespace
