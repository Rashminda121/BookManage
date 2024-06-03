using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookManagement.Views.Seller
{
    public partial class Selling : System.Web.UI.Page
    {
        Models.Functions Con;
        int Seller = WebForm1.User;
        string SNAme = WebForm1.UName;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();

            if (!IsPostBack)
            {
                ShowBooks();
                DataTable dt=new DataTable();
                dt.Columns.AddRange(new DataColumn[5]
                {
                    new DataColumn("ID"),
                    new DataColumn("Book"),
                    new DataColumn("Price"),
                    new DataColumn("Quantity"),
                    new DataColumn("Total")
                });
                ViewState["Bill"]= dt;
                this.BindGrid();
            }
        }

        protected void BindGrid()
        {
            BillList.DataSource = ViewState["Bill"];
            BillList.DataBind();
        }
        private void ShowBooks()
        {
            String Query = "Select bid as Code,bname as Name,bqty as Qty,bprice as Price  from book";
            BooksList.DataSource = Con.GetData(Query);
            BooksList.DataBind();
        }

        int Key = 0;
        int Stock = 0;
        protected void BooksList_SelectedIndexChanged(object sender, EventArgs e)
        {

            BName.Value = BooksList.SelectedRow.Cells[2].Text;
            Stock=Convert.ToInt32(BooksList.SelectedRow.Cells[3].Text);
            Price.Value= BooksList.SelectedRow.Cells[4].Text;
            

            if (BName.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BooksList.SelectedRow.Cells[1].Text);
            }
        }

        private void UpdateStock()
        {

            int newQty;
            newQty= Convert.ToInt32(BooksList.SelectedRow.Cells[3].Text)-Convert.ToInt32(Quan.Value);

            string Query = "update book set bqty='{0}' where bid='{1}'";
            Query = string.Format(Query, newQty, BooksList.SelectedRow.Cells[1].Text);
            Con.SetData(Query);
            ShowBooks();
        }

        int Grdtotal = 0; 
        int Amount;
        protected void AddToBtn_Click(object sender, EventArgs e)
        {
            

            if (Quan.Value == ""|| Price.Value==""||BName.Value=="")
            {
                errMsg.Text = "Missing Values";
            }
            else
            {
                int Total = Convert.ToInt32(Quan.Value) * Convert.ToInt32(Price.Value);
                DataTable dt = (DataTable)ViewState["Bill"];

                dt.Rows.Add(BillList.Rows.Count + 1,
                    BName.Value.Trim(),
                    Price.Value.Trim(),
                    Quan.Value.Trim(),
                    Total
                );

                ViewState["Bill"] = dt;
                this.BindGrid();
                UpdateStock();

                for (int i = 0; i < BillList.Rows.Count ; i++)
                {
                    
                    Grdtotal = Grdtotal + Convert.ToInt32(BillList.Rows[i].Cells[5].Text);
                    
                }
                Amount = Grdtotal;
                GrndTotal.Text = "Rs " + Amount;
                BName.Value = "";
                Price.Value = "";
                Quan.Value = "";

            }
            Grdtotal = 0;



        }
    }
}