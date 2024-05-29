<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="BookManagement.Views.Admin.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
      <div class="row">
        <div class="col">
            <h3 class="text-center">Manage Books</h3>
        </div>
      </div>
        <div class="row">
            <div class="col-md-4">
                <div class="mb-3">
                    <label for="" class="from-label text-success">Books Title</label>
                    <input type="text" placeholder="Title" autocomplete="off" class="form-control"/>
                </div>
                <div class="mb-3">
                    <label for="" class="from-label text-success">Book Author</label>
                    <asp:DropDownList ID="DropDownList2" runat="server" class="form-control"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="" class="from-label text-success">Categories</label>
                    <asp:DropDownList ID="DropDownList1" runat="server" class="form-control"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="" class="from-label text-success">Price</label>
                    <input type="text" placeholder="Price" autocomplete="off" class="form-control"/>
                </div>
                <div class="mb-3">
                    <label for="" class="from-label text-success">Quantity</label>
                    <input type="text" placeholder="Quantity" autocomplete="off" class="form-control"/>
                </div>
                <div class="row">
                      <div class="col d-grid">
                         <asp:Button Text="Update" runat="server" class="btn-warning btn-block btn"/>
                      </div>
                      <div class="col d-grid">
                        <asp:Button Text="Save" runat="server" class="btn-success btn-block btn"/>
                      </div>
                      <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server" class="btn-danger btn-block btn"/>
                      </div>
                    
                </div>




            </div>
             <div class="col-md-8">
                 <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </div>
</div>
</asp:Content>
