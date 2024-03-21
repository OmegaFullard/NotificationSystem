<%@ Page Title="Admin Login" Language="C#" AutoEventWireup="true" MasterPageFile="MasterPage.Master" CodeBehind="AdminLogin.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.AdminLogin" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>



<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container">
        <div class="row">
            <div class="col-md-6">

                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Admin Login</h4>
                                    </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                 
                                    <asp:Image ID="agent" runat="server" ImageUrl="images/admin.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="150px" style="margin-top: 5px" Width="150px" />
                                       
                                    </center>
                            </div>
                        </div>
                       
                        <div class="row">
                            <div class="col-md-6">
                                <center></center>
                                <label>Admin ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID" AutoPostBack="True" CausesValidation="True" MaxLength="10"></asp:TextBox>
                                        
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                        
                                      </div>
                                </div>
                            </div>
                            </div>
                            <div class="col-md-6">
                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" AutoPostBack="True" CausesValidation="True" MaxLength="10"></asp:TextBox>

                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-4 mx-auto">
                               <div class="card" style="width: 18rem;">
                                <div class="card-body">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Width="150px" Height="25px" style="color: #ffffff; background-color: #009900; border: medium solid #e6ffe6" Text="Login" OnClick="Button2_Click" />
                

       <br />
</div>
                                   </div>
                        </div>
                        </div>


                    </div>
                </div>
                <br />
                <a href="Default.aspx"><< Back to Home</a><br/>
                <br/>
            </div>

            <div class="col-md-7">

                <div class="card">
                    <div class="card-body">

    </div>


            </div>

        </div>
    </div>
  
    </asp:Content>


