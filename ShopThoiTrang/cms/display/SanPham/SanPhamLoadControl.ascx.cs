﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopThoiTrang.cms.display.SanPham
{
    public partial class SanPhamLoadControl : System.Web.UI.UserControl
    {
        private string modulphu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modulphu"] != null)
                modulphu = Request.QueryString["modulphu"];
            switch (modulphu)
            {
                case "DanhSachSanPham":
                    plLoadControl.Controls.Add(LoadControl("DanhSachCacSanPham.ascx"));
                    break;

                case "ChiTietSanPham":
                    plLoadControl.Controls.Add(LoadControl("ChiTietSanPham.ascx"));
                    break;

                case "GioHang":
                    plLoadControl.Controls.Add(LoadControl("GioHang.ascx"));

                    break;
                default:
                    plLoadControl.Controls.Add(LoadControl("TrangChuModulSanPham.ascx"));
                    break;
            }
        }
    }
}