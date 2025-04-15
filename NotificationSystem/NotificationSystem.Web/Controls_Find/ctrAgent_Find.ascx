<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ctrAgent_Find.ascx.cs" Inherits="ctrAgent_Find" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>




 
 <div style="width: 1050px; height:800px;  overflow: auto; padding-left:30px" >
           <h2>Agent Details</h2><br />  
     
           <div> <asp:Label ID="lblAgentID" runat="server" Text=""></asp:Label></div><br />
           <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
           <asp:GridView ID="grdAgent" runat="server" 
                    AutoGenerateColumns="False" 
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="700px" AllowPaging="True" AllowSorting="True" PageSize="18" OnLoad="Page_Load" OnPageIndexChanging="grdAgent_PageIndexChanging" OnSorting="grdAgent_Sorting">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>
                              <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" HtmlEncode="False"
                                  ReadOnly="True" Visible="True" />
									     <asp:BoundField DataField="StartDate" HeaderText="Start Date" HtmlEncode="False" DataFormatString="{0:MM/dd/yyyy}"
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="TroubleTicketNo" HeaderText="Trouble Ticket#" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="Title" HeaderText="Title" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="Salary" HeaderText="Salary" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />                           
                              <asp:BoundField DataField="FirstN" HeaderText="First Name" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="LastN" HeaderText="Last Name" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="Email" HeaderText="Email" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="Phone" HeaderText="Phone" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="Fax" HeaderText="Fax" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                             
                                 
                          </Columns>
                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
               </asp:GridView>
        </div>	
		