using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau2
{
    public partial class WFTimKiemSinhVien : System.Web.UI.Page
    {
        QuanLyHocEntities1 myQlh;
        protected void Page_Load(object sender, EventArgs e)
        {
            myQlh = new QuanLyHocEntities1();
            if (!IsPostBack)
            {
                var sv = from i in myQlh.SinhViens
                         select i;
                ddlTim.DataSource = sv.ToList();
                ddlTim.DataValueField = "MaSV";
                ddlTim.DataBind();
                ddlTim_SelectedIndexChanged(sender, e);
            }
            
        }



        protected void btnTim_Click(object sender, EventArgs e)
        {
            var TimTheoTen = from i in myQlh.SinhViens join j in myQlh.KhoaDaoTaos
                     on i.MaKhoa equals j.MaKhoa
                      where i.HoTen.Contains(txtTim.Text)
                      select new
                      {
                          i.MaSV,
                          i.HoTen,
                          j.TenKhoa
                    };
            grvTimSV.DataSource = TimTheoTen.ToList();
            grvTimSV.DataBind();
        }

        protected void ddlTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            var TimTheoMa = from i in myQlh.SinhViens join j in myQlh.KhoaDaoTaos on i.MaKhoa equals j.MaKhoa
                            where i.MaSV.ToString() == ddlTim.SelectedValue
                            select new
                            {
                                i.MaSV,
                                i.HoTen,
                                j.TenKhoa
                            };
            grvTimSV.DataSource = TimTheoMa.ToList();
            grvTimSV.DataBind();
        }

        protected void grvTimSV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            String maSV = grvTimSV.Rows[row].Cells[0].Text;
            if(e.CommandName == "ChiTiet")
            {
                var chiTiet = from i in myQlh.MonHocs
                              join j in myQlh.DangKyHocs on i.MaMon equals j.MaMon
                              where j.MaSV.ToString() == maSV
                              select new
                              {
                                  i.TenMon,
                                  j.NamHK
                              };
                grvChiTietSV.DataSource = chiTiet.ToList();
                grvChiTietSV.DataBind();
            }
        }
    }
}