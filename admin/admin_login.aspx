<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_login.aspx.cs" Inherits="admin_admin_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    <link href="~/assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">

                <div class="col-md-4 mx-auto" style="-webkit-box-shadow: -1px 0px 25px 5px rgba(0,0,0,0.75);
                 -moz-box-shadow: -1px 0px 25px 5px rgba(0,0,0,0.75);
                  box-shadow: 2px 0px 15px -1px rgba(0,0,0,0.75);">
                  <br />

                    <div class="text-center text-black">
                        <h2>Admin Login</h2>
                    </div>
                    <br />

                    <asp:TextBox ID="txtusername" placeholder="enter ur username" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorusername" runat="server" ErrorMessage=" username is Required" ControlToValidate="txtusername" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    <br />

                    <asp:TextBox ID="txtpassword" TextMode="Password" placeholder="enter ur password" CssClass="form-control"  runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorpassword" runat="server" ErrorMessage=" Password is Required" ControlToValidate="txtpassword" ForeColor="Red" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    <br />

                    <asp:Button ID="btnlogin" runat="server" Text="Login" CssClass="btn btn-primary btn-block" OnClick="btnlogin_Click" />
                    <br />
                </div>
            </div>
        </div>
    </form>
    <script src="~/assets/vendor/bootstrap/jquery/jquery.min.js"></script>
    <script src="~/assets/vendor/bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
