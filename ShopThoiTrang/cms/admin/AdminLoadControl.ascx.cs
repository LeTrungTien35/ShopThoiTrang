using System;

namespace ShopThoiTrang.cms.admin
{
    public partial class AdminLoadControl : System.Web.UI.UserControl
    {
        private string modul = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];
            switch (modul)
            {
                case "SanPham":
                    plAdminLoadControl.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
                    break;

                case "TaiKhoan":
                    plAdminLoadControl.Controls.Add(LoadControl("TaiKhoan/TaiKhoanLoadControl.ascx"));
                    break;

                default:
                    plAdminLoadControl.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
                    break;
            }

        }
    }
}