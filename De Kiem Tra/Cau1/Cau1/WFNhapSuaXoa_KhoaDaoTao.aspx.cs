using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau1
{
    public partial class WFNhapSuaXoa_KhoaDaoTao : System.Web.UI.Page
    {
        QuanlyhocDBEntities qlh;
        static bool isAdd;
        protected void Page_Load(object sender, EventArgs e)
        {
            qlh = new QuanlyhocDBEntities();
            //if (!IsPostBack)
            //{
                var khoa = from i in qlh.KhoaDaoTaos
                           select i;
                grvKhoa.DataSource = khoa.ToList();
                grvKhoa.DataBind();
            //}
        }

        protected void grvKhoa_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            string x = grvKhoa.Rows[row].Cells[0].Text;
            if(e.CommandName == "Sua")
            {
                isAdd = false;
                txtMaKhoa.Text = grvKhoa.Rows[row].Cells[0].Text;
                txtTenKhoa.Text = grvKhoa.Rows[row].Cells[1].Text;
                txtDienThoai.Text = grvKhoa.Rows[row].Cells[2].Text;
            }
            else if(e.CommandName == "Xoa")
            {
                var xoa = from i in qlh.KhoaDaoTaos
                          where i.MaKhoa == x
                          select i;
                KhoaDaoTao khoa = xoa.First();
                qlh.KhoaDaoTaos.Remove(khoa);
                qlh.SaveChanges();
            }
            Page_Load(sender, e);
        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                KhoaDaoTao khoa = new KhoaDaoTao();
                khoa.MaKhoa = txtMaKhoa.Text;
                khoa.TenKhoa = txtTenKhoa.Text;
                khoa.Phone = txtDienThoai.Text;
                qlh.KhoaDaoTaos.Add(khoa);
                qlh.SaveChanges();
            }
            else
            {
                var sua = from i in qlh.KhoaDaoTaos
                          where i.MaKhoa == txtMaKhoa.Text
                          select i;
                KhoaDaoTao khoa = sua.First();
                khoa.TenKhoa = txtTenKhoa.Text;
                khoa.Phone = txtDienThoai.Text;
                qlh.SaveChanges();
            }
            Page_Load(sender, e);
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtDienThoai.Text = "";
            Page_Load(sender, e);
        }
    }
}