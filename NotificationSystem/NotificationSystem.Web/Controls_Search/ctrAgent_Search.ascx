<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrAgent_Search.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Controls_Search.ctrAgent_Search" %>

<asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
                       <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                             <asp:TableRow>
                                          <asp:TableCell>Agents:&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>
                                               <asp:TextBox ID="txtagentid" runat="server" Width="180"></asp:TextBox>
                                          </asp:TableCell>
                              </asp:TableRow>
                             <asp:TableRow>
                                          <asp:TableCell>&nbsp;</asp:TableCell>
                                         <asp:TableCell VerticalAlign="Top">
                                               <asp:Button ID="btnSearch" runat="server" Text="Search" Width="180" />
                                        </asp:TableCell>
                              </asp:TableRow>
                         </asp:Table>