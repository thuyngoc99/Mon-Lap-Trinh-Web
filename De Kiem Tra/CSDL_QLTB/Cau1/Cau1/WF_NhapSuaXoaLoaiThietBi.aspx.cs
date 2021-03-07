using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau1
{
    public partial class WF_NhapSuaXoaLoaiThietBi : System.Web.UI.Page
    {
        QLTBEntities qLTB;
        static bool isAdd;
        protected void Page_Load(object sender, EventArgs e)
        {
            qLTB = new QLTBEntities();
            var loaithietbi = from i in qLTB.Loaithietbis
                              select i;
            GridViewDM.DataSource = loaithietbi.ToList();
            GridViewDM.DataBind();
        }

        protected void GridViewDM_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "Sua")
            {
                isAdd = false;
                txtMaloai.Text = GridViewDM.Rows[row].Cells[0].Text;
                txtTenloai.Text = GridViewDM.Rows[row].Cells[1].Text;
                txtDanhmuc.Text = GridViewDM.Rows[row].Cells[2].Text;
            }
            else if(e.CommandName == "Xoa")
            {
                string Maloai = GridViewDM.Rows[row].Cells[0].Text;
                var xoa = from i in qLTB.Loaithietbis
                          where i.Maloai.ToString() == Maloai
                          select i;
                Loaithietbi loai = xoa.First();
                qLTB.Loaithietbis.Remove(loai);
                qLTB.SaveChanges();

            }
            Page_Load(sender, e);
        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                Loaithietbi loai = new Loaithietbi();
                loai.Tenloai = txtTenloai.Text;
                loai.Danhmuc = txtDanhmuc.Text;
                qLTB.Loaithietbis.Add(loai);
                qLTB.SaveChanges();
            }
            else
            {
                var sua = from i in qLTB.Loaithietbis
                          where i.Maloai.ToString() == txtMaloai.Text
                          select i;
                Loaithietbi loai = sua.First();
                loai.Tenloai = txtTenloai.Text;
                loai.Danhmuc = txtDanhmuc.Text;
                qLTB.SaveChanges();
              
            }
            Page_Load(sender, e);
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            txtMaloai.Text = "";
            txtTenloai.Text = "";
            txtDanhmuc.Text = "";
        }
    }
}