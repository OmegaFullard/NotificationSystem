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
                    width="950px" AllowPaging="True" AllowSorting="True" PageSize="18">
                    <PagerSettings Mode="NumericFirstLast"    Position="Bottom" />
                          <Columns>

                               <asp:CommandField ShowEditButton="true"  EditText="Edit"  ButtonType="Button" ItemStyle-Width="150"/> 

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
                                 
                              <asp:TemplateField HeaderText="Title" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("Title") %>' Width="140"></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txttitle" runat="server" Text='<%# Eval("Title") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                               </asp:TemplateField>
                              
                               <asp:TemplateField HeaderText="Start Date" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblStartDate" runat="server" Text='<%# Eval("StartDate") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtStartDate" runat="server" Text='<%# Eval("StartDate") %>' Width="140" AutoPostBack="True"></asp:TextBox>
                                   </EditItemTemplate>
                               </asp:TemplateField>
                                 
                                
                               <asp:TemplateField HeaderText="Salary" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblSalary" runat="server" Text='<%# Eval("Salary") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtsalary" runat="server" Text='<%# Eval("Salary") %>' Width="140" AutoPostBack="True"></asp:TextBox>
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
                                  
                               <asp:TemplateField HeaderText="Fax" ItemStyle-Width="150">
                                   <ItemTemplate>
                                          <asp:Label ID="lblfax" runat="server" Text='<%# Eval("Fax") %>'></asp:Label>
                                  </ItemTemplate>
                                  <EditItemTemplate>
                                       <asp:TextBox ID="txtfax" runat="server" Text='<%# Eval("Fax") %>' Width="140" AutoPostBack="True"></asp:TextBox>
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