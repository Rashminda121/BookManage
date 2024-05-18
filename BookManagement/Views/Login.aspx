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
        <div class="row">

        </div>
        <div class="row">
            <div class="col-md-4">

            </div>
            <div class="col-md-4">
                <form id="form1" runat="server">
                    <div>
                        <div class="row">
                            <div class="col-md-4"></div>
                            <div class="col-md-8">
                                <img src="../Assets/Images/book.png" />
                            </div>

                        </div>
                        
                    </div>
                    <div class="mt-3">
                        <label for="" class="from-label">User Name</label>
                        <input type="text" placeholder="User Name" autocomplete="off" class="form-control"/>
                    </div>
                    <div class="mt-3">
                        <label for="" class="from-label">Password</label>
                        <input type="text" placeholder="Password" autocomplete="off" class="form-control"/>
                    </div>
                    <div class="mt-3 d-grid">
                        <asp:Button Text="Login" runat="server" class="btn-success btn"/>
                    </div>

                </form>

            </div>
            <div class="col-md-4">

            </div>
            
        </div>
        
    </div>
    
</body>
</html>
