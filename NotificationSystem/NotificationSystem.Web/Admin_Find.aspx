<%@ Page Language="C#" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeBehind="Admin_Find.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Admin_Find" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="Controls_Search/ctrSearch_Admin.ascx" TagPrefix="uc1" TagName="ctrSearch_Admin" %>
<%@ Register Src="Controls_Find/ctrAdmin_Find.ascx" TagPrefix="uc1" TagName="ctrAdmin_Find" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceholder1">
              <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#eee9f7">    
                     <h2>Find Admin</h2><br />
                  
                          <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> 
                                              <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                           <asp:Image ID="admin" runat="server" ImageUrl="images/admin.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="100px" style="margin-top: 5px" Width="100px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrSearch_Admin runat="server" id="ctrSearch_Admin"  /></asp:TableCell>
                                    </asp:TableRow>
                         </asp:Table>
                  <br />
                  
                  <div class="clear hideSkiplink">
                                          <asp:Menu ID="NavigationMenu" runat="server" CssClass="sub_menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                                              <Items>
                                                  <asp:MenuItem Text="Find" NavigateUrl="Admin_Find.aspx"></asp:MenuItem> 
                                                   <asp:MenuItem  Text="Add"  NavigateUrl="Admin_Add.aspx"></asp:MenuItem>
                                                  <asp:MenuItem Text="Update" NavigateUrl="Admin_Update.aspx"></asp:MenuItem> 
                                                 
                                              </Items>
                                           </asp:Menu>
                                 </div>
                          <uc1:ctrAdmin_Find runat="server" id="ctrAdmin_Find" />
                         
                  </div>
            
             
    </asp:Content>

