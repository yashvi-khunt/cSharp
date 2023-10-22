using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.NetworkInformation;

namespace Exercise2
{
    public partial class ProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = null;

            try
            {

                //create conn
                con = new SqlConnection("data source = .; database = Invoice; Integrated Security = SSPI");

                //create commmand
                SqlCommand cm = new SqlCommand("get_products", con);
                cm.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cm);

                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                productGrid.DataSource = dt;
                productGrid.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Context.Items["ActionName"] = "Add";
            Server.Transfer("~/AddEditProduct.aspx");
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {

            Context.Items["ActionName"] = "Edit";

            Button editBtn = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)editBtn.NamingContainer;

            string productid = selectedRow.Cells[0].Text;
            string productName = selectedRow.Cells[1].Text;
            string productRate = selectedRow.Cells[2].Text;
            string productDate = selectedRow.Cells[3].Text;

            Context.Items["ProductID"] = productid;
            Context.Items["ProductName"] = productName;
            Context.Items["ProductRate"] = productRate;
            Context.Items["ProductDate"] = productDate;
            Server.Transfer("~/AddEditProduct.aspx");

        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            Button editBtn = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)editBtn.NamingContainer;

            string productid = selectedRow.Cells[0].Text;
            SqlConnection conn = null;
            SqlCommand cm;
            try
            {
                conn = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");

                cm = new SqlCommand("DeleteProduct", conn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@productid", SqlDbType.Int) { Value = productid });

                conn.Open();

                cm.ExecuteScalar();
                //string result = cm.ExecuteScalar().ToString();

                //lblError.Text = result;
            }
            catch (Exception ex)
            {
                //lblError.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}