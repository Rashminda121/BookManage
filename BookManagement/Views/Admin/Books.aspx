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
                    <input type="text" placeholder="Author" autocomplete="off" class="form-control"/>
                </div>
                <div class="mb-3">
                    <label for="" class="from-label text-success">Categories</label>
                    <input type="text" placeholder="Categories" autocomplete="off" class="form-control"/>
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
                         <asp:Button Text="Login" runat="server" class="btn-success btn-block btn"/>
                      </div>
                      <div class="col d-grid">
                        <asp:Button Text="Login" runat="server" class="btn-success btn-block btn"/>
                      </div>
                      <div class="col d-grid">
                        <asp:Button Text="Login" runat="server" class="btn-success btn-block btn"/>
                      </div>
                    
                </div>




            </div>
             <div class="col-md-8">

            </div>
        </div>
</div>
</asp:Content>
