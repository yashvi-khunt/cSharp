using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise2
{
    public partial class InvoicePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = null;
          
            try
            {
                con = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");
                SqlCommand cm = new SqlCommand("get_invoiceList", con);
                cm.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                invoiceGrid.DataSource = dt;
                invoiceGrid.DataBind();
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

        protected void btnAddInvoice_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/AddInvoice.aspx");
        }


        protected void viewBtn_Click(object sender, EventArgs e)
        {
            Button viewBtn = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)viewBtn.NamingContainer;

            string invid = selectedRow.Cells[0].Text;

            Context.Items["invID"] = invid;
            Server.Transfer("~/ViewInvoice.aspx");
        }
    }
}