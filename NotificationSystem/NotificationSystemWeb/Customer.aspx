<%@ Page Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="False" CodeBehind="Customer.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Customer" %>
<%@ Register Src="Controls_Search/ctrCustomer_Search.ascx" TagPrefix="uc1" TagName="ctrCustomer_Search" %>
<%@ Register Src="ctrCustomer.ascx" TagPrefix="uc1" TagName="ctrCustomer" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">

    
                   <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                          <asp:Image ID="defaultuser" runat="server" ImageUrl="images/defaultuser.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="100px" style="margin-top: 5px" Width="100px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrCustomer_Search runat="server" ID="ctrCustomer_Search" /></asp:TableCell>
                                    </asp:TableRow>
                             
                         </asp:Table>
                  <br />
               
              <uc1:ctrCustomer runat="server" id="ctrCustomer" />
            <br />
    <div>
            <a href="Default.aspx"><< Back to Home</a><br />
        </div>
  
</asp:Content>


