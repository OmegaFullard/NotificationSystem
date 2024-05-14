<%@ Page Title="Home" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Default" %>


<asp:Content ID="Content0" ContentPlaceHolderID="head" Runat="Server">
    
    
<link rel="Stylesheet" href="https://cdn.jsdeliver.net/gh/openlayers.github.io@master/en/v6.2.1/css/ol.css" />
<style>
.map {
Height: 400px;
Width: 100%;
}

</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
  
                            <div aria-dropeffect="move" style="padding-left:10px;padding-top:10px; padding-bottom:10px; height:500px;">
                                <asp:Panel ID="Panel1" runat="server" BackColor="#884dff" BorderColor="#1e1e2f" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="450px" HorizontalAlign="Center" Width="250px">
                                    Created By: Omega Fullard<br />
                                    <br />
                                    <br />
                                    For: Royal City<br /> Notification System<asp:Image ID="handshake" runat="server" ImageUrl="images/handshake.png" BorderColor="#f2c2f2" BorderStyle="Solid" BorderWidth="1px" Height="132px" style="margin-top: 50px" Width="144px" />
                
                                    <br />
                                    <br />
                                    Version 1.0<br /> Date: April 22, 2024</asp:Panel>
                              </div>
<div class="card card-transparent">

    
        <h4 class="card-title">Reviews</h4>
        <p><strong>Please be sure to follow us on Social Media!, links to social media websites</strong></p>
        <a href="#" class="btn btn-primary">Reviews</a>
		<div class="card-footer text-muted">
   <p>Leave us a review and let us how we are doing and how we can improve. </p>
 

    <h4 class="card-title"><strong>Directions to Our Help Desk Center</strong></h4>                       
    <a href="#" class="btn btn-primary">Directions</a>
            <a href="https://google.com/maps?q=39.57.09,75.10.14.8"></a>
  </div>
  <div class="card-footer text-muted">
   <p>Available throughout the U.S 24/7</p>
  </div>
</div>
    
 
</asp:Content>
