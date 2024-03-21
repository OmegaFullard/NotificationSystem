<%@ Page Title="Ticket Details" Language="C#" AutoEventWireup="true" MasterPageFile="MasterPage.Master" CodeBehind="TicketDetails.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.TicketDetails" %>

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
   
                  <div class="col-md-7">
                      <div class="card">
                          <div class="card-body">
                     <div class="row">
                         <div class="col">
                             <center>
                      <asp:Image ID="issue2" runat="server" ImageUrl="images/issue2.png" BorderStyle="Solid" BorderWidth="1px" Height="250px" style="margin-top: 0px" Width="350px" />
                      </center>
                             </div>
                 </div>
    </div>
                          </div>
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
                         <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="AgentID" DataSourceID="SqlDataSource1">
                             <Columns>
                                 <asp:BoundField DataField="AgentID" HeaderText="AgentID" SortExpression="AgentID" ReadOnly="True"></asp:BoundField>
                                 <asp:BoundField DataField="TroubleTickeNo" HeaderText="TroubleTickeNo" SortExpression="TroubleTickeNo"></asp:BoundField>
                                 <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title"></asp:BoundField>
                                 <asp:BoundField DataField="StartDate" HeaderText="StartDate" SortExpression="StartDate"></asp:BoundField>
                                 <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary"></asp:BoundField>
                                 <asp:BoundField DataField="FirstN" HeaderText="FirstN" SortExpression="FirstN"></asp:BoundField>
                                 <asp:BoundField DataField="LastN" HeaderText="LastN" SortExpression="LastN" />
                                 <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                 <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                                 <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" />
                             </Columns>
                         </asp:GridView>
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NotificationSystemConnectionString1 %>" SelectCommand="SELECT * FROM [Agent] WHERE ([TroubleTickeNo] = @TroubleTickeNo)">
                             <SelectParameters>
                                 <asp:ControlParameter ControlID="TextBox3" Name="TroubleTickeNo" PropertyName="Text" Type="Int32" ></asp:ControlParameter>
                             </SelectParameters>
                         </asp:SqlDataSource>
                         
                     </div>
        </div>

</asp:Content>