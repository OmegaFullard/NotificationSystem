<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeBehind="Agent_Add.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Agent_Add" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="Controls_Search/ctrAgent_Search.ascx" TagPrefix="uc1" TagName="ctrAgent_Search" %>
<%@ Register Src="Controls_Add/ctrAgent_Add.ascx" TagPrefix="uc1" TagName="ctrAgent_Add" %>



<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceholder1">
               <script type="text/javascript">

                   function OnClientLoad1(sender, args) {
                       $telerik.$(".k-input")[1].setAttribute("readonly", "true");
                   }

               </script>
             

                 
              <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#eee9f7">    
                     <h2>Add Agent</h2><br />

                       <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Height="153px" Width="154px" >

 <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="150px" HorizontalAlign="Center"  Width="150px">
                                                            <asp:Image ID="agent" runat="server" ImageUrl="images/person1.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="170px" style="margin-top: 5px" Width="170px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
     
                                           <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrAgent_search runat="server" id="ctrAgent_Search" Visible="false" /></asp:TableCell>
                                                 
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
                                                  
                                              </Items>
                                           </asp:Menu>
                                 </div>

<uc1:ctrAgent_Add runat="server" id="ctrAgent_Add" />

                     </div>                  
                
    </asp:Content>
