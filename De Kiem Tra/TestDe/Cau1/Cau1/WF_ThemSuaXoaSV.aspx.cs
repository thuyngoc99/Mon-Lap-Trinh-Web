using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau1
{
    public partial class WF_ThemSuaXoaSV : System.Web.UI.Page
    {
        QuanlydiemEntities quanlydiem;
        static bool isAdd;

        protected void SetControl(bool edit)
        {
            txtMasv.Enabled = edit;
            txtHoTen.Enabled = edit;
            txtNgaySinh.Enabled = edit;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            quanlydiem = new QuanlydiemEntities();
            var sv = from i in quanlydiem.SinhViens select i;
            GridView1.DataSource = sv.ToList();
            GridView1.DataBind();
            //SetControl(false);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "Sua")
            {
                isAdd = false;
                SetControl(true);
                txtMasv.Text = GridView1.Rows[row].Cells[0].Text;
                txtHoTen.Text = GridView1.Rows[row].Cells[1].Text;
                txtNgaySinh.Text = GridView1.Rows[row].Cells[2].Text;
            }
            else if(e.CommandName == "Xoa")
            {
                string xoa = GridView1.Rows[row].Cells[0].Text;
                var xoaa = from i in quanlydiem.SinhViens
                           where i.MaSV.ToString() == xoa
                           select i;
                SinhVien sinhVien = xoaa.First();
                quanlydiem.SinhViens.Remove(sinhVien);
                quanlydiem.SaveChanges();
            }
            Page_Load(sender, e);
            //SetControl(true);
        }

        protected void btnGhi_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                SetControl(true);
                SinhVien sinhVien = new SinhVien();
                sinhVien.HoTen = txtHoTen.Text;
                sinhVien.NgaySinh = txtNgaySinh.Text;
                quanlydiem.SinhViens.Add(sinhVien);
                quanlydiem.SaveChanges();
            }
            else
            {
                SetControl(true);
                var sua = from i in quanlydiem.SinhViens
                          where i.MaSV.ToString() == txtMasv.Text
                          select i;
                SinhVien sinhVien = sua.First();
                sinhVien.HoTen = txtHoTen.Text;
                sinhVien.NgaySinh = txtNgaySinh.Text;
                quanlydiem.SaveChanges();
            }
            Page_Load(sender, e);
            //SetControl(true);
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            txtMasv.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            SetControl(true);
        }
    }
}