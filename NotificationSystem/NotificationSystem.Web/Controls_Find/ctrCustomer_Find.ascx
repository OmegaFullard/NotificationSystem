<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrCustomer_Find.ascx.cs" Inherits="ctrCustomer_Find" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

 

 <div style="width: 1050px; height:800px;  overflow: auto; padding-left:30px" >
<div style="padding-left:5px; padding-top:5px; padding-bottom:5px">

                              <h2>Customers</h2><br />
							  
                              <div> <asp:Label ID="lblCustomerID" runat="server" Text=""></asp:Label></div><br />
                              <asp:GridView ID="grdCustomers" runat="server" 
                    AutoGenerateColumns="False" 
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="700px" AllowPaging="True" AllowSorting="True" PageSize="18">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>
                              
					   <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />		  
                     <asp:BoundField DataField="TroubleTicketNo" HeaderText="Ticket Number" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
      
                          </Columns>
                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
               </asp:GridView>
                    
                 </div>
				 </div>
				
                 
			