<%@ Page Title="User Profile" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="false" CodeBehind="UserViewProfile.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.UserViewProfile" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
      <link href="styles/default.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">

    <div class="container-fluid">

      <div class="row">
         <div class="col-md-12">
            <div class="card">
               <div class="card-body">
                  </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                     
                          <asp:Image ID="users" runat="server" ImageUrl="images/handshake.png" BorderStyle="Solid" BorderWidth="1px" Height="250px" style="margin-top: 0px" Width="350px" />
                        </center>
                     </div>
                      <div class="row">
                     <div class="col">
                        <center>
                           <h4>Customer Details</h4>
                            <span>Account Status - </span>
                            <asp:Label CssClass="badge badge-pill badge-info" ID="Label1" runat="server" Text="Active"></asp:Label>
                        </center>
                     </div>
                  </div>
                      </div>

             
                  <div class="row">
                     <div class="col-md-4">
                        <label>Customer ID</label>
  
                         <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Customer ID" ReadOnly="True"></asp:TextBox>
                             </div>
                         </div>
                       <div class="col-md-4">
                             <label>Password</label>
                             <div class="form-group">
                                 <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Email-ID" TextMode="Password" ReadOnly="False"></asp:TextBox>
                             </div>
                              </div>

                      <br />
                        <br />
                              <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Width="150px" Height="35px" style="color: #ffffff; background-color: #009900; border: medium solid #e6ffe6" Text="Login" CommandArgument="&quot;SELECT UserName FROM Customer WHERE Username = @UserName and Password=@Password&quot;;" CommandName="LoginName" />
                           <br />
                            </div>
  
                  </div>
                 
               
                        
                         </div>
          <br />
          <br />
               
            <a href="Default.aspx"><< Back to Home</a><br />
            <br/>
      
               </div>
</asp:Content>
