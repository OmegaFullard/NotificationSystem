<%@ Page Language="C#" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeBehind="Customer_Update.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Customer_Update" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="Controls_Search/ctrCustomer_Search.ascx" TagPrefix="uc1" TagName="ctrCustomer_Search" %>
<%@ Register Src="Controls_Add/ctrCustomer_Add.ascx" TagPrefix="uc1" TagName="ctrCustomer_Add" %>
<%@ Register Src="Controls_Update/ctrCustomer_Update.ascx" TagPrefix="uc1" TagName="ctrCustomer_Update" %>




<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceholder1">
              <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#b6b7bc">    
                                               <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Height="141px" Width="152px" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                           <asp:Image ID="customer" runat="server" ImageUrl="images/defaultuser.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="100px" style="margin-top: 5px" Width="100px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>

<asp:TableCell VerticalAlign="Top"><uc1:ctrCustomer_Search runat="server" ID="ctrCustomer_Search" /></asp:TableCell>
</asp:TableRow>
                         </asp:Table>
             <br />

                 
                  <uc1:ctrCustomer_Update runat="server" id="ctrCustomer_Update" />

                      </div>
                             
               </asp:Content>
