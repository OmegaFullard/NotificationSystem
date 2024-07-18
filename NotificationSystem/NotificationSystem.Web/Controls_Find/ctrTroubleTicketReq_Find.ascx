<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ctrTroubleTicketReq_Find.ascx.cs" Inherits="ctrTroubleTicketReq_Find" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>



<div style="width: 1050px; height:800px;  overflow: auto; padding-left:30px" >
           <h2>Ticket Details</h2><br />   
           <div> <asp:Label ID="lblTroubleTicketNo" runat="server" Text=""></asp:Label></div><br />
           <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
           <asp:GridView ID="grdTroubleTicketReq" runat="server" 
                    AutoGenerateColumns="False" 
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="700px" AllowPaging="True" AllowSorting="True" PageSize="18" OnPageIndexChanging="grdTroubleTicketReq_PageIndexChanging" OnSorting="grdTroubleTicketReq_Sorting">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>
                              
									   <asp:BoundField DataField="AgentID" HeaderText="Agent ID" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
									   <asp:BoundField DataField="TroubleTicketNo" HeaderText="Trouble Ticket #" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />									                                     
                              <asp:BoundField DataField="FirstN" HeaderText="Customer ID" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                             
                               <asp:BoundField DataField="RequestDate" HeaderText="RequestDate" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" DataFormatString="{0:MM/dd/yyyy}"/>
									   <asp:BoundField DataField="DueDate" HeaderText="Due Date" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" DataFormatString="{0:MM/dd/yyyy}"/>
									   
                          </Columns>
                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
               </asp:GridView>
        </div>	
		