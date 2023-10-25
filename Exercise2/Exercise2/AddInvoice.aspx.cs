using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;

namespace Exercise2
{
    public partial class AddInvoice : System.Web.UI.Page
    {
        public static string action,invoiceid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                action = Context.Items["ActionName"].ToString();

                pageTitle.Text = action + " Invoice";
                if (action == "Edit")
                {
                    invoiceid = Context.Items["InvoiceID"].ToString();
                }
            }
        }
    }
}