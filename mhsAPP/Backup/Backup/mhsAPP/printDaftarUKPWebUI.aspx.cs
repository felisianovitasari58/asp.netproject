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
using mhsAPP.dataset.DataSetvUKPTableAdapters;

namespace mhsAPP
{
    public partial class printDaftarUKPWebUI : System.Web.UI.Page
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
            mhsAPP.dataset.DataSetvUKP data = new mhsAPP.dataset.DataSetvUKP();
            vDaftarUKPTableAdapter view = new vDaftarUKPTableAdapter();
            view.FillBy(data.vDaftarUKP, nodok);
            mhsAPP.report.daftarUKPrpt daftar = new mhsAPP.report.daftarUKPrpt();
            daftar.SetDataSource(data);
            CrystalReportViewer1.ReportSource = daftar;
            CrystalReportViewer1.DisplayPage = true;
        }
    }
}
