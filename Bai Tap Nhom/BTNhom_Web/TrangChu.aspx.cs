using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTNhom_Web
{
    public partial class TrangChu : System.Web.UI.Page
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = @"Data Source=THANH-2020LDGFL\SQLEXPRESS;Initial Catalog=CongTy;Integrated Security=True";
            sqlConnection = new SqlConnection(str);
        }

        protected void txtDatHang_Click(object sender, EventArgs e)
        {
            string strDatHang = "Select * from NhanVien";
            sqlCommand = new SqlCommand(strDatHang, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(sqlDataReader);
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }
}