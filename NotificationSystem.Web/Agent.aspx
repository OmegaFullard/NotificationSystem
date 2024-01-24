<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master"AutoEventWireup="true" CodeBehind="Agents.aspx.cs" Inherits="Agents" %>
<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <telerik:RadCard ID="RadCard1" runat="server" Width="285px">
       
    <telerik:CardImageComponent runat="server" src="images/Employee2.png"></telerik:CardImageComponent>

    <telerik:CardBodyComponent runat="server">
        <telerik:CardTitleComponent runat="server">
            <center><b>Agent Login</b></center>   
            <br />    
        </telerik:CardTitleComponent>
        </telerik:CardBodyComponent>
        </telerik:RadCard>
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        </telerik:RadAjaxManager>
        <div>
            <telerik:RadDataForm ID="RadDataForm1" Skin="Glow" runat="server" DataKeyNames="AgentID" DataSourceID="SqlDataSource1">
                <LayoutTemplate>
                    <div>
                        <div id="itemPlaceholder" runat="server"></div>
                    </div>
                    <div class="RadDataForm RadDataForm_<%# Container.Skin %> rdfLeftAligned rdfNoFieldHint">
                        <div id="Div1" runat="server">
                        </div>
                        <telerik:RadDataPager ID="RadDataPager1" runat="server" PagedControlID="RadDataForm1">
                            <Fields>
                                <telerik:RadDataPagerButtonField FieldType="FirstPrev" />
                                <telerik:RadDataPagerButtonField FieldType="NextLast" />
                                <telerik:RadDataPagerTemplatePageField>
                                    <PagerTemplate>
                                        <div>
                                            <label>
                                                Contact <strong>
                                                    <%#Container.Owner.StartRowIndex+1%></strong> of <strong>
                                                        <%# Container.Owner.TotalRowCount%></strong></label>
                                        </div>
                                    </PagerTemplate>
                                </telerik:RadDataPagerTemplatePageField>
                            </Fields>
                        </telerik:RadDataPager>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <fieldset class="rdfFieldset rdfBorders">
                        <div class="rdfRow">
                            <asp:Label runat="server" ID="lblAgentID" Text="Agent ID:"></asp:Label>
                            <asp:Label Text='<%# Eval("AgentID") %>' runat="server" ID="Label5" />
                        </div>
                        <div class="rdfRow">
                            <asp:Label runat="server" ID="lblTitle" Text="Job Title:"></asp:Label>
                            <asp:Label Text='<%# Eval("Title") %>' runat="server" ID="Label8" />
                        </div>
                        <div class="rdfRow">
                            <asp:Label runat="server" ID="lblSalary" Text="Salary:"></asp:Label>
                            <asp:Label Text='<%# Eval("Salary") %>' runat="server" ID="Label9" />
                        </div>
                        <div class="rdfRow">
                            <asp:Label runat="server" ID="lblFN" Text="First Name:"></asp:Label>
                            <asp:Label Text='<%# Eval("FirstN") %>' runat="server" ID="lbl2" />
                        </div>
                        <div class="rdfRow">
                            <asp:Label runat="server" ID="lblLN" Text="Last Name:"></asp:Label>
                            <asp:Label Text='<%# Eval("LastN") %>' runat="server" ID="lbl4" />
                        </div>
                        <div class="rdfRow">
                            <asp:Label runat="server" ID="lblTroubleTicketNo" Text="Trouble Ticket#:"></asp:Label>
                            <asp:Label Text='<%# Eval("TroubleTicketNo") %>' runat="server" ID="Label6" />
                        </div>
                        <div class="rdfRow">
                            <asp:Label runat="server" ID="lblStartDate" Text="Start Date:"></asp:Label>
                            <asp:Label Text='<%# Eval("Start Date") %>' runat="server" ID="Label7" />
                        </div>                        

                        <div class="rdfRow">
                            <asp:Label runat="server" ID="lblEmail" Text="Email Address:"></asp:Label>
                            <asp:Label Text='<%# Eval("Email") %>' runat="server" ID="lbl6" />
                        </div>
                        <div class="rdfRow">
                            <asp:Label runat="server" ID="lblPhone" Text="Phone Number:"></asp:Label>
                            <asp:Label Text='<%# Eval("Phone") %>' runat="server" ID="lbl8" />
                        </div>
                        <div class="rdfRow">
                            <asp:Label runat="server" ID="lblFax" Text="Fax Number:"></asp:Label>
                            <asp:Label Text='<%# Eval("Fax") %>' runat="server" ID="lbl10" />
                    </fieldset>
                </ItemTemplate>
            </telerik:RadDataForm>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:NotificationSystemConnectionString %>' SelectCommand="SELECT * FROM [Agent]"></asp:SqlDataSource>
            <br />
            <br />
            <a href="Default.aspx"><< Back to Home</a><br />
        </div>
  
</asp:Content>
