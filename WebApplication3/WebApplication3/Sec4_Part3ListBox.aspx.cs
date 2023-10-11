using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Part3ListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 0; i < 5; i++)
                {
                    ListItem li = new ListItem();
                    li.Text = "Item" + i;
                    li.Value = i.ToString();
                    lstLeft.Items.Add(li);
                }
            }
        }

        protected void btnMoveToRight_Click(object sender, EventArgs e)
        {
            ListItem li = lstLeft.SelectedItem;
            if (li == null)
            {
                li = lstLeft.Items[0];
                
            }
            else
            {
               
                li.Selected = false;
            }
            lstLeft.Items.Remove(li);
            lstRight.Items.Add(li);
        }

        protected void btnMovToLeft_Click(object sender, EventArgs e)
        {
            ListItem li = lstRight.SelectedItem;
            if (li == null)
            {
                li = lstRight.Items[0];

            }
            else
            {

                li.Selected = false;
            }
            lstRight.Items.Remove(li);
            lstLeft.Items.Add(li);
        }
    }
}