﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Agent_Delete.aspx.cs" MasterPageFile="MasterPage.master" Inherits="NotificationSystem.NotificationSystem.Web.Agent_Delete" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="Controls_Search/ctrAgent_Search.ascx" TagPrefix="uc1" TagName="ctrAgent_Search" %>
<%@ Register Src="Controls_Delete/ctrAgent_Delete.ascx" TagPrefix="uc1" TagName="ctrAgent_Delete" %>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceholder1">
              <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#b6b7bc">    
                     <h2>Delete Agent</h2><br />

                       <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >

 <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="agent" runat="server" ImageUrl="images/person1.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="100px" style="margin-top: 5px" Width="100px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                           <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrAgent_Search runat="server" id="ctrAgent_Search" Visible="false" /></asp:TableCell>
                                                 
                                    </asp:TableRow>
                         </asp:Table>
                  <br />

<uc1:ctrAgent_Delete runat="server" id="ctrAgent_Delete" />

                     </div>                  
                
    </asp:Content>