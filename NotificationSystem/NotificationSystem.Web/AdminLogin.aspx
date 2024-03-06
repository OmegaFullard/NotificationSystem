<%@ Page Title="Admin Login" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="AdminLogin.aspx.cs" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <telerik:RadCard ID="RadCard1" runat="server" Width="285px">
       
    <telerik:CardImageComponent runat="server" src="images/adminuser.png"></telerik:CardImageComponent>

    <telerik:CardBodyComponent runat="server">
        <telerik:CardTitleComponent runat="server">
            <center><b>Admin Login</b></center>   
            <br />
    
        </telerik:CardTitleComponent>
        <div class="demo-containers">
        <div class="demo-container">
        <telerik:RadTextBox ID="RadTextBox1" RenderMode="Lightweight" Width="245px" runat="server" Label="Admin ID: "
                EmptyMessage="Admin ID" InvalidStyleDuration="100"></telerik:RadTextBox>
        
               <br />
                <br />
            </div>
        <div class="demo-container">
        <telerik:RadTextBox RenderMode="Lightweight" Width="245px"  ID="RadTextBox2" runat="server" TextMode="Password" Label="Password: "  
                placeholder="Password" InvalidStyleDuration="100"></telerik:RadTextBox>
             </div>
            </div>
    </telerik:CardBodyComponent>
         
    <telerik:CardActionsContainerComponent runat="server" CardActionsAlignment="Stretched">
        <span class="k-button k-solid k-success" style="color: #ffffff; background-color: #009900; border: medium solid #e6ffe6">Login</span>
        <telerik:CardSeparatorComponent runat="server" Orientation="Vertical">
        </telerik:CardSeparatorComponent>
    
    </telerik:CardActionsContainerComponent>

    <telerik:CardFooterComponent runat="server">
            <a href="Default.aspx"><< Back to Home</a>
        <br />
        <br />
    </telerik:CardFooterComponent>
</telerik:RadCard>

</asp:Content>
