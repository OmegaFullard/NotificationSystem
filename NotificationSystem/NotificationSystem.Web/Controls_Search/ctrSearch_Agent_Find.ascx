<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrSearch_Agent_Find.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Controls_Search.ctrSearch_Agent_Find" %>
<asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
                        You can use a partial Agent ID in your search
                       <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                             <asp:TableRow>
                                          <asp:TableCell>Agent:&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>
                                               <asp:TextBox ID="txtAgentName" runat="server" Width="180"></asp:TextBox>
                                           </asp:TableCell>
                              </asp:TableRow>
                             <asp:TableRow>
                                          <asp:TableCell>&nbsp;</asp:TableCell>
                                         <asp:TableCell VerticalAlign="Top">
                                               <asp:Button ID="btnSearch" runat="server" Text="Search" Width="180" />
                                        </asp:TableCell>
                              </asp:TableRow>
                         </asp:Table>
