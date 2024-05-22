<%@ Page Title="Ticket Details" Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="TicketDetails.aspx.cs" Inherits="TicketDetails" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">  
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">

    <div class="row">
                     <div class="col">
                        <center>
                           <h4>Ticket Details</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                         <img src="images/techbanner.png" />
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
                        <label>Trouble Ticket Number</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Trouble Ticket Number" ReadOnly="False"></asp:TextBox>
                        </div>
                     </div>
                     
                  <div class="row">
                     <div class="col-md-6">
                        <label>Request Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Request Date"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Due Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Due Date"></asp:TextBox>
                        </div>
                     </div>
                  </div>
     <br />
  
                  <div class="row">
                     <div class="col-6">
                         <asp:Button ID="Button2" class="btn btn-lg btn-block btn-primary" runat="server" Width="150px" Height="25px" Style="color: #ffffff; background-color: #0000ff; border: medium solid #e6ffe6" Text="Search Invoice" />
                     </div>
                     
                  </div>
        <br />
              
            <a href="Default.aspx"><< Back to Home</a><br/>
            <br/>
         </div>
    <div class="row">
                     <div class="col">
                         <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TroubleTicketNo" DataSourceID="SqlDataSource1" EnableModelValidation="True">
                             <Columns>
                                 <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID"></asp:BoundField>
                                 <asp:BoundField DataField="AgentID" HeaderText="AgentID" SortExpression="AgentID"></asp:BoundField>
                                 <asp:BoundField DataField="TroubleTicketNo" HeaderText="TroubleTicketNo" SortExpression="TroubleTicketNo" InsertVisible="False" ReadOnly="True"></asp:BoundField>
                                 <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"></asp:BoundField>
                                 <asp:BoundField DataField="DueDate" HeaderText="DueDate" SortExpression="DueDate"></asp:BoundField>
                                 <asp:BoundField DataField="RequestDate" HeaderText="RequestDate" SortExpression="RequestDate"></asp:BoundField>
                             </Columns>
                         </asp:GridView>
                         <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:NotificationSystemConnectionString %>' SelectCommand="SELECT * FROM [TroubleTicketReq] WHERE ([TroubleTicketNo] = @TroubleTicketNumber)">
                             <SelectParameters>
                                 <asp:ControlParameter ControlID="TextBox3" PropertyName="Text" Name="TroubleTicketNumber"></asp:ControlParameter>
                             </SelectParameters>
                         </asp:SqlDataSource>
                     </div>
        </div>

</asp:Content>