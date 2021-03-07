<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Bai4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 266px;
        }
        .auto-style2 {
            width: 266px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 266px;
            height: 34px;
        }
        .auto-style5 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ĐĂNG KÝ THÀNH VIÊN</div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Tên đăng nhập: </td>
                <td>
                    <asp:TextBox ID="txttendangnhap" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Mật khẩu: </td>
                <td>
                    <asp:TextBox ID="txtmatkhau" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Nhập lại mật khẩu:</td>
                <td>
                    <asp:TextBox ID="txtnhaplaimatkhau" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Email:</td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Giới tính:</td>
                <td>
                    <asp:RadioButton ID="Radio1" runat="server" Text="Nam" />
                    <asp:RadioButton ID="Radio2" runat="server" Text="Nữ" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Ngày sinh:</td>
                <td>
                    <asp:TextBox ID="txtngaysinh" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Sở thích:</td>
                <td class="auto-style3">
                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" Text="Thể thao" />
                    <br />
                    <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" Text="Mua sắm" />
                    <br />
                    <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" Text="Âm nhạc" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btndangky" runat="server" OnClick="btndangky_Click" Text="Đăng ký" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="btnnhaplai" runat="server" OnClick="btnnhaplai_Click" Text="Nhập lại" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
