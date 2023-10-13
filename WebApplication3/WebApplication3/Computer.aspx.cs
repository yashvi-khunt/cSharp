using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Computer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("URL: " + Request.Url + "<br>");
            Response.Write("Path: " + Request.Path + "<br>");
            Response.Write("FilePath: " + Request.FilePath + "<br>");
            Response.Write("RawURL: " + Request.RawUrl + "<br>");
        }
    }
}