using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau1
{
    public partial class WFTimTheoTenMon : System.Web.UI.Page
    {
        QuanlyhocDBEntities qlh;
        protected void Page_Load(object sender, EventArgs e)
        {
            qlh = new QuanlyhocDBEntities();
            if (!IsPostBack)
            {
                var tim = from i in qlh.DangKyHocs
                          join j in qlh.SinhViens on i.MaSV equals j.MaSV
                          join k in qlh.MonHocs on i.MaMon equals k.MaMon
                          select new
                          {
                              i.MaSV,
                              j.HoTen,
                              j.NgaySinh,
                              k.TenMon
                          };
                grvMon.DataSource = tim.ToList();
                grvMon.DataBind();
            }
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            var timMon = from i in qlh.DangKyHocs
                         join j in qlh.SinhViens on i.MaSV equals j.MaSV
                         join k in qlh.MonHocs on i.MaMon equals k.MaMon
                         where k.TenMon.Contains(txtTim.Text)
                         select new
                         {
                             i.MaSV,
                             j.HoTen,
                             j.NgaySinh,
                             k.TenMon
                         };
            grvMon.DataSource = timMon.ToList();
            grvMon.DataBind();
        }
    }
}