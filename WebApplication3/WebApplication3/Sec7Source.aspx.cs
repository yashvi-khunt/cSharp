using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Sec7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string DemoText
        {
            get
            {
                return txtDemo.Text;
            }
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            string value = txtDemo.Text;
            Response.Redirect("Sec7Target.aspx?demo=" + value);
        }

        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            Context.Items["demo"] = txtDemo.Text;
            Server.Transfer("Sec7Target.aspx");
        }

    }
}