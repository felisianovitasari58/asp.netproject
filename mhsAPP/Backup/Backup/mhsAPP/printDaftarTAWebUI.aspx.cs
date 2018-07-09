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
using mhsAPP.dataset.DataSetvTATableAdapters;
using mhsAPP.entity;

namespace mhsAPP
{
    public partial class printDaftarTAWebUI : System.Web.UI.Page
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
            mhsAPP.dataset.DataSetvTA data = new mhsAPP.dataset.DataSetvTA();
            vDaftarTATableAdapter view = new vDaftarTATableAdapter();
            view.FillBy(data.vDaftarTA, nodok);
            mhsAPP.report.daftarTArpt daftar = new mhsAPP.report.daftarTArpt();
            daftar.SetDataSource(data);
            CrystalReportViewer1.ReportSource = daftar;
            CrystalReportViewer1.DisplayPage = true;
        }
    }
}
