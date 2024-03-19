<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrTroubleTicketReq_Find.ascx.cs" Inherits="ctrTroubleTicketReq_Find" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

 
 

							  
        <div> <asp:Label ID="lblTroubleTicketNo" runat="server" Text=""></asp:Label></div><br />
     <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
<div style="padding-left:5px; padding-top:5px; padding-bottom:5px">
                                <h2>Trouble Tickets</h2><br />
							  
                              
							  
							  Customer#:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<telerik:RadLabel ID="lblCustomerID" BackColor="White"  text="--" Width="145px"  runat="server"></telerik:RadLabel>&nbsp;&nbsp;&nbsp
							 Agent#:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<telerik:RadLabel ID="lblAgentID" BackColor="White"  text="--" Width="145px"  runat="server"></telerik:RadLabel>&nbsp;&nbsp;&nbsp
							 Status:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<telerik:RadLabel ID="lblStatus" BackColor="White"  text="--" Width="145px"  runat="server"></telerik:RadLabel>&nbsp;&nbsp;&nbsp
                              Due Date:&nbsp;&nbsp;<telerik:RadLabel ID="lblDueDate" BackColor="White"  text="--" Width="145px"  runat="server"></telerik:RadLabel><br /><br />
							  Request Date:&nbsp;&nbsp;<telerik:RadLabel ID="lblRequestDate" BackColor="White"  text="--" Width="145px"  runat="server"></telerik:RadLabel><br /><br /> 
                             Type:&nbsp;&nbsp;<telerik:RadLabel ID="lblType" BackColor="White" text="--"  Width="145px"  runat="server"></telerik:RadLabel> &nbsp;&nbsp;&nbsp
                              
                               
     </div>
