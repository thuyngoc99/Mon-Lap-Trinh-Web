using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau1
{
    public partial class Form_TimKiemCB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            QuanlycanboEntities2 qlcb = new QuanlycanboEntities2();
            var tim = from i in qlcb.SinhViens
                      join j in qlcb.CanBoes on i.MaCB equals j.MaCB
                      join k in qlcb.MonHocs on i.MaMon equals k.MaMon
                      select new
                      {
                          j.HoTen,
                          i.HoTenSV,
                          i.MaSV,
                          k.TenMon
                      };
            GridView1.DataSource = tim.ToList();
            GridView1.DataBind();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            QuanlycanboEntities2 qlcb = new QuanlycanboEntities2();
            var tim = from i in qlcb.SinhViens
                      join j in qlcb.CanBoes on i.MaCB equals j.MaCB
                      join k in qlcb.MonHocs on i.MaMon equals k.MaMon
                      where i.HoTenSV.Contains(txtTim.Text)
                      select new
                      {
                          j.HoTen,
                          i.HoTenSV,
                          i.MaSV,
                          k.TenMon
                      };
            GridView1.DataSource = tim.ToList();
            GridView1.DataBind();
        }
    }
}