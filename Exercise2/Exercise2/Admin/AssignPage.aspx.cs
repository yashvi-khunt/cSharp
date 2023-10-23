using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise2
{
    public partial class AssignPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = null;

            try
            {

                //create conn
                con = new SqlConnection("data source = .; database = Invoice; Integrated Security = SSPI");

                //create commmand
                SqlCommand cm = new SqlCommand("get_assignList", con);
                cm.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cm);

                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                assignGrid.DataSource = dt;
                assignGrid.DataBind();
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

        protected void btnAddAssign_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/AddAssign.aspx");
        }
    }
}