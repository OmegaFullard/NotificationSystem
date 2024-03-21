<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrTroubleTicketReq.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.ctrTroubleTicketReq" %>

<div style="width: 1200px; height:500px;  overflow: auto; padding-left:5px" >
           <div class="Heading" >Customer List</div>
           <div><asp:HiddenField ID="ctrHiddebField" runat="server" /></div><br />
    
           <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
           <asp:GridView ID="grdTroubleTicketReq" runat="server" 
                    AutoGenerateColumns="False" 
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="1200px" AllowPaging="True" AllowSorting="True" PageSize="9">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>

                                     <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" HtmlEncode="False" SortExpression="CustomerID" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />  
									<asp:BoundField DataField="AgentID" HeaderText="Agent ID" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />									   
                                     <asp:BoundField DataField="TroubleTicketNo" HeaderText="TicketNo" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />                                    
                                      <asp:BoundField DataField="Status" HeaderText="Status" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                      <asp:BoundField DataField="DueDate" HeaderText="Due Date" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />                                     
                                    <asp:BoundField DataField="RequestDate" HeaderText="Request Date" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                     <asp:BoundField DataField="Type" HeaderText="Type" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
									
                                   
                                 </Columns>


                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
               </asp:GridView>
        </div>