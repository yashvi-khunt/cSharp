using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}