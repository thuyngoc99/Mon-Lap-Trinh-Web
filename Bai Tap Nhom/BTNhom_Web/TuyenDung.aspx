<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TuyenDung.aspx.cs" Inherits="BTNhom_Web.TuyenDung" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 219px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Thông tin tuyển dụng bao gồm:</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Mã khách hàng: </td>
                <td>
                    <asp:TextBox ID="txtMa" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Họ tên:</td>
                <td>
                    <asp:TextBox ID="txtTen" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Địa chỉ:</td>
                <td>
                    <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Email:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="btnXacnhan" runat="server" OnClick="btnXacnhan_Click" Text="Gửi đi" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
