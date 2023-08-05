<%@ Page Title="" Language="C#" MasterPageFile="~/TMS.master" AutoEventWireup="true" CodeFile="tutor_login.aspx.cs" Inherits="tutor_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <div class="container">
            <div class="row">
                <div class="col-md-4 mx-auto" style="-webkit-box-shadow: -1px 0px 25px 5px rgba(0,0,0,0.75);
                 -moz-box-shadow: -1px 0px 25px 5px rgba(0,0,0,0.75);
                  box-shadow: 2px 0px 15px -1px rgba(0,0,0,0.75);">
                  <br />

                    <div class="text-center text-black">
                        <h2>Tutor Login</h2>
                    </div>
                    <br />

                    <asp:TextBox ID="txtusername" placeholder="enter ur username" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorusername" runat="server" ErrorMessage=" username is Required" ControlToValidate="txtusername" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    <br />

                    <asp:TextBox ID="txtpassword" TextMode="Password" placeholder="enter ur password" CssClass="form-control"  runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorpassword" runat="server" ErrorMessage=" Password is Required" ControlToValidate="txtpassword" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    <br />

                    <asp:Button ID="btnlogin" runat="server" Text="Login" CssClass="btn btn-primary btn-block" OnClick="btnlogin_Click"  />
                    <br />

                    <%--<div class="text-center">
                    <a href="~/tutor_login.aspx" class="text-center">Tutor Login? click here</a>
                    </div>
                    <br />--%>
                </div>
            </div>
        </div>
    <br />


</asp:Content>

