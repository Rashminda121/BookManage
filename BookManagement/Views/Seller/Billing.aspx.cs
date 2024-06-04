using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookManagement.Views.Seller
{
    public partial class Billing : System.Web.UI.Page
    {
        Models.Functions Con;
        int Seller = WebForm1.User;
        string SNAme = WebForm1.UName;
        protected void Page_Load(object sender, EventArgs e)
        {

            Con = new Models.Functions();

            if (!IsPostBack)
            {
                ShowBills();
                
            }

        }
        private void ShowBills()
        {
            String Query = "Select bid as Code,bdate as Date,seller as Seller, amount as Amount  from bill where seller='{0}'";
            Query = string.Format(Query, Seller);
            BillList.DataSource = Con.GetData(Query);
            BillList.DataBind();
        }
    }
}