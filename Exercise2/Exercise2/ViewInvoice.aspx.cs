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
    public partial class ViewInvoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string invoiceID = string.Empty;
            if (!IsPostBack)  { 
             invoiceID = Context.Items["invID"].ToString();
            }
            //get partyname,date by its id and add to textbox
            GetInvoiceData(invoiceID);

            //get invoiceDetails
            GetDataFromInvoiceDetails(invoiceID);
        }

        public void GetInvoiceData(string invoiceId)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");

                SqlCommand cm = new SqlCommand("get_InvoicebyId", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@invoiceid", SqlDbType.Int) { Value = invoiceId });
                cm.Parameters.Add(new SqlParameter("@date", SqlDbType.Date) { Direction = ParameterDirection.Output });
                cm.Parameters.Add(new SqlParameter("@party", SqlDbType.VarChar, 50) { Direction = ParameterDirection.Output });
                cm.Parameters.Add(new SqlParameter("@gt",SqlDbType.Int) { Direction = ParameterDirection.Output });

                con.Open();
                cm.ExecuteNonQuery();

                lblParty.Text = cm.Parameters["@party"].Value.ToString();
                lblInvoiceid.Text = invoiceId;
                lblInvDate.Text = Convert.ToDateTime(cm.Parameters["@date"].Value.ToString()).Date.ToString("dd-MM-yyyy");
                lblGTotal.Text = cm.Parameters["@gt"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
        }


        public void GetDataFromInvoiceDetails(string invoiceId)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");

                SqlCommand cm = new SqlCommand("get_invoiceDetailsById", connection);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@invid", SqlDbType.Int) { Value = invoiceId });

                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();

                sda.Fill(dt);

                currentInvoiceGrid.DataSource = dt;
                currentInvoiceGrid.DataBind();


            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/InvoicePage.aspx");
        }
    }
}