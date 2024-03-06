<%@ Page Title="Customer Management" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeFile="CustomerMgt.aspx.cs" Inherits="CustomerMgt" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
     <div class="container">
      <div class="row">
         <div class="col-md-6">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Customer Details</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img src="images/person1.png" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr/>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Customer ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Customer ID"></asp:TextBox>
                              <asp:LinkButton class="btn btn-primary" ID="LinkButton4" runat="server"><i class="fas fa-check-circle"></i></asp:LinkButton>
                               <asp:Button class="btn btn-primary" ID="Button1" runat="server" Width="150px" Height="25px" style="color: #ffffff; background-color: #0000ff; border: medium solid #C0C0C0" Text="Go" />
                           </div>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Full Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Full Name" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Ticket Status</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control mr-1" ID="TextBox7" runat="server" placeholder="Ticket Status" ReadOnly="True"></asp:TextBox>
                              <asp:LinkButton class="btn btn-success mr-1" ID="LinkButton1" runat="server"><i class="fas fa-check-circle"></i></asp:LinkButton>
                              <asp:LinkButton class="btn btn-warning mr-1" ID="LinkButton2" runat="server"><i class="far fa-pause-circle"></i></asp:LinkButton>
                              <asp:LinkButton class="btn btn-danger mr-1" ID="LinkButton3" runat="server"><i class="fas fa-times-circle"></i></asp:LinkButton>
                               
                           </div>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-3">
                        <label>Agent Assigned</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="Agent" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-3">
                        <label>Phone Number</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Phone Number" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-3">
                        <label>Email </label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Email" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-6">
                        <label>Full Postal Address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Full Postal Address" TextMode="MultiLine" Rows="2" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                     <div class="col-md-3">
                        <label>City</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="City" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     
                    <div class="row">
                     <div class="col-md-3">
                        <label>State</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="State" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  
                  <div class="row">
                        <div class="col-4 mx-auto">
                     <telerik:cardseparatorcomponent runat="server"></telerik:cardseparatorcomponent>
                         <telerik:cardactionscontainercomponent runat="server" CardActionsAlignment="Stretched" Orientation="Vertical">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Width="150px" Height="25px" style="color: #ffffff; background-color: #009900; border: medium solid #e6ffe6" Text="Add" />
     
                        <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Width="150px" Height="25px" style="color: #ffffff; background-color: #c0c0c0; border: medium solid #000000" Text="Update" />
                                 
                        <asp:Button ID="Button4" class="btn btn-lg btn-block btn-danger" runat="server" Width="150px" Height="25px" style="color: #ffffff; background-color: #4800ff; border: medium solid #ffeef3" Text="Delete" />
                     
                         </telerik:cardactionscontainercomponent>
                     </div>   
                  </div>
               </div>
            </div>
            <a href="Default.aspx"><< Back to Home</a><br/>
            <br/>
         </div>
         <div class="col-md-4">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Customer List</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr/>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"></asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
    </asp:Content>
