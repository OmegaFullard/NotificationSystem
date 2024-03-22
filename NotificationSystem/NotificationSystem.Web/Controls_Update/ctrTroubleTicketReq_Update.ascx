<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ctrTroubleTicketReq_Update.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.ctrTroubleTicketReq_Update" %>
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
							<H2>Trouble Ticket Update</h2><br/>
                         
                              <div> <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></div><br />
							  Request Date:&nbsp;&nbsp;<telerik:RadDatePicker  ID="pickRequestDate"  DateInput-EmptyMessage="Select"    DataFormatString="{0:MM/dd/yyyy}" Width="140px" Runat="server" >
                                                          </telerik:RadDatePicker><br /><br />
          
                             <asp:Table ID="Table1" runat="server" Width="930px">
                                            <asp:TableRow><asp:TableCell ColumnSpan="2"> <div style="padding-bottom:20px;"> Required fields are marked with <span style="color: red">* </span> (red asterisk).
                                                </div> </asp:TableCell>
                                            </asp:TableRow>
                                  <asp:TableRow> 
                                             <asp:TableCell HorizontalAlign="Right" Width="150px"><div class="containerText"><b>Customer ID:<span style="color: red">*</span></b></div></asp:TableCell>
                                             <asp:TableCell HorizontalAlign="Left"> 
                                             
                                                 <asp:RequiredFieldValidator  ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcustomerid" ValidationGroup="Submit"  
                                             ErrorMessage="Customer ID is Required Field!"><span style="color: red">!</span></asp:RequiredFieldValidator>
                                              &nbsp;&nbsp; <asp:TextBox ID="txtcustomerid" runat="server" Height="20px" Width="300px"  ></asp:TextBox>
                                           </asp:TableCell>
                                 </asp:TableRow>
     
										
                                   <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 

                                             <asp:TableRow>                     
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Agent ID:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                       &nbsp;&nbsp; <asp:TextBox ID="txtAgentID" runat="server" Height="20px" Width="300px"  MaxLength="127"></asp:TextBox>
                                                    </asp:TableCell>
                                             </asp:TableRow>
                                              <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                             </asp:TableRow> 
                                             <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Trouble Ticket #:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<asp:TextBox ID="txttroubleticketno" runat="server" Height="20px" Width="300px"  MaxLength="127"></asp:TextBox>     
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
										  <asp:TableCell HorizontalAlighn="Right" Font-Bold="true">Status:<span style="color: red">*</span></asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;
                                                        <telerik:RadMultiColumnComboBox runat="server"   ID="cmbStatus" DropDownWidth="100px" Height="200px"  Width="100px" AutoPostBack="true"
                                                                Placeholder="--Select" >
                                                                <ColumnsCollection>
                                                                    <telerik:MultiColumnComboBoxColumn Field="Status" Title="Status" Width="100px" />
                                                                </ColumnsCollection>
                                                 </telerik:RadMultiColumnComboBox>                                                                  
                                                     </asp:TableCell>
                                         
									</asp:TableRow>  
									
											<asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                          </asp:TableRow>  							 

                                 <asp:TableRow>
									<asp:TableCell HorizontalAlighn="Right" Font-Bold="true">Type:<span style="color: red">*</span></asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;
                                                        <telerik:RadMultiColumnComboBox runat="server"   ID="cmbType" DropDownWidth="100px" Height="200px"  Width="100px" AutoPostBack="true"
                                                                Placeholder="--Select" >
                                                                <ColumnsCollection>
                                                                    <telerik:MultiColumnComboBoxColumn Field="Type" Title="Type" Width="100px" />
                                                                </ColumnsCollection>
                                                 </telerik:RadMultiColumnComboBox>                                                                  
                                                     </asp:TableCell>
                                         
									</asp:TableRow>                                 							 
										  
											<asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                          </asp:TableRow>  
										  
										  
										      
										  
										    <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true"> Due Date:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        &nbsp;&nbsp;<Telerik:RadDatePicker ID="pickDueDate" DateInput-EmptyMessage="Select" DataFormatString="{0:MM/dd/yyyy}" Width="140px" runat="server" Height="20px" MaxLength="127"></Telerik:RadDatePicker>     
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
                 <asp:Button ID="btnUpdate" runat="server" Text="Add" Width="150" Height="25px" ValidationGroup="Submit" /></div>