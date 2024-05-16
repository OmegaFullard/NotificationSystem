<%@ Page Language="C#" AutoEventWireup="false" MasterPageFile="MasterPage.Master" CodeBehind="TroubleTicketReq_Update.aspx.cs" Inherits="TroubleTicketReq_Update" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="Controls_Search/ctrTroubleTicketReq_Search.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq_Search" %>
<%@ Register Src="Controls_Search/ctrSearch_TTR_Update.ascx" TagPrefix="uc1" TagName="ctrSearch_TTR_Update" %>
<%@ Register Src="Controls_Add/ctrTroubleTicketReq_Add.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq_Add" %>
<%@ Register Src="Controls_Update/ctrTroubleTicketReq_Update.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq_Update" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceholder1">
                
              <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#b6b7bc">    
                     <h2>Update Ticket</h2><br />

                          <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Height="400px" Width="400px" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="350px" HorizontalAlign="Center"  Width="350px">
                                           <asp:Image ID="issue1" runat="server" ImageUrl="images/issue1.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="350px" style="margin-top: 5px" Width="350px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>

<asp:TableCell VerticalAlign="Top"><uc1:ctrSearch_TTR_Update runat="server" ID="ctrSearch_TTR_Update" /></asp:TableCell>
</asp:TableRow>
                         </asp:Table>
             <br />

                 
                  <uc1:ctrTroubleTicketReq_Update runat="server" id="ctrTroubleTicketReq_Update" />

                      </div>
                             
               </asp:Content>