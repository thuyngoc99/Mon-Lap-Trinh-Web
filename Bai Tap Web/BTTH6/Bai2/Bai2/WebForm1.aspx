<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Bai2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txta" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="txtb" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btntinhhieu" runat="server" OnClick="btntinhhieu_Click" Text="Hiệu" />
            <br />
        </div>
        <asp:Label ID="lblkq" runat="server"></asp:Label>
    </form>
</body>
</html>
