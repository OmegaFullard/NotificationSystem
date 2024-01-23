<%@ Page Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeBehind="Agent.aspx.cs" Inherits="Agent" %>

<%@ Register Src="ctrAgent.ascx" TagPrefix="uc1" TagName="ctrAgent" %>
<%@ Register Src="Controls_Search/ctrAgent_Search.ascx" TagPrefix="uc1" TagName="ctrAgent_Search" %>


<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
 
    
                       <title>Agents</title>
    </asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">

    
                   <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="techbg" runat="server" ImageUrl="~/images/techbg.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="80px" style="margin-top: 5px" Width="80px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrAgent_Search runat="server" ID="ctrAgent_Search" /></asp:TableCell>
                                    </asp:TableRow>
                             
                         </asp:Table>
                  <br />
               
              <uc1:ctrAgent runat="server" id="ctrAgent" />

    </asp:Content>

           
