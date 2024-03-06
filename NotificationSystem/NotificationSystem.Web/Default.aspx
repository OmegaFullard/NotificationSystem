<%@ Page Title="Home" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Default" %>


<asp:Content ID="Content0" ContentPlaceHolderID="head" Runat="Server">
    <link href="styles/default.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   
                        <h1>Welcome to Royal City Help Desk</h1>
                        <h2>Submit a Trouble Ticket:
                            <asp:Button runat="server" ID="btn1" Text="Fill Out Request" ButtonType="SkinnedButton" Skin="WebBlue" NavigateUrl="~/TicketReq.aspx"></asp:Button>
                        </h2>
                        
</asp:Content>


          
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <PageLayout runat="server" ID="Content1">
        <Rows>
            <LayoutRow>
                <Columns>
                    <LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        <h4>Update Coming Soon!!</h4>
                        <p><strong>Please stay tuned for site updates</strong></p>
                       
                        
                    </LayoutColumn>

                    <LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        <h4>Royal City's on Social Media</h4>
                        <p><strong>Please be sure to follow us on Social Media!</strong>, links to social media websites</p>

                        <p>Leave us a review and let us how we are doing and how we can improve. </p>
                        <asp:Button runat="server" ID="btn2" Text="Reviews" ButtonType="SkinnedButton"></asp:Button>
                    </LayoutColumn>

                    <LayoutColumn Span="4" SpanMd="12" SpanSm="12" HiddenXs="true">
                        <h4>Directions</h4>
                        <p><strong>Directions to Our Help Desk Center</strong>, add details here</p>

                        <p>Available throughout the U.S 24/7</p>
                        <asp:Button runat="server" ID="btn3" Text="Directions" ButtonType="SkinnedButton"></asp:Button>
                        <br />
                    </LayoutColumn>
                </Columns>
            </LayoutRow>
        </Rows>
    </PageLayout>
</asp:Content>
