<%@ Page Title="" Language="C#" MasterPageFile="~/tutor/tutor_dashboard.master" AutoEventWireup="true" CodeFile="view_students.aspx.cs" Inherits="tutor_view_students" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <br />
	<div class="row">
		<div class="col-md-12">

			<h1 class =" jumbotron bg-dark text-white text-center"> STUDENTS DETAILS</h1>

		</div>

	</div>

	<div class="row">

        <div class="col-md-4">

            <div class="input-group">
               
                <asp:TextBox ID="txtsearch" runat="server" class="from-control" placeholder="search tutor" ></asp:TextBox>
                <div class="input-group-append">
                    <button id="btnsearch" runat="server" class ="btn btn-secondary" type="button" onserverclick="btnsearch_ServerClick">
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

                 <asp:BoundField DataField="gender" HeaderText="Gender">
						<ItemStyle Width="15%" />
					</asp:BoundField>

                  <asp:BoundField DataField="country" HeaderText="Country">
						<ItemStyle Width="10%" />
					</asp:BoundField>
                                  
              
                <asp:BoundField DataField="standard" HeaderText="standard">
						<ItemStyle Width="10%" />
					</asp:BoundField>

                <asp:BoundField DataField="subject" HeaderText="subject">
						<ItemStyle Width="20%" />
					</asp:BoundField>
               
                <asp:BoundField DataField="contactno" HeaderText="contactno">
						<ItemStyle Width="20%" />
					</asp:BoundField>

			   <asp:BoundField DataField="tutiontype" HeaderText="tutiontype">
						<ItemStyle Width="20%" />
					</asp:BoundField>

			  

                </Columns>
            <EmptyDataTemplate>
		     <span class="warning">Its Empty Here... :(</span>
			   </EmptyDataTemplate>
				<PagerStyle CssClass="" />

    </asp:GridView>
             </div>   
         
 

</asp:Content>

