<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrTroubleTicketReq_Find.ascx.cs" Inherits="ctrTroubleTicketReq_Find" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

 
 <div style="width: 1050px; height:800px;  overflow: auto; padding-left:30px" >

<div style="padding-left:5px; padding-top:5px; padding-bottom:5px">

                              <h2>Trouble Tickets</h2><br />
							  
                              <div> <asp:Label ID="lblTroubleTicketNo" runat="server" Text=""></asp:Label></div><br />
     <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
           <asp:GridView ID="grdTroubleTicektReq" runat="server" 
                    AutoGenerateColumns="False" 
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="700px" AllowPaging="True" AllowSorting="True" PageSize="18">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>
                              
                     <asp:BoundField DataField="TroubleTicketNo" HeaderText="Ticket Number" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                               <asp:BoundField DataField="RequestDate" HeaderText="Request Date" HtmlEncode="False" DataFormatString="{0:MM/dd/yyyy}"
                                       ReadOnly="True"  Visible="True" />
                                 
                     
                          </Columns>
                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
               </asp:GridView>
        </div>
     </div>
