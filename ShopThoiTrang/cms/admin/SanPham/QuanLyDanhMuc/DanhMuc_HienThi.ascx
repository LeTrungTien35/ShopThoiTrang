<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhMuc_HienThi.ascx.cs" Inherits="ShopThoiTrang.cms.admin.SanPham.QuanLyDanhMuc.DanhMuc_HienThi" %>
<div class="head">
    Các danh mục sản phẩm đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=SanPham&modulphu=DanhMuc&thaotac=ThemMoi">Thêm mới danh mục</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên danh mục</th>
           <th class="cotAnh">Ảnh đại diện</th>
           <th class="cotThuTu">Thứ tự</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <tr>
           <td class="cotMa">1</td>
           <td class="cotTen">2</td>
           <td class="cotAnh">3</td>
           <td class="cotThuTu">4</td>
           <td class="cotCongCu">
               <a href="#" class="dmcon" title="Xem danh mục con"></a>
               <a href="#" class="sua" title="Sửa"></a>
               <a href="#" class="xoa" title="Xóa"></a>
           </td>
       </tr>
       <asp:Literal ID="ltrDanhMuc" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    function XoaDanhMuc(MaDM)
    {
        if(confirm("Bạn chắc chắn muốn xóa danh mục này"))
        {
            //Viết code xóa danh mục tại đây

            $.post("cms/admin/SanPham/QuanLyDanhMuc/Ajax/XoaDanhMuc.aspx",
                {
                    "ThaoTac":"XoaDM",
                    "MaDM": MaDM
                },
                function (data, status)
                {
                    //alert("Data :" + data + "\n Status :" + status);
                    if(data==1)
                    {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + MaDM).slideUp();

                    }
                });
        }
    }
</script>