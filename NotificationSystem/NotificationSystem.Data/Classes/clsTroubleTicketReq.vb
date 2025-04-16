


Namespace NotificationSystem.NotificationSystem.Data.Classes
    Public Class clsTroubleTicketReq
        Friend Property Original_TroubleTicketNo As Integer = 0
        Private m_Status As String = String.Empty
        Private m_Type As String = String.Empty
        Private m_CustomerID As Integer = 0
        Private m_AgentID As Integer = 0
        Private m_TroubleTicketNo As Integer = 0
        Private m_DueDate As Date
        Private m_RequestDate As Date = Date.Now

        Public Property Status As String
            Get
                Return m_Status
            End Get
            Set(value As String)
                m_Status = value
            End Set
        End Property

        Public Property Type As String
            Get
                Return m_Type
            End Get
            Set(value As String)
                m_Type = value
            End Set
        End Property
        Public Property CustomerID As Integer
            Get
                Return m_CustomerID
            End Get
            Set(value As Integer)
                m_CustomerID = value
            End Set
        End Property


        Public Property AgentID As Integer
            Get
                Return m_AgentID
            End Get
            Set(value As Integer)
                m_AgentID = value
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

        Public Property DueDate As Date
            Get
                Return m_DueDate
            End Get
            Set(value As Date)
                m_DueDate = value
            End Set
        End Property

        Public Property RequestDate As Date
            Get
                Return m_RequestDate
            End Get
            Set(value As Date)
                m_RequestDate = value
            End Set
        End Property


    End Class
End Namespace
