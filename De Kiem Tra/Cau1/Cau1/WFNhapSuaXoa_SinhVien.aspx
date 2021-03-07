<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFNhapSuaXoa_SinhVien.aspx.cs" Inherits="Cau1.WFNhapSuaXoa_SinhVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 155px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nhập, sửa, xoá sinh viên<br />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">Khoa đào tạo:</td>
                    <td>
                        <asp:DropDownList ID="ddlKhoa" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlKhoa_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Lớp BC:</td>
                    <td>
                        <asp:TextBox ID="txtLop" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Mã sinh viên:</td>
                    <td>
                        <asp:TextBox ID="txtMaSV" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Họ và tên:</td>
                    <td>
                        <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Ngày sinh:</td>
                    <td>
                        <asp:TextBox ID="txtNgaySinh" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Địa chỉ:</td>
                    <td>
                        <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" Text="Thêm mới" />
&nbsp;
                        <asp:Button ID="btnGhi" runat="server" OnClick="btnGhi_Click" Text="Ghi" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="grvSV" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="grvSV_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="MaKhoa" HeaderText="Mã khoa" />
                <asp:BoundField DataField="LopBC" HeaderText="Lớp BC" />
                <asp:BoundField DataField="MaSV" HeaderText="Mã SV" />
                <asp:BoundField DataField="HoTen" HeaderText="Họ và tên" />
                <asp:BoundField DataField="NgaySinh" HeaderText="Ngày sinh" />
                <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
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
