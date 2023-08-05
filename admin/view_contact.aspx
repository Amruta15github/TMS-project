<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin_dashboard.master" AutoEventWireup="true" CodeFile="view_contact.aspx.cs" Inherits="admin_view_contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
	<br />
	<div class="row">
		<div class="col-md-12">

			<h1 class ="jumbotron bg-dark text-white text-center"> VIEW CONTACT DETAILS</h1>

		</div>

	</div>
	<%--<br />--%>

    <span class="space20"></span>
        <div class="formPanel table-responsive-md">
    <div class="formPanel table-responsive-md">
			<asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
				AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand"  >
				 <HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />
				<Columns>
			       <%-- <asp:BoundField DataField="id">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>--%>

					<asp:BoundField DataField="id">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>
					
					 <asp:BoundField DataField="name" HeaderText="Name">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:BoundField DataField="email" HeaderText="emailid">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					<asp:BoundField DataField="subject" HeaderText=" Select Subject">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:BoundField DataField="message" HeaderText="Message">
						<ItemStyle Width="20%" />
					</asp:BoundField>

					 <asp:TemplateField>
						<ItemStyle Width="20%" />
						<ItemTemplate>
                        <asp:Button ID="btndelete" runat="server" Text="Delete" class="btn btn-outline-dark" OnClientClick="return confirm('are u sure to delete??')" CommandName="itemdelete" CommandArgument='<%# Eval("id") %>' CausesValidation="false"/>	
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

