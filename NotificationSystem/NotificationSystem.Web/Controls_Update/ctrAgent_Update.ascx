 <%@ Control Language="c#" AutoEventWireup="false" CodeBehind="ctrAgent_Update.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.ctrAgent_Update" %>
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
                         <div class="Heading" >Update Agent</div>
      <br />
                              <div> <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></div><br />
          
                             <asp:Table ID="Table1" runat="server" Width="930px">
                                            <asp:TableRow><asp:TableCell ColumnSpan="2"> <div style="padding-bottom:20px;"> Required fields are marked with <span style="color: red">* </span> (red asterisk).
                                                </div> </asp:TableCell>
                                            </asp:TableRow>
     
                                           <asp:TableRow> 
                                             <asp:TableCell HorizontalAlign="Right" Width="150px"><div class="containerText"><b>First Name:<span style="color: red">*</span></b></div></asp:TableCell>
                                             <asp:TableCell HorizontalAlign="Left"> 
                                             
                                                 <asp:RequiredFieldValidator  ID="valFirstN" runat="server" ControlToValidate="txtfirstname" ValidationGroup="Submit"  
                                             ErrorMessage="First Name is Required Field!"><span style="color: red">!</span></asp:RequiredFieldValidator>
                                              &nbsp;&nbsp; <asp:TextBox ID="txtfirstname" runat="server" Height="20px" Width="300px"  ></asp:TextBox>
                                           </asp:TableCell>
             
                                          </asp:TableRow> 
										  <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                          </asp:TableRow> 
										  
                                           <asp:TableRow> 
                                             <asp:TableCell HorizontalAlign="Right" Width="150px"><div class="containerText"><b>Last Name:<span style="color: red">*</span></b></div></asp:TableCell>
                                             <asp:TableCell HorizontalAlign="Left"> 
                                               &nbsp;&nbsp; <asp:TextBox ID="txtlastname" runat="server" Height="20px" Width="300px"  ></asp:TextBox>
                                                 <asp:RequiredFieldValidator  ID="valLastN" runat="server" ControlToValidate="txtlastname" ValidationGroup="Submit"  
                                             ErrorMessage="Last Name is Required Field!"><span style="color: red">!</span></asp:RequiredFieldValidator>
                                            
                                           </asp:TableCell>
             
                                          </asp:TableRow> 
										  
                                          <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                          </asp:TableRow> 
                                    <asp:TableRow>   
                                                    
              
                                                     <asp:TableCell HorizontalAlign="Right" Font-Bold="true"><div class="containerText"> Title:</div></asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">
                                                         &nbsp;&nbsp; <asp:TextBox ID="txttitle" runat="server" Height="20px" Width="300px"  ></asp:TextBox>
                                                         
                                                     </asp:TableCell>
                                             </asp:TableRow>

                                              <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                            </asp:TableRow> 
                                             <asp:TableRow>                     
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Salary:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                       &nbsp;&nbsp; <asp:TextBox ID="txtsalary" runat="server" Height="20px" Width="300px"  MaxLength="127"></asp:TextBox>
                                                    </asp:TableCell>
                                             </asp:TableRow>
                                              <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 
                                             <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Agent ID:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<asp:TextBox ID="txtagentid" runat="server" Height="20px" Width="300px"  MaxLength="127"></asp:TextBox>     
                                                    </asp:TableCell>
                                                </asp:TableRow> 
                                   <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 
											 
											 
                                             <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">StartDate:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<Telerik:RadDatePicker ID="pickStartDate" DateInput-EmptyMessage="Select" DataFormatString="{0:MM/dd/yyyy}" Width="140px" runat="server" Height="20px" MaxLength="127"></Telerik:RadDatePicker>     
                                                    </asp:TableCell>
                                                </asp:TableRow> 
                                                 <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                                </asp:TableRow> 
												
												
                                               
                                                <asp:TableRow>            
                                                        <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Email Address:<span style="color: red">*</span></asp:TableCell>
                                                        <asp:TableCell HorizontalAlign="Left">
                                                                &nbsp;&nbsp;<asp:TextBox ID="txtemailaddress" runat="server" Height="20px" Width="300px"  MaxLength="50"></asp:TextBox>
                                                                 <asp:RequiredFieldValidator  ID="valEmailAddress" runat="server" ControlToValidate="txtemailaddress" ValidationGroup="Submit" 
                                                                                            ErrorMessage="Email Address cannot be blank!"><span style="color: red">!</span></asp:RequiredFieldValidator>

                                                               
                
                                                                <asp:RegularExpressionValidator ID="valRegularExprEmailAddr" runat="server" ControlToValidate="txtemailaddress"
                                                                                             ErrorMessage="Email Address is in the wrong format" 
                                                                                             ValidationExpression="^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
                                                                                             ValidationGroup="Submit">!</asp:RegularExpressionValidator>
                                                                
                                                            </asp:TableCell>                                         
                                                </asp:TableRow>
												
                                                 <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                                </asp:TableRow> 
                                                <asp:TableRow>                     
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Phone:</asp:TableCell>
                                                      <asp:TableCell HorizontalAlign="Left" Font-Bold="true">
                                                        &nbsp;&nbsp;<asp:textbox ID="txtPhoneNumber" SelectionOnFocus="CaretToBeginning" Height="20px" Width="200px" RenderMode="Lightweight" Runat="server" Mask="(###)-#######"  ValidationGroup="Submit">
                                                         </asp:textbox>&nbsp;&nbsp;Fax:
                                                        
														
														<asp:textbox ID="txtFaxNumber" SelectionOnFocus="CaretToBeginning" Height="20px" Width="200px" RenderMode="Lightweight" Runat="server" Mask="(###)-#######" ValidationGroup="Submit">
                                                         </asp:textbox>
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
                 <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="150" Height="25px" ValidationGroup="Submit" /></div>

              


