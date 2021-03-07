using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cau2
{
    public partial class KHOADAOTAO : System.Web.UI.Page
    {
        static bool isAdd;
        QuanLyHocEntities1 myQlh;
        protected void Page_Load(object sender, EventArgs e)
        {
            myQlh = new QuanLyHocEntities1();
            var khoa = from i in myQlh.KhoaDaoTaos
                           select i;
             GridView1.DataSource = khoa.ToList();
             GridView1.DataBind();
        
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "Sua")
            {
                isAdd = false;
                txtMaKhoa.Text = GridView1.Rows[row].Cells[0].Text;
                txtTenKhoa.Text = GridView1.Rows[row].Cells[1].Text;
                txtPhone.Text = GridView1.Rows[row].Cells[2].Text;
            }
            else if(e.CommandName == "Xoa")
            {
                int makhoa = Convert.ToInt32(GridView1.Rows[row].Cells[0].Text);
                var xoaMaKhoa = from i in myQlh.KhoaDaoTaos 
                                where i.MaKhoa == makhoa
                                select i;
                KhoaDaoTao khoaDaoTao = xoaMaKhoa.First();
                myQlh.KhoaDaoTaos.Remove(khoaDaoTao);
                myQlh.SaveChanges();
            }
            Page_Load(sender, e);
        }

        protected void txtGhi_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                KhoaDaoTao khoa = new KhoaDaoTao();
                khoa.TenKhoa = txtTenKhoa.Text;
                khoa.Phone = txtPhone.Text;
                myQlh.KhoaDaoTaos.Add(khoa);
                myQlh.SaveChanges();
            }
            else
            {
                var query = from i in myQlh.KhoaDaoTaos
                            where i.MaKhoa.ToString() == (txtMaKhoa.Text)
                            select i;
                KhoaDaoTao khoa = query.First();
                khoa.TenKhoa = txtTenKhoa.Text;
                khoa.Phone = txtPhone.Text;
                myQlh.SaveChanges();
            }
            Page_Load(sender, e);
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            isAdd = true;
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtPhone.Text = "";
        }
    }
}