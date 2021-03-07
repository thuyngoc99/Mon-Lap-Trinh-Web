<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="BTNhom_Web.TrangChu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
        }
        .auto-style1 {
            width: 370px;
            height: 199px;
        }
        .auto-style3 {
            width: 350px;
            height: 183px;
            margin-left: 0px;
            float: left;
        }
        a{
            text-decoration:none;
            color:black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            CÔNG TY THIẾT KẾ WEBSITE
            <br />
            Cao cấp - chuẩn SEO - Responsive

        </div>
    <div class="auto-style3">
        <img class="auto-style1" src="file:///C:/Users/HH/Pictures/hinh1.png" />

    </div>

    <div style="float:left">
        <a href="">Thiết kế Website <br /></a>
        <div>
            Điều đặc biệt nhất khi thiết kế website ở Mona Media là bạn không cần phải lo lắng về trình độ kỹ thuật, thẩm mỹ thiết kế hay hậu mãi, 
            bảo trì, bảo hành, bảo mật… Tất cả những gì bạn cần chuẩn bị một ý tưởng rõ ràng để cùng Project Manager của chúng tôi trao đổi tư vấn cho bạn. 
            Mona Media sẽ phân tích ưu/khuyết, đưa ra những tính năng phù hợp nhất cho kế hoạch, phương hướng phát triển, độ phù hợp với thị trường và kinh phí dự kiến
            <p> - Tư vấn và triển khai theo nhu cầu và yêu cầu </p>
            <p> - Giao diện thiết kế độc quyền. </p>
            <p> - Cấu trúc web chuẩn SEO </p>
            <p> - Hiển thị tốt trên các thiết bị di động </p>
            <p> - Tối ưu trải nghiệm người dùng, tốc độ website </p>
            <p> - Dễ dàng quản lý website </p>
            <p> 
                <asp:Button ID="txtDatHang" runat="server" OnClick="txtDatHang_Click" Text="Đặt hàng" Width="146px" />
            </p>
            
        </div>
    </div>
        <p>Các nhân viên trong công ty</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="923px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="MaNV" HeaderText="Mã nhân viên" HtmlEncode="False" />
                <asp:BoundField DataField="TenNV" HeaderText="Tên nhân viên" HtmlEncode="False" />
                <asp:BoundField DataField="NgaySinh" HeaderText="Ngày sinh" HtmlEncode="False" />
                <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" HtmlEncode="False" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" HtmlEncode="False" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </form>
    </body>
</html>
