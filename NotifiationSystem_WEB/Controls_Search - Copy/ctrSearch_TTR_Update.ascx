<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ctrSearch_TTR_Update.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Controls_Search.ctrSearch_TTR_Update" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>


    
                       <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                             <asp:TableRow>
                                     
                                         <asp:TableCell VerticalAlign="Top">
                                               <telerik:RadMultiColumnComboBox    runat="server" ClearButton="false" ClientEvents-OnLoad="OnClientLoad0" ID="cmbStatus" DropDownWidth="300px"  Height="200px" Width="180px" AutoPostBack="true"
                                                       Placeholder="--Select" EnableViewState="true">
                                                <ColumnsCollection> 
                                                      <telerik:MultiColumnComboBoxColumn Field="Status" Title="Open" Width="150px" />
                                                      <telerik:MultiColumnComboBoxColumn Field="Status" Title="Pending" Width="150px" />
                                                    <telerik:MultiColumnComboBoxColumn Field="Status" Title="Resolved" Width="150px" />
                                                    <telerik:MultiColumnComboBoxColumn Field="Status" Title="Closed" Width="150px" />
                                                </ColumnsCollection></telerik:RadMultiColumnComboBox> &nbsp;&nbsp;&nbsp
                                        </asp:TableCell>
                              </asp:TableRow>
                           
                             <asp:TableRow>
                                     
                                         <asp:TableCell VerticalAlign="Top">
                                               <telerik:RadMultiColumnComboBox    runat="server" ClearButton="false" ClientEvents-OnLoad="OnClientLoad0" ID="cmbType" DropDownWidth="300px"  Height="200px" Width="180px" AutoPostBack="true"
                                                       Placeholder="--Select" EnableViewState="true">
                                                <ColumnsCollection> 
                                                      <telerik:MultiColumnComboBoxColumn Field="Type" Title="Incident" Width="150px" />
                                                      <telerik:MultiColumnComboBoxColumn Field="Type" Title="Task" Width="150px" />
                                                    <telerik:MultiColumnComboBoxColumn Field="Type" Title="Problem" Width="150px" />
                                                </ColumnsCollection></telerik:RadMultiColumnComboBox> &nbsp;&nbsp;&nbsp
                                        </asp:TableCell>
                              </asp:TableRow>
                               
                 </asp:Table>