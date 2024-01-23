<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ctrAgent.ascx.cs" Inherits="NotificationSystem.NotificationSystem.Web.ctrAgent" %>

<div style="width: 1200px; height:500px;  overflow: auto; padding-left:5px" >
           <div class="Heading" >Agent List</div>
           <div><asp:HiddenField ID="ctrHiddebField" runat="server" /></div><br />
    
           <div style="padding-bottom:10px; font-weight:400"> <asp:Label ID="lblSearchResult" runat="server" Text=""></asp:Label></div>
    <asp:GridView ID="grdAgents" runat="server"
        AutoGenerateColumns="False"
        ShowFooter="True"
        EmptyDataText="There are no records matching this search criteria."
        BackColor="White" ForeColor="Black" CssClass="grdRecords"
        HeaderStyle-CssClass="grdHeader"
        Width="1200px" AllowPaging="True" AllowSorting="True" PageSize="9" DataKeyNames="AgentID" DataSourceID="SqlDataSource1">
        <PagerSettings Mode="NumericFirstLast" Position="Bottom" />
        <Columns>

            <asp:BoundField DataField="AgentID" HeaderText="AgentID" SortExpression="AgentID" ItemStyle-Width="100"
                ReadOnly="True" Visible="True" />
            <asp:BoundField DataField="TroubleTickeNo" HeaderText="TroubleTickeNo" ItemStyle-Width="100" Visible="True" SortExpression="TroubleTickeNo" />
            <asp:BoundField DataField="Title" HeaderText="Title" ItemStyle-Width="100" Visible="True" SortExpression="Title" />
            <asp:BoundField DataField="StartDate" HeaderText="StartDate" ItemStyle-Width="100" Visible="True" SortExpression="StartDate" />
            <asp:BoundField DataField="Salary" HeaderText="Salary" ItemStyle-Width="100" Visible="True" SortExpression="Salary" />
            <asp:BoundField DataField="FirstN" HeaderText="FirstN" ItemStyle-Width="100" Visible="True" SortExpression="FirstN" />
            <asp:BoundField DataField="LastN" HeaderText="LastN" ItemStyle-Width="100" Visible="True" SortExpression="LastN" />
            <asp:BoundField DataField="Email" HeaderText="Email" ItemStyle-Width="100" Visible="True" SortExpression="Email" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" ItemStyle-Width="100" Visible="True" SortExpression="Phone" />
            <asp:BoundField DataField="Fax" HeaderText="Fax" ItemStyle-Width="100" Visible="True" SortExpression="Fax" />

        </Columns>


        <FooterStyle BackColor="#CCCCCC" ForeColor="black" />
        <HeaderStyle HorizontalAlign="Left" ForeColor="#303030" />
        <AlternatingRowStyle CssClass="grdAlternatingRow"></AlternatingRowStyle>
    </asp:GridView>
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:NotificationSystemConnectionString %>' SelectCommand="SELECT * FROM [Agent]"></asp:SqlDataSource>
</div>