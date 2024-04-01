<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="MasterPage.master" CodeBehind="rptAgent.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.rptAgent" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<%@ Register Src="Controls_Search/ctrAgent_Search.ascx" TagPrefix="uc1" TagName="ctrAgent_Search" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
            </asp:Content>
           <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="ContentPlaceholder1">
                <div aria-dropeffect="move" style="padding-left:10px; height:600px;overflow: auto; background:rgba(236, 236, 236, 1);">   
                  
                     <h2>Reports:Agents</h2><br />
                         <asp:Table ID="Table1" runat="server" ForeColor="#0000A0" >
                                   
                                     <asp:TableRow>
                                        <asp:TableCell> <asp:Panel ID="Panel1" runat="server" BackColor="#465c71"   Height="90px" HorizontalAlign="Center"  Width="90px">
                                                            <asp:Image ID="Image1" runat="server" ImageUrl="Images/Report2.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="80px" style="margin-top: 5px" Width="80px" />
                                                       </asp:Panel> 
                                         </asp:TableCell>
                                          <asp:TableCell>&nbsp;&nbsp;&nbsp</asp:TableCell>
                                        <asp:TableCell VerticalAlign="Top"><uc1:ctrAgent_Search runat="server" id="ctrAgent_Search" /></asp:TableCell>
                                    </asp:TableRow>
                         </asp:Table>

               
                          <rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor=""  ZoomPercent= "75" ClientIDMode="AutoID" HighlightBackgroundColor="" 
                                InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor=""
                                LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor=""
                                PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor=""
                                SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor=""
                                ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px"
                                ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px"
                                ToolBarItemPressedHoverBackColor="153, 187, 226" Width="100%">
                             <LocalReport ReportPath="">
                                    <DataSources>
                                        <rsweb:ReportDataSource DataSourceId="" Name="" />
                                    </DataSources>
                                </LocalReport>
                        </rsweb:ReportViewer>
                </div>
          
 </asp:Content>
