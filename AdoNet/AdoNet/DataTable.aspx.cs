using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace AdoNet
{
    public partial class DataTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //System.Data.DataTable dt = new System.Data.DataTable();
            //dt.Columns.Add("ID");
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Email");
            //dt.Rows.Add("101", "Rameez", "rameez@example.com");
            //dt.Rows.Add("102", "Sam Nicolus", "sam@example.com");
            //dt.Rows.Add("103", "Subramanium", "subramanium@example.com");
            //dt.Rows.Add("104", "Ankur Kumar", "ankur@example.com");
            //GridView.DataSource = dt;
            //GridView.DataBind();

            /*
            using (SqlConnection con = new SqlConnection("data source = .; database = student; integrated security = SSPI "))
            {
                SqlCommand cm = new SqlCommand("Select * from StudentInfo", con);
                SqlDataAdapter sde = new SqlDataAdapter(cm);
                System.Data.DataTable dt = new System.Data.DataTable();
                sde.Fill(dt);

                GridView.DataSource = dt;
                GridView.DataBind();
            }
            */

            using (SqlConnection con = new SqlConnection("data source = .; database = student; integrated security = SSPI "))
            {
                SqlCommand cm = new SqlCommand("Select * from StudentInfo", con);
                SqlDataAdapter sde = new SqlDataAdapter(cm);
                System.Data.DataSet ds = new System.Data.DataSet();
                sde.Fill(ds);

                System.Data.DataTable dt = new System.Data.DataTable();
                dt = ds.Tables[0];

                GridView.DataSource = dt;
                GridView.DataBind();
            }

        }
    }
}