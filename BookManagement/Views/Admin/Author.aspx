<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Author.aspx.cs" Inherits="BookManagement.Author" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
        <div class="container-fluid">
      <div class="row">
        <div class="col">
            <h3 class="text-center">Manage Authors</h3>
        </div>
      </div>
        <div class="row">
            <div class="col-md-4">
                <div class="mb-3">
                    <label for="" class="from-label text-success">Author Name</label>
                    <input type="text" placeholder="Title" autocomplete="off" class="form-control" runat="server" id="ANameTb"/>
                </div>
                <div class="mb-3">
                    <label for="" class="from-label text-success">Author Gender</label>
                    <asp:DropDownList  runat="server" class="form-control" id="GenCb">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="" class="from-label text-success">Country</label>
                    <asp:DropDownList ID="CountryCb" runat="server" class="form-control">
                        <asp:ListItem>USA</asp:ListItem>
                         <asp:ListItem>UK</asp:ListItem>
                         <asp:ListItem>SL</asp:ListItem>
                        <asp:ListItem>INDIA</asp:ListItem>
                        <asp:ListItem>JAPAN</asp:ListItem>
                        <asp:ListItem>OTHER</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="row">
                    <asp:Label runat="server" ID="errMsg" class="text-danger"></asp:Label>
                      <div class="col d-grid">
                         <asp:Button Text="Update" runat="server" class="btn-warning btn-block btn" ID="editBtn"/>
                      </div>
                      <div class="col d-grid">
                        <asp:Button Text="Save" runat="server" class="btn-success btn-block btn" ID="saveBtn" OnClick="saveBtn_Click"/>
                      </div>
                      <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server" class="btn-danger btn-block btn" ID="deleteBtn"/>
                      </div>
                    
                </div>




            </div>
             <div class="col-md-8">
                 <asp:GridView ID="AuthorsList" runat="server"></asp:GridView>
            </div>
        </div>
</div>
</asp:Content>
