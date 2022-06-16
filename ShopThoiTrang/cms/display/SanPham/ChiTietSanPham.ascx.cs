using System;
using System.Linq;
using Database;
using System.Data;

namespace ShopThoiTrang.cms.display.SanPham
{
    public partial class ChiTietSanPham : System.Web.UI.UserControl
    {
        protected string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];

            if (!IsPostBack)
                LayChiTietSanPham(id);
        }

        private void LayChiTietSanPham(string id)
        {
            DataTable dt = new DataTable();
            dt = Database.SanPham.Thongtin_Sanpham_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ltrAnhSanPham.Text = "<img class='imgsp' src='/pic/sanpham/" + dt.Rows[0]["AnhSP"] + @"' alt='" + dt.Rows[0]["TenSP"] + @"' />";

                ltrTenSanPham.Text = dt.Rows[0]["TenSP"].ToString();
                ltrGiaSP.Text = dt.Rows[0]["GiaSP"].ToString();

                ltrKichThuoc.Text = LayTenKichThuoc(dt.Rows[0]["SizeID"].ToString());
                ltrMau.Text = LayTenMau(dt.Rows[0]["MauID"].ToString());
                ltrChatLieu.Text = LayTenChatLieu(dt.Rows[0]["ChatLieuID"].ToString());

                ltrThongTinChiTiet.Text = dt.Rows[0]["MotaSP"].ToString();
            }
        }

        private string LayTenKichThuoc(string SizeID)
        {
            DataTable dt = new DataTable();
            dt = Database.Size.Thongtin_Size_by_id(SizeID);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["TenSize"].ToString();
            else
                return "";
        }

        private string LayTenMau(string MauID)
        {
            DataTable dt = new DataTable();
            dt = Database.Mau.Thongtin_Mau_by_id(MauID);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["TenMau"].ToString();
            else
                return "";
        }

        private string LayTenChatLieu(string ChatLieuID)
        {
            DataTable dt = new DataTable();
            dt = Database.ChatLieu.Thongtin_ChatLieu_by_id(ChatLieuID);
            if (dt.Rows.Count > 0)
                return dt.Rows[0]["TenChatLieu"].ToString();
            else
                return "";
        }
    }
}