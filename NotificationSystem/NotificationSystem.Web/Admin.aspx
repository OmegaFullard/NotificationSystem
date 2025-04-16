<%@ Page Language="vb#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Admin" %>

<%@ Register Src="ctrAdmin.ascx" TagPrefix="uc1" TagName="ctrAdmin" %>
<%@ Register Src="Controls_Search/ctrSearch_Admin.ascx" TagPrefix="uc1" TagName="ctrSearch_Admin" %>


<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
    <title>Admins</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    
                   <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Height="222px" Width="483px" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="admin" runat="server" ImageUrl="images/admin.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="150px" style="margin-top: 5px" Width="150px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrSearch_Admin runat="server" ID="ctrSearch_Admin" /></asp:TableCell>
                                    </asp:TableRow>
                             
                         </asp:Table>
                  <br />
               
              <uc1:ctrAdmin runat="server" id="ctrAdmin" />
            <br />
    <div>
            <a href="Default.aspx"><< Back to Home</a><br />
        </div>
    </asp:Content>