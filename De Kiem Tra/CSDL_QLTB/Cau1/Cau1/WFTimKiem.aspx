<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFTimKiem.aspx.cs" Inherits="Cau1.WFTimKiem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Tìm:
            <asp:TextBox ID="txtTim" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnTim" runat="server" OnClick="btnTim_Click" Text="Tìm kiếm" />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="TenTB" HeaderText="Tên TB" HtmlEncode="False" />
                <asp:BoundField DataField="Tenloai" HeaderText="Tên loại" HtmlEncode="False" />
                <asp:BoundField DataField="TenDV" HeaderText="Tên DV" HtmlEncode="False" />
                <asp:BoundField DataField="Maloai" HeaderText="Mã loại" />
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
