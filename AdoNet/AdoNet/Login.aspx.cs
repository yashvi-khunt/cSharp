using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;

namespace AdoNet
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //string un = txtUsername.Text;
            //string pwd = txtPwd.Text;
            //bool isAuthenticated = FormsAuthentication.Authenticate(un, pwd);
            //if (isAuthenticated)
            //{
            //    FormsAuthentication.SetAuthCookie(un,false);
            //    Response.Redirect("~/HomePage.html");

            //    FormsAuthentication.SignOut();
            //}
            //else
            //{
            //    lblError.Text = "Invalid UserName or Password";
            //}

            if (ValidateUser(txtUsername.Text, txtPwd.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, false);
                Response.Redirect("~/HomePage.aspx?userName="+txtUsername.Text, true);
            }

        }


        private bool ValidateUser(string userName, string passWord)
        {
            SqlConnection conn;
            SqlCommand cmd;
            string lookupPassword = null;

            // Check for invalid userName.
            // userName must not be null and must be between 1 and 15 characters.
            if ((null == userName) || (0 == userName.Length) || (userName.Length > 15))
            {
                lblError.Text = "UserName cannot be empty and must be between 1 and 15 characters.";
                return false;
            }

            // Check for invalid passWord.
            // passWord must not be null and must be between 1 and 25 characters.
            if ((null == passWord) || (0 == passWord.Length) || (passWord.Length > 25))
            {
                lblError.Text = "Password cannot be empty and must be between 1 and 25 characters.";
                return false;
            }

            try
            {
                // Consult with your SQL Server administrator for an appropriate connection
                // string to use to connect to your local SQL Server.
                conn = new SqlConnection("data source=.;Integrated Security=SSPI;database=student");
                conn.Open();

                // Create SqlCommand to select pwd field from users table given supplied userName.
                cmd = new SqlCommand($"Select pwd from users where uname='{userName}'", conn);
                cmd.Parameters.Add("@userName", SqlDbType.VarChar, 25);
                cmd.Parameters["@userName"].Value = userName;

                // Execute command and fetch pwd field into lookupPassword string.
                lookupPassword = (string)cmd.ExecuteScalar();

                // Cleanup command and connection objects.
                cmd.Dispose();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                // Add error handling here for debugging.
                // This error message should not be sent back to the caller.
                lblError.Text = ex.Message;
            }

            // If no password found, return false.
            if (null == lookupPassword)
            {
                // You could write failed login attempts here to event log for additional security.
                lblError.Text = "Incorrect UserName or Password";
                return false;
            }

            // Compare lookupPassword and input passWord, using a case-sensitive comparison.
            return (0 == string.Compare(lookupPassword, passWord, false));
        }
    }
    
}