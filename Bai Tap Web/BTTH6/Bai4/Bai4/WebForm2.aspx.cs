using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bai4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("THÔNG TIN TÀI KHOẢN <br>");
            Response.Write("Tên đăng nhập: " + Session["name"] + "<br>");
            Response.Write("Mật khẩu: " + Session["pass"] + "<br>");
            Response.Write("Email: " + Session["email"] + "<br>");
            Response.Write("Giới tính: " + Session["gioitinh"] + "<br>");
            Response.Write("Ngày sinh: " + Session["date"] + "<br>");
            Response.Write("Sở thích: " + Session["hobbie1"] + " | " + Session["hobbie2"] + "<br>");
        }
    }
}