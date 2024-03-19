<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrAgent_Find.ascx.cs" Inherits="ctrAgent_Find" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

 
 <div style="width: 1050px; height:800px;  overflow: auto; padding-left:30px" >

<div style="padding-left:5px; padding-top:5px; padding-bottom:5px">
                              <h2>Agents</h2><br />
                              <div> <asp:Label ID="lblAgentID" runat="server" Text=""></asp:Label></div><br />
                              Start Date:&nbsp;&nbsp;<telerik:RadLabel ID="lblStartDate" BackColor="White"  text="--" Width="145px"  runat="server"></telerik:RadLabel><br /><br />
                              Trouble Ticket#:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<telerik:RadLabel ID="lblTroubleTicketNo" BackColor="White"  text="--" Width="145px"  runat="server"></telerik:RadLabel>&nbsp;&nbsp;&nbsp
                              Title:&nbsp;&nbsp;<telerik:RadLabel ID="lblTitle" BackColor="White" text="--"  Width="145px"  runat="server"></telerik:RadLabel> &nbsp;&nbsp;&nbsp
                               Salary:&nbsp;&nbsp;<telerik:RadLabel ID="lblSalary" BackColor="White" text="--"  Width="145px"  runat="server"></telerik:RadLabel>
							   
							  First:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<telerik:RadLabel ID="lblFN" BackColor="White"  text="--" Width="145px"  runat="server"></telerik:RadLabel>&nbsp;&nbsp;&nbsp
                              Last:&nbsp;&nbsp;<telerik:RadLabel ID="lblLN" BackColor="White" text="--"  Width="145px"  runat="server"></telerik:RadLabel> &nbsp;&nbsp;&nbsp
                               
							   Email:&nbsp;&nbsp;<telerik:RadLabel ID="lblEmail" BackColor="White" text="--"  Width="145px"  runat="server"></telerik:RadLabel>							   
							 Phone#:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<telerik:RadLabel ID="lblPhone" BackColor="White"  text="--" Width="145px"  runat="server"></telerik:RadLabel>&nbsp;&nbsp;&nbsp
                              Fax#:&nbsp;&nbsp;<telerik:RadLabel ID="lblFax" BackColor="White" text="--"  Width="145px"  runat="server"></telerik:RadLabel> &nbsp;&nbsp;&nbsp
                               
							   
                    
                 </div>
                 

     </div>
