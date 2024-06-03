<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Seller/SellerMaster.Master" AutoEventWireup="true" CodeBehind="Selling.aspx.cs" Inherits="BookManagement.Views.Seller.Selling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

    <div class="container-fluid">
        <div class="row">

        </div>
        <div class="row mt-5">
            <div class="col-md-5">
                <h3 class="text-center" style="color:teal;">Book Details</h3>   

                <div class="row"> 
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label text-success">Book Name</label>
                            <input type="text" placeholder="Name" autocomplete="off" class="form-control" runat="server" id="BName"/>
                        </div>
                    </div>
                     <div class="col">
                         <div class="mt-3">
                             <label for="" class="form-label text-success">Book Price</label>
                             <input type="text" placeholder="Price" autocomplete="off" class="form-control" runat="server" id="Price"/>
                         </div>
                     </div>
                    

                </div>
                <div class="row"> 
                    <div class="col">
                        <div class="mt-3">
                            <label for="" class="form-label text-success">Quantity</label>
                            <input type="text" placeholder="Quantity" autocomplete="off" class="form-control" runat="server" id="Quan"/>
                        </div>
                    </div>
                     <div class="col">
                         <div class="mt-3">
                             <label for="" class="form-label text-success">Billing Date</label>
                             <input type="date"  class="form-control" runat="server" id="Date"/>
                         </div>
                     </div>
                    <div class="row mt-3 mb-3">
                        <div class="col d-grid">
                            <asp:Label runat="server" ID="errMsg" class="text-danger mb-3"></asp:Label>
                            <asp:Button Text="Add To Bill" runat="server" class="btn-warning btn-block btn" ID="AddToBtn" OnClick="AddToBtn_Click"/>
                        </div>
                    </div>

                </div>

                <div class="row mt-5">
                    <h4 class="text-center" style="color:teal;">Book List</h4> 
                    <div class="col">  
                         <asp:GridView ID="BooksList" runat="server" class="table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="BooksList_SelectedIndexChanged"  >
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
             <div class="col-md-7">
                 <h4 class="text-center" style="color:crimson;">Client's List</h4> 
                <div class="col">  
                     <asp:GridView ID="BillList" runat="server" class="table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" >
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

                    <div class="d-grid">
                        <asp:Label runat="server" ID="GrndTotal" class="text-danger mb-3 "></asp:Label>
                        <asp:Button Text="Print" runat="server" class="btn-warning btn-block btn" ID="printBtn"/>

                    </div>
                    
                </div>

            </div>
        </div>
    </div>


</asp:Content>
