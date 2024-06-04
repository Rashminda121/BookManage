using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookManagement.Views.Admin
{
    public partial class Books : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            if (!IsPostBack)
            {
                ShowBooks();
                Getcategories();
                GetAuthors();
            }
            
        }

        private void ShowBooks()
        {
            String Query = "Select bid as Id,bname as BName, bauthor as BAuthor, bcategory as BCategory ,bqty as Quantity,bprice as Price from book";
            BooksList.DataSource = Con.GetData(Query);
            BooksList.DataBind();
        }

        private void Getcategories()
        {
            string Query = "select * from category";
            BCat.DataTextField = Con.GetData(Query).Columns["cname"].ToString();
            BCat.DataValueField = Con.GetData(Query).Columns["cid"].ToString();
            BCat.DataSource = Con.GetData(Query);
            BCat.DataBind();

        }
        private void GetAuthors()
        {
            string Query = "select * from author";
            BAuth.DataTextField = Con.GetData(Query).Columns["aname"].ToString();
            BAuth.DataValueField = Con.GetData(Query).Columns["aid"].ToString();
            BAuth.DataSource = Con.GetData(Query);
            BAuth.DataBind();

        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BName.Value == "" || BAuth.SelectedIndex == -1 || BCat.SelectedIndex == -1|| Price.Value==""||Quan.Value=="")
                {
                    errMsg.Text = "Missing Data!";
                }
                else
                {
                    string bName = BName.Value;
                    string bAuth = BAuth.SelectedValue.ToString();
                    string bCat = BCat.SelectedValue.ToString();
                    int quan = Convert.ToInt32(Quan.Value);
                    int price= Convert.ToInt32(Price.Value);
                    


                    string Query = "insert into book values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, bName, bAuth, bCat, quan,price );
                    Con.SetData(Query);
                    ShowBooks();
                    errMsg.Text = "Book Added Successfully!";

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
            BName.Value = "";
            BAuth.SelectedIndex = -1;
            BCat.SelectedIndex = -1;
            Quan.Value = "";
            Price.Value = "";
            
        }

        int Key = 0;
        protected void BooksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BName.Value = BooksList.SelectedRow.Cells[2].Text;
            BAuth.SelectedValue = BooksList.SelectedRow.Cells[3].Text;
            BCat.SelectedValue = BooksList.SelectedRow.Cells[4].Text;
            Quan.Value = BooksList.SelectedRow.Cells[5].Text;
            Price.Value = BooksList.SelectedRow.Cells[6].Text;
            
            if (BName.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BooksList.SelectedRow.Cells[1].Text);
            }
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BName.Value == "" || BAuth.SelectedIndex == -1 || BCat.SelectedIndex == -1 || Price.Value == "" || Quan.Value == "")
                {
                    errMsg.Text = "Missing Data!";
                }
                else
                {
                    string bName = BName.Value;
                    string bAuth = BAuth.SelectedValue.ToString();
                    string bCat = BCat.SelectedValue.ToString();
                    int quan = Convert.ToInt32(Quan.Value);
                    int price = Convert.ToInt32(Price.Value);



                    string Query = "update book set bname='{0}', bauthor='{1}', bcategory='{2}',bqty='{3}',bprice='{4}' where bid='{5}'";
                    Query = string.Format(Query, bName, bAuth, bCat, quan, price, BooksList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    errMsg.Text = "Book Updated Successfully!";

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
                if (BName.Value == "" || BAuth.SelectedIndex == -1 || BCat.SelectedIndex == -1 || Price.Value == "" || Quan.Value == "")
                {
                    errMsg.Text = "Missing Data!";
                }
                else
                {

                    string Query = "delete from book where bid='{0}'";
                    Query = string.Format(Query,BooksList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    errMsg.Text = "Book Deleted Successfully!";

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