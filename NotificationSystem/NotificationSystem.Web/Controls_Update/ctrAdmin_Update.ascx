<%@ Control Language="vb" AutoEventWireup="true" CodeBehind="ctrAdmin_Update.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Controls_Update.ctrAdmin_Update" %>
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


 <script>
     function OnClientLoad0(sender, args) {

         $telerik.$(".k-input")[0].setAttribute("readonly", "true");
     }
     function OnClientLoad1(sender, args) {

         $telerik.$(".k-input")[1].setAttribute("readonly", "true");
     }
     function OnClientLoad2(sender, args) {

         $telerik.$(".k-input")[2].setAttribute("readonly", "true");
     }
     function OnClientLoad3(sender, args) {

         $telerik.$(".k-input")[3].setAttribute("readonly", "true");
     }
     function OnClientLoad4(sender, args) {

         $telerik.$(".k-input")[4].setAttribute("readonly", "true");
     }

 </script>
 

  <div style="padding-left:5px; padding-top:5px; padding-bottom:5px">
       <h2>Update Admin</h2><br />
                         
                              <div> <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></div><br />
          
                             <asp:Table ID="Table1" runat="server" Width="930px">
                                            <asp:TableRow><asp:TableCell ColumnSpan="2"> <div style="padding-bottom:20px;"> Required fields are marked with <span style="color: red">* </span> (red asterisk).
                                                </div> </asp:TableCell>
                                            </asp:TableRow>
                                
                                           <asp:TableRow> 
                                             <asp:TableCell HorizontalAlign="Right" Width="150px"><div class="containerText"><b>First Name:<span style="color: red">*</span></b></div></asp:TableCell>
                                             <asp:TableCell HorizontalAlign="Left"> 
                                             
                                                   &nbsp;&nbsp; <telerik:RadTextBox ID="txtfirstname" runat="server" Height="20px" Width="300px"  ></telerik:RadTextBox>
                                                 <asp:RequiredFieldValidator  ID="valRequiredFieldFirst" runat="server" ControlToValidate="txtfirstname" ValidationGroup="Submit"  
                                             ErrorMessage="First Name is Required Field!"><span class="required"></span></asp:RequiredFieldValidator>
                                            
                                                 
                                                 <ajaxtoolkit:ValidatorCalloutExtender ID="Require_First"  TargetControlID="valRequiredFieldFirst"  Width="250px"  
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
                                                 <asp:RequiredFieldValidator  ID="valRequiredFieldLast" runat="server" ControlToValidate="txtlastname" ValidationGroup="Submit"  
                                             ErrorMessage="Last Name is Required Field!"><span class="required">!</span></asp:RequiredFieldValidator>
                                            
                                                      <ajaxtoolkit:ValidatorCalloutExtender ID="valRequiredLast"  TargetControlID="valRequiredFieldLast"  Width="250px"  
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
                                                        <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Email Address:<span style="color: red">*</span></asp:TableCell>
                                                        <asp:TableCell HorizontalAlign="Left">
                                                                &nbsp;&nbsp;<telerik:RadTextBox ID="txtemailaddress" runat="server" Height="20px" Width="300px"  MaxLength="50"></telerik:RadTextBox>
                                                                 
                

                                                            </asp:TableCell>                                         
                                                </asp:TableRow>
												
                            </asp:Table>                 
                          </div>       
                <br />
<br />
                 <div style="padding-left:700px;padding-bottom:10px;"  ><asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="150" Height="25px" OnClick="btnCancel_Click"  />&nbsp;&nbsp;
                 <asp:Button ID="btnUpdate" runat="server" Text="Update" Width="150" Height="25px" ValidationGroup="Submit" /></div>

              