using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau1
{
    public partial class WF_TimKiem : System.Web.UI.Page
    {
        QuanlydiemEntities quanlydiem;
        protected void SetControl(bool edit)
        {
            txtTim.Enabled = edit;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            quanlydiem = new QuanlydiemEntities();
            var tim = from i in quanlydiem.DiemThis
                      join j in quanlydiem.SinhViens on i.MaSV equals j.MaSV
                      join k in quanlydiem.MonHocs on i.MaMon equals k.MaMon
                      select new
                      {
                          j.HoTen,
                          k.TenMon,
                          i.DiemCC,
                          i.DiemGK
                      };
            GridView1.DataSource = tim.ToList();
            GridView1.DataBind();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            quanlydiem = new QuanlydiemEntities();
            var tim = from i in quanlydiem.DiemThis
                      join j in quanlydiem.SinhViens on i.MaSV equals j.MaSV
                      join k in quanlydiem.MonHocs on i.MaMon equals k.MaMon
                      where j.HoTen.Contains(txtTim.Text)
                      select new
                      {
                          j.HoTen,
                          k.TenMon,
                          i.DiemCC,
                          i.DiemGK
                      };
            GridView1.DataSource = tim.ToList();
            GridView1.DataBind();
        }
    }
}