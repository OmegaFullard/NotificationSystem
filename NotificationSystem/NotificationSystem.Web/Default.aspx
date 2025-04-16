<%@ Page Title="Home" Language="vb" MasterPageFile="MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.Default" %>


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
  
                            <div aria-dropeffect="move" style="padding-left:10px; padding-right:10px; height:850px;overflow: auto; background:#eee9f7">   
                                
                                <br />
                                <br />
                                <br />
                                <br />
                                <asp:Panel ID="Panel1" runat="server" BackColor="#8035f0" BorderColor="#1e1e2f" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Size="Small" ForeColor="White" Height="450px" HorizontalAlign="Center" Width="250px">
                                    Created By: Omega Fullard<br />
                                    <br />
                                    <br />
                                    Royal City<br /> Notification System<asp:Image ID="handshake" runat="server" ImageUrl="images/handshake.png" BorderColor="#f2c2f2" BorderStyle="Solid" BorderWidth="1px" Height="132px" style="margin-top: 50px" Width="144px" />
                
                                    <br />
                                    <br />
                                    Version 1.0<br /> Date: April 22, 2024</asp:Panel>
                              </div>

         
            <a href="https://google.com/maps?q=39.57.09,75.10.14.8"></a>
    <center><p class="card-title"><strong>Directions to Our Help Desk Center</strong></p>                      
    
            <iframe src="https://www.google.com/maps/embed?pb=!1m16!1m12!1m3!1d12234.543958929013!2d-75.16621169999999!3d39.94953124999999!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!2m1!1s39.57.09%2C75.10.14.8!5e0!3m2!1sen!2sus!4v1723056453703!5m2!1sen!2sus" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
       </center>
        <center><a href="#" class="btn btn-primary">Directions</a></center>
        <br />
      
 

</asp:Content>
