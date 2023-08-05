<%@ Page Title="" Language="C#" MasterPageFile="~/student/student_dashboard.master" AutoEventWireup="true" CodeFile="view_tutors.aspx.cs" Inherits="student_view_tutors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <br />
	<div class="row">
		<div class="col-md-12">

			<h1 class =" jumbotron bg-dark text-white text-center"> TUTORS DETAILS</h1>

		</div>

	</div>

    <div class="row">

        <div class="col-md-4">

            <div class="input-group">
               
                <asp:TextBox ID="txtsearch" runat="server" class="from-control" placeholder="search tutor" ></asp:TextBox>
                <div class="input-group-append">
                    <button id="btnsearch" runat="server" onserverclick="btnsearch_ServerClick" class ="btn btn-secondary" type="button">
                        <i class=" fa fa-search"></i>
                    </button>
                </div>
            </div>
            <br />
        </div>
    </div>
<%--	<br />--%>
     <span class="space20"></span>
        <div class="formPanel table-responsive-md">
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-hover" GridLines="None" 
				AutoGenerateColumns="false" >
        <HeaderStyle CssClass="thead-dark" />
				<RowStyle CssClass="" />
				<AlternatingRowStyle CssClass="alt" />

           <Columns>
         
                <asp:BoundField DataField="id">
						<HeaderStyle CssClass="HideCol" />
						<ItemStyle  CssClass="HideCol"/>
					</asp:BoundField>
					
                  <asp:BoundField DataField="name" HeaderText="Name">
						<ItemStyle Width="15%" />
					</asp:BoundField>

                 <asp:BoundField DataField="email" HeaderText="Emailid">
						<ItemStyle Width="15%" />
					</asp:BoundField>

                  <asp:BoundField DataField="country" HeaderText="Country">
						<ItemStyle Width="10%" />
					</asp:BoundField>
                                  
                <asp:BoundField DataField="city" HeaderText="City">
						<ItemStyle Width="10%" />
					</asp:BoundField>

                <asp:BoundField DataField="qualification" HeaderText="qualification">
						<ItemStyle Width="10%" />
					</asp:BoundField>

                <asp:BoundField DataField="experience" HeaderText="experience">
						<ItemStyle Width="20%" />
					</asp:BoundField>
               
                <asp:BoundField DataField="contactno" HeaderText="contactno">
						<ItemStyle Width="20%" />
					</asp:BoundField>

                </Columns>
            <EmptyDataTemplate>
		     <span class="warning">Its Empty Here...:(</span>
			   </EmptyDataTemplate>
				<PagerStyle CssClass="" />

    </asp:GridView>
             </div>   
         
 

   <%-- <div class="row">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>

            <div class="col-md-4">
            <div class="card bg-dark text-white text-center">
                <div class="card-header">
                    <h3> <asp:Label ID="Label1" runat="server" Text='<%# Bind("name")%>''></asp:Label></h3>
                </div>
                <div class="card-body">
                   <h5> <asp:Label ID="Label2" runat="server" Text='<%# Bind("email")%>''></asp:Label></h5>
                   <h5> <asp:Label ID="Label3" runat="server" Text='<%# Bind("country")%>''></asp:Label></h5>
                   <h5> <asp:Label ID="Label4" runat="server" Text='<%# Bind("city")%>''></asp:Label></h5>
                 
                   <h5> <asp:Label ID="Label5" runat="server" Text='<%# Bind("experience")%>''></asp:Label></h5>
                   <h5> <asp:Label ID="Label6" runat="server" Text='<%# Bind("contactno")%>''></asp:Label></h5>

                </div>
                <div class="card-footer">
                    <h4> <asp:Label ID="Label7" runat="server" Text='<%# Bind("qualification")%>''></asp:Label></h4>

                </div>
            </div>
             </div>   
        </ItemTemplate>

    </asp:Repeater>--%>
       <%-- </div>--%>


</asp:Content>

