using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau1
{
    public partial class WFNhapSuaXoa_SinhVien : System.Web.UI.Page
    {
        QuanlyhocDBEntities qlh;
        static Boolean isAdd;
        protected void Page_Load(object sender, EventArgs e)
        {
            qlh = new QuanlyhocDBEntities();
            if (!IsPostBack)
            {
                var khoa = from i in qlh.KhoaDaoTaos
                           select i;
                ddlKhoa.DataSource = khoa.ToList();
                ddlKhoa.DataTextField = "TenKhoa";
                ddlKhoa.DataValueField = "MaKhoa";
                ddlKhoa.DataBind();
                ddlKhoa_SelectedIndexChanged(sender, e);
            }
        }

        protected void ddlKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var khoa = from i in qlh.SinhViens
                       where i.MaKhoa == ddlKhoa.SelectedValue.ToString()
                       select i;
            grvSV.DataSource = khoa.ToList();
            grvSV.DataBind();
        }

        protected void grvSV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Sua")
            {
                isAdd = false;
                txtMaSV.Text = grvSV.Rows[row].Cells[2].Text;
                txtLop.Text = grvSV.Rows[row].Cells[1].Text;
                //txtMaSV.Text = grvSV.Rows[row].Cells[2].Text;
                txtHoTen.Text = grvSV.Rows[row].Cells[3].Text;
                txtNgaySinh.Text = grvSV.Rows[row].Cells[4].Text;
                txtDiaChi.Text = grvSV.Rows[row].Cells[5].Text;
            }
            else if(e.CommandName == "Xoa")
            {

                string maSV = grvSV.Rows[row].Cells[2].Text;
                var xoa = from i in qlh.SinhViens
                          where i.MaSV == maSV
                          select i;
                SinhVien sinhVien = xoa.First();
                qlh.SinhViens.Remove(sinhVien);
                qlh.SaveChanges();
            }
            ddlKhoa_SelectedIndexChanged(sender, e);
        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.MaKhoa = ddlKhoa.SelectedValue.ToString();
                sinhVien.LopBC = txtLop.Text;
                sinhVien.MaSV = txtMaSV.Text;
                sinhVien.HoTen = txtHoTen.Text;
                sinhVien.NgaySinh = txtNgaySinh.Text;
                sinhVien.DiaChi = txtDiaChi.Text;
                qlh.SinhViens.Add(sinhVien);
                qlh.SaveChanges();
            }
            else
            {
                var ghi = from i in qlh.SinhViens
                          where i.MaSV == txtMaSV.Text
                          select i;
                SinhVien sinhVien = ghi.First();
                sinhVien.MaKhoa = ddlKhoa.SelectedValue.ToString();
                sinhVien.HoTen = txtHoTen.Text;
                sinhVien.LopBC = txtLop.Text;
                
                sinhVien.NgaySinh = txtNgaySinh.Text;
                sinhVien.DiaChi = txtDiaChi.Text;
                qlh.SaveChanges();
            }
            ddlKhoa_SelectedIndexChanged(sender, e);
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            txtMaSV.Text = "";
            txtLop.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
        }
    }
}