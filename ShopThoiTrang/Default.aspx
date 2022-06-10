<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShopThoiTrang.Default" %>

<%@ Register Src="~/cms/display/DisplayLoadControl.ascx" TagPrefix="uc1" TagName="DisplayLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="MenuChinh">
                <div class="container">
                    <ul>
                        <li><a href="Default.aspx?modul=SanPham">Sản phẩm</a></li>
                        <li><a href="Default.aspx?modul=ThanhVien">Thành viên</a></li>
                        <li><a href="Default.aspx?modul=TrangChu">Trang chủ</a></li>                                               
                    </ul>
                </div>              
            </div>  
        <uc1:DisplayLoadControl runat="server" id="DisplayLoadControl" />
    </div>
    </form>
</body>
</html>
