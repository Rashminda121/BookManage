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
                    string AName=ANameTb.Value;
                    string Gender=GenCb.SelectedItem.ToString();
                    string Country=CountryCb.SelectedItem.ToString();

                    string Query = "insert into author values('{0}','{1}','{2}')";
                    Query =string.Format(Query, AName, Gender, Country);
                    Con.SetData(Query);
                    ShowAuthors() ;
                    errMsg.Text = "Author Inserted Successfully!";

                    clearData();

                }

            }catch(Exception ex)
            {
                errMsg.Text = ex.Message;
            }

        }

        public void clearData()
        {
            ANameTb.Value = "";
            GenCb.SelectedIndex = -1;
            CountryCb.SelectedIndex = -1;
        }

        int Key = 0;

        protected void AuthorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ANameTb.Value = AuthorsList.SelectedRow.Cells[2].Text;
            GenCb.SelectedItem.Value = AuthorsList.SelectedRow.Cells[3].Text;
            CountryCb.SelectedItem.Value = AuthorsList.SelectedRow.Cells[4].Text;
            if (ANameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AuthorsList.SelectedRow.Cells[1].Text);
            }
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == "" || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    errMsg.Text = "Missing Data!";
                }
                else
                {
                    string AName = ANameTb.Value;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Country = CountryCb.SelectedItem.ToString();

                    string Query = "update author set aname='{0}', agender='{1}' , acountry='{2}' where aid='{3}'  ";
                    Query = string.Format(Query, AName, Gender, Country, AuthorsList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowAuthors();
                    errMsg.Text = "Author Updated Successfully!";

                    clearData();

                }

            }
            catch (Exception ex)
            {
                errMsg.Text = ex.Message;
            }
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == "" || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    errMsg.Text = "Please Select Data!";
                }
                else
                {
                    string AName = ANameTb.Value;
                    string Gender = GenCb.SelectedItem.ToString();
                    string Country = CountryCb.SelectedItem.ToString();

                    string Query = "delete from author where aid='{0}'  ";
                    Query = string.Format(Query, AuthorsList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowAuthors();
                    errMsg.Text = "Author Deleted Successfully!";

                    clearData();

                }

            }
            catch (Exception ex)
            {
                errMsg.Text = ex.Message;
            }
        }
    }
}