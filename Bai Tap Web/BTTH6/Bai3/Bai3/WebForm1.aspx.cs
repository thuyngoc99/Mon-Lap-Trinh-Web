using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt1.Text);
            int b = Convert.ToInt32(txt2.Text);
            for(int i = 0; i <= ddltoantu.Items.Count; i++)
            {
                if (ddltoantu.Items[0].Selected)
                {
                    lblKQ.Text = (a + b).ToString();
                }
                else if (ddltoantu.Items[1].Selected)
                {
                    lblKQ.Text = (a - b).ToString();
                }
                else if (ddltoantu.Items[2].Selected)
                {
                    lblKQ.Text = (a * b).ToString();
                }
                else if (ddltoantu.Items[3].Selected)
                {
                    lblKQ.Text = (a / b).ToString();
                }
                else if (ddltoantu.Items[4].Selected)
                {
                    lblKQ.Text = (a % b).ToString();
                }
                else if (ddltoantu.Items[5].Selected)
                {
                    lblKQ.Text = (Math.Pow(a,b)).ToString();
                }   
            }
            
        }
    }
}