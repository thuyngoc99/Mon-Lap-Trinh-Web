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
        QLTBEntities qLTB;
        protected void Page_Load(object sender, EventArgs e)
        {
            qLTB = new QLTBEntities();
            var tim = from i in qLTB.Thietbis
                      join j in qLTB.DonVis on i.MaDV equals j.MaDV
                      join k in qLTB.Loaithietbis on i.Maloai equals k.Maloai
                      select new
                      {
                          i.TenTB,
                          k.Tenloai,
                          j.TenDV,
                          k.Maloai
                      };
            GridView1.DataSource = tim.ToList();
            GridView1.DataBind();

        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            qLTB = new QLTBEntities();
            var tim = from i in qLTB.Thietbis
                      join j in qLTB.DonVis on i.MaDV equals j.MaDV
                      join k in qLTB.Loaithietbis on i.Maloai equals k.Maloai
                      where i.TenTB.Contains(txtTim.Text)
                      select new
                      {
                          i.TenTB,
                          k.Tenloai,
                          j.TenDV,
                          k.Maloai
                      };
            GridView1.DataSource = tim.ToList();
            GridView1.DataBind();

        }
    }
}