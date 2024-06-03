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
    public partial class Seller : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowSellers();
        }
        private void ShowSellers()
        {
            String Query = "Select * from seller";
            SellersList.DataSource = Con.GetData(Query);
            SellersList.DataBind();
        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SName.Value == "" || SEmail.Value=="" || SPhone.Value==""|| SAddress.Value=="")
                {
                    errMsg.Text = "Missing Data!";
                }
                else
                {
                    string sName = SName.Value;
                    string sEmail = SEmail.Value;
                    string sPhone= SPhone.Value;
                    string sAdd=SAddress.Value;

                    string Query = "insert into seller values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, sName, sEmail, sPhone, sAdd);
                    Con.SetData(Query);
                    ShowSellers();
                    errMsg.Text = "Seller Added Successfully!";

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
            SName.Value = "";
            SEmail.Value = "";
            SPhone.Value="";
            SAddress.Value = "";
        }

        int Key = 0;
        protected void AuthorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SName.Value = SellersList.SelectedRow.Cells[2].Text;
            SEmail.Value = SellersList.SelectedRow.Cells[3].Text;
            SPhone.Value = SellersList.SelectedRow.Cells[4].Text;
            SAddress.Value = SellersList.SelectedRow.Cells[5].Text;

            if (SName.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SellersList.SelectedRow.Cells[1].Text);
            }
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (SName.Value == "" || SEmail.Value == "" || SPhone.Value == "" || SAddress.Value == "")
                {
                    errMsg.Text = "Missing Data!";
                }
                else
                {
                    string sName = SName.Value;
                    string sEmail = SEmail.Value;
                    string sPhone = SPhone.Value;
                    string sAdd = SAddress.Value;

                    string Query = "update seller set sname='{0}', semail='{1}', sphone='{2}', spass='{3}' where sid='{4}'";
                    Query = string.Format(Query, sName, sEmail, sPhone, sAdd, SellersList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    errMsg.Text = "Seller Updated Successfully!";

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
                if (SName.Value == "" || SEmail.Value == "" || SPhone.Value == "" || SAddress.Value == "")
                {
                    errMsg.Text = "Missing Data!";
                }
                else
                {
                    string Query = "delete from seller where sid='{0}'";
                    Query = string.Format(Query, SellersList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    errMsg.Text = "Seller Deleted Successfully!";

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