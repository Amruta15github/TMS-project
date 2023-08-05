<%@ Page Title="" Language="C#" MasterPageFile="~/TMS.master" AutoEventWireup="true" CodeFile="stud_register.aspx.cs" Inherits="stud_register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
    <div class="container" style="-webkit-box-shadow: -1px 0px 25px 5px rgba(0,0,0,0.75);
                 -moz-box-shadow: -1px 0px 25px 5px rgba(0,0,0,0.75);
                  box-shadow: 2px 0px 15px -1px rgba(0,0,0,0.75);">
        <br />
        <div class="row">
            <div class="col-md-12">
            <h2 "col-md-4 mx-auto text-center text-black">Student Registration</h2>            
            </div>            
                    
        </div>

        <div class="row">
            <div class="col-md-4">

                <asp:TextBox ID="txtname" CssClass="form-control" placeholder="Enter ur Name" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidatorname" runat="server" ErrorMessage=" Name is Required" 
                 ControlToValidate="txtname" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="txtfathername" CssClass="form-control" placeholder="Enter ur Fathername" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidatorfathername" runat="server" ErrorMessage=" FatherName is Required" 
                 ControlToValidate="txtfathername" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="txtsurname" CssClass="form-control" placeholder="Enter ur Surname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorsurname" runat="server" ErrorMessage=" SurName is Required" 
                 ControlToValidate="txtsurname" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />
                <asp:DropDownList ID="ddlgender" CssClass="form-control"  runat="server">

                    <asp:ListItem>Select Gender</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorddlgender" runat="server" ErrorMessage="Select Gender" 
                 ControlToValidate="ddlgender" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" InitialValue="Select Gender"></asp:RequiredFieldValidator>
                <br />
                <asp:TextBox ID="txtage" CssClass="form-control" placeholder="Enter ur Age" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorage" runat="server" ErrorMessage=" Age is Required" 
                 ControlToValidate="txtage" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidatorage" runat="server" ErrorMessage="Age must be between 5 to 50" ControlToValidate="txtage" Display="Dynamic" ForeColor="Red" MaximumValue="50" MinimumValue="5" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                <br />

                
                <asp:DropDownList ID="ddlcountry" CssClass="form-control"  runat="server">

                    <asp:ListItem>Select country</asp:ListItem>
                    <asp:ListItem>India</asp:ListItem>
                    <asp:ListItem>US</asp:ListItem>
                    <asp:ListItem>South Korea</asp:ListItem>
                    <asp:ListItem>China</asp:ListItem>
                    <asp:ListItem>Japan</asp:ListItem>                    

               </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorcountry" runat="server" ErrorMessage=" country is Required" 
                 ControlToValidate="ddlcountry" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" InitialValue="Select country"></asp:RequiredFieldValidator>
                <br />
                </div>

               
                <div class="col-md-4">
                    <asp:TextBox ID="txtcity" CssClass="form-control" placeholder="Enter ur City" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorcity" runat="server" ErrorMessage=" city is Required" 
                     ControlToValidate="txtcity" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />
                    <asp:TextBox ID="txtaddress" CssClass="form-control" TextMode="MultiLine" Rows="4" Columns="20" placeholder="Enter ur Address" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatoraddress" runat="server" ErrorMessage=" address is Required" 
                     ControlToValidate="txtaddress" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />
                    <asp:TextBox ID="txtstandard" CssClass="form-control" placeholder="Enter ur Class/Standard" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorclass" runat="server" ErrorMessage=" Class/Standard is Required" 
                     ControlToValidate="txtstandard" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />
                     <asp:DropDownList ID="ddlgoingto" CssClass="form-control"  runat="server">

                    <asp:ListItem>Select Going To</asp:ListItem>
                    <asp:ListItem>School</asp:ListItem>
                    <asp:ListItem>College</asp:ListItem>
                    <asp:ListItem>University</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>                    
               </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorddlgoingon" runat="server" ErrorMessage="Select Going To" 
                 ControlToValidate="ddlgoingto" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" InitialValue="Select Going To"></asp:RequiredFieldValidator>
                
                <br />
                    <asp:TextBox ID="txtsubject" CssClass="form-control" placeholder="Enter Subject" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorsubject" runat="server" ErrorMessage=" Subject is Required" 
                     ControlToValidate="txtsubject" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <br />

                </div>

                <div class="col-md-4">
                    <asp:TextBox ID="txtcontact" CssClass="form-control" placeholder="Enter Contact no" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidatorcontact" runat="server" ErrorMessage=" Contact no is Required" 
                     ControlToValidate="txtcontact" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorcontact" runat="server" ForeColor="Red" Display="Dynamic" ControlToValidate ="txtcontact" ErrorMessage="number must be 10 digits"  
                      ValidationExpression ="[0-9]{10}" SetFocusOnError="true"></asp:RegularExpressionValidator> 
                    <br />

                     <asp:DropDownList ID="ddltutiontype" CssClass="form-control"  runat="server">

                    <asp:ListItem>Select Tution Type</asp:ListItem>
                    <asp:ListItem>Online</asp:ListItem>
                    <asp:ListItem>Offline</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorddltution" runat="server" ErrorMessage="Select Tution Type" 
                 ControlToValidate="ddltutiontype" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" InitialValue="Select Tution Type"></asp:RequiredFieldValidator>
                <br />

                     <asp:DropDownList ID="ddltutorperfer" CssClass="form-control"  runat="server">

                    <asp:ListItem>Select Tution Perfer</asp:ListItem>
                    <asp:ListItem>Graduate</asp:ListItem>
                    <asp:ListItem>Masters</asp:ListItem>
                    <asp:ListItem>PHD</asp:ListItem>
                    <asp:ListItem>MPHIL</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>                    

               </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorddltutorprefer" runat="server" ErrorMessage="Select Tution Perfer" 
                 ControlToValidate="ddltutorperfer" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" InitialValue="Select Tution Perfer"></asp:RequiredFieldValidator>
                <br />

                    <asp:TextBox ID="txtusername" CssClass="form-control" placeholder="Enter ur Username" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidatorusername" runat="server" ErrorMessage=" Username is Required" 
                     ControlToValidate="txtusername" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    
                    <br />
                    <asp:TextBox ID="txtpassword" CssClass="form-control" placeholder="Enter password" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" password is Required" 
                     ControlToValidate="txtpassword" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorpass" runat="server" ErrorMessage="Password must contain: Minimum 8 characters atleast 1 Alphabet and 1 Number" ControlToValidate="txtpassword" Display="Dynamic" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"></asp:RegularExpressionValidator>
                    <br />

                    <asp:TextBox ID="txtconfirmpassword" CssClass="form-control" placeholder="Confirm Password" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidatorconfirmpass" runat="server" ErrorMessage=" confirm Password  is Required" 
                     ControlToValidate="txtconfirmpassword" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidatorpass" runat="server" ErrorMessage="password and confirmpass must be match" ControlToCompare="txtpassword" ControlToValidate="txtconfirmpassword" Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
                </div>
                
        </div>  
         <div class="row">
             <div class="col-md-4 mx-auto">
                 <asp:Button ID="btnregister" runat="server" Text="Register" CssClass="btn btn-primary btn-block" OnClick="btnregister_Click"/>
             </div>
             </div>
     <br />

             <div class="row">
             <div class="col-md-6 mx-auto text-center">
             <a href="stud_register.aspx" class="btn btn-info">Register as student</a>
             <a href="tutor_register.aspx" class="btn btn-success">Register as tutor</a>
             </div>
                 </div>
                 <br />
                    
        </div>
    


    <br />
</asp:Content>

