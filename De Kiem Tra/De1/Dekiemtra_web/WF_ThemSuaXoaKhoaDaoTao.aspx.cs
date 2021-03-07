using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dekiemtra_web
{
    public partial class WF_ThemSuaXoaKhoaDaoTao : System.Web.UI.Page
    {
        QuanlyhocDBEntities quanlyhoc;
        static bool isAdd;
        protected void SetControl(bool edit)
        {
            txtMaKhoa.Enabled = edit;
            txtTenKhoa.Enabled = edit;
            txtPhone.Enabled = edit;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            quanlyhoc = new QuanlyhocDBEntities();
            var khoa = from i in quanlyhoc.KhoaDaoTaos
                           select i;
            GridView1.DataSource = khoa.ToList();
            GridView1.DataBind();
            SetControl(false);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "Sua")
            {
                isAdd = false;
                //SetControl(true);
                txtMaKhoa.Text = GridView1.Rows[row].Cells[0].Text;
                txtTenKhoa.Text = GridView1.Rows[row].Cells[1].Text;
                txtPhone.Text = GridView1.Rows[row].Cells[2].Text;
            }
            else if(e.CommandName == "Xoa")
            {
                string xoa = GridView1.Rows[row].Cells[0].Text;
                var xoaKhoa = from i in quanlyhoc.KhoaDaoTaos
                              where i.MaKhoa == xoa
                              select i;
                KhoaDaoTao khoa = xoaKhoa.First();
                quanlyhoc.KhoaDaoTaos.Remove(khoa);
                quanlyhoc.SaveChanges();
            }
            Page_Load(sender, e);
            SetControl(true);
        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                //SetControl(true);
                KhoaDaoTao khoa = new KhoaDaoTao();
                khoa.MaKhoa = txtMaKhoa.Text;
                khoa.TenKhoa = txtTenKhoa.Text;
                khoa.Phone = txtPhone.Text;
                quanlyhoc.KhoaDaoTaos.Add(khoa);
                quanlyhoc.SaveChanges();
            }
            else
            {
                //SetControl(true);
                var sua = from i in quanlyhoc.KhoaDaoTaos
                          where i.MaKhoa == txtMaKhoa.Text
                          select i;
                KhoaDaoTao khoaa = sua.First();
                khoaa.TenKhoa = txtTenKhoa.Text;
                khoaa.Phone = txtPhone.Text;
                quanlyhoc.SaveChanges();
            }
            Page_Load(sender, e);
            //SetControl(true);
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtPhone.Text = "";
            SetControl(true);
        }
    }
}