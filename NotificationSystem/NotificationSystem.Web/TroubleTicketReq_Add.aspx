<%@ Page Language="C#" AutoEventWireup="false"  MasterPageFile="MasterPage.master" CodeBehind="TroubleTicketReq_Add.aspx.cs" Inherits="TroubleTicketReq_Add" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="Controls_Search/ctrTroubleTicketReq_Search.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq_Search" %>
<%@ Register Src="Controls_Add/ctrTroubleTicketReq_Add.ascx" TagPrefix="uc1" TagName="ctrTroubleTicketReq_Add" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
              <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#b6b7bc">    
                     <h2>Create Ticket</h2><br />

                       <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Height="400px" Width="400px" >

 <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71" Height="480px" HorizontalAlign="Center"  Width="480px">
                                           <asp:Image ID="issue2" runat="server" ImageUrl="images/issue2.png" Height="450px" width="450px" style="margin-top: 5px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                           <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrTroubleTicketReq_search runat="server" id="ctrTroubleTicketReq_Search" Visible="false" /></asp:TableCell>
                                                 
                                    </asp:TableRow>
                         </asp:Table>
                  <br />

                  <div class="clear hideSkiplink">
                                          <asp:Menu ID="NavigationMenu" runat="server" CssClass="sub_menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                                              <Items>
                                                  <asp:MenuItem Text="Find" NavigateUrl="Customer_Find.aspx"></asp:MenuItem> 
                                                   <asp:MenuItem  Text="Add"  NavigateUrl="Customer_Add.aspx"></asp:MenuItem>
                                                  <asp:MenuItem Text="Update" NavigateUrl="Customer_Update.aspx"></asp:MenuItem> 
                                                  <asp:MenuItem Text="Delete" NavigateUrl="Customer_Delete.aspx"></asp:MenuItem> 
                                              </Items>
                                           </asp:Menu>
                                 </div>

<uc1:ctrTroubleTicketReq_Add runat="server" id="ctrTroubleTicketReq_Add" />

                     </div>                  
                
    </asp:Content>
