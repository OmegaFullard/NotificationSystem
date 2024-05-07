<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ctrTroubleTicketReq_Update.ascx.cs" Inherits="ctrTroubleTicketReq_Update" %>
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
   
							<H2>Trouble Ticket Update</h2><br/>
                         
                              <div> <asp:Label ID="lblResult" runat="server" Text=""></asp:Label></div><br />
							 
          
                             <asp:Table ID="Table1" runat="server" Width="930px">
                                            <asp:TableRow><asp:TableCell ColumnSpan="2"> <div style="padding-bottom:20px;"> Required fields are marked with <span style="color: red">* </span> (red asterisk).
                                                </div> </asp:TableCell>
                                            </asp:TableRow>
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
										  <asp:TableCell HorizontalAlighn="Right" Font-Bold="true">Status:<span style="color: red">*</span></asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;
                                                         <telerik:RadMultiColumnComboBox runat="server"  ID="cmbStatus" DropDownWidth="100px" Height="200px"  Width="100px"  Filter="Contains" MarkFirstMatch="true" ChangeTextOnKeyBoardNavigation="false" AutoPostBack="true"
                                                                Placeholder="--Select" EnableEmbeddedSkins="True">
                                                                <ColumnsCollection>
                                                                    <telerik:MultiColumnComboBoxColumn Field="Status" Title="Status" Width="100px" />
                                                                </ColumnsCollection>
                                                 </telerik:RadMultiColumnComboBox>  
                                                         
                                                         
                                                 <asp:RequiredFieldValidator  ID="valRequiredStatus" runat="server" ClientEvents-OnLoad="OnClientLoad1" ControlToValidate="cmbStatus" ValidationGroup="Submit"  
                                             ErrorMessage="Status is Required Field!"><span class="required">!</span></asp:RequiredFieldValidator>
                                              
                                                  <ajaxtoolkit:ValidatorCalloutExtender ID="Required_cmbStatus"  TargetControlID="valRequiredStatus"  Width="250px"  
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
									<asp:TableCell HorizontalAlighn="Right" Font-Bold="true">Type:<span style="color: red">*</span></asp:TableCell>
                                                     <asp:TableCell HorizontalAlign="Left">&nbsp;&nbsp;
                                                        <telerik:RadMultiColumnComboBox runat="server" ClientEvents-OnLoad="OnClientLoad1" ID="cmbType" DropDownWidth="100px" Height="200px"  Width="100px"  Filter="Contains" MarkFirstMatch="true" ChangeTextOnKeyBoardNavigation="false" AutoPostBack="true" 
                                                            Placeholder="--Select" EnableEmbeddedSkins="True">    
                                                            <ColumnsCollection>
                                                                    <telerik:MultiColumnComboBoxColumn Field="Type" Title="Type" Width="100px" />
                                                                </ColumnsCollection>
                                                 </telerik:RadMultiColumnComboBox>    
                                                         

                                                         
                                                 <asp:RequiredFieldValidator  ID="valcmbType" runat="server" ControlToValidate="cmbType" ValidationGroup="Submit"  
                                             ErrorMessage="Type is Required Field!"><span class="required">!</span></asp:RequiredFieldValidator>
                                              
                                                  <ajaxtoolkit:ValidatorCalloutExtender ID="required_cmbType"  TargetControlID="valcmbType"  Width="250px"  
                                                               HighlightCssClass="highlight" runat="server">
                                                       </ajaxtoolkit:ValidatorCalloutExtender>                                                               
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