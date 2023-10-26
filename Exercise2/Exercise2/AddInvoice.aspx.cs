using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;
using System.Xml.Linq;

namespace Exercise2
{
    public partial class AddInvoice : System.Web.UI.Page
    {
        public static string invoiceId, partyId, productid;
        static bool counter = false;
        static int grandTotal = 0;

        protected void Page_load(object sender, EventArgs e)
        {
            if (!counter)
            {
                detailView.Visible = false;
            }
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                counter = false;
                grandTotal = 0;
                //Fill Party DropDown
                GetDropDownParty();
            }
            string currentProduct = DDProduct.Text;
            if (partyId != DDParty.Text)
            {
                partyId = DDParty.Text;
                currentProduct = String.Empty;
            }

            //Fill Product dd based on partyID
            GetDropDownProduct(partyId, currentProduct);
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            productid = DDProduct.Text;

            if (counter)
            {
                DDParty.Text = partyId;
                DDParty.Enabled = false;
                txtDate.Enabled = false;
            }
            //Get Product Rate
            GetTxtRate(productid);
            txtQuantity.Text = String.Empty;
        }

        public void GetDropDownParty()
        {
            DDParty.Items.Clear();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");
                con.Open();
                SqlCommand cmd = new SqlCommand("get_partyInvoiceList", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListItem partyNames = new ListItem(reader["PartyName"].ToString(), reader["PartyID"].ToString());

                        DDParty.Items.Add(partyNames);
                    }
                }

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

            if (!counter)
            {
                //creates invoice
                invoiceId = CreateNewInvoice();
                counter = true;
            }
            if (invoiceId != string.Empty)
            {
                //retrieves and fills invoice data in textfields
                GetInvoiceData(invoiceId);
                detailView.Visible = true;

                if(btnAddInvoice.Text == "Edit Invoice")
                {
                    UpdateDataIntoInvoiceDetails(invoiceId);
                }
                else
                {
                    //insert data into database table invoice details
                    InsertDataIntoInvoiceDetails(invoiceId);

                }

                //get data into grid view from invoice details
                GetDataFromInvoiceDetails(invoiceId);

                //update grandTotal
                //CalculateGrandTotal();
                lblGTotal.Text = grandTotal.ToString();
            }
        }

        public void UpdateDataIntoInvoiceDetails(string invoiceId)
        {
            SqlConnection connection = null;

            try
            {
                string quantity = txtQuantity.Text;
                string product = DDProduct.Text;
                int total = Int32.Parse(txtRate.Text) * Int32.Parse(quantity);
                grandTotal += total;


                connection = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");

                SqlCommand cmd = new SqlCommand("edit_invoice_details_by_Id", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = invoiceId });
                cmd.Parameters.Add(new SqlParameter("@productid", SqlDbType.Int) { Value = productid });
                cmd.Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int) { Value = quantity });
                cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Int) { Value = total });

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex) 
            {
                Response.Write(ex);
            }
            finally
            {
                connection.Close();
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
        public void InsertDataIntoInvoiceDetails(string invoiceId)
        {
            SqlConnection connection = null;

            try
            {
                string quantity = txtQuantity.Text;
                string product = DDProduct.Text;
                int total = Int32.Parse(txtRate.Text) * Int32.Parse(quantity);
                grandTotal += total;


                connection = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");

                SqlCommand cmd = new SqlCommand("AddInvoiceDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@invoiceid", SqlDbType.Int) { Value = invoiceId });
                cmd.Parameters.Add(new SqlParameter("@productid", SqlDbType.Int) { Value = productid });
                cmd.Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int) { Value = quantity });
                cmd.Parameters.Add(new SqlParameter("@total", SqlDbType.Int) { Value = total });

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
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
                cm.Parameters.Add(new SqlParameter("@gt", SqlDbType.Int) { Direction = ParameterDirection.Output });

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
        public string CreateNewInvoice()
        {
            string result = String.Empty;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");

                SqlCommand cm = new SqlCommand("AddInvoice", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@partyID", SqlDbType.Int) { Value = partyId });
                cm.Parameters.Add(new SqlParameter("@date", SqlDbType.Date) { Value = txtDate.Text });
                cm.Parameters.Add(new SqlParameter("@invID", SqlDbType.Int) { Direction = ParameterDirection.Output });

                con.Open();
                cm.ExecuteNonQuery();

                result = cm.Parameters["@invID"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return result;
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");
                SqlCommand cm = new SqlCommand("AddGrantTotal", con);

                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@invid", SqlDbType.Int) { Value = invoiceId });
                cm.Parameters.Add(new SqlParameter("@gt", SqlDbType.Int) { Value = grandTotal });
                con.Open();
                cm.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { con.Close(); }

            counter = false;
            Response.Redirect("~/InvoicePage.aspx");
        }

        protected void editBtn_Click(object sender, EventArgs e)
        {
            Button viewBtn = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)viewBtn.NamingContainer;

            string invdetailsid = selectedRow.Cells[0].Text;
            string productid = selectedRow.Cells[1].Text;
            string rate = selectedRow.Cells[2].Text;
            string quantity = selectedRow.Cells[3].Text;

            DDProduct.SelectedValue = productid;
            txtRate.Text = rate;
            txtQuantity.Text = quantity;

            btnAddInvoice.Text = "Edit invoice";

        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            Button viewBtn = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)viewBtn.NamingContainer;

            string invdetailsid = selectedRow.Cells[0].Text;


    
           
        }

        public void GetDropDownProduct(string partyid, string current)
        {
            DDProduct.Items.Clear();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");
                con.Open();
                SqlCommand cmd = new SqlCommand("get_productInvoiceList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@partyid", SqlDbType.Int) { Value = partyid });

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListItem productNames = new ListItem(reader["ProductName"].ToString(), reader["ProductID"].ToString());
                        DDProduct.Items.Add(productNames);
                    }
                }
                if (current != string.Empty)
                {

                    DDProduct.Text = current;
                }
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


        public void GetTxtRate(string productid)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");
                con.Open();
                SqlCommand cmd = new SqlCommand("get_productRateList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@productid", SqlDbType.Int) { Value = productid });

                txtRate.Text = cmd.ExecuteScalar().ToString();
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