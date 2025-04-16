Imports System
Imports System.Web

Namespace Telerik.Web
    Public Class [Global]
        Inherits HttpApplication

        Protected Sub Application_Start(sender As Object, e As EventArgs)
            'Telerik.Reporting.Services.WebApi.ReportsControllerConfiguration.RegisterRoutes(System.Web.Http.GlobalConfiguration.Configuration);
            'Telerik.WebReportDesigner.Services.WebApi.ReportDesignerControllerConfiguration.RegisterRoutes(System.Web.Http.GlobalConfiguration.Configuration);

            'Telerik.Reporting.Services.WebApi.ReportsControllerConfiguration.RegisterRoutes(System.Web.Http.GlobalConfiguration.Configuration);
        End Sub

        Protected Sub Session_Start(sender As Object, e As EventArgs)

        End Sub

        Protected Sub Application_BeginRequest(sender As Object, e As EventArgs)

        End Sub

        Protected Sub Application_AuthenticateRequest(sender As Object, e As EventArgs)

        End Sub

        Protected Sub Application_Error(sender As Object, e As EventArgs)

        End Sub

        Protected Sub Session_End(sender As Object, e As EventArgs)

        End Sub

        Protected Sub Application_End(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace
