using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise2
{
    public partial class PartyPage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            SqlConnection con = null;

            try
            {

                //create conn
                con = new SqlConnection("data source = .; database = Invoice; Integrated Security = SSPI");

                //create commmand
                SqlCommand cm = new SqlCommand("get_Party", con);
                cm.CommandType = CommandType.StoredProcedure;
                
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cm);

                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                partyGrid.DataSource = dt;
                partyGrid.DataBind();
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

        protected void btnAddParty_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/AddEditParty.aspx?type=Add&source=Party");
            
            Context.Items["ActionName"] = "Add";
            Server.Transfer("~/AddEditParty.aspx");
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/AddEditParty.aspx?type=Edit&source=Party");

            Context.Items["ActionName"] = "Edit";

            Button editBtn = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)editBtn.NamingContainer;

            string partyid = selectedRow.Cells[0].Text;
            string partyName = selectedRow.Cells[1].Text;

            Context.Items["PartyID"] = partyid;
            Context.Items["PartyName"] = partyName;
            Server.Transfer("~/AddEditParty.aspx");

        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            Button editBtn = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)editBtn.NamingContainer;

            string partyid = selectedRow.Cells[0].Text;
            SqlConnection conn = null;
            SqlCommand cm;
            try
            {
                conn = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");

                cm = new SqlCommand("DeleteParty", conn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@partyid", SqlDbType.Int) { Value = partyid });

                conn.Open();

                cm.ExecuteScalar() ;
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