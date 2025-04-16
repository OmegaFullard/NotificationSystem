<%@ Control Language="vb" AutoEventWireup="true" CodeBehind="ctrCustomer_Delete.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Controls_Delete.ctrCustomer_Delete" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<style type="text/css">

    div.RadCalendarFastNavPopup {
        width: 105px !important;
        overflow: hidden;
    }

    table.RadCalendarMonthView_Default {
        width: 210px !important;
        margin-left: -105px;
    }

    table.RadCalendarMonthView_Default tr:nth-child(7) td.rcButtons
    {
        text-align: right !important;
    }

    .rcOkButton {
        margin-left: 20px;
    }
</style>

 

  <div style="padding-left:5px; padding-top:5px; padding-bottom:5px">
                          <div class="Heading" >Delete Customer</div>
                              <div> <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></div><br />
          
                             <asp:Table ID="Table1" runat="server" Width="930px">
                                            <asp:TableRow><asp:TableCell ColumnSpan="2"> <div style="padding-bottom:20px;"> Required fields are marked with <span style="color: red">* </span> (red asterisk).
                                                </div> </asp:TableCell>
                                            </asp:TableRow>
                                  <asp:TableRow> 
                                             <asp:TableCell HorizontalAlign="Right" Width="150px"><div class="containerText"><b>Customer ID:<span style="color: red">*</span></b></div></asp:TableCell>
                                             <asp:TableCell HorizontalAlign="Left"> 
                                             
                                              &nbsp;&nbsp; <telerik:RadTextBox ID="txtcustomerid" runat="server" Height="20px" Width="300px"  ></telerik:RadTextBox>
                                                  <asp:RequiredFieldValidator  ID="valRequiredFieldID" runat="server" ControlToValidate="txtcustomerid" ValidationGroup="Submit"  
                                             ErrorMessage="Customer ID is Required Field!"><span class="required">!</span></asp:RequiredFieldValidator>
                                             

                                                 <ajaxtoolkit:ValidatorCalloutExtender ID="Required_ID"  TargetControlID="valRequiredFieldID"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>


                                           </asp:TableCell>
                                 </asp:TableRow>
                                           <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                          </asp:TableRow> 
										  
                                           <asp:TableRow> 
                                             <asp:TableCell HorizontalAlign="Right" Width="150px"><div class="containerText"><b>First Name:<span style="color: red">*</span></b></div></asp:TableCell>
                                             <asp:TableCell HorizontalAlign="Left"> 
                                             
                                                  &nbsp;&nbsp; <telerik:RadTextBox ID="txtfirstname" runat="server" Height="20px" Width="300px"  ></telerik:RadTextBox>
                                                 <asp:RequiredFieldValidator  ID="valRequiredFieldFirstN" runat="server" ControlToValidate="txtfirstname" ValidationGroup="Submit"  
                                             ErrorMessage="First Name is Required Field!"><span class="required">!</span></asp:RequiredFieldValidator>
                                             


                                                 <ajaxtoolkit:ValidatorCalloutExtender ID="Require_FirstN"  TargetControlID="valRequiredFieldFirstN"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>
                                           </asp:TableCell>
             
                                          </asp:TableRow> 
										  <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                          </asp:TableRow> 
										  
                                           <asp:TableRow> 
                                             <asp:TableCell HorizontalAlign="Right" Width="150px"><div class="containerText"><b>Last Name:<span style="color: red">*</span></b></div></asp:TableCell>
                                             <asp:TableCell HorizontalAlign="Left"> 
                                               &nbsp;&nbsp; <telerik:RadTextBox ID="txtlastname" runat="server" Height="20px" Width="300px"  ></telerik:RadTextBox>
                                                 <asp:RequiredFieldValidator  ID="valRequiredFieldLastN" runat="server" ControlToValidate="txtlastname" ValidationGroup="Submit"  
                                             ErrorMessage="Last Name is Required Field!"><span class="required">!</span></asp:RequiredFieldValidator>

                                                  <ajaxtoolkit:ValidatorCalloutExtender ID="Require_LastN"  TargetControlID="valRequiredFieldLastN"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>
                                            
                                           </asp:TableCell>
             
                                          </asp:TableRow> 
										  
                                          <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                          </asp:TableRow> 
                                    <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">User Name:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<telerik:RadTextBox ID="txtusername" runat="server" Height="20px" Width="300px"  MaxLength="10" CausesValidation="True"></telerik:RadTextBox>     
                                                    </asp:TableCell>
                                                </asp:TableRow> 
                                   <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 

                                   <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Password:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<telerik:RadTextBox ID="txtpassword" runat="server" Height="20px" Width="300px"  MaxLength="10" CausesValidation="True"></telerik:RadTextBox>     
                                                    </asp:TableCell>
                                                </asp:TableRow> 
                                   <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow>

                                  <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Address:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<telerik:RadTextBox ID="txtaddress" runat="server" Height="20px" Width="300px"  MaxLength="127"></telerik:RadTextBox>     
                                                    </asp:TableCell>
                                                </asp:TableRow> 
                                   <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 

                                   <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">City:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<telerik:RadTextBox ID="txtcity" runat="server" Height="20px" Width="300px"  MaxLength="50"></telerik:RadTextBox>     
                                                    </asp:TableCell>
                                                </asp:TableRow> 
                                   <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 

                                
                                   <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">State:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<telerik:RadTextBox ID="txtstate" runat="server" Height="20px" Width="300px"  MaxLength="25"></telerik:RadTextBox>     
                                                    </asp:TableCell>
                                                </asp:TableRow> 
                                 <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                          </asp:TableRow> 
										  
                                   <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Zip:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<telerik:RadTextBox ID="txtzip" runat="server" Height="20px" Width="300px"  MaxLength="10"></telerik:RadTextBox>     
                                                    </asp:TableCell>
                                                </asp:TableRow> 
                                   <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 
                                   <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 

                                             <asp:TableRow>                     
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Agent ID:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                       &nbsp;&nbsp; <telerik:RadTextBox ID="txtAgentID" runat="server" Height="20px" Width="300px"  MaxLength="127"></telerik:RadTextBox>
                                                    </asp:TableCell>
                                             </asp:TableRow>
                                              <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 
                                             <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Trouble Ticket #:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<telerik:RadTextBox ID="txttroubleticketno" runat="server" Height="20px" Width="300px"  MaxLength="127"></telerik:RadTextBox>     
                                                    </asp:TableCell>
                                                </asp:TableRow> 
                                   <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 
											 
                   
                                                <asp:TableRow>            
                                                        <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Email Address:<span style="color: red">*</span></asp:TableCell>
                                                        <asp:TableCell HorizontalAlign="Left">
                                                                &nbsp;&nbsp;<telerik:RadTextBox ID="txtemailaddress" runat="server" Height="20px" Width="300px"  MaxLength="50"></telerik:RadTextBox>
                                                               
                                                                
                                                                
                                                            </asp:TableCell>                                         
                                                </asp:TableRow>
												
                                                 <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                                </asp:TableRow> 
                                                <asp:TableRow>                     
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Phone:</asp:TableCell>
                                                      <asp:TableCell HorizontalAlign="Left" Font-Bold="true">
                                                        &nbsp;&nbsp;<telerik:RadTextBox ID="txtPhoneNumber" SelectionOnFocus="CaretToBeginning" Height="20px" Width="200px" RenderMode="Lightweight" Runat="server" Mask="(###)-#######"  ValidationGroup="Submit">
                                                         </telerik:RadTextBox>
                                                          </asp:TableCell>
                                                </asp:TableRow>
                       <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                          </asp:TableRow> 
                                   </asp:Table>     
      <br />
                          </div>       
                <br />
<br />
                 <div style="padding-left:700px;padding-bottom:10px;"  ><asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="150" Height="25px" OnClick="btnCancel_Click"  />&nbsp;&nbsp;
                 <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="150" Height="25px" ValidationGroup="Submit" /></div>

              
