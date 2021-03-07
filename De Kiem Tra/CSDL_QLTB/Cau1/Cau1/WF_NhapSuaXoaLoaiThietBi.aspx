<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WF_NhapSuaXoaLoaiThietBi.aspx.cs" Inherits="Cau1.WF_NhapSuaXoaLoaiThietBi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 107px;
        }
        .auto-style3 {
            height: 23px;
            width: 107px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">Mã loại</td>
                    <td>
                        <asp:TextBox ID="txtMaloai" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Tên loại</td>
                    <td>
                        <asp:TextBox ID="txtTenloai" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Danh mục</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtDanhmuc" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="btnGhi" runat="server" OnClick="btnGhi_Click" Text="Ghi" />
&nbsp;
                        <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" Text="Thêm mới" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridViewDM" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="GridViewDM_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Maloai" HeaderText="Mã loại" HtmlEncode="False" />
                <asp:BoundField DataField="Tenloai" HeaderText="Tên loại" HtmlEncode="False" />
                <asp:BoundField DataField="Danhmuc" HeaderText="Danh mục" HtmlEncode="False" />
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
