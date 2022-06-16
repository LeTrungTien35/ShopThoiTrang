using System;
using System.Linq;
using Database;
using System.Data;

namespace ShopThoiTrang
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                #region Kiểm tra đã đăng nhập hay chưa

                if (Session["KhachHang"] != null && Session["KhachHang"].ToString() == "1")
                {
                    //Đã đăng nhập
                    plDaDangNhap.Visible = true;
                    plChuaDangNhap.Visible = false;

                    if (Session["KhachHang"] != null)
                        ltrTenKhachHang.Text = Session["TenKh"].ToString();
                }
                else
                {
                    plDaDangNhap.Visible = false;
                    plChuaDangNhap.Visible = true;
                }
                #endregion

                ltrDanhMucSanPHam.Text = LayDanhMuc();
            }
        }

        private string LayDanhMuc()
        {
            
            string s = "";
            DataTable dt = new DataTable();
            dt = Database.DanhMuc.Thongtin_Danhmuc_by_MaDMCha("0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s += @"<li><a href='/Default.aspx?modul=SanPham&modulphu=DanhSachSanPham&id=" + dt.Rows[i]["MaDM"] + @"' title='" + dt.Rows[i]["TenDM"] + @"'>" + dt.Rows[i]["TenDM"] + @"</a></li>";
            }
            return s;
        }

        protected void lbtDangXuat_Click(object sender, EventArgs e)
        {
            //Xóa các session đã lưu
            Session["KhachHang"] = null;

            Session["MaKH"] = null;
            Session["TenKh"] = null;
            Session["DiaChiKH"] = null;
            Session["sdtKH"] = null;
            Session["EmailKH"] = null;

            //đẩy về trang đăng nhập
            Response.Redirect("/Default.aspx");
        }
    }
}