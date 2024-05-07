<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="Agent_Find_Details.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Agent_Find_Details" %>	
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
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
                          <div class="Heading" ><h2>Agents</h2></div>
                         <br/>
                            <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Width="900px" Height="300px" >
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
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Start Date:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<Telerik:RadDatePicker ID="pickStartDate" DateInput-EmptyMessage="Select" DataFormatString="{0:MM/dd/yyyy}" Width="140px" runat="server" Height="20px" MaxLength="127"></Telerik:RadDatePicker>     
                                                    </asp:TableCell>
                                                </asp:TableRow> 
                                                 <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                                </asp:TableRow> 
                              <asp:TableRow>
                                         <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                              </asp:TableRow>
                             <asp:TableRow>
                                          <asp:TableCell>Salary:</asp:TableCell>
                                          <asp:TableCell>
                                                   <telerik:RadTextBox ID="txtSalary" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                          <asp:TableCell>Title:</asp:TableCell>
                                           <asp:TableCell>
                                                  <telerik:RadTextBox ID="txttitle" runat="server" Width="200px" Height="25px" Enabled="false"></telerik:RadTextBox>
                                          </asp:TableCell>
                                           <asp:TableCell>&nbsp;&nbsp;</asp:TableCell> <asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
                                         
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
                                           <asp:TableCell>Phone:</asp:TableCell>
                                           <asp:TableCell>
                                               <telerik:RadMaskedTextBox ID="txtPhoneNumber" style="padding-left:10px;  color:GrayText" RenderMode="Lightweight" Runat="server" Mask="(###)###-####" Width="200px" Height="25px" Enabled="false" >
                                               </telerik:RadMaskedTextBox>
                                          </asp:TableCell>
                                           <asp:TableCell>Fax:</asp:TableCell>
                                           <asp:TableCell>
                                                <telerik:RadMaskedTextBox ID="txtFaxNumber" style="padding-left:10px;  color:GrayText" RenderMode="Lightweight" Runat="server" Mask="(###)###-####" Width="200px" Height="25px" Enabled="false">
                                               </telerik:RadMaskedTextBox>
                                          </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;</asp:TableCell><asp:TableCell>&nbsp;&nbsp;</asp:TableCell>
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

