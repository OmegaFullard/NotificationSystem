<%@ Control Language="vb" AutoEventWireup="true" CodeBehind="ctrAdmin.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.ctrAdmin" %>

<div style="width: 1200px; height:500px;  overflow: auto; padding-left:5px" >
           <div class="Heading" >Admin List</div>
           <div><asp:HiddenField ID="ctrHiddebField" runat="server" /></div><br />
    
           <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
           <asp:GridView ID="grdAdmin" runat="server" 
                    AutoGenerateColumns="False" 
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="1200px" AllowPaging="True" AllowSorting="True" PageSize="9" OnPageIndexChanging="grdAdmin_PageIndexChanging" OnSorting="grdAdmin_Sorting" OnLoad="Page_Load">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>

                                     <asp:BoundField DataField="UserName" HeaderText="Name" HtmlEncode="False" SortExpression="UserName" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />    
                                     <asp:BoundField DataField="PassWord" HeaderText="PassWord" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />                                   
                                    <asp:BoundField DataField="Email" HeaderText="Email" HtmlEncode="False" ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                     <asp:BoundField DataField="First" HeaderText="First" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                     <asp:BoundField DataField="Last" HeaderText="Last" HtmlEncode="False"  ItemStyle-Width="100"
                                       ReadOnly="True"  Visible="True" />
                                   
                                 </Columns>


                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
               </asp:GridView>
        </div>