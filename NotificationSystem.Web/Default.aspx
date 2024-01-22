<%@ Page Title="Home" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Default.aspx.cs" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" Runat="Server">
    <link href="styles/default.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <telerik:RadPageLayout runat="server" ID="RadPageLayout1">

        <Rows>
            <telerik:LayoutRow>
                <Columns>
                    <telerik:LayoutColumn CssClass="jumbotron">
                        <h1>Welcome to Royal City Help Desk</h1>
                        <h2>Submit a Trouble Ticket
                            <telerik:RadButton runat="server" ID="RadButton0" Text="Order Now" ButtonType="SkinnedButton" Skin="WebBlue" NavigateUrl="~/TicketReq.aspx"></telerik:RadButton>
                        </h2>
                        </telerik:LayoutColumn>
                    </Columns>
                </telerik:LayoutRow>
            </Rows>
        </telerik:RadPageLayout>
</asp:Content>


          
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <telerik:RadPageLayout runat="server" ID="Content1">
        <Rows>
            <telerik:LayoutRow>
                <Columns>
                    <telerik:LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        <h4>Update Coming Soon!!</h4>
                        <p><strong>Please stay tuned for site updates</strong></p>
                       
                        
                    </telerik:LayoutColumn>

                    <telerik:LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        <h4>Royal City's on Social Media</h4>
                        <p><strong>Please be sure to follow us on Social Media!</strong>, links to social media websites</p>

                        <p>Leave us a review and let us how we are doing and how we can improve. </p>
                        <telerik:RadButton runat="server" ID="RadButton2" Text="Reviews" ButtonType="SkinnedButton"></telerik:RadButton>
                    </telerik:LayoutColumn>

                    <telerik:LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        <h4>Directions</h4>
                        <p><strong>Directions to Our Help Desk Center</strong>, add details here</p>

                        <p>Available throughout the U.S 24/7</p>
                        <telerik:RadButton runat="server" ID="RadButton3" Text="Tickets" ButtonType="SkinnedButton"></telerik:RadButton>
                    </telerik:LayoutColumn>
                </Columns>
            </telerik:LayoutRow>
        </Rows>
    </telerik:RadPageLayout>
</asp:Content>
