<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LienKet.aspx.cs" Inherits="Dekiemtra_web.LienKet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        a{
            font-size:20px;
        }
        .vao{
            font-size:30px;
            color:red;
        }
        .ra{
            font-size:40px;
            color:yellow;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="WF_ThemSuaXoaKhoaDaoTao.aspx" onmouseover="this.className='vao'" onmouseout="this.className='ra'">Thêm - sửa - xoá khoa đào tạo</a><br>
            <a href="WF_TimKiem.aspx" onmouseover="this.className='vao'" onmouseout="this.className='ra'">Tìm kiếm</a>
        </div>
    </form>
</body>
</html>
