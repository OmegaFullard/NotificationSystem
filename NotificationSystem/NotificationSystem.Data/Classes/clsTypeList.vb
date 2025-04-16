
Namespace NotificationSystem.NotificationSystem.Data.Classes
    Public Class clsTypeList

        Private m_Type As String = String.Empty
        Private m_TroubleTicketNo As Integer = 0


        Public Property Type As String
            Get
                Return m_Type
            End Get
            Set(value As String)
                m_Type = value
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
