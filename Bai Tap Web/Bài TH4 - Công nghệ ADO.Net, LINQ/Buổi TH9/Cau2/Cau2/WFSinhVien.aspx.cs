using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau2
{
    public partial class SINHVIEN : System.Web.UI.Page
    {
        QuanLyHocEntities1 myqlh;
        static bool isAdd;
        protected void Page_Load(object sender, EventArgs e)
        {
            myqlh = new QuanLyHocEntities1();
            if (!IsPostBack)
            {
                var sinhvien = from i in myqlh.KhoaDaoTaos
                               select i;
                ddlKhoa.DataSource = sinhvien.ToList();
                ddlKhoa.DataTextField = "TenKhoa";
                ddlKhoa.DataValueField = "MaKhoa";
                ddlKhoa.DataBind();
                ddlKhoa_SelectedIndexChanged(sender, e);
            }
            
        }

        protected void ddlKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from i in myqlh.SinhViens
                        where i.MaKhoa.ToString() == ddlKhoa.SelectedValue.ToString()
                        select i;
            GridviewSV.DataSource = query.ToList();
            GridviewSV.DataBind();
        }

        protected void GridviewSV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            
            if (e.CommandName == "Sua")
            {
                isAdd = false;
                ddlKhoa.Text = GridviewSV.Rows[row].Cells[0].Text;
                txtLop.Text = GridviewSV.Rows[row].Cells[1].Text;
                txtMaSV.Text = GridviewSV.Rows[row].Cells[2].Text;
                txtTen.Text = GridviewSV.Rows[row].Cells[3].Text;
                txtNgaySinh.Text = GridviewSV.Rows[row].Cells[4].Text;
                txtDiaChi.Text = GridviewSV.Rows[row].Cells[5].Text;

            }
            else if(e.CommandName == "Xoa")
            {
                String masv = (GridviewSV.Rows[row].Cells[2].Text);
                var xoa = from i in myqlh.SinhViens
                          where i.MaSV.ToString() == masv
                          select i;
                SinhVien sv = xoa.First();
                myqlh.SinhViens.Remove(sv);
                myqlh.SaveChanges();
            }
            ddlKhoa_SelectedIndexChanged(sender, e);
        }

        protected void txtGhi_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                SinhVien sv = new SinhVien();
                sv.MaKhoa = Convert.ToInt32(ddlKhoa.SelectedValue.ToString());
                sv.LopBC = txtLop.Text;
                sv.HoTen = txtTen.Text;
                sv.NgaySinh = txtNgaySinh.Text;
                sv.DiaChi = txtDiaChi.Text;
                myqlh.SinhViens.Add(sv);
                myqlh.SaveChanges();
               
            }
            else
            {
                var rewrite = from i in myqlh.SinhViens
                              where i.MaSV.ToString() == txtMaSV.Text
                              select i;
                SinhVien sv = rewrite.First();
                sv.MaKhoa = Convert.ToInt32(ddlKhoa.SelectedValue.ToString());
                sv.LopBC = txtLop.Text;
                sv.HoTen = txtTen.Text;
                sv.NgaySinh = txtNgaySinh.Text;
                sv.DiaChi = txtDiaChi.Text;
                myqlh.SaveChanges();

            }
            ddlKhoa_SelectedIndexChanged(sender, e);
        }

        protected void txtThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            txtLop.Text = "";
            txtMaSV.Text = "";
            txtTen.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
        }
    }
}