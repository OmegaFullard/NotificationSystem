<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Customer" %>


<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
     <div class="container">
      <div class="row">
         <div class="col-md-6">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Customer Details</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <img src="images/defaultuser.png" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr/>
                     </div>
                  </div>
    
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <div>

        <telerik:RadDataForm ID="RadDataForm1" Skin="Glow" runat="server" DataKeyNames="CustomerID" DataSourceID="SqlDataSource1">
           <LayoutTemplate>
        <div >
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
                <asp:Label runat="server" ID="lblCustomerID" Text="Customer ID:"></asp:Label>
                <asp:Label Text='<%# Eval("CustomerID") %>' runat="server" ID="Label4" />
            </div>
               <div class="rdfRow">
                <asp:Label runat="server" ID="lblAgentID" Text="Agent ID:"></asp:Label>
                <asp:Label Text='<%# Eval("AgentID") %>' runat="server" ID="Label1" />
            </div>
               <div class="rdfRow">
                <asp:Label runat="server" ID="lblTicketNo" Text="Ticket #:"></asp:Label>
                <asp:Label Text='<%# Eval("TroubleTicketNo") %>' runat="server" ID="Label5" />
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
                <asp:Label runat="server" ID="lblEmail" Text="Email Address:"></asp:Label>
                <asp:Label Text='<%# Eval("Email") %>' runat="server" ID="lbl6" />
            </div>
            <div class="rdfRow">
                <asp:Label runat="server" ID="lblPhone" Text="Phone Number:"></asp:Label>
                <asp:Label Text='<%# Eval("Phone") %>' runat="server" ID="lbl8" />
            </div>
            <div class="rdfRow">
                <asp:Label runat="server" ID="lblAddress" Text="Address:"></asp:Label>
                <asp:Label Text='<%# Eval("Address") %>' runat="server" ID="lbl10" />
            </div>
            <div class="rdfRow">
                <asp:Label runat="server" ID="lblCity" Text="City:"></asp:Label>
                <asp:Label Text='<%# Eval("City") %>' runat="server" ID="lbl12" />
            </div>
            <div class="rdfRow">
                <asp:Label runat="server" ID="lblState" Text="State:"></asp:Label>
                <asp:Label Text='<%# Eval("State") %>' runat="server" ID="Label2" />
            </div>
            <div class="rdfRow">
                <asp:Label runat="server" ID="lblZip" Text="Zip:"></asp:Label>
                <asp:Label Text='<%# Eval("Zip") %>' runat="server" ID="Label3" />
            </div>
         
        </fieldset>
    </ItemTemplate>
        </telerik:RadDataForm>
        <br />
           <a href="Default.aspx"><< Back to Home</a><br />
    </div>
                   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:NotificationSystemConnectionString %>' SelectCommand="SELECT * FROM [Customer]">
          
        </asp:SqlDataSource>
    </div>
                </div>
             </div>
          </div>
         </div>
    </asp:Content>
