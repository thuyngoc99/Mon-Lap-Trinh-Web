<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ucMenu.aspx.cs" Inherits="BTNhom_Web.ucMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
    </title>
    <style>
        .Menu{
            display:flex;
            
        }
        .auto-style1 {
            float: right;
            text-decoration:none;
            padding-left:15px;
            font-size:18px;
            font-weight:bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Menu">
            <a href="" class="auto-style1">Trang chủ</a>
            <a href="" class="auto-style1">Giới thiệu</a>
            <a href="" class="auto-style1">Dịch vụ</a>
            <a href="" class="auto-style1">Liên hệ</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="127px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" BackColor="#00CC99" ForeColor="Black" Height="21px" Text="Tìm kiếm" />
        </div>
    </form>
</body>
</html>
