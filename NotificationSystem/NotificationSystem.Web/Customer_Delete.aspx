<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer_Delete.aspx.cs" MasterPageFile="MasterPage.master" Inherits="NotificationSystem.NotificationSystem.Web.Customer_Delete" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="Controls_Search/ctrSearch_Customer_Update.ascx" TagPrefix="uc1" TagName="ctrSearch_Customer_Update" %>
<%@ Register Src="Controls_Delete/ctrCustomer_Delete.ascx" TagPrefix="uc1" TagName="ctrCustomer_Delete" %>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceholder1">
              <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#b6b7bc">    
                     <h2>Delete Customer</h2><br />

                       <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >

 <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="customer" runat="server" ImageUrl="images/defaultuser.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="100px" style="margin-top: 5px" Width="100px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                           <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrSearch_Customer_Update runat="server" id="ctrSearch_Customer_Update" Visible="false" /></asp:TableCell>
                                                 
                                    </asp:TableRow>
                         </asp:Table>
                  <br /> <div class="clear hideSkiplink">
                                          <asp:Menu ID="NavigationMenu" runat="server" CssClass="sub_menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                                              <Items>
                                                  <asp:MenuItem Text="Find" NavigateUrl="Customer_Find.aspx"></asp:MenuItem> 
                                                   <asp:MenuItem  Text="Add"  NavigateUrl="Customer_Add.aspx"></asp:MenuItem>
                                                  <asp:MenuItem Text="Update" NavigateUrl="Customer_Update.aspx"></asp:MenuItem> 
                                                  <asp:MenuItem Text="Delete" NavigateUrl="Customer_Delete.aspx"></asp:MenuItem> 
                                              </Items>
                                           </asp:Menu>
                                 </div>

<uc1:ctrCustomer_Delete runat="server" id="ctrCustomer_Delete" />

                     </div>                  
                
    </asp:Content>

