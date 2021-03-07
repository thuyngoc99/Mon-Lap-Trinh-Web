<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFLogin.aspx.cs" Inherits="Cau1.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <div style="margin-left: 68px">
                    Đăng nhập
                </div>
                Tài khoản:&nbsp;
                <asp:TextBox ID="txtTaiKhoan" runat="server"></asp:TextBox>
                <br />
                Mật khẩu:&nbsp;
                <asp:TextBox ID="txtMatKhau" runat="server"></asp:TextBox>
                <br />
                <div style="margin-left: 68px">
                    <asp:Button ID="btnDangNhap" runat="server" OnClick="btnDangNhap_Click" Text="Đăng nhập" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
