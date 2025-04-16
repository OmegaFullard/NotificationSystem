Imports System
Imports System.Net.Mail
Public Class clsNotificationSystem_Web
    Public Sub SendMailMessage(theNotification As String)


        Try
            ' Use ConfigurationManager.AppSettings to retrieve settings instead of My.Settings
            Dim [to] = System.Configuration.ConfigurationManager.AppSettings("EmailTo")
            Dim cc = System.Configuration.ConfigurationManager.AppSettings("EmailCc")
            Dim bcc = System.Configuration.ConfigurationManager.AppSettings("EmailBcc")
            Dim emailFrom = System.Configuration.ConfigurationManager.AppSettings("EmailFrom")
            Dim emailSubject = System.Configuration.ConfigurationManager.AppSettings("EmailSubject")
            Dim smtpServerID = System.Configuration.ConfigurationManager.AppSettings("SmtpServerID")

            Dim mMailMessage = New MailMessage()

            mMailMessage.From = New MailAddress(emailFrom)   ' Set the sender address of the mail message
            mMailMessage.To.Add([to])  ' Set the recipient address of the mail message

            ' Check if the bcc value is null or an empty string
            If Not String.IsNullOrEmpty(bcc) Then
                ' Set the Bcc address of the mail message
                mMailMessage.Bcc.Add(New MailAddress(bcc))
            End If

            ' Check if the cc value is null or an empty value
            If Not String.IsNullOrEmpty(cc) Then
                ' Set the CC address of the mail message
                mMailMessage.CC.Add(cc)
            End If

            mMailMessage.Subject = emailSubject  ' Set the subject of the mail message
            mMailMessage.Body = theNotification  ' Set the body of the mail message
            mMailMessage.IsBodyHtml = True  ' Set the format of the mail message body as HTML
            mMailMessage.Priority = MailPriority.Normal ' Set the priority of the mail message to normal

            Dim mSmtpClient = New SmtpClient(smtpServerID) ' Instantiate a new instance of SmtpClient

            mSmtpClient.Send(mMailMessage) ' Send the mail message

            mMailMessage.Dispose()

        Catch ex As Exception
            ' Handle exception (optional logging or rethrow)
        End Try
    End Sub
End Class
