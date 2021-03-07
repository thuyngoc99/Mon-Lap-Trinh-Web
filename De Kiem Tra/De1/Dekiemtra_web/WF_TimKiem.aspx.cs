using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dekiemtra_web
{
    public partial class WF_TimKiem : System.Web.UI.Page
    {

        protected void SetControl(bool edit)
        {
            txtTim.Enabled = edit;
            ddlKhoa.Enabled = edit;
        }

        QuanlyhocDBEntities quanlyhoc;
        protected void Page_Load(object sender, EventArgs e)
        {
            quanlyhoc = new QuanlyhocDBEntities();
            if (!IsPostBack)
            {
                var tim = from i in quanlyhoc.KhoaDaoTaos
                          select i;
                ddlKhoa.DataSource = tim.ToList();
                ddlKhoa.DataTextField = "TenKhoa";
                ddlKhoa.DataValueField = "MaKhoa";
                ddlKhoa.DataBind();
                ddlKhoa_SelectedIndexChanged(sender, e);
                SetControl(true);
            }
        }

        protected void ddlKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tim = from i in quanlyhoc.KhoaDaoTaos
                      join j in quanlyhoc.SinhViens on i.MaKhoa equals j.MaKhoa
                      join k in quanlyhoc.DangKyHocs on j.MaSV equals k.MaSV
                      where i.MaKhoa == ddlKhoa.SelectedValue.ToString()
                      select new
                      {
                        j.HoTen,
                        i.TenKhoa,
                        k.NamHocKy
                      };
            GridView1.DataSource = tim.ToList();
            GridView1.DataBind();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            var tim = from i in quanlyhoc.KhoaDaoTaos
                      join j in quanlyhoc.SinhViens on i.MaKhoa equals j.MaKhoa
                      join k in quanlyhoc.DangKyHocs on j.MaSV equals k.MaSV
                      where j.HoTen.Contains(txtTim.Text)
                      select new
                      {
                          j.HoTen,
                          i.TenKhoa,
                          k.NamHocKy
                      };
            GridView1.DataSource = tim.ToList();
            GridView1.DataBind();
            
        }
    }
}