using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Exercise2
{
    public partial class AddEditProduct : System.Web.UI.Page
    {
        public static string action, id, name, rate, date;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                action = Context.Items["ActionName"].ToString();
                txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

                if (action == "Edit")
                {
                    id = Context.Items["ProductID"].ToString();
                    name = Context.Items["ProductName"].ToString();
                    rate = Context.Items["ProductRate"].ToString();
                    date = Context.Items["ProductDate"].ToString();

                    txtName.Text = name;
                    txtRate.Text = rate;

                    txtDate.Text = Convert.ToDateTime(date).Date.ToString("yyyy-MM-dd");

                }
                pageTitle.Text = action + " Product";

            }

        }

        protected bool validateProduct()
        {
            string name = txtName.Text;
            int rate;
            if (name == "")
            {
                lblError.Text = "Please enter a name";
                return false;
            }
            if (!Int32.TryParse(txtRate.Text, out rate))
            {
                lblError.Text = "Please enter a value > 0";
                return false;
            }
            else if (rate < 0)
            {
                lblError.Text = "Rate can not be negative";
                return false;
            }
            return true;
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (validateProduct())
            {



                string newName = txtName.Text;
                string newRate = txtRate.Text;
                string newDate = txtDate.Text;
                SqlConnection conn = null;
                SqlCommand cm;
                try
                {
                    conn = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");

                    if (action == "Add")
                    {
                        cm = new SqlCommand("AddProduct", conn);
                        cm.CommandType = System.Data.CommandType.StoredProcedure;
                        cm.Parameters.Add(new SqlParameter("@pname", SqlDbType.VarChar, 50) { Value = newName });
                        cm.Parameters.Add(new SqlParameter("@rate", SqlDbType.Int) { Value = newRate });
                        cm.Parameters.Add(new SqlParameter("@date", SqlDbType.Date) { Value = newDate });
                    }
                    else
                    {
                        cm = new SqlCommand("EditProduct", conn);
                        cm.CommandType = System.Data.CommandType.StoredProcedure;
                        cm.Parameters.Add(new SqlParameter("@newname", SqlDbType.VarChar, 50) { Value = newName });
                        cm.Parameters.Add(new SqlParameter("@productid", SqlDbType.Int) { Value = id });
                        cm.Parameters.Add(new SqlParameter("@newdate", SqlDbType.Date) { Value = newDate });
                        cm.Parameters.Add(new SqlParameter("@newrate", SqlDbType.VarChar, 50) { Value = newRate });
                    }
                    conn.Open();

                    string result = cm.ExecuteScalar().ToString();

                    lblError.Text = result;
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
                txtName.Text = string.Empty;
                txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                txtRate.Text = string.Empty;

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/ProductPage.aspx");

        }
    }
}