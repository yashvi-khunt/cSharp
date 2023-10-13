using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class CourseMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMaster_Click(object sender, EventArgs e)
        {
            lblBtnClick.Text = "Click From Master Page";
        }

        public string MasterLabel
        {
            get
            {
                return lblBtnClick.Text;
            }
            set
            {
                lblBtnClick.Text = value;
            }
        }
    }
}