using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndangky_Click(object sender, EventArgs e)
        {
            Session["name"] = txttendangnhap.Text;
            Session["pass"] = txtmatkhau.Text;
            Session["nhaplaimatkhau"] = txtnhaplaimatkhau.Text;
            Session["email"] = txtemail.Text;

           
            if (Radio1.Checked)
            {
                Session["gioitinh"] = Radio1.Text;
            }
            else if(Radio2.Checked)
            {
                Session["gioitinh"] = Radio2.Text;
            }

            Session["date"] = txtngaysinh.Text;

            
            if (CheckBox1.Checked && CheckBox2.Checked)
            {
                Session["hobbie1"] = CheckBox1.Text;
                Session["hobbie2"] = CheckBox2.Text;
            }
            else if (CheckBox2.Checked && CheckBox3.Checked)
            {
                Session["hobbie1"] = CheckBox2.Text;
                Session["hobbie2"] = CheckBox3.Text;
            }
            else if (CheckBox1.Checked && CheckBox3.Checked)
            {
                Session["hobbie1"] = CheckBox1.Text;
                Session["hobbie2"] = CheckBox3.Text;
            }
           
            Response.Redirect("~/WebForm2.aspx");

        }

        protected void btnnhaplai_Click(object sender, EventArgs e)
        {
            txttendangnhap.Text = string.Empty;
            txtmatkhau.Text = string.Empty;
            txtnhaplaimatkhau.Text = string.Empty;
            txtemail.Text = string.Empty;

            if (Radio1.Checked)
            {
                Radio1.Checked = false;
            }
            else if (Radio2.Checked)
            {
                Radio2.Checked = false;
            }

            txtngaysinh.Text = string.Empty;

            if (CheckBox1.Checked && CheckBox2.Checked)
            {
                CheckBox1.Checked = false;
                CheckBox2.Checked = false;
            }
            else if (CheckBox2.Checked && CheckBox3.Checked)
            {
                CheckBox2.Checked = false;
                CheckBox3.Checked = false;
            }
            else if (CheckBox1.Checked && CheckBox3.Checked)
            {
                CheckBox1.Checked = false;
                CheckBox3.Checked = false;
            }
        }
    }
}