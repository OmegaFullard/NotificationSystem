<%@ Page Title="Agent Management" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeFile="AgentMgt.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.AgentMgt" %>

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
                                        <h4>Agent Details</h4>
                                    </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                 
                                    <asp:Image ID="agent" runat="server" ImageUrl="images/person1.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="250px" style="margin-top: 5px" Width="250px" />
                                       
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
                                <label>Agent ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="ID"></asp:TextBox>
                                        
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                        
                                        <asp:Button class="btn btn-primary" ID="Button1" runat="server" Width="150px" Height="25px" style="color: #ffffff; background-color: #0000ff; border: medium solid #C0C0C0" Text="Go" />
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-8">
                                <label>Agent Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Agent Name"></asp:TextBox>

                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-4 mx-auto">
                               <div class="card" style="width: 18rem;">
                                <div class="card-body">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Width="150px" Height="25px" style="color: #ffffff; background-color: #009900; border: medium solid #e6ffe6" Text="Add" />
                
                        &nbsp;&nbsp;&nbsp;&nbsp;
                
                        <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Width="150px" Height="25px" style="color: #ffffff; background-color: #c0c0c0; border: medium solid #000000" Text="Update" />
                    
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    
                        <asp:Button ID="Button4" class="btn btn-lg btn-block btn-danger" runat="server" Width="150px" Height="25px" style="color: #ffffff; background-color: #4800ff; border: medium solid #ffeef3" Text="Delete" />
                     
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



                        <div class="row">
                            <div class="col">
                                <center>
                                        <h4>Agent List</h4>
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
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="AgentID" DataSourceID="SqlDataSource1" EnableModelValidation="True">
                                    <Columns>
                                        <asp:BoundField DataField="AgentID" HeaderText="AgentID" SortExpression="AgentID" InsertVisible="False" ReadOnly="True"></asp:BoundField>
                                        <asp:BoundField DataField="TroubleTicketNo" HeaderText="TroubleTicketNo" SortExpression="TroubleTicketNo"></asp:BoundField>
                                        <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title"></asp:BoundField>
                                        <asp:BoundField DataField="StartDate" HeaderText="StartDate" SortExpression="StartDate"></asp:BoundField>
                                        <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary"></asp:BoundField>
                                        <asp:BoundField DataField="FirstN" HeaderText="FirstN" SortExpression="FirstN"></asp:BoundField>
                                        <asp:BoundField DataField="LastN" HeaderText="LastN" SortExpression="LastN"></asp:BoundField>
                                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email"></asp:BoundField>
                                        <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone"></asp:BoundField>
                                        <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax"></asp:BoundField>
                                    </Columns>
                                </asp:GridView>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:NotificationSystemConnectionString %>' SelectCommand="SELECT AgentID, TroubleTicketNo, Title, StartDate, Salary, FirstN, LastN, Email, Phone, Fax FROM Agent WHERE (AgentID = @AgentID)">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="TextBox1" PropertyName="Text" Name="AgentID"></asp:ControlParameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </div>
                        </div>


                    </div>
                </div>


            </div>

        </div>
    </div>

    </asp:Content>