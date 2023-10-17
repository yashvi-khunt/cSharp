using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace AdoNet
{
    public partial class ExampleAdoNet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonId_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            try
            {
                //creating conncection
                conn = new SqlConnection("data source = .; database = student; integrated security = SSPI");

                //writing insert query
                string query = "insert into student2(name,email,contact) values('" + UsernameId.Text + "','" + EmailId.Text+"','"+ContactId.Text+"')";


                SqlCommand cm = new SqlCommand(query,conn);

                //opening connection
                conn.Open();

                //executing query
                int status = cm.ExecuteNonQuery();
                Label1.Text = "Your record has been saved with the following details!";

                string query2 = "Select * from Student2";
                cm = new SqlCommand(query2,conn);
                SqlDataAdapter sde = new SqlDataAdapter(cm);
                System.Data.DataTable dt = new System.Data.DataTable();
                sde.Fill(dt);

                //ui 
                GridView1.DataSource = dt;
                GridView1.DataBind();
                
            }
            catch (Exception ex)
            {
                Response.Write("Error: "+ex.ToString());
            }
        }
    }
}