using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class CSharp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncs_Click(object sender, EventArgs e)
        {
            Label txt = (Label)Master.FindControl("lblBtnClick");
            txt.Text = "Click From C# Page";
        }
    }
}