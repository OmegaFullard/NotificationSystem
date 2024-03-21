<%@ Page Language="C#" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeBehind="TroubleTicketReq_Find.aspx.cs" Inherits="TroubleTicketReq_Find" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="Controls_Search/ctrTroubleTicketReq_Search.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq_Search" %>
<%@ Register Src="Controls_Find/ctrTroubleTicketReq_Find.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq_Find" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceholder1">
              <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#b6b7bc">    
                     <h2>Find Ticket</h2><br />
                  
                          <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Height="350px" Width="700px" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> 
                                              <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
											 
                                                           <asp:Image ID="issue2" runat="server" ImageUrl="images/issue2.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="200px" style="margin-top: 5px" Width="200px" />
														
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrTroubleTicketReq_Search runat="server" id="ctrTroubleTicketReq_Search"  /></asp:TableCell>
                                    </asp:TableRow>
                         </asp:Table>
                  <br />
                          <uc1:ctrTroubleTicketReq_Find runat="server" id="ctrTroubleTicketReq_Find" />
                         
                  </div>
            
             
    </asp:Content>
