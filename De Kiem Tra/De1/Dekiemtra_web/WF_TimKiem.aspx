<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WF_TimKiem.aspx.cs" Inherits="Dekiemtra_web.WF_TimKiem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Tìm kiếm:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTim" runat="server"></asp:TextBox>
&nbsp;
            <asp:DropDownList ID="ddlKhoa" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlKhoa_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button ID="btnTim" runat="server" CssClass="auto-style1" OnClick="btnTim_Click" Text="Tìm kiếm" />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="HoTen" HeaderText="Họ tên" HtmlEncode="False" />
                <asp:BoundField DataField="TenKhoa" HeaderText="Tên khoa" />
                <asp:BoundField DataField="NamHocKy" HeaderText="Năm học kỳ" />
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
    <a href="LienKet.aspx">Quay lại trang liên kết</a>
</body>
</html>
