<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFTimKiemSinhVien.aspx.cs" Inherits="Cau2.WFTimKiemSinhVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Tìm theo:
            <asp:DropDownList ID="ddlTim" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlTim_SelectedIndexChanged">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp; Nội dung tìm:
            <asp:TextBox ID="txtTim" runat="server" Width="161px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnTim" runat="server" OnClick="btnTim_Click" Text="Tìm" />
        </div>
        <asp:GridView ID="grvTimSV" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="grvTimSV_RowCommand">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="MaSV" HeaderText="Mã SV" HtmlEncode="False" />
                <asp:BoundField DataField="HoTen" HeaderText="Họ và tên" HtmlEncode="False" />
                <asp:BoundField DataField="TenKhoa" HeaderText="Tên khoa" HtmlEncode="False" />
                <asp:ButtonField ButtonType="Button" CommandName="ChiTiet" HeaderText="Chi tiết" Text="Chi tiết" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <br />
        <asp:GridView ID="grvChiTietSV" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="TenMon" HeaderText="Tên môn" HtmlEncode="False" />
                <asp:BoundField DataField="NamHK" HeaderText="Năm đăng ký" HtmlEncode="False" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    </form>
</body>
</html>
