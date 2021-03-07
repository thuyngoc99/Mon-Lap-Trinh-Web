using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau1
{
    public partial class WFTimKiem : System.Web.UI.Page
    {
        QuanlyhocDBEntities qlh;
        protected void Page_Load(object sender, EventArgs e)
        {
            qlh = new QuanlyhocDBEntities();
            if (!IsPostBack)
            {
                var tim = from i in qlh.SinhViens
                          select i;
                ddlTim.DataSource = tim.ToList();
                ddlTim.DataValueField = "MaSV";
                ddlTim.DataBind();
                ddlTim_SelectedIndexChanged(sender, e);
            }
        }

        protected void ddlTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            var timTen = from i in qlh.SinhViens
                         join j in qlh.KhoaDaoTaos on i.MaKhoa equals j.MaKhoa
                         where i.MaSV == ddlTim.SelectedValue
                         select new
                         {
                             i.MaSV,
                             i.HoTen,
                             j.TenKhoa
                         };
            grvChiTietSV.DataSource = timTen.ToList();
            grvChiTietSV.DataBind();
        }

        protected void grvChiTietSV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);      
            if(e.CommandName == "ChiTiet")
            {
                string maSV = grvChiTietSV.Rows[row].Cells[0].Text;
                var tim = from i in qlh.DangKyHocs
                          join j in qlh.MonHocs on i.MaMon equals j.MaMon
                          where i.MaSV == maSV
                          select new
                          {
                              i.NamHocKy,
                              j.TenMon,
                              
                          };
                grvDangKy.DataSource = tim.ToList();
                grvDangKy.DataBind();
            }
            ddlTim_SelectedIndexChanged(sender, e);
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            var timTen = from i in qlh.SinhViens
                         join j in qlh.KhoaDaoTaos on i.MaKhoa equals j.MaKhoa
                         where i.HoTen.Contains(txtTim.Text)
                         select new
                         {
                             i.MaSV,
                             i.HoTen,
                             j.TenKhoa
                         };
            grvChiTietSV.DataSource = timTen.ToList();
            grvChiTietSV.DataBind();
        }
    }
}