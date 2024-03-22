<%@ Control Language="C#" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeBehind="ctrCustomer_Update.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.ctrCustomer_Update" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>


  <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      </asp:Content>
<style type="text/css">

    div.RadCalendarFastNavPopup {
        width: 105px !important;
        overflow: hidden;
    }

    table.RadCalendarMonthView_Default {
        width: 210px !important;
        margin-left: -105px;
    }

    table.RadCalendarMonthView_Default tr:nth-child(7) td.rcButtons
    {
        text-align: right !important;
    }

    .rcOkButton {
        margin-left: 20px;
    }

   
</style>

  <div style="width: 950px; height:500px;  overflow: auto; padding-left:30px" >
      <h2>Customer Update</h2>
            
           <div> <asp:Label ID="lblcustomerid" runat="server" Text=""></asp:Label></div><br />
           <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
     
           <asp:GridView ID="grdCustomers" runat="server" 
                    AutoGenerateColumns="False" 
               DataKeyNames="CustomerID"
                    ShowFooter="True"
                    EmptyDataText="There are no records matching this search criteria."
                    BackColor="White" ForeColor="Black" CssClass="grdRecords"
                    HeaderStyle-CssClass="grdHeader"
                    width="950px" AllowPaging="True" AllowSorting="True" PageSize="18">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>

                               <asp:CommandField ShowEditButton="true"  EditText="Edit"  ButtonType="Button" ItemStyle-Width="150"/> 

                               <asp:TemplateField HeaderText="Customer ID" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblcustomerid" runat="server" Text='<%# Eval("CustomerID") %>' Width="140"></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtCustomerID" runat="server" Text='<%# Eval("CustomerID") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                               </asp:TemplateField>
							   
							     <asp:TemplateField HeaderText="Agent ID" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblagentid" runat="server" Text='<%# Eval("AgentID") %>' Width="140"></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtAgentID" runat="server" Text='<%# Eval("AgentID") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                               </asp:TemplateField>
                              
                              <asp:TemplateField HeaderText="Ticket Number" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblTroubleTicketNo" runat="server" Text='<%# Eval("TroubleTicketNo") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtTroubleTicketNo" runat="server" Text='<%# Eval("TroubleTicketNo") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                               </asp:TemplateField>                                                       
                                 
								   <asp:TemplateField HeaderText="First Name" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblfirstname" runat="server" Text='<%# Eval("FirstN") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtfirstname" runat="server" Text='<%# Eval("FirstN") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                               </asp:TemplateField>
							   
							   
                                <asp:TemplateField HeaderText="Last Name" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lbllastname" runat="server" Text='<%# Eval("LastN") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtlastname" runat="server" Text='<%# Eval("LastN") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                               </asp:TemplateField>
							   
							                  
                    
                                <asp:TemplateField HeaderText="Email" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblemail" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtemail" runat="server" Text='<%# Eval("Email") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                               </asp:TemplateField>

                              <asp:TemplateField HeaderText="Phone" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblphone" runat="server" Text='<%# Eval("Phone") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtphone" runat="server" Text='<%# Eval("Phone") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                               </asp:TemplateField>
                                  
                         
                                   <asp:TemplateField HeaderText="Address" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lbladdress" runat="server" Text='<%# Eval("Address") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtaddress" runat="server" Text='<%# Eval("Address") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                              </asp:TemplateField>
							  
							        <asp:TemplateField HeaderText="City" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblcity" runat="server" Text='<%# Eval("City") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtcity" runat="server" Text='<%# Eval("City") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                              </asp:TemplateField>
      <asp:TemplateField HeaderText="State" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblstate" runat="server" Text='<%# Eval("State") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtstate" runat="server" Text='<%# Eval("State") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                              </asp:TemplateField>
							        <asp:TemplateField HeaderText="Zip" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblzip" runat="server" Text='<%# Eval("Zip") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtzip" runat="server" Text='<%# Eval("Zip") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                              </asp:TemplateField>




                          </Columns>
                        <FooterStyle BackColor ="#CCCCCC" ForeColor="black"/>
                        <HeaderStyle  HorizontalAlign="Left" ForeColor="#303030" />
                          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>

               
               </asp:GridView>
        </div>
<br />
<br />
 <div style="padding-left:750px;padding-bottom:10px;"  ><asp:Button ID="btnUpdate" runat="server" Text="Update" Width="150" /></div>
