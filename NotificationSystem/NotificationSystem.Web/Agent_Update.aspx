<%@ Page Language="C#" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeBehind="Agent_Update.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Agent_Update" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="Controls_Update/ctrAgent_Update.ascx" TagPrefix="uc1" TagName="ctrAgent_Update" %>
<%@ Register Src="Controls_Search/ctrSearch_Agent_Update.ascx" TagPrefix="uc1" TagName="ctrSearch_Agent_Update" %>
<%@ Register Src="Controls_Search/ctrAgent_Search.ascx" TagPrefix="uc1" TagName="ctrAgent_Search" %>
<%@ Register Src="Controls_Add/ctrAgent_Add.ascx" TagPrefix="uc1" TagName="ctrAgent_Add" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceholder1">

               <script type="text/javascript">
                   function OnClientLoad0(sender, args) {
                       $telerik.$(".k-input")[0].setAttribute("readonly", "true");
                   }

                   function OnClientLoad1(sender, args) {
                       $telerik.$(".k-input")[2].setAttribute("readonly", "true");
                   }

               </script>


                 <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
              <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#b6b7bc">    
                     <h2>Update Agent</h2><br />

                          <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="agent" runat="server" ImageUrl="images/person1.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="100px" style="margin-top: 5px" Width="100px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>



<asp:TableCell VerticalAlign="Top"><uc1:ctrSearch_Agent_Update runat="server" ID="ctrSearch_Agent_Update" /></asp:TableCell>
</asp:TableRow>
                         </asp:Table>
                  <br />
                  <br />
              <div class="clear hideSkiplink">
                                          <asp:Menu ID="NavigationMenu" runat="server" CssClass="sub_menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                                              <Items>
                                                  <asp:MenuItem Text="Find" NavigateUrl="Agent_Find.aspx"></asp:MenuItem> 
                                                   <asp:MenuItem  Text="Add"  NavigateUrl="Agent_Add.aspx"></asp:MenuItem>
                                                  <asp:MenuItem Text="Update" NavigateUrl="Agent_Update.aspx"></asp:MenuItem> 
                                                  <asp:MenuItem Text="Delete" NavigateUrl="Agent_Delete.aspx"></asp:MenuItem> 
                                              </Items>
                                           </asp:Menu>
                                 </div>
                  <div>


<uc1:ctragent_update runat="server" id="ctrAgent_Update" />

                      </div>
                              </div>
               </asp:Content>

