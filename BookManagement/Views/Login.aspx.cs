using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookManagement.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }

        public static string UName = "";
        public static int User;

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            if(username.Value==""|| password.Value == "")
            {
                errMsg.Text = "Missing Data!";

            }
            else if(username.Value=="admin@gmail.com" && password.Value=="admin"){

                Response.Redirect("Admin/Books.aspx");
            }
            else
            {
                string query = "select * from seller where semail='{0}' and spass='{1}'";
                query= string.Format(query, username.Value,password.Value);
                DataTable dt= Con.GetData(query);
                if (dt.Rows.Count == 0)
                {
                    
                    errMsg.Text = "Invalid Data!";
                }
                else
                {
                    UName=username.Value;
                    User = Convert.ToInt32(dt.Rows[0]["sid"].ToString());
                    Response.Redirect("Seller/Selling.aspx");
                }
            }
        }
    }
}