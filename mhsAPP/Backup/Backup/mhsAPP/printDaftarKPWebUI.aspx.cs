using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using mhsAPP.entity;
using mhsAPP.control;
using mhsAPP.dataset.DataSetvKPTableAdapters;

namespace mhsAPP
{
    public partial class printDaftarKPWebUI : System.Web.UI.Page
    {
        private static int nodok;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mhs"] == null)
            {
                Response.Redirect("loginWebUI.aspx");
            }
            else
            {
                MahasiswaWeb Mhs = Session["mhs"] as MahasiswaWeb;
                nodok = int.Parse(Request.QueryString["nodok"]);
                tampilForm();
            }
        }
        protected void tampilForm()
        {
            mhsAPP.dataset.DataSetvKP data = new mhsAPP.dataset.DataSetvKP();
            vDaftarKPTableAdapter view = new vDaftarKPTableAdapter();
            view.FillBy(data.vDaftarKP, nodok);
            mhsAPP.report.daftarKPrpt daftar = new mhsAPP.report.daftarKPrpt();
            daftar.SetDataSource(data);
            CrystalReportViewer1.ReportSource = daftar;
            CrystalReportViewer1.DisplayPage = true;
        }
    }
}
