﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopThoiTrang.cms.admin.SanPham.QuanLyDanhMuc
{
    public partial class DanhMucLoadControl : System.Web.UI.UserControl
    {
        private string thaotac = "null";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["thaotac"] != null)
                thaotac = Request.QueryString["thaotac"];
            switch (thaotac)
            {
                case "ThemMoi":
                case "ChinhSua":
                    plLoadControl.Controls.Add(LoadControl("DanhMuc_ThemMoi.ascx"));
                    break;

                case "HienThi":
                    plLoadControl.Controls.Add(LoadControl("DanhMuc_HienThi.ascx"));
                    break;

                default:
                    plLoadControl.Controls.Add(LoadControl("DanhMuc_HienThi.ascx"));
                    break;

            }
        }
    }
}