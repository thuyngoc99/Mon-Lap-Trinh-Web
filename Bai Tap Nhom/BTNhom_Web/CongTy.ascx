<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CongTy.ascx.cs" Inherits="BTNhom_Web.CongTy" %>
<style type="text/css">

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
        <div class="Menu">
            <a href="" class="auto-style1">Trang chủ</a>
            <a href="" class="auto-style1">Giới thiệu</a>
            <a href="" class="auto-style1">Dịch vụ</a>
            <a href="" class="auto-style1">Tuyển dụng</a>
            <a href="" class="auto-style1">Liên hệ</a>
            <asp:TextBox ID="TextBox1" runat="server" Width="127px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" BackColor="#00CC99" ForeColor="Black" Height="21px" Text="Tìm kiếm" />
        </div>
    
