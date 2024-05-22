<%@ Page Title="Account Login" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeBehind="Logins.aspx.cs" Inherits="Logins" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
  
       <link href="styles/default.css" rel="stylesheet" />
</asp:Content>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    
     
    <telerik:RadCard ID="RadCard1" runat="server" Width="285px">
       
    <telerik:CardImageComponent runat="server" src="images/Employee.png"></telerik:CardImageComponent>

    <telerik:CardBodyComponent runat="server">
        <telerik:CardTitleComponent runat="server">
            <center><b>Agent Account Login</b></center>   
            <br />
    
        </telerik:CardTitleComponent>
        <div class="demo-containers">
        <div class="demo-container">
        <telerik:RadTextBox ID="RadTextBox1" RenderMode="Lightweight" Width="245px" runat="server" Label="Agent ID: "
                EmptyMessage="Agent ID" InvalidStyleDuration="100"></telerik:RadTextBox>
        
               <br />
                <br />
            </div>
            <center>
        <div class="demo-container">
        <telerik:RadTextBox RenderMode="Lightweight" Width="245px"  ID="RadTextBox2" runat="server" TextMode="Password" Label="Password: "  
                placeholder="Password" InvalidStyleDuration="100"></telerik:RadTextBox>
             </div>
            </div>
        
    </telerik:CardBodyComponent>
        
    <telerik:CardActionsContainerComponent runat="server" Orientation="Vertical" CardActionsAlignment="Stretched">
         <telerik:CardSeparatorComponent runat="server">
        <span class="k-button k-solid k-success" style="color: #ffffff; background-color: #009900; border: medium solid #e6ffe6">Login</span>
  <span class="k-button k-solid k-success" style="color: #ffffff; background-color: #884dff; border: medium solid #f0f0f5"><asp:HyperLink ID="DynamicHyperLink1" runat="server" NavigateUrl="~/UserRegistration.aspx">Sign Up</asp:HyperLink></span>
         
                </telerik:CardSeparatorComponent>

    </telerik:CardActionsContainerComponent>
       
     
     
             
        
    <telerik:CardFooterComponent runat="server">
            <a href="Default.aspx"><< Back to Home</a>
        <br />
        <br />
    </telerik:CardFooterComponent>
</telerik:RadCard>

    
</asp:Content>


