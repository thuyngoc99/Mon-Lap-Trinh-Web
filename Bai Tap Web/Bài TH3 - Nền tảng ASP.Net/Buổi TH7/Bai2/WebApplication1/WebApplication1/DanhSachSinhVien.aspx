<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DanhSachSinhVien.aspx.cs" Inherits="WebApplication1.DanhSachSinhVien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="color:red; font-weight:bold; text-align: center;"> DANH SÁCH SINH VIÊN KHOÁ 56 NGÀNH CÔNG NGHỆ THÔNG TIN
    <br />
    </div>
    <asp:DataList ID="DataList" runat="server" RepeatColumns="4" BorderColor="Black" GridLines="Both">
        <ItemTemplate>
           <div style="text-align:center;">
                <p>Mã số sinh viên: <%#Eval("mSV") %></p>
                <p>Họ và tên: <%#Eval("hoTen") %></p>
                <p>Lớp: <%#Eval("lop") %></p>
                <p>Tỉnh: <%#Eval("tinh") %></p>
                <p>Điện thoại: <%#Eval("soDienThoai") %></p>
                <img src="<%#Eval("hinhAnh") %>" />
           </div>
       </ItemTemplate>
    </asp:DataList>
            
    <br />
            
</asp:Content>

