<%@ Page Title="viewtutor | TMS" Language="C#" MasterPageFile="~/admin/admin_dashboard.master" AutoEventWireup="true" CodeFile="viewtutor.aspx.cs" Inherits="admin_viewtutor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
	<div class="row">
		<div class="col-md-12">

			<h1 class ="jumbotron bg-dark text-white text-center"> VIEW TUTOR DETAILS</h1>

		</div>

	</div>

	<span class="space10"></span>
	 
	 <div id="editinfo" runat="server">
		<div class="card card-primary">
			<div class="card-header">
				<h3 class="card-title"><%=pgTitle %></h3>			
			</div>
			<%-- Card Body --%>
			<div class="card-body">
				<div class="colorLightBlue">
						<%--<span>Id</span>--%>
					<asp:Label ID="lblId" runat="server" Text="[New]"></asp:Label>
				</div>
				<span class="space15"></span>
					<%-- From Row Start --%>
				<div class="form-row">
					<div class="form-group col-md-6">
						<label>Tutor Name:*</label>
						<asp:TextBox ID="txttutorname" runat="server" CssClass="form-control" Width="100%" 
							MaxLength="50" ></asp:TextBox>
					</div>
					
                    <div class="form-group col-md-6">
                        <label>Tutor Surname Name:*</label>
                        <asp:TextBox ID="txttutorsurname" runat="server" CssClass="form-control" Width="100%"
                            MaxLength="50"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="exampleFormControlSelect2" class="fontRegular semiBold clrBlack">Select Gender: *</label>
                        <asp:DropDownList ID="ddlgender" CssClass="form-control" runat="server">
                            <asp:ListItem Value="0"><-Select Gender-></asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>

                    </div>
                       
                    <div class="form-group col-md-6">
                        <label>Age:*</label>
                        <asp:TextBox ID="txtage" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>
                    </div>

					 <div class="form-group col-md-6">
                        <label for="exampleFormControlSelect2" class="fontRegular semiBold clrBlack">Select Marital Status: *</label>
                        <asp:DropDownList ID="ddlmarital" CssClass="form-control" runat="server">
                            <asp:ListItem Value="0"><-Marital Status-></asp:ListItem>
                            <asp:ListItem>Single</asp:ListItem>
                            <asp:ListItem>Married</asp:ListItem>
							 <asp:ListItem>Divorced</asp:ListItem>
                        </asp:DropDownList>

                    </div>

                     <div class="form-group col-md-6">
                        <label for="exampleFormControlSelect2" class="fontRegular semiBold clrBlack">Select Country: *</label>
                        <asp:DropDownList ID="ddlcountry" CssClass="form-control" runat="server">
                            <asp:ListItem Value="0"><-Select Country-></asp:ListItem>
                            <asp:ListItem>India</asp:ListItem>
                            <asp:ListItem>US</asp:ListItem>
							 <asp:ListItem>SouthKoprea</asp:ListItem>
							 <asp:ListItem>China</asp:ListItem>
							 <asp:ListItem>Japan</asp:ListItem>
                        </asp:DropDownList>

                    </div>
                    <div class="form-group col-md-6">
                        <label>City:*</label>
                        <asp:TextBox ID="txtcity" runat="server" CssClass="form-control" Width="100%"
                            MaxLength="50"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label>Address:*</label>
                        <asp:TextBox ID="txtaddress" runat="server" CssClass="form-control" Width="100%"></asp:TextBox>

                    </div>
					<div class="form-group col-md-6">
                        <label for="exampleFormControlSelect2" class="fontRegular semiBold clrBlack">Select Qualification: *</label>
                        <asp:DropDownList ID="ddlqualification" CssClass="form-control" runat="server">
                            <asp:ListItem Value="0"><-Select Qualification-></asp:ListItem>
                            <asp:ListItem>Graduate</asp:ListItem>
                            <asp:ListItem>Masters</asp:ListItem>
							 <asp:ListItem>PHD</asp:ListItem>
							 <asp:ListItem>MPHIL</asp:ListItem>
							 <asp:ListItem>Other</asp:ListItem>
							
                        </asp:DropDownList>

                    </div>
					 <div class="form-group col-md-6">
                        <label for="exampleFormControlSelect2" class="fontRegular semiBold clrBlack">Select Experience: *</label>
                        <asp:DropDownList ID="ddlexp" CssClass="form-control" runat="server">
                            <asp:ListItem Value="0"><-Select Experience-></asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
							 <asp:ListItem>3</asp:ListItem>
							 <asp:ListItem>4+</asp:ListItem>
							<asp:ListItem>8+</asp:ListItem>
							
                        </asp:DropDownList>

                    </div>
					
					 <div class="form-group col-md-6">
                        <label>Contact No:*</label>
                        <asp:TextBox ID="txtcontact" runat="server" CssClass="form-control" Width="100%"
                            MaxLength="10"></asp:TextBox>
                    </div>
					
					
					 <div class="form-group col-md-6">
                        <label>Username:*</label>
                        <asp:TextBox ID="txtusername" runat="server" CssClass="form-control" Width="100%"
                            MaxLength="50"></asp:TextBox>
                    </div>
					 <div class="form-group col-md-6">
                        <label>Password:*</label>
                        <asp:TextBox ID="txtpass" runat="server" CssClass="form-control" Width="100%"
                            MaxLength="50"></asp:TextBox>
                    </div>
					
					</div>
            </div>
        </div>
		 <!-- Button controls starts -->
		<span class="space10"></span>
		 <br />
		
		
		<asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click"   />
		<asp:Button ID="btnDelete" runat="server" CssClass="btn btn-outline-info" Text="Delete" OnClientClick="return confirm('Are you sure to delete?');" OnClick="btnDelete_Click" />
		<asp:Button ID="btnCancel" runat="server" CssClass="btn btn-outline-dark" Text="Cancel" OnClick="btnCancel_Click"  />
		<div class="float_clear"></div>
		<!-- Button controls ends -->	
	</div>

       <div id="viewinfo" runat="server">
		<a href="viewtutor.aspx?action=new" runat="server" class="btn btn-primary btn-md">Add New</a>	
		  <br />
		<span class="space20"></span>
		<div class="formPanel table-responsive-md">
			<asp:GridView ID="gvviewtutor" runat="server"  CssClass="table table-striped table-bordered table-hover" GridLines="None"
				AutoGenerateColumns="false" OnRowDataBound="gvviewtutor_RowDataBound">
			<HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />
			<Columns>
					<%-- <asp:BoundField DataField="id">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>--%>

					 <asp:BoundField DataField="name" HeaderText="Name">
						<ItemStyle Width="10%" />
					</asp:BoundField>

					 <asp:BoundField DataField="email" HeaderText="Email">
						<ItemStyle Width="10%" />
					</asp:BoundField>

				 <asp:BoundField DataField="address" HeaderText="Address">
						<ItemStyle Width="10%" />
					</asp:BoundField>

				 <asp:BoundField DataField="contactno" HeaderText="Contactno">
						<ItemStyle Width="10%" />
					</asp:BoundField>

				 <asp:BoundField DataField="qualification" HeaderText="Qualification">
						<ItemStyle Width="10%" />
					</asp:BoundField>

				<asp:TemplateField headertext="View">
						<ItemStyle Width="5%" />
						<ItemTemplate>
							<asp:Literal ID="litAnch" runat="server"></asp:Literal>
						</ItemTemplate>
					</asp:TemplateField>   
				</Columns>
			<EmptyDataTemplate>
					<span class="warning">Its Empty Here... :(</span>
				</EmptyDataTemplate>
				<PagerStyle CssClass="" />
				</asp:GridView>
				</div>
	          </div>
</asp:Content>

