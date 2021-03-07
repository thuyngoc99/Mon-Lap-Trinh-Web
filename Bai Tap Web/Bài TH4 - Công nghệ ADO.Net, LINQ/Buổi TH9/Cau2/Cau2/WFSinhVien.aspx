<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFSinhVien.aspx.cs" Inherits="Cau2.SINHVIEN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 231px;
        }
        .auto-style3 {
            height: 23px;
            width: 231px;
        }
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1" colspan="2">TÌM KIẾM - SỬA - XOÁ SINH VIÊN</td>
                </tr>
                <tr>
                    <td class="auto-style3">Khoa đào tạo:</td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="ddlKhoa" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlKhoa_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Lớp BC:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtLop" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Mã sinh viên:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtMaSV" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Họ và tên:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtTen" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Ngày sinh:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtNgaySinh" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Địa chỉ:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtDiaChi" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;
                        <asp:Button ID="txtGhi" runat="server" OnClick="txtGhi_Click" Text="Ghi" />
                    &nbsp;<asp:Button ID="txtThem" runat="server" OnClick="txtThem_Click" Text="Thêm mới" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridviewSV" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GridviewSV_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="MaKhoa" HeaderText="Mã khoa" HtmlEncode="False" />
                <asp:BoundField DataField="LopBC" HeaderText="Lớp BC" HtmlEncode="False" />
                <asp:BoundField DataField="MaSV" HeaderText="Mã sinh viên" />
                <asp:BoundField DataField="HoTen" HeaderText="Họ và tên" HtmlEncode="False" />
                <asp:BoundField DataField="NgaySinh" HeaderText="Ngày sinh" HtmlEncode="False" />
                <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" HtmlEncode="False" />
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
