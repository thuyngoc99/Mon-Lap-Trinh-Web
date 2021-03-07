<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_TimKiemCB.aspx.cs" Inherits="Cau1.Form_TimKiemCB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 193px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
            <asp:TextBox ID="txtTim" runat="server"></asp:TextBox>
&nbsp;
            <asp:Button ID="btnTim" runat="server" OnClick="btnTim_Click" style="height: 26px" Text="Tìm kiếm" />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="HoTen" HeaderText="Họ tên GV" />
                <asp:BoundField DataField="HoTenSV" HeaderText="Họ Tên SV" />
                <asp:BoundField DataField="MaSV" HeaderText="Mã sinh viên" />
                <asp:BoundField DataField="TenMon" HeaderText="Tên môn" />
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
