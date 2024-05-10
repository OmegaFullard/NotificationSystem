<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrSearch_Customer_Update.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Controls_Search.ctrSearch_Customer_Update" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>


    
                       <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                             <asp:TableRow>
                                     
                                         <asp:TableCell VerticalAlign="Top">
                                               <telerik:RadMultiColumnComboBox    runat="server" ClearButton="false" ClientEvents-OnLoad="OnClientLoad0" ID="cmbCustomer" DropDownWidth="300px"  Height="200px" Width="180px" AutoPostBack="true"
                                                       Placeholder="--Select" EnableViewState="true">
                                                <ColumnsCollection> 
                                                      <telerik:MultiColumnComboBoxColumn Field="CustomerID" Title="CustomerID" Width="150px" />
                                                      <telerik:MultiColumnComboBoxColumn Field="FirstN" Title="FirstN" Width="75px" />
                                                </ColumnsCollection></telerik:RadMultiColumnComboBox> &nbsp;&nbsp;&nbsp
                                        </asp:TableCell>
                              </asp:TableRow>
                           
                               
                 </asp:Table>