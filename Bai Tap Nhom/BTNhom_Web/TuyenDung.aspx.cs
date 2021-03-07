using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTNhom_Web
{
    public partial class TuyenDung : System.Web.UI.Page
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        string str = @"Data Source=THANH-2020LDGFL\SQLEXPRESS;Initial Catalog=CongTy;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            sqlConnection = new SqlConnection(str);
            sqlConnection.Open();
        }

        protected void btnXacnhan_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(str);
            sqlConnection.Open();
            string strDatHang = "Insert Into KhachHang values('"+txtMa.Text+"', '"+txtTen.Text+"', '"+txtDiaChi.Text+"', '"+txtEmail.Text+"')";
            sqlCommand = new SqlCommand(strDatHang, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Response.Write("<script>alert('Đăng ký thành công')</script>");
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
        }
    }
}