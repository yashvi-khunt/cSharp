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

                //dt.Columns["invoiceDate"].ReadOnly = false;
                //DateTime dateandTime = DateTime.Parse();
                //dt.Columns["invoiceDate"] = dateandTime.Date; 
                //int i = 0;
                //string d = "";
                //foreach (DataRow dr in dt.Rows)
                //{
                //    d = ((DateTime)dr["invoiceDate"]).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                //    Response.Write(d);
                //    dt.Rows[i]["invoiceDate"] = d;

                //    Response.Write(dt.Rows[i]["invoiceDate"]);
                //    i++;
                //}

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
    }
}