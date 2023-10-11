using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Hello! This is a Label";
        }
        protected void rbnColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            Label1.ForeColor = System.Drawing.Color.FromName(rbn.Text);
            //if(rbnRed.Checked)
            //    Label1.ForeColor = System.Drawing.Color.Red;
            //else if(rbnGreen.Checked)
            //    Label1.ForeColor = System.Drawing.Color.Green;
            //else
            //    Label1.ForeColor = System.Drawing.Color.Blue;
        }


    }
}