<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SanPhamLoadControl.ascx.cs" Inherits="ShopThoiTrang.cms.display.SanPham.SanPhamLoadControl" %>
<asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>
<ul>
    <li><a href="Default.aspx?modul=SanPham">Sản Phẩm</a></li>       
    <li><a href="Default.aspx?modul=SanPham&modulphu=DanhSachSanPham">Danh sách sản phẩm</a></li>
    <li><a href="Default.aspx?modul=SanPham&modulphu=ChiTietSanPham">Chi tiết sản phẩm</a></li>
    <li><a href="Default.aspx?modul=SanPham&modulphu=GioHang">Giỏ Hàng</a></li>                                        
</ul>