using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class ThemSinhVien : System.Web.UI.Page 
    {
        static List<SinhVien> sinhviens;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               sinhviens = new List<SinhVien>();
            }   
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMSV.Text == "" || txtHoTen.Text == "" || txtDienThoai.Text == "")
            {
                Response.Write("<script>alert('Không được để trống')</script>");
                return;
            }
            else if (txtDienThoai.Text.Length > 11)
            {
                Response.Write("<script>alert('Số điện thoại phải nhập 10 số')</script>");
                return;
            }

            SinhVien sinhVien = new SinhVien();
            sinhVien.mSV = txtMSV.Text;
            sinhVien.hoTen = txtHoTen.Text;
            sinhVien.lop = ddlLop.SelectedValue;
            sinhVien.tinh = ddlTinh.SelectedValue;
            sinhVien.soDienThoai = txtDienThoai.Text;
            sinhVien.hinhAnh = FileUpLoad.FileName;
            
            sinhviens.Add(sinhVien);
            Session["sinhviens"] = sinhviens;

            Response.Redirect("~/DanhSachSinhVien.aspx");
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            txtMSV.Text = "";
            txtHoTen.Text = "";
            txtDienThoai.Text = "";  
        }
    }
}