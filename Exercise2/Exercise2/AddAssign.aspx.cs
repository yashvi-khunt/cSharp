using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise2.Admin
{
    public partial class AddAssign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");
                con.Open();
                SqlCommand cmd = new SqlCommand("get_party", con);
                cmd.CommandType = CommandType.Text;
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListItem partyNames = new ListItem(reader["PartyName"].ToString(), reader["PartyID"].ToString());
                        DDParty.Items.Add(partyNames);
                    }
                }

                cmd = new SqlCommand("get_products", con);
                cmd.CommandType = CommandType.Text;
           
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListItem productNames = new ListItem(reader["ProductName"].ToString(), reader["ProductID"].ToString());
                        DDProduct.Items.Add(productNames);
                    }
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/AssignPage.aspx");
        }
    }
}