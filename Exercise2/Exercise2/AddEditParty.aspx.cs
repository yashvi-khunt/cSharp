using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise2
{
    public partial class AddEditParty : System.Web.UI.Page
    {
        public static string action, id, name;
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                action = Context.Items["ActionName"].ToString();
                

                if (action == "Edit")
                {
                    id = Context.Items[$"PartyID"].ToString();
                    name = Context.Items[$"PartyName"].ToString();
                }
                pageTitle.Text = action + " party";
                lblName.Text = "Party Name";

                if (action == "Edit")
                {
                    txtName.Text = name;
                }
            } 
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {

            string newName = txtName.Text;
            SqlConnection conn = null;
            SqlCommand cm;
            try
            {
                conn = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");

                if (action == "Add")
                {
                    cm = new SqlCommand("AddParty", conn);
                    cm.CommandType = System.Data.CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@pname", SqlDbType.VarChar, 50) { Value = newName });
                }
                else
                {
                    cm = new SqlCommand("EditParty", conn);
                    cm.CommandType = System.Data.CommandType.StoredProcedure;
                    cm.Parameters.Add(new SqlParameter("@newname", SqlDbType.VarChar, 50) { Value = newName });
                    cm.Parameters.Add(new SqlParameter("@partyid", SqlDbType.Int) { Value = id });
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

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/Admin/PartyPage.aspx");

        }
    }
}