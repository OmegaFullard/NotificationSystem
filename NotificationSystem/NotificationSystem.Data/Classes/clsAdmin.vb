
Namespace NotificationSystem.NotificationSystem.Data.Classes
    Public Class clsAdmin
        Private m_UserName As String = String.Empty
        Private m_Password As String = String.Empty
        Private m_Email As String = String.Empty
        Private m_First As String = String.Empty
        Private m_Last As String = String.Empty

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

        Public Property First As String
            Get
                Return m_First
            End Get
            Set(value As String)
                m_First = value
            End Set
        End Property

        Public Property Last As String
            Get
                Return m_Last
            End Get
            Set(value As String)
                m_Last = value
            End Set
        End Property

        Public Property Email As String
            Get
                Return m_Email
            End Get
            Set(value As String)
                m_Email = value
            End Set
        End Property
    End Class
End Namespace
