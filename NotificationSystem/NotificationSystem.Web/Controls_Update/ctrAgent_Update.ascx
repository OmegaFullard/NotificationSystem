<%@ Control Language="C#" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeBehind="ctrAgent_Update.ascx.cs" Inherits="ctrAgent_Update" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>


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
      <h2>Agent Update</h2>
            
           <div> <asp:Label ID="lblagentid" runat="server" Text=""></asp:Label></div><br />
           <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
     
      <asp:GridView ID="grdAgent" runat="server"
          AutoGenerateColumns="False"
          DataKeyNames="AgentID"
          ShowFooter="True"
          EmptyDataText="There are no records matching this search criteria."
          BackColor="White" ForeColor="Black" CssClass="grdRecords"
          HeaderStyle-CssClass="grdHeader"
          Width="950px" AllowPaging="True" AllowSorting="True" PageSize="18" DataSourceID="SqlDataSource1">
          <PagerSettings Mode="NumericFirstLast" Position="Bottom" />
          <Columns>
              <asp:BoundField DataField="AgentID" HeaderText="AgentID" ReadOnly="True" SortExpression="AgentID"></asp:BoundField>
              <asp:BoundField DataField="TroubleTickeNo" HeaderText="TroubleTickeNo" SortExpression="TroubleTickeNo"></asp:BoundField>
              <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title"></asp:BoundField>
              <asp:BoundField DataField="StartDate" HeaderText="StartDate" SortExpression="StartDate"></asp:BoundField>
              <asp:BoundField DataField="Salary" HeaderText="Salary" SortExpression="Salary"></asp:BoundField>
              <asp:BoundField DataField="FirstN" HeaderText="FirstN" SortExpression="FirstN"></asp:BoundField>
              <asp:BoundField DataField="LastN" HeaderText="LastN" SortExpression="LastN"></asp:BoundField>
              <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email"></asp:BoundField>
              <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone"></asp:BoundField>
              <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax"></asp:BoundField>




          </Columns>
          <FooterStyle BackColor="#CCCCCC" ForeColor="black" />
          <HeaderStyle HorizontalAlign="Left" ForeColor="#303030" />
          <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>


      </asp:GridView>
      <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:NotificationSystemConnectionString %>' SelectCommand="SELECT * FROM [Agent]"></asp:SqlDataSource>
  </div>
<br />
<br />
 <div style="padding-left:750px;padding-bottom:10px;"  ><asp:Button ID="btnUpdate" runat="server" Text="Update" Width="150" /></div>
