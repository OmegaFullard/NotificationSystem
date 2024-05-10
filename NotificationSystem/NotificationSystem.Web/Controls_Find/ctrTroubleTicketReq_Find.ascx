<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ctrTroubleTicketReq_Find.ascx.cs" Inherits="ctrTroubleTicketReq_Find" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

 <script type="text/javascript">
            function showDetails(param) {

                var oWnd = window.radopen(null, "FormDetails");
                oWnd.setUrl(oWnd.get_navigateUrl().split("?")[0] + '?' + param.toString());
            }

            function OnClientclose(radWindow) {
                window.close;
            }
 </script>

   <telerik:RadWindowManager ID="Singleton" runat="server" >
                              <Windows>
                                  <telerik:RadWindow  ID="FormDetails" Behaviors="Close" 
                                    VisibleStatusbar="false"
                                     ReloadOnShow="true" OnClientClose="OnClientclose"
                                     BackColor="Gray" Modal="true" runat="server"  Height="450px"  Width="900px"
                                     NavigateUrl='<%# "../TroubleTicket_Find_Details.aspx" %>'>
                                </telerik:RadWindow>
                             </Windows>
        </telerik:RadWindowManager>

<div style="width: 1050px; height:800px;  overflow: auto; padding-left:30px" >
           <h2>Ticket Details</h2><br />   
           <div> <asp:Label ID="lblTroubleTicketNo" runat="server" Text=""></asp:Label></div><br />
    <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
  
           <asp:GridView ID="grdTroubleTicketReq" runat="server" 
                    AutoGenerateColumns="False" 
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="700px" AllowPaging="True" AllowSorting="True" PageSize="18">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>
						   	<asp:TemplateField HeaderText="ID" SortExpression="TroubleTicketNo" ItemStyle-Width="100"    Visible="True">
                                            <ItemTemplate>
                                                <a onclick="javascript:showDetails('troubleticketno=<%#Eval("TroubleTicketNo")%>;return false; href="#" id="a1"><%#Eval("TroubleTicketNo")%></a> 
                                            </ItemTemplate>
                                       </asp:TemplateField> 
                               <asp:BoundField DataField="ID" HeaderText="Customer ID" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
									   <asp:BoundField DataField="AgentID" HeaderText="Agent ID" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
									  								                                     
                              <asp:BoundField DataField="Status" HeaderText="Status" HtmlEncode="False" ReadOnly="True"  Visible="True" />
							    <asp:BoundField DataField="DueDate" HeaderText="Due Date" HtmlEncode="False" DataFormatString="{0:MM/dd/yyyy}"
                                       ReadOnly="True"  Visible="True" />
									     <asp:BoundField DataField="RequestDate" HeaderText="Request Date" HtmlEncode="False" DataFormatString="{0:MM/dd/yyyy}"
                                       ReadOnly="True"  Visible="True" />
                                  
                              <asp:BoundField DataField="Type" HeaderText="Type" HtmlEncode="False" 
                                       ReadOnly="True"  Visible="True" />
                             
                          </Columns>
                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
               </asp:GridView>
        </div>	