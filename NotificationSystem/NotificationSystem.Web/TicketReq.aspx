
<%@ Page Language="C#" AutoEventWireup="false"  MasterPageFile="MasterPage.master" CodeBehind="TicketReq.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.TicketReq" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="ctrTroubleTicketReq.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq" %>
<%@ Register Src="Controls_Search/ctrTroubleTicketReq_Search.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq_Search" %>
<%@ Register Src="Controls_Find/ctrTroubleTicketReq_Find.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq_Find" %>


<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
    <title>Tickets</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    
                   <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Height="222px" Width="483px" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="ticket" runat="server" ImageUrl="images/issue1.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="150px" style="margin-top: 5px" Width="150px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrTroubleTicketReq_Search runat="server" ID="ctrTroubleTicketReq_Search" /></asp:TableCell>
                                    </asp:TableRow>
                             
                         </asp:Table>
                  <br />
               
              <uc1:ctrTroubleTicketReq runat="server" id="ctrTroubleTicketReq" />
            <br />
    <div>
            <a href="Default.aspx"><< Back to Home</a><br />
        </div>
  
</asp:Content>


