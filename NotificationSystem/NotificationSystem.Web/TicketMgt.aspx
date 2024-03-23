<%@ Page Title="Ticket Request" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true"  CodeBehind="TicketMgt.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.TicketMgt" %>

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
                           <h4>Ticket Request</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                          <asp:Image ID="Issues" runat="server" ImageUrl="images/issue1.png" BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" style="margin-top: 5px" Width="800px" Height="400px"/>
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
                        <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Agent ID</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Agent ID"></asp:TextBox>
                              <asp:LinkButton class="btn btn-primary" ID="LinkButton4" runat="server"><i class="fas fa-check-circle"></i></asp:LinkButton>
                               <asp:Button class="btn btn-primary" ID="Button1" runat="server" Width="150px" Height="25px" style="color: #ffffff; background-color: #0000ff; border: medium solid #e6ecff" Text="Go" />
                           </div>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Ticket Number</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Ticket Number"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                    <div class="row">
                     <div class="col-md-4">
                     <label>Type</label>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList2" runat="server">
                              <asp:ListItem Text="Incident" Value="Incident" />   
                              <asp:ListItem Text="Task" Value="Task" />
                               <asp:ListItem Text="Problem" Value="Problem" />
                           </asp:DropDownList>
                        </div>
                 
                        <label>Language</label>
                        <div class="form-group">
                           <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                              <asp:ListItem Text="English" Value="English" />
							   <asp:ListItem Text="French" Value="French" />
                              <asp:ListItem Text="German" Value="German" />
                              <asp:ListItem Text="Hindi" Value="Hindi" />
                              <asp:ListItem Text="Mandarin" Value="Mandarin" />
                              <asp:ListItem Text="Spanish" Value="Spanish" />
                             
                           </asp:DropDownList>
                        </div>
                      </div>
                     </div>                   
                        </div>
                                   
                 
                  <div class="row">
                     <div class="col-8 mx-auto">
                    <telerik:cardseparatorcomponent runat="server"></telerik:cardseparatorcomponent>
                         <telerik:cardactionscontainercomponent runat="server" CardActionsAlignment="Stretched" Orientation="Vertical">
                        
                             <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Width="150px" Height="25px" Style="color: #ffffff; background-color: #009900; border: medium solid #e6ffe6" Text="Add" />
            
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
         <div class="col-md-6">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Ticket List</h4>
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
                         <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#D1E0E0" DataKeyNames="TroubleTicketNo">
                             <Columns>
                                 <asp:BoundField DataField="AgentID" HeaderText="AgentID" SortExpression="AgentID"></asp:BoundField>
                                 <asp:BoundField DataField="TroubleTicketNo" HeaderText="TroubleTicketNo" SortExpression="TroubleTicketNo" InsertVisible="False" ReadOnly="True"></asp:BoundField>
                                 <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"></asp:BoundField>
                                 <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                             </Columns>
                         </asp:GridView>
                         <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:NotificationSystemConnectionString1 %>' SelectCommand="SELECT [AgentID], [TroubleTicketNo], [Status], [Type] FROM [TroubleTicketReq]">
                         </asp:SqlDataSource>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   
    </asp:Content>