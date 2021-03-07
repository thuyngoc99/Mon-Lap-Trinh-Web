<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFNhapSuaXoa_KhoaDaoTao.aspx.cs" Inherits="Cau1.WFNhapSuaXoa_KhoaDaoTao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 211px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nhập sửa xoá khoa đào tạo<br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Mã khoa:</td>
                    <td>
                        <asp:TextBox ID="txtMaKhoa" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Tên khoa:</td>
                    <td>
                        <asp:TextBox ID="txtTenKhoa" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Điện thoại:</td>
                    <td>
                        <asp:TextBox ID="txtDienThoai" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" Text="Thêm mới" />
&nbsp;&nbsp;
                        <asp:Button ID="btnGhi" runat="server" OnClick="btnGhi_Click" Text="Ghi" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="grvKhoa" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="grvKhoa_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="MaKhoa" HeaderText="Mã khoa" HtmlEncode="False" />
                <asp:BoundField DataField="TenKhoa" HeaderText="Tên khoa" HtmlEncode="False" />
                <asp:BoundField DataField="Phone" HeaderText="Điện thoại" />
                <asp:ButtonField ButtonType="Button" CommandName="Sua" HeaderText="Sửa" Text="Sửa" />
                <asp:ButtonField ButtonType="Button" CommandName="Xoa" HeaderText="Xoá" Text="Xoá" />
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
