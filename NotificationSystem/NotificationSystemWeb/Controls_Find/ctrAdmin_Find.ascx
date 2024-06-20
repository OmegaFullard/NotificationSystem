<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrAdmin_Find.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Controls_Find.ctrAdmin_Find" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>




 
 <div style="width: 1050px; height:800px;  overflow: auto; padding-left:30px" >
           <h2>Admin Details</h2><br />  
     
           <div> <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label></div><br />
           <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
           <asp:GridView ID="grdAdmin" runat="server" 
                    AutoGenerateColumns="False" 
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="700px" AllowPaging="True" AllowSorting="True" PageSize="18">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>
                                                      
                              <asp:BoundField DataField="First" HeaderText="First Name" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="Last" HeaderText="Last Name" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="Email" HeaderText="Email" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="UserName" HeaderText="User Name" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                              <asp:BoundField DataField="PassWord" HeaderText="PassWord" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                             
                                 
                          </Columns>
                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
               </asp:GridView>
        </div>	
		
