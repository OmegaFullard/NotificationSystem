<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ctrTroubleTicketReq_Add.ascx.cs" Inherits="ctrTroubleTicketReq_Add" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>

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
  
							<H2>Trouble Ticket Request</h2><br/>
                         
                              <div> <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></div><br />
							  <br />
                              <br />
          
                             <asp:Table ID="Table1" runat="server" Width="930px">

                                     
                                  <asp:TableRow> 
                                             <asp:TableCell HorizontalAlign="Right" Width="150px"><div class="containerText"><b>Customer ID:<span style="color: red">*</span></b></div></asp:TableCell>
                                             <asp:TableCell HorizontalAlign="Left"> 
                                               &nbsp;&nbsp; <asp:TextBox ID="txtcustomerid" runat="server" Height="20px" Width="300px"  ></asp:TextBox>
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
										  <asp:TableCell HorizontalAlighn="Right" Font-Bold="true">Status:</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;
                                                        <telerik:RadMultiColumnComboBox runat="server"  ID="cmbStatus" DropDownWidth="100px" Height="200px"  Width="100px"  Filter="Contains" MarkFirstMatch="true" ChangeTextOnKeyBoardNavigation="false" AutoPostBack="true"
                                                                Placeholder="--Select" EnableEmbeddedSkins="True" ClientEvents-OnLoad="OnClientLoad3">
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
                                 
											<asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                          </asp:TableRow>  	

                                 <asp:TableRow>
									<asp:TableCell HorizontalAlighn="Right" Font-Bold="true">Type:</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;
                                                        <telerik:RadMultiColumnComboBox runat="server" ID="cmbType" DropDownWidth="100px" Height="200px"  Width="100px"  Filter="Contains" MarkFirstMatch="true" ChangeTextOnKeyBoardNavigation="false" AutoPostBack="true" 
                                                            Placeholder="--Select" EnableEmbeddedSkins="True" ClientEvents-OnLoad="OnClientLoad4">    
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
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true">Request Date:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                        <asp:TextBox CssClass="form-control" ID="RequestDate" runat="server" placeholder="Request Date" TextMode="Date"></asp:TextBox>
                                                     <ajaxToolkit:CalendarExtender ID="RequestDate_CalendarExtender" runat="server" BehaviorID="RequestDate_CalendarExtender" PopupPosition="TopRight" TargetControlID="TextBox5" />
                                                    </asp:TableCell>
                                                </asp:TableRow> 
                                                 <asp:TableRow  > 
                                                     <asp:TableCell HorizontalAlign="Right">&nbsp;&nbsp;</asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;</asp:TableCell>
                                                </asp:TableRow> 
										      
										  
										    <asp:TableRow> 
                                                    <asp:TableCell HorizontalAlign="Right" Font-Bold="true"> Due Date:</asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Left">
                                                         <asp:TextBox CssClass="form-control" ID="DueDate" runat="server" placeholder="Due Date" TextMode="Date"></asp:TextBox>
                                                       <ajaxToolkit:CalendarExtender ID="DueDate_CalendarExtender" runat="server" SelectedDate="" BehaviorID="DueDate_CalendarExtender" PopupPosition="TopRight" TargetControlID="TextBox6" />
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
                 <asp:Button ID="btnAdd" runat="server" Text="Add" Width="150" Height="25px" ValidationGroup="Submit" /></div>

              



