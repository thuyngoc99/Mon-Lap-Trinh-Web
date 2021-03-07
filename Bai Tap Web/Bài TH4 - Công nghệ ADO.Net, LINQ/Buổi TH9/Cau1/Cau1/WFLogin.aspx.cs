using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau1
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            LOGINEntities login = new LOGINEntities();
            try {
                var str_login = from i in login.Logins
                                where i.UserName == txtTaiKhoan.Text && i.PassWord == txtMatKhau.Text
                                select i;
                Login dangnhap = str_login.First();
                if (dangnhap.UserName == txtTaiKhoan.Text && dangnhap.PassWord == txtMatKhau.Text)
                {
                    Session["User"] = txtTaiKhoan.Text;
                    Response.Redirect("WFChuyenHuong.aspx");
                }
                
            }
            catch
            {
                Response.Write("<script>alert('Bạn nhập sai tài khoản')</script>");
            }
        }
    }
}