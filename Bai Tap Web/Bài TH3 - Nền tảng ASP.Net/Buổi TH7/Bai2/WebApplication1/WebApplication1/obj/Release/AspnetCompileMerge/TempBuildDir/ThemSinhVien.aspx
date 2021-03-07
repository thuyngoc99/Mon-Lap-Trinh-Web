<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ThemSinhVien.aspx.cs" Inherits="WebApplication1.ThemSinhVien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 65%;
        }
        .auto-style2 {
            width: 147px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Mã sinh viên: </td>
            <td>
                <asp:TextBox ID="txtMSV" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Họ và tên:</td>
            <td>
                <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Lớp:</td>
            <td>
                <asp:DropDownList ID="ddlLop" runat="server" AutoPostBack="True">
                    <asp:ListItem>56K1</asp:ListItem>
                    <asp:ListItem>57K1</asp:ListItem>
                    <asp:ListItem>58K2</asp:ListItem>
                    <asp:ListItem>58K1</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Tỉnh:</td>
            <td>
                <asp:DropDownList ID="ddlTinh" runat="server" AutoPostBack="True" Height="16px">
                    <asp:ListItem>Nghệ An</asp:ListItem>
                    <asp:ListItem>Đà Nẵng</asp:ListItem>
                    <asp:ListItem>Hà Nội</asp:ListItem>
                    <asp:ListItem>Hà Tĩnh</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Điện thoại:</td>
            <td>
                <asp:TextBox ID="txtDienThoai" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Hình ảnh:</td>
            <td>
            <asp:FileUpload ID="FileUpLoad" runat="server" />
&nbsp;
                </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />
&nbsp;
                <asp:Button ID="btnXoa" runat="server" Text="Xóa" OnClick="btnXoa_Click" />
            &nbsp;
                </td>
        </tr>
    </table>
</asp:Content>
