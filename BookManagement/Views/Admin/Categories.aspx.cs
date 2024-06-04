using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookManagement.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowCategories();
        }
        private void ShowCategories()
        {
            String Query = "Select cid as Id , cname as CName,cdescription as Description  from category";
            CategoriesList.DataSource = Con.GetData(Query);
            CategoriesList.DataBind();
        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" || DescriptionTb.Value=="")
                {
                    errMsg.Text = "Missing Data!";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    string CDesc = DescriptionTb.Value;

                    string Query = "insert into category values('{0}','{1}')";
                    Query = string.Format(Query, CName, CDesc);
                    Con.SetData(Query);
                    ShowCategories();
                    errMsg.Text = "Category Added Successfully!";

                    clearData();

                }

            }
            catch (Exception ex)
            {
                errMsg.Text = ex.Message;
            }
        }

        public void clearData()
        {
            CatNameTb.Value = "";
            DescriptionTb.Value = "";
        }

        int Key = 0;
        protected void AuthorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatNameTb.Value = CategoriesList.SelectedRow.Cells[2].Text;
            DescriptionTb.Value= CategoriesList.SelectedRow.Cells[3].Text;

            if (CatNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoriesList.SelectedRow.Cells[1].Text);
            }
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (CatNameTb.Value == "" || DescriptionTb.Value == "")
                {
                    errMsg.Text = "Missing Data!";
                }
                else
                {
                    string CName = CatNameTb.Value;
                    string CDesc = DescriptionTb.Value;

                    string Query = "Update category set cname='{0}',cdescription='{1}' where cid='{2}'";
                    Query = string.Format(Query, CName, CDesc, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    errMsg.Text = "Category Updated Successfully!";

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
                if (CatNameTb.Value == "" || DescriptionTb.Value == "")
                {
                    errMsg.Text = "Missing Data!";
                }
                else
                {
                    string Query = "delete from category where cid='{0}'";
                    Query = string.Format(Query, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    errMsg.Text = "Category Deleted Successfully!";

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