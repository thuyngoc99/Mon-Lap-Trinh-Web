using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau1
{
    public partial class Form_CanBo : System.Web.UI.Page
    {
        QuanlycanboEntities2 qlcb;
        static bool isAdd;
        protected void Page_Load(object sender, EventArgs e)
        {
            qlcb = new QuanlycanboEntities2();
            var cb = from i in qlcb.CanBoes
                     select i;
            GridView1.DataSource = cb.ToList();
            GridView1.DataBind();
        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                CanBo canBo = new CanBo();
                //canBo.MaCB = Convert.ToInt32(txtcanbo.Text);
                canBo.HoTen = txthoten.Text;
                qlcb.CanBoes.Add(canBo);
                qlcb.SaveChanges();

            }
            else
            {
                var sua = from i in qlcb.CanBoes
                          where i.MaCB.ToString() == txtcanbo.Text
                          select i;
                CanBo canBo = sua.First();
                canBo.HoTen = txthoten.Text;
                qlcb.SaveChanges();
            }
            Page_Load(sender, e);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "Sua")
            {
                isAdd = false;
                txtcanbo.Text = GridView1.Rows[row].Cells[0].Text;
                txthoten.Text = GridView1.Rows[row].Cells[1].Text;
            }
            else if(e.CommandName == "Xoa")
            {
                string maCb = GridView1.Rows[row].Cells[0].Text;
                var xoa = from i in qlcb.CanBoes
                          where i.MaCB.ToString() == maCb
                          select i;
                CanBo canBo = xoa.First();
                qlcb.CanBoes.Remove(canBo);
                qlcb.SaveChanges();
            }
            Page_Load(sender, e);
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            txtcanbo.Text = "";
            txthoten.Text = "";
        }
    }
}