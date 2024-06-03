<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookManagement.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <link href="../../Assets/lib/bootstrap.css" />
</head>
<body>
    <div class="container-fluid">
        <div class="row mt-5">

        </div>
        <div class="row">
            <div class="col-md-4 ">

            </div>
            <div class="col-md-4">
                <form id="form1" runat="server">
                    <div>
                        <div class="row">
                            <div class="col-md-4"></div>
                            <div class="col-md-8">
                                <img src="../Assets/Images/profile.png" width="90" height="90"/>
                            </div>

                        </div>
                        
                    </div>
                    <div class="mt-3">
                        <label for="" class="from-label">User Name</label>
                        <input type="email" placeholder="Email" autocomplete="off" class="form-control" id="username" runat="server"/>
                    </div>
                    <div class="mt-3">
                        <label for="" class="from-label">Password</label>
                        <input type="password" placeholder="Password" autocomplete="off" class="form-control" id="password" runat="server"/>
                    </div>
                    <div class="mt-3 d-grid">
                        <asp:Label runat="server" ID="errMsg" class="text-danger mb-3"></asp:Label>
                        <asp:Button Text="Login" runat="server" class="btn-success btn" ID="loginBtn" OnClick="loginBtn_Click"/>
                    </div>

                </form>

            </div>
            <div class="col-md-4">

            </div>
            
        </div>
        
    </div>
    
</body>
</html>
