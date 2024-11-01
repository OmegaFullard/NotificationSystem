<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Add.aspx.cs" MasterPageFile="MasterPage.master" Inherits="NotificationSystem.NotificationSystem.Web.Admin_Add" %>
<%@ Register Src="Controls_Search/ctrSearch_Admin_Update.ascx" TagPrefix="uc1" TagName="ctrSearch_Admin_Update" %>
<%@ Register Src="Controls_Search/ctrSearch_Admin.ascx" TagPrefix="uc1" TagName="ctrSearch_Admin" %>
<%@ Register Src="Controls_Delete/ctrAdmin_Delete.ascx" TagPrefix="uc1" TagName="ctrAdmin_Delete" %>
<%@ Register Src="Controls_Add/ctrAdmin_Add.ascx" TagPrefix="uc1" TagName="ctrAdmin_Add" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
   <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceholder1">
              <script type="text/javascript">
                  function OnClientLoad0(sender, args) {
                      $telerik.$(".k-input")[0].setAttribute("readonly", "true");
                  }

              </script>
              
              <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#b6b7bc">    
                     <h2>Add Admin</h2><br />

                       <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >

 <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="admin" runat="server" ImageUrl="images/person1.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="100px" style="margin-top: 5px" Width="100px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                           <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrSearch_Admin runat="server" id="ctrSearch_Admin" Visible="false" /></asp:TableCell>
                                                 
                                    </asp:TableRow>
                         </asp:Table>
                  <br />
                   <div class="clear hideSkiplink">
                                          <asp:Menu ID="NavigationMenu" runat="server" CssClass="sub_menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                                              <Items>
                                                  <asp:MenuItem Text="Find" NavigateUrl="Admin_Find.aspx"></asp:MenuItem> 
                                                   <asp:MenuItem  Text="Add"  NavigateUrl="Admin_Add.aspx"></asp:MenuItem>
                                                  <asp:MenuItem Text="Update" NavigateUrl="Admin_Update.aspx"></asp:MenuItem> 
                                                  <asp:MenuItem Text="Delete" NavigateUrl="Admin_Delete.aspx"></asp:MenuItem> 
                                              </Items>
                                           </asp:Menu>
                                 </div>

       <uc1:ctrAdmin_Add runat="server" id="ctrAdmin_Add" />

                     </div>                  
                
    </asp:Content>
	
