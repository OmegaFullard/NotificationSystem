<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrAgent.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.ctrAgent" %>

<div style="width: 1200px; height:500px;  overflow: auto; padding-left:5px" >
           <div class="Heading" >Agent List</div>
           <div><asp:HiddenField ID="ctrHiddebField" runat="server" /></div><br />
    
           <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
           <asp:GridView ID="grdAgents" runat="server" 
                    AutoGenerateColumns="False" 
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="1200px" AllowPaging="True" AllowSorting="True" PageSize="9">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>

                                     <asp:BoundField DataField="AgentID" HeaderText="Agent Id" HtmlEncode="False" SortExpression="AgentID" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />    
                                     <asp:BoundField DataField="TroubleTicketNo" HeaderText="TicketNo" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                     <asp:BoundField DataField="Title" HeaderText="Title" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                     <asp:BoundField DataField="StartDate" HeaderText="Start Date" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                      <asp:BoundField DataField="Salary" HeaderText="Salary" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                      <asp:BoundField DataField="FirstN" HeaderText="First Name" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                      <asp:BoundField DataField="LastN" HeaderText="Last Name" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />                                     
                                    <asp:BoundField DataField="Email" HeaderText="Email" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                     <asp:BoundField DataField="Phone" HeaderText="Phone" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                     <asp:BoundField DataField="Fax" HeaderText="Fax" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                   
                                 </Columns>


                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
               </asp:GridView>
        </div>