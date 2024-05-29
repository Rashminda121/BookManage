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
                    <asp:Label runat="server" ID="errMsg" class="text-danger mb-3"></asp:Label>
                      <div class="col d-grid">
                         <asp:Button Text="Update" runat="server" class="btn-warning btn-block btn" ID="editBtn" OnClick="editBtn_Click"/>
                      </div>
                      <div class="col d-grid">
                        <asp:Button Text="Save" runat="server" class="btn-success btn-block btn" ID="saveBtn" OnClick="saveBtn_Click"/>
                      </div>
                      <div class="col d-grid">
                        <asp:Button Text="Delete" runat="server" class="btn-danger btn-block btn" ID="deleteBtn" OnClick="deleteBtn_Click"/>
                      </div>
                    
                </div>




            </div>
             <div class="col-md-8">
                 <asp:GridView ID="AuthorsList" runat="server" class="table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorsList_SelectedIndexChanged">
                     <AlternatingRowStyle BackColor="White" />
                     <EditRowStyle BackColor="#7C6F57" />
                     <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                     <HeaderStyle BackColor="teal" Font-Bold="false" ForeColor="White" />
                     <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                     <RowStyle BackColor="#E3EAEB" />
                     <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                     <SortedAscendingCellStyle BackColor="#F8FAFA" />
                     <SortedAscendingHeaderStyle BackColor="#246B61" />
                     <SortedDescendingCellStyle BackColor="#D4DFE1" />
                     <SortedDescendingHeaderStyle BackColor="#15524A" />
                 </asp:GridView>
            </div>
        </div>
</div>
</asp:Content>
