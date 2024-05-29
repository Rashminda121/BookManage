using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookManagement
{
    public partial class Author : System.Web.UI.Page
    {
        Models.Functions Con;

        protected void Page_Load(object sender, EventArgs e)
        {
            Con= new Models.Functions();
            ShowAuthors();
        }

        private void ShowAuthors()
        {
            String Query = "Select * from author";
            AuthorsList.DataSource = Con.GetData(Query);
            AuthorsList.DataBind();
        }
        protected void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == "" || GenCb.SelectedIndex == -1||CountryCb.SelectedIndex==-1)
                {
                    errMsg.Text = "Missing Data!";
                }
                else
                {

                }

            }catch(Exception ex)
            {
                errMsg.Text = ex.Message;
            }

        }
    }
}