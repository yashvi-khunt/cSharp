﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;

namespace Exercise2
{
    public partial class AddInvoice : System.Web.UI.Page
    {
        public static string action, invoiceid, partyId, productid;
        static bool counter = false;
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                counter = false;
                action = Context.Items["ActionName"].ToString();

                pageTitle.Text = action + " Invoice";
                if (action == "Edit")
                {
                    invoiceid = Context.Items["InvoiceID"].ToString();
                }

                //Fill Party DropDown
                GetDropDownParty();
            }

            if (!counter)
            {
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

                //Get Product Rate
                GetTxtRate(productid);
            }
            else
            {
                DDParty.Text = partyId;
                DDParty.Enabled = false;
                txtDate.Enabled = false;
            }
        }

        public void GetDropDownParty()
        {
            DDParty.Items.Clear();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");
                con.Open();
                SqlCommand cmd = new SqlCommand("get_partyInvoice", con);
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
            string invoiceId;
            if (!counter)
            {
                invoiceId = CreateNewInvoice();
                Response.Write(invoiceId);
                counter = true;
            }
           
        }

        public string CreateNewInvoice()
        {
            string result= String.Empty;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");

                SqlCommand cm = new SqlCommand("AddInvoice",con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Add(new SqlParameter("@partyID", SqlDbType.Int) { Value = partyId });
                cm.Parameters.Add(new SqlParameter("@date", SqlDbType.Date) { Value = txtDate.Text });
                cm.Parameters.Add(new SqlParameter("@invID", SqlDbType.Int) { Direction = ParameterDirection.Output });
                
                con.Open();
                cm.ExecuteNonQuery();

                result = cm.Parameters["@invID"].Value.ToString();
            }
            catch(Exception ex)
            {
               
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public void GetDropDownProduct(string partyid, string current)
        {
            DDProduct.Items.Clear();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = .; database = invoice; integrated security = SSPI");
                con.Open();
                SqlCommand cmd = new SqlCommand("get_productInvoice", con);
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
                SqlCommand cmd = new SqlCommand("get_productRate", con);
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