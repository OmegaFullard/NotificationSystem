﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrCustomer_Find.ascx.cs" Inherits="ctrCustomer_Find" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>



<div style="width: 1050px; height:800px;  overflow: auto; padding-left:30px" >
           <h2>Customer Details</h2><br />   
           <div> <asp:Label ID="lblCustomerID" runat="server" Text=""></asp:Label></div><br />
           <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
           <asp:GridView ID="grdCustomer" runat="server" 
                    AutoGenerateColumns="False" 
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="700px" AllowPaging="True" AllowSorting="True" PageSize="18">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>
                                <asp:TemplateField HeaderText="ID" SortExpression="CustomerID" ItemStyle-Width="100"    Visible="True">
                                            
                                       </asp:TemplateField> 
									   <asp:BoundField DataField="AgentID" HeaderText="Agent ID" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
									   <asp:BoundField DataField="TroubleTicketNo" HeaderText="Trouble Ticket #" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />									                                     
                              <asp:BoundField DataField="FirstN" HeaderText="First Name" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="LastN" HeaderText="Last Name" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="Email" HeaderText="Email" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" DataFormatString='\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*' />
                              <asp:BoundField DataField="Phone" HeaderText="Phone" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" DataFormatString="(###)-#######" />
                               <asp:BoundField DataField="Address" HeaderText="Address" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
									   <asp:BoundField DataField="City" HeaderText="City" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
									   <asp:BoundField DataField="State" HeaderText="State" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                                  <asp:BoundField DataField="Zip" HeaderText="Zip" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                          </Columns>
                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
               </asp:GridView>
        </div>	
		
                 
			