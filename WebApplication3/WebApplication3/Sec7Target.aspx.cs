using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Sec7Target : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage == null)
            {
                string value = Request.QueryString["demo"];
                Response.Write("HyperLink / Redirect - <b>" + value + "</b>");
            }
            else if (PreviousPage.IsCrossPagePostBack)
            {
                //string value = Request.Form["txtDemo"];

                //TextBox txtDemo = (TextBox)PreviousPage.FindControl("txtDemo");
                //string value = txtDemo.Text; 

                string value = PreviousPage.DemoText;
                Response.Write("Cross Page PostBack - <b>" +value+ "</b>");
            }
            else
            {
                string value = Context.Items["demo"].ToString();

                //TextBox txtDemo = (TextBox)PreviousPage.FindControl("txtDemo");
                //string value = txtDemo.Text;

                //string value = PreviousPage.DemoText;
                Response.Write("Transfer - <b>"+value+"</b>");
            }
        }
    }
}
