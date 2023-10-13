using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Sec12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnexception_Click(object sender, EventArgs e)
        {
            throw new ApplicationException();
        }

        protected void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Context.Error;
            if(ex is ApplicationException)
            {
                Response.Write(ex.Message);
                Context.ClearError();
            }
        }

    }
}