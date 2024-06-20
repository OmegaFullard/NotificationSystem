using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

	public class clsNotificationSystem_Web
	{
        public void SendMailMessage(string theNotification)
        {

        //syntax error My.Settings?
        //    try
        //    {
        //        string to = My.Settings.EmailTo;
        //        string cc = string.Empty;

        //        MailMessage mMailMessage = new MailMessage();

        //        mMailMessage.From = new MailAddress(My.Settings.EmailFrom);   // Set the sender address of the mail message
        //        mMailMessage.To.Add(to);  // Set the recepient address of the mail message

        //        // Check If the bcc value Is null Or an empty string
        //        if ((My.Settings.EmailBcc != null/* TODO Change to default(_) if this is not a reference type */) && (My.Settings.EmailBcc != string.Empty))
        //            // Set the Bcc address of the mail message
        //            mMailMessage.Bcc.Add(new MailAddress(My.Settings.EmailBcc));

        //        if ((My.Settings.EmailCc != null/* TODO Change to default(_) if this is not a reference type */) && (My.Settings.EmailCc != string.Empty))
        //            // Set the CC address of the mail message
        //            mMailMessage.CC.Add(cc);

        //        mMailMessage.Subject = My.Settings.EmailSubject;  // Set the subject of the mail message"
        //        mMailMessage.Body = theNotification;  // Set the body of the mail message
        //        mMailMessage.IsBodyHtml = true;  // Set the format of the mail message body as HTML
        //        mMailMessage.Priority = MailPriority.Normal; // Set the priority of the mail message to normal

        //        SmtpClient mSmtpClient = new SmtpClient(My.Settings.SmtpServerID); // Instantiate a new instance of SmtpClient

        //        mSmtpClient.Send(mMailMessage); // Send the mail message

        //        mMailMessage.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        }
    }
