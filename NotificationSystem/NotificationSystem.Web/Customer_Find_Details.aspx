<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer_Find_Details.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Customer_Find_Details" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detailed Form</title>
    <link href="/Styles/base.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" style="background:rgba(236, 236, 236, 1);">


                           <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                         <div style="padding-left:5px; padding-top:5px; padding-bottom:5px;">
						  <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#b6b7bc">   
						  </div>
                          <div class="Heading" ><h2>Customers</h2></div>
                         <br/>
						 
						 <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Width="900px" Height="300px" >
						 
						       <asp:TableRow>
                                        <asp:TableCell>Customer ID:</asp:TableCell>
                                         <asp:TableCell> 
                                              <telerik:RadTextBox ID="txtCustomerID" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                         </asp:TableCell>
                                          </asp:TableRow>
                                <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                             <asp:TableRow>
                                         <asp:TableCell>First Name:</asp:TableCell>
                                          <asp:TableCell > 
                                                  <telerik:RadTextBox ID="txtfirstname" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> 
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                             </asp:TableRow>
							 
							 
							 <asp:TableRow>
                                         <asp:TableCell>Last Name:</asp:TableCell>
                                          <asp:TableCell > 
                                                  <telerik:RadTextBox ID="txtlastname" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> 
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                             </asp:TableRow>
							 
													 
							 
							  <asp:TableRow>
                                         <asp:TableCell>Address:</asp:TableCell>
                                          <asp:TableCell > 
                                                  <telerik:RadTextBox ID="txtaddress" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> 
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                             </asp:TableRow>
							 
							 
							 <asp:TableRow>
                                         <asp:TableCell>City:</asp:TableCell>
                                          <asp:TableCell > 
                                                  <telerik:RadTextBox ID="txtcity" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> 
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                             </asp:TableRow>
							 
							 
							  <asp:TableRow>
                                         <asp:TableCell>State:</asp:TableCell>
                                          <asp:TableCell > 
                                                  <telerik:RadTextBox ID="txtstate" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> 
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                             </asp:TableRow>
							 
							 
							 <asp:TableRow>
                                         <asp:TableCell>Zip:</asp:TableCell>
                                          <asp:TableCell > 
                                                  <telerik:RadTextBox ID="txtzip" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> 
                                        <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                             </asp:TableRow>
							 													 
				
							
                              <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                              </asp:TableRow>
							  
							  
							  
							        <asp:TableRow>
                                        <asp:TableCell>Agent ID:</asp:TableCell>
                                         <asp:TableCell> 
                                              <telerik:RadTextBox ID="txtAgentID" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                         </asp:TableCell>
                                          </asp:TableRow>
                                <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                             <asp:TableRow>
                                          <asp:TableCell>Ticket:</asp:TableCell>
                                          <asp:TableCell>
                                                   <telerik:RadTextBox ID="txttroubleticketno" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                
                              </asp:TableRow>
                              <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                              </asp:TableRow>
                              
                              <asp:TableRow>
                                           <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                         
                               <asp:TableRow>
                                           <asp:TableCell>Phone:</asp:TableCell>
                                           <asp:TableCell>
                                               <telerik:RadMaskedTextBox ID="txtPhoneNumber" style="padding-left:10px;  color:GrayText" RenderMode="Lightweight" Runat="server" Mask="(###)###-####" Width="200px" Height="25px" Enabled="false" >
                                               </telerik:RadMaskedTextBox>
                                          </asp:TableCell>
         </asp:TableRow>
                              <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
							   
                               <asp:TableRow>
                               
                                          <asp:TableCell>Email1:</asp:TableCell>
                                          <asp:TableCell>
                                                 <telerik:RadTextBox ID="txtEmailAddress" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                         </asp:TableCell>
                               </asp:TableRow>
                                <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                               </asp:TableRow>
                            
                                 
                             
                         </asp:Table>
                  </div>
    </form>
</body>
</html>
