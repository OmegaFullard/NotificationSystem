<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ctrTroubleTicketReq_Find.ascx.cs" Inherits="ctrTroubleTicketReq_Find" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>



<div style="padding-left:5px; padding-top:5px; padding-bottom:5px">
                              <h2>Trouble Ticket</h2><br />
                              <div> <asp:Label ID="lblTroubleTicketNo" runat="server" Text=""></asp:Label></div><br />
                             Request Date:&nbsp;&nbsp;<telerik:RadLabel ID="lblRequestDate" BackColor="White"  text="--" Width="145px"  runat="server"></telerik:RadLabel><br /><br />
							 Due Date:&nbsp;&nbsp;<telerik:RadLabel ID="lblDueDate" BackColor="White"  text="--" Width="145px"  runat="server"></telerik:RadLabel><br /><br />
                              Agent ID:&nbsp;&nbsp;<telerik:RadLabel ID="lblAgentID" BackColor="White" text="--"  Width="145px"  runat="server"></telerik:RadLabel> &nbsp;&nbsp;&nbsp
                               Customer ID:&nbsp;&nbsp;<telerik:RadLabel ID="lblCustomerID" BackColor="White" text="--"  Width="145px"  runat="server"></telerik:RadLabel>
                    
                 </div>
                 
                  
