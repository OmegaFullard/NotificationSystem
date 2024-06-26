<%@ Page Title="Ticket Details" Language="C#" AutoEventWireup="true" MasterPageFile="MasterPage.Master" CodeBehind="TicketDetails.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.TicketDetails" %>

<%@ Register Src="ctrTroubleTicketReq.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq" %>
<%@ Register Src="Controls_Search/ctrTroubleTicketReq_Search.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq_Search" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">  
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
                     <div class="col">
                        <center>
                           <h4>Ticket Details</h4>
                        </center>
                     </div>
                  </div>
   
                  <div class="col-md-7">
                      <div class="card">
                          <div class="card-body">
                     <div class="row">
                         <div class="col">
                             <center>
                      <asp:Image ID="issue2" runat="server" ImageUrl="images/issue2.png" BorderStyle="Solid" BorderWidth="1px" Height="250px" style="margin-top: 0px" Width="350px" />
                      </center>
                             </div>
                 </div>
    </div>
                          </div>
                      </div>
    
                  <div class="row">
                     <div class="col">
                        <hr/>
                     </div>
                  </div>

    <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                                   
                                     <asp:TableRow>
                                         
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrTroubleTicketReq_Search runat="server" id="ctrTroubleTicketReq_Search"  /></asp:TableCell>
                                    </asp:TableRow>
                         </asp:Table>
    <br/>
    <br />
<div class="row">
                     <div class="col-md-6">
                        
                     </div>
                     
                  <div class="row">
                     <div class="col-md-6">
                        <label>Request Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Request Date" TextMode="Date"></asp:TextBox>
                            
                            <ajaxToolkit:CalendarExtender ID="TextBox5_CalendarExtender" runat="server" BehaviorID="TextBox5_CalendarExtender" PopupPosition="TopRight" TargetControlID="TextBox5" />
                            
                      </div>
                     </div>
                     <div class="col-md-6">
                        <label>Due Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Due Date" TextMode="Date"></asp:TextBox>
                            <ajaxToolkit:CalendarExtender ID="TextBox6_CalendarExtender" runat="server" BehaviorID="TextBox6_CalendarExtender" PopupPosition="TopRight" TargetControlID="TextBox6" />
                        </div>
                     </div>
                  </div>
     <br />
  
                  <div class="row">
                     <div class="col-6">
                         <asp:Button ID="Button2" class="btn btn-lg btn-block btn-primary" runat="server" Width="150px" Height="31px" Style="color: #ffffff; background-color: #0000ff; border: medium solid #e6ffe6" Text="Search Date" />
                     </div>
                     
                  </div>
        <br />
              
            <a href="Default.aspx"><< Back to Home</a><br/>
            <br/>
         </div>
   	 <uc1:ctrTroubleTicketReq runat="server" id="ctrTroubleTicketReq" />

</asp:Content>