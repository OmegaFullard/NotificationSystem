<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrAdmin_Delete.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Controls_Delete.ctrAdmin_Delete" %>

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
                         <div class="Heading" >Add Agent</div>
                              <div> <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></div><br />
          
                             <asp:Table ID="Table1" runat="server" Width="930px">
                                            <asp:TableRow><asp:TableCell ColumnSpan="2"> <div style="padding-bottom:20px;"> Required fields are marked with <span style="color: red">* </span> (red asterisk).
                                                </div> </asp:TableCell>
                                            </asp:TableRow>
     
                                           <asp:TableRow> 
                                             <asp:TableCell HorizontalAlign="Right" Width="150px"><div class="containerText"><b>First Name:<span style="color: red">*</span></b></div></asp:TableCell>
                                             <asp:TableCell HorizontalAlign="Left"> 
                                              &nbsp;&nbsp; <asp:TextBox ID="txtfirstname" runat="server" Height="20px" Width="300px"  ></asp:TextBox>
                                                 <asp:RequiredFieldValidator  ID="valRequiredFieldFirstN" runat="server" ControlToValidate="txtfirstname" ValidationGroup="Submit"  
                                             ErrorMessage="First Name is Required Field!"><span class="required">!</span></asp:RequiredFieldValidator>
                                             


                                                 <ajaxtoolkit:ValidatorCalloutExtender ID="Required_First"  TargetControlID="valRequiredFieldFirst"  Width="250px"  
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
                                               &nbsp;&nbsp; <asp:TextBox ID="txtlastname" runat="server" Height="20px" Width="300px"  ></asp:TextBox>
                                                 <asp:RequiredFieldValidator  ID="valRequiredFieldLast" runat="server" ControlToValidate="txtlastname" ValidationGroup="Submit"  
                                             ErrorMessage="Last Name is Required Field!"><span class="required">!</span></asp:RequiredFieldValidator>
                                            

                                                 <ajaxtoolkit:ValidatorCalloutExtender ID="Required_LastN"  TargetControlID="valRequiredFieldLast"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>
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
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">User Name:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                       &nbsp;&nbsp; <asp:TextBox ID="txtusername" runat="server" Height="20px" Width="300px"  MaxLength="127"></asp:TextBox>
                                                    </asp:TableCell>
                                             </asp:TableRow>
                                              <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 
                                             <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Password:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<asp:TextBox ID="txtpassword" runat="server" Height="20px" Width="300px"  MaxLength="127"></asp:TextBox>     
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
                                                        
                                                               
                
                                                                
                                                                
                                                            </asp:TableCell>                                         
                                                </asp:TableRow>
												
                                               

                                   </asp:Table>     
      <br />
                          </div>       
                <br />
<br />
                 <div style="padding-left:700px;padding-bottom:10px;"  ><asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="150" Height="25px" OnClick="btnCancel_Click"  />&nbsp;&nbsp;
                 <asp:Button ID="btnDelete" runat="server" Text="Add" Width="150" Height="25px" ValidationGroup="Submit" /></div>
