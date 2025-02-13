<%@ Page Language="C#" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeBehind="Customer_Update.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Customer_Update" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="Controls_Search/ctrCustomer_Search.ascx" TagPrefix="uc1" TagName="ctrCustomer_Search" %>
<%@ Register Src="Controls_Search/ctrSearch_Customer_Update.ascx" TagPrefix="uc1" TagName="ctrSearch_Customer_Update" %>
<%@ Register Src="Controls_Add/ctrCustomer_Add.ascx" TagPrefix="uc1" TagName="ctrCustomer_Add" %>
<%@ Register Src="Controls_Update/ctrCustomer_Update.ascx" TagPrefix="uc1" TagName="ctrCustomer_Update" %>




<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceholder1">
               <script type="text/javascript">
                  function OnClientLoad0(sender, args) {
                      $telerik.$(".k-input")[0].setAttribute("readonly", "true");
                  }

               </script>
              <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
              <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#eee9f7">    
                                               <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Height="141px" Width="152px" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                           <asp:Image ID="customer" runat="server" ImageUrl="images/defaultuser.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="100px" style="margin-top: 5px" Width="100px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>

<asp:TableCell VerticalAlign="Top"><uc1:ctrSearch_Customer_Update runat="server" ID="ctrSearch_Customer_Update" /></asp:TableCell>
</asp:TableRow>
                         </asp:Table>
             <br />

                  <div class="clear hideSkiplink">
                                          <asp:Menu ID="NavigationMenu" runat="server" CssClass="sub_menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                                              <Items>
                                                  <asp:MenuItem Text="Find" NavigateUrl="Customer_Find.aspx"></asp:MenuItem> 
                                                   <asp:MenuItem  Text="Add"  NavigateUrl="Customer_Add.aspx"></asp:MenuItem>
                                                  <asp:MenuItem Text="Update" NavigateUrl="Customer_Update.aspx"></asp:MenuItem> 
                                              
                                              </Items>
                                           </asp:Menu>
                                 </div>

                  <uc1:ctrCustomer_Update runat="server" id="ctrCustomer_Update" />

                      </div>
                             
               </asp:Content>
