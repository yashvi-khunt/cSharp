using System;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;
using System.Drawing.Printing;

namespace AdoNet
{
    public partial class DataSet : System.Web.UI.Page
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source = .; database = student; integrated security = SSPI "))
            {
                SqlCommand cm = new SqlCommand("Select * from StudentInfo", con);
                SqlDataAdapter sde = new SqlDataAdapter(cm);
                System.Data.DataSet ds = new System.Data.DataSet();

                sde.Fill(ds,"Info");

                
                string query = "Select top 1 * from StudentInfo";
                cm = new SqlCommand(query, con);
                sde = new SqlDataAdapter(cm);
                sde.Fill(ds, "FirstStudent");

                GridView1.DataSource = ds.Tables["FirstStudent"];
                GridView1.DataBind();


                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();

            }
        }

        //protected void btnInsert_Click(object sender, EventArgs e)
        //{
        //    Program ins = new Program();
        //    ins.InsertData("104", "Donald Duck", "donald@eample.com");
        //    btnInsert.Enabled = false;

        //}
    }
}