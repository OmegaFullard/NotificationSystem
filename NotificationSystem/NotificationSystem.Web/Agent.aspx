<%@ Page Language="C#" MasterPageFile="MasterPage.Master"AutoEventWireup="true" CodeBehind="Agent.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Agent" %>
<%@ Register Src="ctrAgent.ascx" TagPrefix="uc1" TagName="ctrAgent" %>
<%@ Register Src="Controls_Search/ctrSearch_Agent_Find.ascx" TagPrefix="uc1" TagName="ctrSearch_Agent_Find" %>
<%@ Register Src="Controls_Search/ctrAgent_Search.ascx" TagPrefix="uc1" TagName="ctrAgent_Search" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
    <title>Agents</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    
                   <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" Height="222px" Width="483px" >
                                   
                                     <asp:TableRow>
                                          <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="employee" runat="server" ImageUrl="images/person1.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="150px" style="margin-top: 5px" Width="150px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrSearch_Agent_Find runat="server" ID="ctrSearch_Agent_Find" /></asp:TableCell>
                                    </asp:TableRow>
                             
                         </asp:Table>
                  <br />
               
              <uc1:ctrAgent runat="server" id="ctrAgent" />
            <br />
    <div>
            <a href="Default.aspx"><< Back to Home</a><br />
        </div>
  
</asp:Content>
