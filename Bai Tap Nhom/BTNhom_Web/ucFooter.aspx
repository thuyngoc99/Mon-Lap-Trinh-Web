<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ucFooter.aspx.cs" Inherits="BTNhom_Web.ucFooter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
      
        .auto-style1 {
            width: 944px;
            height: 164px;
            background-color:tan;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <div style="width:300px; float:left; margin: 0px 0px 0px 10px;">
                Công ty thiết kế Web là công ty chuyên hỗ trợ, tư vấn, thiết kế và xây dựng thương hiệu cho các doanh nghiệp,
                giúp doanh nghiệp sở hữu những thương hiệu độc quyền và thu hút khách hàng.
            </div>
            <div style="width:250px; float:left; margin: 0px 0px 0px 40px;">
                <p style="font-size:23px; font-weight:bold;">Thông tin liên hệ</p>
               
                Địa chỉ: 
                <br />
                Điện thoại:
                <br />
                Email:
            </div>
            <div style="width:250px; float:left; margin: 0px 0px 0px 40px;">
                <p style="font-size:23px; font-weight:bold;">Đăng ký</p>
                Đăng ký để nhận được thông tin mới nhất từ chúng tôi
                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Height="21px" Text="Button" />
            </div>
        </div>
    </form>
</body>
</html>
