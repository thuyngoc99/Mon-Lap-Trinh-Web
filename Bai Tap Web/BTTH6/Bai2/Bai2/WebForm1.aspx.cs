using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btntinhhieu_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txta.Text);
            int y = Convert.ToInt32(txtb.Text);
            lblkq.Text = (x - y).ToString();
        }
    }
}