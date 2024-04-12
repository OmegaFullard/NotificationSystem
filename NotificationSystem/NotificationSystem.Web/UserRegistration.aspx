<%@ Page Title="User Registration" Language="C#" MasterPageFile="MasterPage.Master" AutoEventWireup="false" CodeBehind="UserRegistration.aspx.cs" Inherits="NotificationSystem.NotificationSystem.Web.UserRegistration" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content0" ContentPlaceHolderID="head" runat="server">
</asp:Content>
  

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
     <div class="container-fluid">
      <div class="row">
         <div class="col-md-5">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                         <br />
                         <br />
                         <br />
                         <br />
                        <center>
                                <asp:Image ID="customerreg" runat="server" ImageUrl="images/defaultuser.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="150px" style="margin-top: 5px" Width="150px" />
                        </center>
                     </div>
                  </div>
                   </div>
                  <div class="row">
                     <div class="col">
                      
                     </div>
                  </div>
                   <br />
                       <div class="info-text login">
                <h2>Account Registration</h2>
                <p>Please verify all information is correct.</p>
                  <div class="row">
                     <div class="col">
                        <hr/>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Full Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Full Name" AutoPostBack="True" CausesValidation="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Registration Date</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Registration Date" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Phone Number</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Phone" AutoPostBack="True" CausesValidation="True" MaxLength="10"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Email Address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Email Address" AutoPostBack="True" CausesValidation="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>

                    <div class="row">
                     <div class="col">
                        <label>Full Address</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2" AutoCompleteType="HomeStreetAddress" AutoPostBack="True" CausesValidation="True"></asp:TextBox>
                            <ajaxToolkit:CalendarExtender ID="TextBox5_CalendarExtender" runat="server" BehaviorID="TextBox5_CalendarExtender" TargetControlID="TextBox5" />
                        </div>
                     </div>

                  </div>

                    <div class="col-md-4">
                        <label>City</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox6" runat="server" placeholder="City" AutoCompleteType="HomeCity" AutoPostBack="True" CausesValidation="True"></asp:TextBox>
                        </div>
                     </div>
                  <div class="row">
                     <div class="col-md-4">
                        <label>State</label>
                        <div class="form-group" autocompletetype="HomeState">
                           <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="Alabama" Value="Alabama" />
                              <asp:ListItem Text="Alaska" Value="Alaska" />
                              <asp:ListItem Text="Arizona" Value="Arizona" />
                              <asp:ListItem Text="Arkansas" Value="Arkansas" />
                              <asp:ListItem Text="California" Value="California" />
                              <asp:ListItem Text="Colorado" Value="Colorado" />
                              <asp:ListItem Text="Connecticut" Value="Connecticut" />
                              <asp:ListItem Text="Delaware" Value="Delaware" />
                              <asp:ListItem Text="Florida" Value="Florida" />
                              <asp:ListItem Text="Georgia" Value="Georgia" />
                              <asp:ListItem Text="Hawaii" Value="Hawaii" />
                              <asp:ListItem Text="Idaho" Value="Idaho" />
                              <asp:ListItem Text="Illinois" Value="Illinois" />
                              <asp:ListItem Text="Indiana" Value="Indiana" />
                              <asp:ListItem Text="Iowa" Value="Iowa" />
                              <asp:ListItem Text="Kansas" Value="Kansas" />
                              <asp:ListItem Text="Kentucky" Value="Kentucky" />
                              <asp:ListItem Text="Louisiana" Value="Louisiana" />
                              <asp:ListItem Text="Maine" Value="Maine" />
                              <asp:ListItem Text="Maryland" Value="Maryland" />
                              <asp:ListItem Text="Massachusetts" Value="Massachusetts" />
                              <asp:ListItem Text="Michigan" Value="Michigan" />
                              <asp:ListItem Text="Minnesota" Value="Minnesota" />
                              <asp:ListItem Text="Mississippi" Value="Mississippi" />
                              <asp:ListItem Text="Missouri" Value="Missouri" />
                              <asp:ListItem Text="Montana" Value="Montana" />
                              <asp:ListItem Text="Nebraska" Value="Nebraska" />
                              <asp:ListItem Text="Nevada" Value="Nevada" />
                              <asp:ListItem Text="New Hampshire" Value="New Hampshire" />
                              <asp:ListItem Text="New Jersey" Value="New Jersey" />
                               <asp:ListItem Text="New Mexico" Value="New Mexico" />
                               <asp:ListItem Text="New York" Value="New York" />
                               <asp:ListItem Text="North Carolina" Value="North Carolina" />
                               <asp:ListItem Text="North Dakota" Value="North Dakota" />
                               <asp:ListItem Text="Ohio" Value="Ohio" />
                               <asp:ListItem Text="Oklahoma" Value="Oklahoma" />
                               <asp:ListItem Text="Oregon" Value="Oregon" />
                               <asp:ListItem Text="Pennsylvania" Value="Pennsylvania" />
                               <asp:ListItem Text="Rhode Island" Value="Rhode Island" />
                               <asp:ListItem Text="South Carolina" Value="South Carolina" />
                               <asp:ListItem Text="South Dakota" Value="South Dakota" />
                                <asp:ListItem Text="Tennessee" Value="Tennessee" />
                                <asp:ListItem Text="Texas" Value="Texas" />
                                <asp:ListItem Text="Utah" Value="Utah" />
                                <asp:ListItem Text="Vermont" Value="Vermont" />
                                <asp:ListItem Text="Virginia" Value="Virginia" />
                                <asp:ListItem Text="Washington" Value="Washington" />
                                <asp:ListItem Text="West Virginia" Value="West Virginia" />
                                <asp:ListItem Text="Wisconsin" Value="Wisconsin" />
                                <asp:ListItem Text="Wyoming" Value="Wyoming" />
                           </asp:DropDownList>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Zip</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox11" runat="server" placeholder="Zip" AutoPostBack="True" CausesValidation="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                 </div>
            
                    <br />
                    <br />
                  <div class="row">
                     <div class="col">
                        
                           <span class="badge badge-pill badge-info"><b>Login Credentials</b></span>
                      

                     </div>
                  </div>
                   <br />
                    
                  <div class="row">
                     <div class="col-md-4">
                        <label>User ID</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox8" runat="server" placeholder="User ID" AutoPostBack="True" CausesValidation="True" MaxLength="10"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox9" runat="server" placeholder="Password" TextMode="Password" ReadOnly="True" AutoPostBack="True" CausesValidation="True" MaxLength="10"></asp:TextBox>
                        </div>
                     </div>
                    
                       
                  <div class="row">
                     <div class="col-8 mx-auto">
                      
                            <br />
                               <br />
                           <div class="form-group">
                          
                               <asp:Button class="btn btn-primary btn-block btn-lg" ID="Button2" runat="server" Width="245px" Height="50px" style="color: #ffffff; background-color: #0000ff; border: medium solid #e6ecff" Text="Sign Up" />
                           </div>
                      
                     </div>
                  </div>
                   </div>
                    <br />
                    <p>Already Have an Account?<a href="UserViewProfile.aspx">   Login</a></p>
                    </div>                            
            <br />
                <br />
               </div>
            
              <br/>
             <br/>
            <a href="default.aspx"><< Back to Home</a>
             <br/>
             <br/>
         </div>
         <div class="col-md-7">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                             <asp:Image ID="logo" runat="server" ImageUrl="images/RCLogo.png"  BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="150px" style="margin-top: 5px" Width="150px" />
                        </center>
                     </div>
                  </div>
                  
                  </div>
             
            </div>
         </div>
      </div>
   
</asp:Content>




